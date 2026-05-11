using System;
using System.Data.SqlClient;
using DomesoSystem.Data;
using DomesoSystem.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using DomesoSystem.Forms;

namespace DomesoSystem
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ShowCurrentUserInfo()
        {
            lblCurrentUser.Text = "Пользователь: " + CurrentUser.FullName;
            lblCurrentRole.Text = "Роль: " + GetRoleName(CurrentUser.UserRole);
        }

        private string GetRoleName(string role)
        {
            switch (role)
            {
                case "Admin":
                    return "Администратор";

                case "Storekeeper":
                    return "Кладовщик";

                case "Manager":
                    return "Менеджер";

                default:
                    return "Неизвестная роль";
            }
        }

        private void ConfigureAccessByRole()
        {
            bool isAdmin = CurrentUser.IsAdmin;
            bool isStorekeeper = CurrentUser.IsStorekeeper;
            bool isManager = CurrentUser.IsManager;

            // Товары: CRUD только администратор
            btnAddProduct.Visible = isAdmin;
            btnEditProduct.Visible = isAdmin;
            btnDeleteProduct.Visible = isAdmin;

        }

        private void ShowAccessDeniedMessage()
        {
            MessageBox.Show(
                "У вас недостаточно прав для доступа к данному разделу.",
                "Доступ запрещен",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }

        private void LoadManufacturersFilter()
        {
            string query = @"
        SELECT 
            0 AS PartnerId,
            N'Все производители' AS PartnerName,
            0 AS SortOrder
        UNION ALL
        SELECT 
            PartnerId,
            PartnerName,
            1 AS SortOrder
        FROM dbo.vManufacturers
        ORDER BY SortOrder, PartnerName";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbManufacturerFilter.DataSource = table;
                cmbManufacturerFilter.DisplayMember = "PartnerName";
                cmbManufacturerFilter.ValueMember = "PartnerId";
                cmbManufacturerFilter.DropDownStyle = ComboBoxStyle.DropDownList;

                if (cmbManufacturerFilter.Items.Count > 0)
                {
                    cmbManufacturerFilter.SelectedIndex = 0;
                }
            }
        }

        private void LoadProducts()
        {
            string searchText = txtSearchProduct.Text.Trim();

            int manufacturerId = 0;

            if (cmbManufacturerFilter.SelectedValue != null)
            {
                int.TryParse(cmbManufacturerFilter.SelectedValue.ToString(), out manufacturerId);
            }

            string query = @"
        SELECT
            ProductId,
            ProductName,
            ManufacturerName,
            Description,
            Price
        FROM dbo.vProducts
        WHERE
            (@SearchText = N'' OR ProductName LIKE N'%' + @SearchText + N'%')
            AND (@ManufacturerId = 0 OR ManufacturerId = @ManufacturerId)
        ORDER BY ProductName";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@SearchText", SqlDbType.NVarChar, 150).Value = searchText;
                command.Parameters.Add("@ManufacturerId", SqlDbType.Int).Value = manufacturerId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvProducts.DataSource = table;
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vProducts". При необходимости она может быть перемещена или удалена.
            this.vProductsTableAdapter.Fill(this.domesoSystemDBDataSet.vProducts);
            // TODO: This line of code loads data into the 'domesoSystemDBDataSet.vManufacturers' table. You can move, or remove it, as needed.
            this.vManufacturersTableAdapter.Fill(this.domesoSystemDBDataSet.vManufacturers);
            // TODO: This line of code loads data into the 'domesoSystemDBDataSet.vPartners' table. You can move, or remove it, as needed.
            this.vPartnersTableAdapter.Fill(this.domesoSystemDBDataSet.vPartners);

            ShowCurrentUserInfo();
            ConfigureAccessByRole();
            LoadManufacturersFilter();
            LoadProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmProductEdit frmProductEdit = new FrmProductEdit();
            if (frmProductEdit.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        private void btnPartners_Click(object sender, EventArgs e)
        {
            FrmPartnerList frmPartnerList = new FrmPartnerList();
            frmPartnerList.ShowDialog();
            LoadManufacturersFilter();
            LoadProducts();
        }

        private void btnStorageLocations_Click(object sender, EventArgs e)
        {
            FrmStorageList frmStorageLocations = new FrmStorageList();
            frmStorageLocations.ShowDialog();
        }

        private void btnBatches_Click(object sender, EventArgs e)
        {
            if (!CurrentUser.IsAdmin && !CurrentUser.IsStorekeeper)
            {
                ShowAccessDeniedMessage();
                return;
            }
            FrmBatchList frmBatchList = new FrmBatchList();
            frmBatchList.Show();
            LoadProducts();
        }

        private void btnWriteOffs_Click(object sender, EventArgs e)
        {
            if (!CurrentUser.IsAdmin && !CurrentUser.IsStorekeeper)
            {
                ShowAccessDeniedMessage();
                return;
            }
            FrmWriteOffList frmWriteOffList = new FrmWriteOffList();
            frmWriteOffList.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            if (!CurrentUser.IsAdmin && !CurrentUser.IsManager)
            {
                ShowAccessDeniedMessage();
                return;
            }
            FrmSalesList frmSalesList = new FrmSalesList();
            frmSalesList.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            FrmStockList frmStockList = new FrmStockList();
            frmStockList.ShowDialog();
        }

      
        private void txtSearchProduct_TextChanged_1(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void cmbManufacturerFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbManufacturerFilter.SelectedValue != null)
            {
                LoadProducts();
            }
        }

        private void btnResetProductFilters_Click(object sender, EventArgs e)
        {
            txtSearchProduct.Clear();

            if (cmbManufacturerFilter.Items.Count > 0)
            {
                cmbManufacturerFilter.SelectedIndex = 0;
            }

            LoadProducts();
        }

        private void btnRefreshProducts_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CurrentUser.Clear();

            FrmLogin loginForm = new FrmLogin();
            loginForm.Show();

            this.Close();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CurrentUser.UserId != 0)
            {
                Application.Exit();
            }
        }

        private int? GetSelectedProductId()
        {
            if (dgvProducts.CurrentRow == null)
            {
                return null;
            }

            object value = dgvProducts.CurrentRow.Cells["productIdDataGridViewTextBoxColumn"].Value;

            if (value == null || value == DBNull.Value)
            {
                return null;
            }

            return Convert.ToInt32(value);
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            int? productId = GetSelectedProductId();

            if (productId == null)
            {
                MessageBox.Show(
                    "Выберите товар для изменения.",
                    "Выбор записи",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            FrmProductEdit form = new FrmProductEdit(productId.Value);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }


        private void SoftDeleteProduct(int productId)
        {
            string checkQuery = @"
        SELECT COUNT(*)
        FROM dbo.Batches
        WHERE ProductId = @ProductId
          AND CurrentQuantity > 0";

            string deleteQuery = @"
        UPDATE dbo.Products
        SET IsActive = 0
        WHERE ProductId = @ProductId";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            {
                connection.Open();

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.Add("@ProductId", SqlDbType.Int).Value = productId;

                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        throw new InvalidOperationException(
                            "Нельзя удалить товар, по которому есть остатки на складе."
                        );
                    }
                }

                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.Add("@ProductId", SqlDbType.Int).Value = productId;
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int? productId = GetSelectedProductId();

            if (productId == null)
            {
                MessageBox.Show(
                    "Выберите товар для удаления.",
                    "Выбор записи",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить выбранный товар?",
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
                SoftDeleteProduct(productId.Value);
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при удалении товара.\n\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
