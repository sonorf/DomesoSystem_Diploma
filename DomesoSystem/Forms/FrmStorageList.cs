using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using DomesoSystem.Data;
using DomesoSystem.Models;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomesoSystem.Forms
{
    public partial class FrmStorageList : Form
    {
        public FrmStorageList()
        {
            InitializeComponent();
        }

        private void ConfigureAccessByRole()
        {
            bool isAdmin = CurrentUser.IsAdmin;
            bool isStorekeeper = CurrentUser.IsStorekeeper;

            btnAddStorage.Visible = isAdmin || isStorekeeper;
            btnEditStorage.Visible = isAdmin || isStorekeeper;
            btnDeleteStorage.Visible = isAdmin;
        }

        private void LoadStorageLocations()
        {
            string searchText = txtSearchStorage.Text.Trim();

            string query = @"
        SELECT
            StorageLocationId,
            StorageCode,
            Description
        FROM dbo.vStorageLocations
        WHERE
            @SearchText = N''
            OR StorageCode LIKE N'%' + @SearchText + N'%'
            OR Description LIKE N'%' + @SearchText + N'%'
        ORDER BY StorageCode";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@SearchText", SqlDbType.NVarChar, 100).Value = searchText;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvStorageLocations.DataSource = table;
                }
            }
        }

        private void FrmStorageList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vStorageLocations". При необходимости она может быть перемещена или удалена.
            this.vStorageLocationsTableAdapter.Fill(this.domesoSystemDBDataSet.vStorageLocations);

            ConfigureAccessByRole();
            //ConfigureStorageGrid();
            LoadStorageLocations();
        }

        private void btnAddStorage_Click(object sender, EventArgs e)
        {
            FrmStorageEdit frmStorageEdit = new FrmStorageEdit();
            if (frmStorageEdit.ShowDialog() == DialogResult.OK)
            {
                LoadStorageLocations();
            }
        }

        private void btnRefreshStorage_Click(object sender, EventArgs e)
        {
            LoadStorageLocations();
        }

        private void txtSearchStorage_TextChanged(object sender, EventArgs e)
        {
            LoadStorageLocations();
        }

        private int? GetSelectedStorageLocationId()
        {
            if (dgvStorageLocations.CurrentRow == null)
            {
                return null;
            }

            object value = dgvStorageLocations.CurrentRow.Cells["storageLocationIdDataGridViewTextBoxColumn"].Value;

            if (value == null || value == DBNull.Value)
            {
                return null;
            }

            return Convert.ToInt32(value);
        }

        private void btnEditStorage_Click(object sender, EventArgs e)
        {
            int? storageLocationId = GetSelectedStorageLocationId();

            if (storageLocationId == null)
            {
                MessageBox.Show(
                    "Выберите место хранения для изменения.",
                    "Выбор записи",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            FrmStorageEdit form = new FrmStorageEdit(storageLocationId.Value);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadStorageLocations();
            }
        }

        private void SoftDeleteStorageLocation(int storageLocationId)
        {
            string checkQuery = @"
        SELECT COUNT(*)
        FROM dbo.Batches
        WHERE StorageLocationId = @StorageLocationId
          AND CurrentQuantity > 0";

            string deleteQuery = @"
        UPDATE dbo.StorageLocations
        SET IsActive = 0
        WHERE StorageLocationId = @StorageLocationId";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            {
                connection.Open();

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.Add("@StorageLocationId", SqlDbType.Int).Value = storageLocationId;

                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        throw new InvalidOperationException(
                            "Нельзя удалить место хранения, в котором есть товары с ненулевым остатком."
                        );
                    }
                }

                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.Add("@StorageLocationId", SqlDbType.Int).Value = storageLocationId;
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }
        private void btnDeleteStorage_Click(object sender, EventArgs e)
        {
            int? storageLocationId = GetSelectedStorageLocationId();

            if (storageLocationId == null)
            {
                MessageBox.Show(
                    "Выберите место хранения для удаления.",
                    "Выбор записи",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить выбранное место хранения?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                SoftDeleteStorageLocation(storageLocationId.Value);
                LoadStorageLocations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при удалении места хранения.\n\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
