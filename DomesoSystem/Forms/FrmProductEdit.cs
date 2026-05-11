using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using DomesoSystem.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomesoSystem.Forms
{
    public partial class FrmProductEdit : Form
    {
        private readonly int productId;

        public FrmProductEdit()
        {
            InitializeComponent();

            productId = 0;
            this.Text = "Добавление товара";
            lblTitle.Text = "Добавление товара";

            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }

        public FrmProductEdit(int productId)
        {
            InitializeComponent();

            this.productId = productId;
            this.Text = "Редактирование товара";
            lblTitle.Text = "Редактирование товара";

            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }

        private void LoadManufacturers()
        {
            string query = @"
        SELECT PartnerId, PartnerName
        FROM dbo.vManufacturers
        ORDER BY PartnerName";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbManufacturer.DataSource = table;
                cmbManufacturer.DisplayMember = "PartnerName";
                cmbManufacturer.ValueMember = "PartnerId";
                cmbManufacturer.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void LoadProductData()
        {
            string query = @"
        SELECT ProductName, ManufacturerId, Description, Price
        FROM dbo.Products
        WHERE ProductId = @ProductId
          AND IsActive = 1";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ProductId", SqlDbType.Int).Value = productId;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtProductName.Text = reader["ProductName"].ToString();
                        cmbManufacturer.SelectedValue = Convert.ToInt32(reader["ManufacturerId"]);
                        txtDescription.Text = reader["Description"].ToString();
                        nudPrice.Value = Convert.ToDecimal(reader["Price"]);
                    }
                    else
                    {
                        MessageBox.Show(
                            "Товар не найден или был удален.",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        DialogResult = DialogResult.Cancel;
                        Close();
                    }
                }
            }
        }

        private bool ValidateProduct()
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show(
                    "Введите наименование товара.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtProductName.Focus();
                return false;
            }

            if (cmbManufacturer.SelectedValue == null)
            {
                MessageBox.Show(
                    "Выберите производителя.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbManufacturer.Focus();
                return false;
            }

            if (nudPrice.Value < 0)
            {
                MessageBox.Show(
                    "Цена товара не может быть отрицательной.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                nudPrice.Focus();
                return false;
            }

            return true;
        }

        private void FrmProductEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vManufacturers". При необходимости она может быть перемещена или удалена.
            this.vManufacturersTableAdapter.Fill(this.domesoSystemDBDataSet.vManufacturers);

            LoadManufacturers();

            if (productId > 0)
            {
                LoadProductData();
            }
        }


        private void InsertProduct()
        {
            string query = @"
        INSERT INTO dbo.Products
        (
            ProductName,
            ManufacturerId,
            Description,
            Price
        )
        VALUES
        (
            @ProductName,
            @ManufacturerId,
            @Description,
            @Price
        )";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ProductName", SqlDbType.NVarChar, 150).Value = txtProductName.Text.Trim();
                command.Parameters.Add("@ManufacturerId", SqlDbType.Int).Value = Convert.ToInt32(cmbManufacturer.SelectedValue);
                command.Parameters.Add("@Description", SqlDbType.NVarChar, 500).Value = GetNullableValue(txtDescription.Text);
                command.Parameters.Add("@Price", SqlDbType.Decimal).Value = nudPrice.Value;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void UpdateProduct()
        {
            string query = @"
        UPDATE dbo.Products
        SET
            ProductName = @ProductName,
            ManufacturerId = @ManufacturerId,
            Description = @Description,
            Price = @Price
        WHERE ProductId = @ProductId
          AND IsActive = 1";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ProductName", SqlDbType.NVarChar, 150).Value = txtProductName.Text.Trim();
                command.Parameters.Add("@ManufacturerId", SqlDbType.Int).Value = Convert.ToInt32(cmbManufacturer.SelectedValue);
                command.Parameters.Add("@Description", SqlDbType.NVarChar, 500).Value = GetNullableValue(txtDescription.Text);
                command.Parameters.Add("@Price", SqlDbType.Decimal).Value = nudPrice.Value;
                command.Parameters.Add("@ProductId", SqlDbType.Int).Value = productId;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private object GetNullableValue(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return DBNull.Value;
            }

            return text.Trim();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateProduct())
            {
                return;
            }

            try
            {
                if (productId == 0)
                {
                    InsertProduct();
                }
                else
                {
                    UpdateProduct();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show(
                        "Товар с таким наименованием и производителем уже существует.",
                        "Дублирование данных",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Ошибка базы данных при сохранении товара.\n\n" + ex.Message,
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при сохранении товара.\n\n" + ex.Message,
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
