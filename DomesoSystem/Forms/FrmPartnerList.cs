using DomesoSystem.Data;
using DomesoSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomesoSystem.Forms
{
    public partial class FrmPartnerList : Form
    {
        public FrmPartnerList()
        {
            InitializeComponent();
        }

        private void ConfigureAccessByRole()
        {
            bool isAdmin = CurrentUser.IsAdmin;

            btnAddPartner.Visible = isAdmin;
            btnEditPartner.Visible = isAdmin;
            btnDeletePartner.Visible = isAdmin;
        }

        private void LoadPartnerTypes()
        {
            DataTable table = new DataTable();
            table.Columns.Add("PartnerType", typeof(string));
            table.Columns.Add("PartnerTypeName", typeof(string));

            table.Rows.Add("", "Все контрагенты");
            table.Rows.Add("Manufacturer", "Производители");
            table.Rows.Add("Supplier", "Поставщики");

            cmbPartnerFilter.DataSource = table;
            cmbPartnerFilter.DisplayMember = "PartnerTypeName";
            cmbPartnerFilter.ValueMember = "PartnerType";
            cmbPartnerFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadPartners()
        {
            string searchText = txtSearchPartner.Text.Trim();
            string partnerType = "";

            if (cmbPartnerFilter.SelectedValue != null)
            {
                partnerType = cmbPartnerFilter.SelectedValue.ToString();
            }

            string query = @"
        SELECT
            PartnerId,
            PartnerTypeName,
            PartnerName,
            Country,
            Phone,
            Address,
            Email,
            ContactPerson,
            Description
        FROM dbo.vPartners
        WHERE
            (@SearchText = N'' OR PartnerName LIKE N'%' + @SearchText + N'%')
            AND (@PartnerType = N'' OR PartnerType = @PartnerType)
        ORDER BY PartnerTypeName, PartnerName";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@SearchText", SqlDbType.NVarChar, 150).Value = searchText;
                command.Parameters.Add("@PartnerType", SqlDbType.NVarChar, 20).Value = partnerType;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvPartners.DataSource = table;
                }
            }
        }

        private int? GetSelectedPartnerId()
        {
            if (dgvPartners.CurrentRow == null)
            {
                return null;
            }

            object value = dgvPartners.CurrentRow.Cells["partnerIdDataGridViewTextBoxColumn"].Value;

            if (value == null || value == DBNull.Value)
            {
                return null;
            }

            return Convert.ToInt32(value);
        }

        private void FrmPartnerList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vPartners". При необходимости она может быть перемещена или удалена.
            this.vPartnersTableAdapter.Fill(this.domesoSystemDBDataSet.vPartners);

            ConfigureAccessByRole();
            //ConfigurePartnersGrid();
            LoadPartnerTypes();
            LoadPartners();
        }

        private void btnAddPartner_Click(object sender, EventArgs e)
        {
            FrmPartnerEdit frmPartnerEdit = new FrmPartnerEdit();
            if (frmPartnerEdit.ShowDialog() == DialogResult.OK)
            {
                LoadPartners();
            }
        }

        private void txtSearchPartner_TextChanged(object sender, EventArgs e)
        {
            LoadPartners();
        }

        private void cmbPartnerFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPartnerFilter.SelectedValue != null)
            {
                LoadPartners();
            }
        }

        private void btnRefreshPartner_Click(object sender, EventArgs e)
        {
            LoadPartners();
        }

        private void btnEditPartner_Click(object sender, EventArgs e)
        {
            int? partnerId = GetSelectedPartnerId();

            if (partnerId == null)
            {
                MessageBox.Show(
                    "Выберите контрагента для изменения.",
                    "Выбор записи",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            FrmPartnerEdit form = new FrmPartnerEdit(partnerId.Value);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadPartners();
            }
        }

        private void SoftDeletePartner(int partnerId)
        {
            string checkManufacturerQuery = @"
        SELECT COUNT(*)
        FROM dbo.Products
        WHERE ManufacturerId = @PartnerId
          AND IsActive = 1";

            string checkSupplierQuery = @"
        SELECT COUNT(*)
        FROM dbo.Batches
        WHERE SupplierId = @PartnerId
          AND CurrentQuantity > 0";

            string deleteQuery = @"
        UPDATE dbo.Partners
        SET IsActive = 0
        WHERE PartnerId = @PartnerId";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(checkManufacturerQuery, connection))
                {
                    command.Parameters.Add("@PartnerId", SqlDbType.Int).Value = partnerId;

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        throw new InvalidOperationException(
                            "Нельзя удалить контрагента, который используется как производитель в карточках товаров."
                        );
                    }
                }

                using (SqlCommand command = new SqlCommand(checkSupplierQuery, connection))
                {
                    command.Parameters.Add("@PartnerId", SqlDbType.Int).Value = partnerId;

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        throw new InvalidOperationException(
                            "Нельзя удалить контрагента, который используется как поставщик в партиях с остатками."
                        );
                    }
                }

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.Add("@PartnerId", SqlDbType.Int).Value = partnerId;
                    command.ExecuteNonQuery();
                }
            }
        }
        private void btnDeletePartner_Click(object sender, EventArgs e)
        {
            int? partnerId = GetSelectedPartnerId();

            if (partnerId == null)
            {
                MessageBox.Show(
                    "Выберите контрагента для удаления.",
                    "Выбор записи",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить выбранного контрагента?",
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
                SoftDeletePartner(partnerId.Value);
                LoadPartners();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при удалении контрагента.\n\n" + ex.Message,
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
