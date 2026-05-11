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

namespace DomesoSystem.Forms
{
    public partial class FrmBatchEdit : Form
    {
        public FrmBatchEdit()
        {
            InitializeComponent();

            this.Text = "Регистрация поступления";
            lblTitle.Text = "Регистрация поступления";

            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }

        private void LoadProducts()
        {
            string query = @"
        SELECT ProductId, ProductName
        FROM dbo.vProducts
        ORDER BY ProductName";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbProduct.DataSource = table;
                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "ProductId";
                cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void LoadSuppliers()
        {
            string query = @"
        SELECT PartnerId, PartnerName
        FROM dbo.vSuppliers
        ORDER BY PartnerName";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbSupplier.DataSource = table;
                cmbSupplier.DisplayMember = "PartnerName";
                cmbSupplier.ValueMember = "PartnerId";
                cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void LoadStorageLocations()
        {
            string query = @"
        SELECT StorageLocationId, StorageCode
        FROM dbo.vStorageLocations
        ORDER BY StorageCode";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbStorageLocation.DataSource = table;
                cmbStorageLocation.DisplayMember = "StorageCode";
                cmbStorageLocation.ValueMember = "StorageLocationId";
                cmbStorageLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private bool ValidateBatch()
        {
            if (cmbProduct.SelectedValue == null)
            {
                MessageBox.Show(
                    "Выберите товар.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbProduct.Focus();
                return false;
            }

            if (cmbSupplier.SelectedValue == null)
            {
                MessageBox.Show(
                    "Выберите поставщика.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbSupplier.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBatchNumber.Text))
            {
                MessageBox.Show(
                    "Введите номер партии.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtBatchNumber.Focus();
                return false;
            }

            if (dtpExpirationDate.Value.Date < dtpReceiptDate.Value.Date)
            {
                MessageBox.Show(
                    "Срок годности не может быть раньше даты поступления.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                dtpExpirationDate.Focus();
                return false;
            }

            if (nudQuantity.Value <= 0)
            {
                MessageBox.Show(
                    "Количество должно быть больше нуля.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                nudQuantity.Focus();
                return false;
            }

            if (cmbStorageLocation.SelectedValue == null)
            {
                MessageBox.Show(
                    "Выберите место хранения.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbStorageLocation.Focus();
                return false;
            }

            return true;
        }

        private void FrmBatchEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'domesoSystemDBDataSet.vStorageLocations' table. You can move, or remove it, as needed.
            this.vStorageLocationsTableAdapter.Fill(this.domesoSystemDBDataSet.vStorageLocations);
            // TODO: This line of code loads data into the 'domesoSystemDBDataSet.vSuppliers' table. You can move, or remove it, as needed.
            this.vSuppliersTableAdapter.Fill(this.domesoSystemDBDataSet.vSuppliers);
            // TODO: This line of code loads data into the 'domesoSystemDBDataSet.vProducts' table. You can move, or remove it, as needed.
            this.vProductsTableAdapter.Fill(this.domesoSystemDBDataSet.vProducts);

            LoadProducts();
            LoadSuppliers();
            LoadStorageLocations();

            dtpReceiptDate.Value = DateTime.Today;
            dtpExpirationDate.Value = DateTime.Today.AddYears(1);
        }


        private void InsertBatch()
        {
            string query = @"
        INSERT INTO dbo.Batches
        (
            ProductId,
            SupplierId,
            BatchNumber,
            ReceiptDate,
            ExpirationDate,
            InitialQuantity,
            CurrentQuantity,
            StorageLocationId
        )
        VALUES
        (
            @ProductId,
            @SupplierId,
            @BatchNumber,
            @ReceiptDate,
            @ExpirationDate,
            @InitialQuantity,
            @CurrentQuantity,
            @StorageLocationId
        )";

            int quantity = Convert.ToInt32(nudQuantity.Value);

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ProductId", SqlDbType.Int).Value =
                    Convert.ToInt32(cmbProduct.SelectedValue);

                command.Parameters.Add("@SupplierId", SqlDbType.Int).Value =
                    Convert.ToInt32(cmbSupplier.SelectedValue);

                command.Parameters.Add("@BatchNumber", SqlDbType.NVarChar, 50).Value =
                    txtBatchNumber.Text.Trim();

                command.Parameters.Add("@ReceiptDate", SqlDbType.Date).Value =
                    dtpReceiptDate.Value.Date;

                command.Parameters.Add("@ExpirationDate", SqlDbType.Date).Value =
                    dtpExpirationDate.Value.Date;

                command.Parameters.Add("@InitialQuantity", SqlDbType.Int).Value =
                    quantity;

                command.Parameters.Add("@CurrentQuantity", SqlDbType.Int).Value =
                    quantity;

                command.Parameters.Add("@StorageLocationId", SqlDbType.Int).Value =
                    Convert.ToInt32(cmbStorageLocation.SelectedValue);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateBatch())
            {
                return;
            }

            try
            {
                InsertBatch();

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show(
                        "Партия с таким номером для выбранного товара и поставщика уже существует.",
                        "Дублирование данных",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Ошибка базы данных при сохранении поступления.\n\n" + ex.Message,
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при сохранении поступления.\n\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
