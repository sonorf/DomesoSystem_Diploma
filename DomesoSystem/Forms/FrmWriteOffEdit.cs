using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using DomesoSystem.Data;
using DomesoSystem.Models;

namespace DomesoSystem.Forms
{
    public partial class FrmWriteOffEdit : Form
    {
        private int availableQuantity = 0;
        private bool isLoading = false;

        public FrmWriteOffEdit()
        {
            InitializeComponent();

            this.Text = "Оформление списания";
            lblTitle.Text = "Оформление списания";

            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }

        private void LoadProducts()
        {
            string query = @"
        SELECT DISTINCT
            ProductId,
            ProductName
        FROM dbo.vStock
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

        private void LoadReasons()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Reason", typeof(string));

            table.Rows.Add("Истек срок годности");
            table.Rows.Add("Повреждена упаковка");
            table.Rows.Add("Брак");
            table.Rows.Add("Порча товара");
            table.Rows.Add("Другое");

            cmbWriteOffReason.DataSource = table;
            cmbWriteOffReason.DisplayMember = "Reason";
            cmbWriteOffReason.ValueMember = "Reason";
            cmbWriteOffReason.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadBatchesForSelectedProduct()
        {
            if (cmbProduct.SelectedValue == null)
            {
                cmbBatch.DataSource = null;
                availableQuantity = 0;
                UpdateAvailableQuantityLabel();
                return;
            }

            int productId;

            if (!int.TryParse(cmbProduct.SelectedValue.ToString(), out productId))
            {
                return;
            }

            string query = @"
        SELECT
            BatchId,
            BatchNumber + N' | остаток: ' + CAST(CurrentQuantity AS NVARCHAR(20)) +
            N' | срок: ' + CONVERT(NVARCHAR(10), ExpirationDate, 104) AS BatchDisplay
        FROM dbo.vStock
        WHERE ProductId = @ProductId
          AND CurrentQuantity > 0
        ORDER BY ExpirationDate, BatchNumber";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ProductId", SqlDbType.Int).Value = productId;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    cmbBatch.DataSource = table;
                    cmbBatch.DisplayMember = "BatchDisplay";
                    cmbBatch.ValueMember = "BatchId";
                    cmbBatch.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }

            LoadSelectedBatchQuantity();
        }


        private void UpdateAvailableQuantityLabel()
        {
            lblAvailableQuantity.Text = "Доступный остаток: " + availableQuantity.ToString();
        }


        private void LoadSelectedBatchQuantity()
        {
            availableQuantity = 0;

            if (cmbBatch.SelectedValue == null)
            {
                UpdateAvailableQuantityLabel();
                return;
            }

            int batchId;

            if (!int.TryParse(cmbBatch.SelectedValue.ToString(), out batchId))
            {
                UpdateAvailableQuantityLabel();
                return;
            }

            string query = @"
        SELECT CurrentQuantity
        FROM dbo.Batches
        WHERE BatchId = @BatchId";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@BatchId", SqlDbType.Int).Value = batchId;

                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    availableQuantity = Convert.ToInt32(result);
                }
            }

            if (availableQuantity > 0)
            {
                nudWriteOffQuantity.Maximum = availableQuantity;
                nudWriteOffQuantity.Minimum = 1;

                if (nudWriteOffQuantity.Value > availableQuantity)
                {
                    nudWriteOffQuantity.Value = availableQuantity;
                }
            }

            UpdateAvailableQuantityLabel();
        }

        private void FrmWriteOffEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vProducts". При необходимости она может быть перемещена или удалена.
            this.vProductsTableAdapter.Fill(this.domesoSystemDBDataSet.vProducts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vBatches". При необходимости она может быть перемещена или удалена.
            this.vBatchesTableAdapter.Fill(this.domesoSystemDBDataSet.vBatches);
            isLoading = true;

            LoadProducts();
            LoadReasons();

            dtpWriteOffDate.Value = DateTime.Today;

            isLoading = false;

            LoadBatchesForSelectedProduct();
        }

        private bool ValidateWriteOff()
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

            if (cmbBatch.SelectedValue == null)
            {
                MessageBox.Show(
                    "Выберите партию.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbBatch.Focus();
                return false;
            }

            if (availableQuantity <= 0)
            {
                MessageBox.Show(
                    "По выбранной партии отсутствует доступный остаток.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbBatch.Focus();
                return false;
            }

            if (nudWriteOffQuantity.Value <= 0)
            {
                MessageBox.Show(
                    "Количество списания должно быть больше нуля.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                nudWriteOffQuantity.Focus();
                return false;
            }

            if (nudWriteOffQuantity.Value > availableQuantity)
            {
                MessageBox.Show(
                    "Количество списания не может превышать доступный остаток.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                nudWriteOffQuantity.Focus();
                return false;
            }

            if (cmbWriteOffReason.SelectedValue == null)
            {
                MessageBox.Show(
                    "Выберите причину списания.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbWriteOffReason.Focus();
                return false;
            }

            return true;
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }

            LoadBatchesForSelectedProduct();
        }

        private void cmbBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }

            LoadSelectedBatchQuantity();
        }

        private void InsertWriteOffWithTransaction()
        {
            int batchId = Convert.ToInt32(cmbBatch.SelectedValue);
            int quantity = Convert.ToInt32(nudWriteOffQuantity.Value);
            string reason = cmbWriteOffReason.SelectedValue.ToString();
            DateTime writeOffDate = dtpWriteOffDate.Value.Date;

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string checkQuery = @"
                SELECT CurrentQuantity
                FROM dbo.Batches
                WHERE BatchId = @BatchId";

                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection, transaction))
                    {
                        checkCommand.Parameters.Add("@BatchId", SqlDbType.Int).Value = batchId;

                        int currentQuantity = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (quantity > currentQuantity)
                        {
                            throw new InvalidOperationException(
                                "Недостаточно товара в выбранной партии для списания."
                            );
                        }
                    }

                    string insertQuery = @"
                INSERT INTO dbo.WriteOffs
                (
                    BatchId,
                    Quantity,
                    Reason,
                    WriteOffDate,
                    Comment,
                    CreatedByUserId
                )
                VALUES
                (
                    @BatchId,
                    @Quantity,
                    @Reason,
                    @WriteOffDate,
                    @Comment,
                    @CreatedByUserId
                )";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection, transaction))
                    {
                        insertCommand.Parameters.Add("@BatchId", SqlDbType.Int).Value = batchId;
                        insertCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
                        insertCommand.Parameters.Add("@Reason", SqlDbType.NVarChar, 100).Value = reason;
                        insertCommand.Parameters.Add("@WriteOffDate", SqlDbType.Date).Value = writeOffDate;
                        insertCommand.Parameters.Add("@Comment", SqlDbType.NVarChar, 300).Value = GetNullableValue(txtComment.Text);
                        insertCommand.Parameters.Add("@CreatedByUserId", SqlDbType.Int).Value = CurrentUser.UserId;

                        insertCommand.ExecuteNonQuery();
                    }

                    string updateBatchQuery = @"
                UPDATE dbo.Batches
                SET CurrentQuantity = CurrentQuantity - @Quantity
                WHERE BatchId = @BatchId
                  AND CurrentQuantity >= @Quantity";

                    using (SqlCommand updateCommand = new SqlCommand(updateBatchQuery, connection, transaction))
                    {
                        updateCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
                        updateCommand.Parameters.Add("@BatchId", SqlDbType.Int).Value = batchId;

                        int affectedRows = updateCommand.ExecuteNonQuery();

                        if (affectedRows == 0)
                        {
                            throw new InvalidOperationException(
                                "Не удалось обновить остаток партии."
                            );
                        }
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
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
            if (!ValidateWriteOff())
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Оформить списание выбранного товара?",
                "Подтверждение списания",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                InsertWriteOffWithTransaction();

                MessageBox.Show(
                    "Списание успешно оформлено.",
                    "Готово",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при оформлении списания.\n\n" + ex.Message,
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
