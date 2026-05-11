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
    public partial class FrmPartnerEdit : Form
    {
        private readonly int partnerId;

        public FrmPartnerEdit()
        {
            InitializeComponent();

            partnerId = 0;
            this.Text = "Добавление контрагента";
            lblTitle.Text = "Добавление контрагента";

            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }

        public FrmPartnerEdit(int partnerId)
        {
            InitializeComponent();

            this.partnerId = partnerId;
            this.Text = "Редактирование контрагента";
            lblTitle.Text = "Редактирование контрагента";

            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }

        private void LoadPartnerTypes()
        {
            DataTable table = new DataTable();
            table.Columns.Add("PartnerType", typeof(string));
            table.Columns.Add("PartnerTypeName", typeof(string));

            table.Rows.Add("Manufacturer", "Производитель");
            table.Rows.Add("Supplier", "Поставщик");

            cmbPartnerType.DataSource = table;
            cmbPartnerType.DisplayMember = "PartnerTypeName";
            cmbPartnerType.ValueMember = "PartnerType";
            cmbPartnerType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadPartnerData()
        {
            string query = @"
        SELECT
            PartnerType,
            PartnerName,
            Country,
            Phone,
            Address,
            Email,
            ContactPerson,
            Description
        FROM dbo.Partners
        WHERE PartnerId = @PartnerId
          AND IsActive = 1";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@PartnerId", SqlDbType.Int).Value = partnerId;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cmbPartnerType.SelectedValue = reader["PartnerType"].ToString();
                        txtPartnerName.Text = reader["PartnerName"].ToString();
                        txtCountry.Text = reader["Country"].ToString();
                        txtPhone.Text = reader["Phone"].ToString();
                        txtAddress.Text = reader["Address"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtContactPerson.Text = reader["ContactPerson"].ToString();
                        txtDescription.Text = reader["Description"].ToString();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Контрагент не найден или был удален.",
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

        private bool ValidatePartner()
        {
            if (cmbPartnerType.SelectedValue == null)
            {
                MessageBox.Show(
                    "Выберите тип контрагента.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbPartnerType.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPartnerName.Text))
            {
                MessageBox.Show(
                    "Введите наименование контрагента.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPartnerName.Focus();
                return false;
            }

            string email = txtEmail.Text.Trim();

            if (!string.IsNullOrWhiteSpace(email) && !email.Contains("@"))
            {
                MessageBox.Show(
                    "Введите корректный адрес электронной почты.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtEmail.Focus();
                return false;
            }

            return true;
        }

        private void FrmPartnerEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vPartners". При необходимости она может быть перемещена или удалена.
            this.vPartnersTableAdapter.Fill(this.domesoSystemDBDataSet.vPartners);

            LoadPartnerTypes();

            if (partnerId > 0)
            {
                LoadPartnerData();
            }
        }

        private void InsertPartner()
        {
            string query = @"
        INSERT INTO dbo.Partners
        (
            PartnerType,
            PartnerName,
            Country,
            Phone,
            Address,
            Email,
            ContactPerson,
            Description
        )
        VALUES
        (
            @PartnerType,
            @PartnerName,
            @Country,
            @Phone,
            @Address,
            @Email,
            @ContactPerson,
            @Description
        )";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                FillPartnerParameters(command);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void UpdatePartner()
        {
            string query = @"
        UPDATE dbo.Partners
        SET
            PartnerType = @PartnerType,
            PartnerName = @PartnerName,
            Country = @Country,
            Phone = @Phone,
            Address = @Address,
            Email = @Email,
            ContactPerson = @ContactPerson,
            Description = @Description
        WHERE PartnerId = @PartnerId
          AND IsActive = 1";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                FillPartnerParameters(command);
                command.Parameters.Add("@PartnerId", SqlDbType.Int).Value = partnerId;

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

        private void FillPartnerParameters(SqlCommand command)
        {
            command.Parameters.Add("@PartnerType", SqlDbType.NVarChar, 20).Value =
                cmbPartnerType.SelectedValue.ToString();

            command.Parameters.Add("@PartnerName", SqlDbType.NVarChar, 150).Value =
                txtPartnerName.Text.Trim();

            command.Parameters.Add("@Country", SqlDbType.NVarChar, 100).Value =
                GetNullableValue(txtCountry.Text);

            command.Parameters.Add("@Phone", SqlDbType.NVarChar, 30).Value =
                GetNullableValue(txtPhone.Text);

            command.Parameters.Add("@Address", SqlDbType.NVarChar, 250).Value =
                GetNullableValue(txtAddress.Text);

            command.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value =
                GetNullableValue(txtEmail.Text);

            command.Parameters.Add("@ContactPerson", SqlDbType.NVarChar, 100).Value =
                GetNullableValue(txtContactPerson.Text);

            command.Parameters.Add("@Description", SqlDbType.NVarChar, 500).Value =
                GetNullableValue(txtDescription.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidatePartner())
            {
                return;
            }

            try
            {
                if (partnerId == 0)
                {
                    InsertPartner();
                }
                else
                {
                    UpdatePartner();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show(
                        "Контрагент с таким типом и наименованием уже существует.",
                        "Дублирование данных",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Ошибка базы данных при сохранении контрагента.\n\n" + ex.Message,
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при сохранении контрагента.\n\n" + ex.Message,
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
