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
    public partial class FrmStorageEdit : Form
    {
        private readonly int storageLocationId;
        public FrmStorageEdit()
        {
            InitializeComponent();

            storageLocationId = 0;
            this.Text = "Добавление места хранения";
            lblTitle.Text = "Добавление места хранения";

            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }

        public FrmStorageEdit(int storageLocationId)
        {
            InitializeComponent();

            this.storageLocationId = storageLocationId;
            this.Text = "Редактирование места хранения";
            lblTitle.Text = "Редактирование места хранения";

            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }

        private void LoadStorageLocationData()
        {
            string query = @"
        SELECT StorageCode, Description
        FROM dbo.StorageLocations
        WHERE StorageLocationId = @StorageLocationId
          AND IsActive = 1";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@StorageLocationId", SqlDbType.Int).Value = storageLocationId;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtStorageCode.Text = reader["StorageCode"].ToString();
                        txtStorageDescription.Text = reader["Description"].ToString();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Место хранения не найдено или было удалено.",
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

        private bool ValidateStorageLocation()
        {
            if (string.IsNullOrWhiteSpace(txtStorageCode.Text))
            {
                MessageBox.Show(
                    "Введите код места хранения.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtStorageCode.Focus();
                return false;
            }

            return true;
        }

        private void FrmStorageEdit_Load(object sender, EventArgs e)
        {
            if (storageLocationId > 0)
            {
                LoadStorageLocationData();
            }
        }

        private void InsertStorageLocation()
        {
            string query = @"
        INSERT INTO dbo.StorageLocations
        (
            StorageCode,
            Description
        )
        VALUES
        (
            @StorageCode,
            @Description
        )";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@StorageCode", SqlDbType.NVarChar, 50).Value =
                    txtStorageCode.Text.Trim();

                command.Parameters.Add("@Description", SqlDbType.NVarChar, 300).Value =
                    GetNullableValue(txtStorageDescription.Text);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        
        private void UpdateStorageLocation()
        {
            string query = @"
        UPDATE dbo.StorageLocations
        SET
            StorageCode = @StorageCode,
            Description = @Description
        WHERE StorageLocationId = @StorageLocationId
          AND IsActive = 1";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@StorageCode", SqlDbType.NVarChar, 50).Value =
                    txtStorageCode.Text.Trim();

                command.Parameters.Add("@Description", SqlDbType.NVarChar, 300).Value =
                    GetNullableValue(txtStorageDescription.Text);

                command.Parameters.Add("@StorageLocationId", SqlDbType.Int).Value =
                    storageLocationId;

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
            if (!ValidateStorageLocation())
            {
                return;
            }

            try
            {
                if (storageLocationId == 0)
                {
                    InsertStorageLocation();
                }
                else
                {
                    UpdateStorageLocation();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show(
                        "Место хранения с таким кодом уже существует.",
                        "Дублирование данных",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Ошибка базы данных при сохранении места хранения.\n\n" + ex.Message,
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при сохранении места хранения.\n\n" + ex.Message,
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
