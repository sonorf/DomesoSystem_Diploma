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
    public partial class FrmSaleEdit : Form
    {
        private DataTable saleItemsTable;
        private bool isLoading = false;

        public FrmSaleEdit()
        {
            InitializeComponent();

        }

        private void CreateSaleItemsTable()
        {
            saleItemsTable = new DataTable();

            saleItemsTable.Columns.Add("ProductId", typeof(int));
            saleItemsTable.Columns.Add("ProductName", typeof(string));
            saleItemsTable.Columns.Add("AvailableQuantity", typeof(int));
            saleItemsTable.Columns.Add("Quantity", typeof(int));
            saleItemsTable.Columns.Add("UnitPrice", typeof(decimal));
            saleItemsTable.Columns.Add("LineTotal", typeof(decimal));

            dgvProductItems.DataSource = saleItemsTable;

            UpdateTotalAmount();
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

        private int GetAvailableQuantity(int productId)
        {
            string query = @"
        SELECT ISNULL(SUM(CurrentQuantity), 0)
        FROM dbo.Batches
        WHERE ProductId = @ProductId
          AND CurrentQuantity > 0";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ProductId", SqlDbType.Int).Value = productId;

                connection.Open();

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private decimal GetProductPrice(int productId)
        {
            string query = @"
        SELECT Price
        FROM dbo.Products
        WHERE ProductId = @ProductId
          AND IsActive = 1";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ProductId", SqlDbType.Int).Value = productId;

                connection.Open();

                object result = command.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                {
                    return 0;
                }

                return Convert.ToDecimal(result);
            }
        }

        private void LoadSelectedProductInfo()
        {
            if (cmbProduct.SelectedValue == null)
            {
                lblAvailableQuantity.Text = "Доступный остаток: 0";
                nudQuantity.Maximum = 1;
                nudPrice.Value = 0;
                return;
            }

            int productId;

            if (!int.TryParse(cmbProduct.SelectedValue.ToString(), out productId))
            {
                return;
            }

            int availableQuantity = GetAvailableQuantity(productId);
            decimal price = GetProductPrice(productId);

            lblAvailableQuantity.Text = "Доступный остаток: " + availableQuantity.ToString();

            nudQuantity.Minimum = 1;
            nudQuantity.Maximum = Math.Max(1, availableQuantity);
            nudQuantity.Value = availableQuantity > 0 ? 1 : 1;

            if (price <= nudPrice.Maximum)
            {
                nudPrice.Value = price;
            }
        }


        private void FrmSaleEdit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vSaleItemsDetailed". При необходимости она может быть перемещена или удалена.
            this.vSaleItemsDetailedTableAdapter.Fill(this.domesoSystemDBDataSet.vSaleItemsDetailed);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vProducts". При необходимости она может быть перемещена или удалена.
            this.vProductsTableAdapter.Fill(this.domesoSystemDBDataSet.vProducts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vSaleItemsGrouped". При необходимости она может быть перемещена или удалена.
            this.vSaleItemsGroupedTableAdapter.Fill(this.domesoSystemDBDataSet.vSaleItemsGrouped);

            isLoading = true;

            dtpSaleDate.Value = DateTime.Today;

            ConfigureSaleItemsGrid();
            CreateSaleItemsTable();
            LoadProducts();

            isLoading = false;

            LoadSelectedProductInfo();
        }

        private void ConfigureSaleItemsGrid()
        {
            dgvProductItems.AutoGenerateColumns = false;
            dgvProductItems.Columns.Clear();

            dgvProductItems.ReadOnly = true;
            dgvProductItems.AllowUserToAddRows = false;
            dgvProductItems.AllowUserToDeleteRows = false;
            dgvProductItems.AllowUserToResizeRows = false;
            dgvProductItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductItems.MultiSelect = false;
            dgvProductItems.RowHeadersVisible = false;
            dgvProductItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProductItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProductId",
                HeaderText = "ProductId",
                DataPropertyName = "ProductId",
                Visible = false
            });

            dgvProductItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProductName",
                HeaderText = "Товар",
                DataPropertyName = "ProductName",
                FillWeight = 130
            });

            dgvProductItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAvailableQuantity",
                HeaderText = "Доступно",
                DataPropertyName = "AvailableQuantity",
                FillWeight = 80
            });

            dgvProductItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQuantity",
                HeaderText = "Кол-во",
                DataPropertyName = "Quantity",
                FillWeight = 80
            });

            dgvProductItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUnitPrice",
                HeaderText = "Цена",
                DataPropertyName = "UnitPrice",
                FillWeight = 90,
                DefaultCellStyle = { Format = "N2" }
            });

            dgvProductItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLineTotal",
                HeaderText = "Сумма",
                DataPropertyName = "LineTotal",
                FillWeight = 100,
                DefaultCellStyle = { Format = "N2" }
            });
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }

            LoadSelectedProductInfo();
        }

        private int GetQuantityAlreadyAdded(int productId)
        {
            int quantity = 0;

            foreach (DataRow row in saleItemsTable.Rows)
            {
                if (Convert.ToInt32(row["ProductId"]) == productId)
                {
                    quantity += Convert.ToInt32(row["Quantity"]);
                }
            }

            return quantity;
        }

        private DataRow FindSaleItemRow(int productId, decimal unitPrice)
        {
            foreach (DataRow row in saleItemsTable.Rows)
            {
                int rowProductId = Convert.ToInt32(row["ProductId"]);
                decimal rowUnitPrice = Convert.ToDecimal(row["UnitPrice"]);

                if (rowProductId == productId && rowUnitPrice == unitPrice)
                {
                    return row;
                }
            }

            return null;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedValue == null)
            {
                MessageBox.Show(
                    "Выберите товар.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int productId = Convert.ToInt32(cmbProduct.SelectedValue);
            string productName = cmbProduct.Text;
            int availableQuantity = GetAvailableQuantity(productId);
            int quantity = Convert.ToInt32(nudQuantity.Value);
            decimal unitPrice = nudPrice.Value;

            int alreadyAddedQuantity = GetQuantityAlreadyAdded(productId);
            int availableForAdding = availableQuantity - alreadyAddedQuantity;

            if (quantity > availableForAdding)
            {
                MessageBox.Show(
                    "Недостаточно товара на складе. Уже добавлено в продажу: " + alreadyAddedQuantity +
                    ". Доступно для добавления: " + availableForAdding + ".",
                    "Проверка остатка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (unitPrice < 0)
            {
                MessageBox.Show(
                    "Цена не может быть отрицательной.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DataRow existingRow = FindSaleItemRow(productId, unitPrice);

            if (existingRow != null)
            {
                int oldQuantity = Convert.ToInt32(existingRow["Quantity"]);
                int newQuantity = oldQuantity + quantity;

                existingRow["Quantity"] = newQuantity;
                existingRow["LineTotal"] = newQuantity * unitPrice;
            }
            else
            {
                DataRow row = saleItemsTable.NewRow();

                row["ProductId"] = productId;
                row["ProductName"] = productName;
                row["AvailableQuantity"] = availableQuantity;
                row["Quantity"] = quantity;
                row["UnitPrice"] = unitPrice;
                row["LineTotal"] = quantity * unitPrice;

                saleItemsTable.Rows.Add(row);
            }

            UpdateTotalAmount();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvProductItems.CurrentRow == null)
            {
                MessageBox.Show(
                    "Выберите позицию для удаления.",
                    "Выбор записи",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DataRowView rowView = dgvProductItems.CurrentRow.DataBoundItem as DataRowView;

            if (rowView == null)
            {
                return;
            }

            rowView.Row.Delete();
            UpdateTotalAmount();
        }

        private decimal CalculateTotalAmount()
        {
            decimal total = 0;

            foreach (DataRow row in saleItemsTable.Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                {
                    continue;
                }

                total += Convert.ToDecimal(row["LineTotal"]);
            }

            return total;
        }

        private void UpdateTotalAmount()
        {
            decimal total = CalculateTotalAmount();
            lblTotalAmount.Text = "Итого: " + total.ToString("N2");
        }

        private bool ValidateSale()
        {
            if (string.IsNullOrWhiteSpace(txtSaleClient.Text))
            {
                MessageBox.Show(
                    "Введите наименование клиента.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtSaleClient.Focus();
                return false;
            }

            if (saleItemsTable.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Добавьте хотя бы одну товарную позицию.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            foreach (DataRow row in saleItemsTable.Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                {
                    continue;
                }

                int productId = Convert.ToInt32(row["ProductId"]);
                int quantity = Convert.ToInt32(row["Quantity"]);
                int availableQuantity = GetAvailableQuantity(productId);

                if (quantity > availableQuantity)
                {
                    string productName = row["ProductName"].ToString();

                    MessageBox.Show(
                        "Недостаточно товара на складе для позиции: " + productName,
                        "Проверка остатка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return false;
                }
            }

            return true;
        }


        private void SaveSaleWithTransaction()
        {
            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    int saleId = InsertSale(connection, transaction);

                    foreach (DataRow row in saleItemsTable.Rows)
                    {
                        if (row.RowState == DataRowState.Deleted)
                        {
                            continue;
                        }

                        int productId = Convert.ToInt32(row["ProductId"]);
                        int quantity = Convert.ToInt32(row["Quantity"]);
                        decimal unitPrice = Convert.ToDecimal(row["UnitPrice"]);

                        SaveSaleItemByFefo(connection, transaction, saleId, productId, quantity, unitPrice);
                    }

                    decimal totalAmount = CalculateTotalAmount();
                    UpdateSaleTotalAmount(connection, transaction, saleId, totalAmount);

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private int InsertSale(SqlConnection connection, SqlTransaction transaction)
        {
            string query = @"
        INSERT INTO dbo.Sales
        (
            SaleDate,
            ClientName,
            TotalAmount,
            SaleStatus,
            CreatedByUserId
        )
        OUTPUT INSERTED.SaleId
        VALUES
        (
            @SaleDate,
            @ClientName,
            0,
            N'Active',
            @CreatedByUserId
        )";

            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.Add("@SaleDate", SqlDbType.Date).Value = dtpSaleDate.Value.Date;
                command.Parameters.Add("@ClientName", SqlDbType.NVarChar, 150).Value = txtSaleClient.Text.Trim();
                command.Parameters.Add("@CreatedByUserId", SqlDbType.Int).Value = CurrentUser.UserId;

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        private void SaveSaleItemByFefo(
        SqlConnection connection,
        SqlTransaction transaction,
        int saleId,
        int productId,
        int requiredQuantity,
        decimal unitPrice)
        {
            int remainingQuantity = requiredQuantity;

            string selectBatchesQuery = @"
            SELECT
            BatchId,
            CurrentQuantity
            FROM dbo.Batches
            WHERE ProductId = @ProductId
            AND CurrentQuantity > 0
            ORDER BY ExpirationDate, BatchId";

            using (SqlCommand selectCommand = new SqlCommand(selectBatchesQuery, connection, transaction))
            {
                selectCommand.Parameters.Add("@ProductId", SqlDbType.Int).Value = productId;

                DataTable batchesTable = new DataTable();

                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    batchesTable.Load(reader);
                }

                foreach (DataRow batchRow in batchesTable.Rows)
                {
                    if (remainingQuantity <= 0)
                    {
                        break;
                    }

                    int batchId = Convert.ToInt32(batchRow["BatchId"]);
                    int currentQuantity = Convert.ToInt32(batchRow["CurrentQuantity"]);

                    int quantityFromBatch = Math.Min(remainingQuantity, currentQuantity);

                    InsertSaleItem(connection, transaction, saleId, productId, batchId, quantityFromBatch, unitPrice);
                    DecreaseBatchQuantity(connection, transaction, batchId, quantityFromBatch);

                    remainingQuantity -= quantityFromBatch;
                }
            }

            if (remainingQuantity > 0)
            {
                throw new InvalidOperationException(
                    "Недостаточно товара на складе для оформления продажи."
                );
            }
        }

        private void InsertSaleItem(
        SqlConnection connection,
        SqlTransaction transaction,
        int saleId,
        int productId,
        int batchId,
        int quantity,
        decimal unitPrice)
        {
            string query = @"
        INSERT INTO dbo.SaleItems
        (
            SaleId,
            ProductId,
            BatchId,
            Quantity,
            UnitPrice
        )
        VALUES
        (
            @SaleId,
            @ProductId,
            @BatchId,
            @Quantity,
            @UnitPrice
        )";

            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.Add("@SaleId", SqlDbType.Int).Value = saleId;
                command.Parameters.Add("@ProductId", SqlDbType.Int).Value = productId;
                command.Parameters.Add("@BatchId", SqlDbType.Int).Value = batchId;
                command.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
                command.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value = unitPrice;

                command.ExecuteNonQuery();
            }
        }


        private void DecreaseBatchQuantity(
        SqlConnection connection,
        SqlTransaction transaction,
        int batchId,
        int quantity)
        {
            string query = @"
        UPDATE dbo.Batches
        SET CurrentQuantity = CurrentQuantity - @Quantity
        WHERE BatchId = @BatchId
          AND CurrentQuantity >= @Quantity";

            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
                command.Parameters.Add("@BatchId", SqlDbType.Int).Value = batchId;

                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows == 0)
                {
                    throw new InvalidOperationException(
                        "Не удалось уменьшить остаток партии при оформлении продажи."
                    );
                }
            }
        }


        private void UpdateSaleTotalAmount(
        SqlConnection connection,
        SqlTransaction transaction,
        int saleId,
        decimal totalAmount)
        {
            string query = @"
        UPDATE dbo.Sales
        SET TotalAmount = @TotalAmount
        WHERE SaleId = @SaleId";

            using (SqlCommand command = new SqlCommand(query, connection, transaction))
            {
                command.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = totalAmount;
                command.Parameters.Add("@SaleId", SqlDbType.Int).Value = saleId;

                command.ExecuteNonQuery();
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateSale())
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                "Оформить продажу?",
                "Подтверждение продажи",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                SaveSaleWithTransaction();

                MessageBox.Show(
                    "Продажа успешно оформлена.",
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
                    "Ошибка при оформлении продажи.\n\n" + ex.Message,
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
