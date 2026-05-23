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
using Microsoft.VisualBasic;
using DomesoSystem.Services;

namespace DomesoSystem.Forms
{
    public partial class FrmSalesList : Form
    {
        public FrmSalesList()
        {
            InitializeComponent();
        }

        private void ConfigureAccessByRole()
        {
            btnAddSale.Visible = CurrentUser.IsManager;
            btnCancelSale.Visible = CurrentUser.IsManager;
            btnPrintInvoice.Visible = CurrentUser.IsAdmin || CurrentUser.IsManager;
        }


        private void FrmSalesList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vSaleItemsDetailed". При необходимости она может быть перемещена или удалена.
            this.vSaleItemsDetailedTableAdapter.Fill(this.domesoSystemDBDataSet.vSaleItemsDetailed);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vSales". При необходимости она может быть перемещена или удалена.
            this.vSalesTableAdapter.Fill(this.domesoSystemDBDataSet.vSales);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vSaleItemsGrouped". При необходимости она может быть перемещена или удалена.
            this.vSaleItemsGroupedTableAdapter.Fill(this.domesoSystemDBDataSet.vSaleItemsGrouped);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.domesoSystemDBDataSet.Sales);

            ConfigureAccessByRole();
            //ConfigureSalesGrid();

            dtpDateFrom.Value = DateTime.Today.AddMonths(-1);
            dtpDateTo.Value = DateTime.Today;

            LoadSales();
        }


        private void LoadSales()
        {
            string searchText = txtSearchSale.Text.Trim();
            DateTime dateFrom = dtpDateFrom.Value.Date;
            DateTime dateTo = dtpDateTo.Value.Date;

            string query = @"
        SELECT
            SaleId,
            SaleDate,
            ClientName,
            TotalAmount,
            SaleStatus,
            SaleStatusName,
            CreatedByUser,
            CancelReason
        FROM dbo.vSales
        WHERE
            (@SearchText = N'' OR ClientName LIKE N'%' + @SearchText + N'%')
            AND SaleDate >= @DateFrom
            AND SaleDate <= @DateTo
        ORDER BY SaleDate DESC, SaleId DESC";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@SearchText", SqlDbType.NVarChar, 150).Value = searchText;
                command.Parameters.Add("@DateFrom", SqlDbType.Date).Value = dateFrom;
                command.Parameters.Add("@DateTo", SqlDbType.Date).Value = dateTo;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvSales.DataSource = table;
                }
            }

            LoadSelectedSaleItems();
        }

        private int? GetSelectedSaleId()
        {
            if (dgvSales.CurrentRow == null)
            {
                return null;
            }

            object value = dgvSales.CurrentRow.Cells["saleIdDataGridViewTextBoxColumn"].Value;

            if (value == null || value == DBNull.Value)
            {
                return null;
            }

            return Convert.ToInt32(value);
        }

        private string GetSelectedSaleStatus()
        {
            if (dgvSales.CurrentRow == null)
            {
                return string.Empty;
            }

            if (!dgvSales.Columns.Contains("saleStatusDataGridViewTextBoxColumn"))
            {
                return string.Empty;
            }

            object value = dgvSales.CurrentRow.Cells["saleStatusDataGridViewTextBoxColumn"].Value;

            if (value == null || value == DBNull.Value)
            {
                return string.Empty;
            }

            return value.ToString();
        }

        private void LoadSelectedSaleItems()
        {
            int? saleId = GetSelectedSaleId();

            if (saleId == null)
            {
                dgvSaleItems.DataSource = null;
                return;
            }

            string query = @"
        SELECT
            ProductName,
            Quantity,
            UnitPrice,
            LineTotal
        FROM dbo.vSaleItemsGrouped
        WHERE SaleId = @SaleId
        ORDER BY ProductName";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@SaleId", SqlDbType.Int).Value = saleId.Value;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvSaleItems.DataSource = table;
                }
            }
        }


        private void btnAddSale_Click(object sender, EventArgs e)
        {
            FrmSaleEdit frmSaleEdit = new FrmSaleEdit();
            if (frmSaleEdit.ShowDialog() == DialogResult.OK)
            {
                LoadSales();
            }
        }

        private void dgvSales_SelectionChanged(object sender, EventArgs e)
        {
            LoadSelectedSaleItems();
        }

        private void txtSearchSale_TextChanged(object sender, EventArgs e)
        {
            LoadSales();
        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadSales();
        }

        private void dtpDateTo_ValueChanged(object sender, EventArgs e)
        {
            LoadSales();
        }

        private void btnRefreshSales_Click(object sender, EventArgs e)
        {
            LoadSales();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            int? saleId = GetSelectedSaleId();

            if (saleId == null)
            {
                MessageBox.Show(
                    "Выберите продажу для отмены.",
                    "Выбор записи",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string saleStatus = GetSelectedSaleStatus();

            if (saleStatus == "Canceled")
            {
                MessageBox.Show(
                    "Выбранная продажа уже отменена.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string reason;

            using (FrmCancelReason reasonForm = new FrmCancelReason())
            {
                if (reasonForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                reason = reasonForm.CancelReason;
            }

            DialogResult result = MessageBox.Show(
                "Отменить выбранную продажу? Количество товаров будет возвращено в соответствующие партии.",
                "Подтверждение отмены",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                CancelSaleWithTransaction(saleId.Value, reason.Trim());

                MessageBox.Show(
                    "Продажа успешно отменена.",
                    "Готово",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadSales();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при отмене продажи.\n\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void CancelSaleWithTransaction(int saleId, string cancelReason)
        {
            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string checkSaleQuery = @"
                SELECT SaleStatus
                FROM dbo.Sales
                WHERE SaleId = @SaleId";

                    using (SqlCommand checkCommand = new SqlCommand(checkSaleQuery, connection, transaction))
                    {
                        checkCommand.Parameters.Add("@SaleId", SqlDbType.Int).Value = saleId;

                        object statusObj = checkCommand.ExecuteScalar();

                        if (statusObj == null)
                        {
                            throw new InvalidOperationException("Продажа не найдена.");
                        }

                        string status = statusObj.ToString();

                        if (status == "Canceled")
                        {
                            throw new InvalidOperationException("Продажа уже отменена.");
                        }
                    }

                    string selectItemsQuery = @"
                SELECT BatchId, Quantity
                FROM dbo.SaleItems
                WHERE SaleId = @SaleId";

                    using (SqlCommand selectCommand = new SqlCommand(selectItemsQuery, connection, transaction))
                    {
                        selectCommand.Parameters.Add("@SaleId", SqlDbType.Int).Value = saleId;

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            DataTable saleItems = new DataTable();
                            saleItems.Load(reader);

                            foreach (DataRow row in saleItems.Rows)
                            {
                                int batchId = Convert.ToInt32(row["BatchId"]);
                                int quantity = Convert.ToInt32(row["Quantity"]);

                                string updateBatchQuery = @"
                            UPDATE dbo.Batches
                            SET CurrentQuantity = CurrentQuantity + @Quantity
                            WHERE BatchId = @BatchId";

                                using (SqlCommand updateBatchCommand = new SqlCommand(updateBatchQuery, connection, transaction))
                                {
                                    updateBatchCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = quantity;
                                    updateBatchCommand.Parameters.Add("@BatchId", SqlDbType.Int).Value = batchId;

                                    updateBatchCommand.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    string updateSaleQuery = @"
                UPDATE dbo.Sales
                SET
                    SaleStatus = N'Canceled',
                    CanceledAt = SYSDATETIME(),
                    CanceledByUserId = @CanceledByUserId,
                    CancelReason = @CancelReason
                WHERE SaleId = @SaleId
                  AND SaleStatus = N'Active'";

                    using (SqlCommand updateSaleCommand = new SqlCommand(updateSaleQuery, connection, transaction))
                    {
                        updateSaleCommand.Parameters.Add("@CanceledByUserId", SqlDbType.Int).Value = CurrentUser.UserId;
                        updateSaleCommand.Parameters.Add("@CancelReason", SqlDbType.NVarChar, 300).Value = cancelReason;
                        updateSaleCommand.Parameters.Add("@SaleId", SqlDbType.Int).Value = saleId;

                        int affectedRows = updateSaleCommand.ExecuteNonQuery();

                        if (affectedRows == 0)
                        {
                            throw new InvalidOperationException("Не удалось изменить статус продажи.");
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

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            int? saleId = GetSelectedSaleId();

            if (saleId == null)
            {
                MessageBox.Show(
                    "Выберите продажу для формирования счета.",
                    "Выбор записи",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                InvoicePdfService service = new InvoicePdfService();

                string filePath = service.GenerateInvoicePdf(saleId.Value);

                DialogResult result = MessageBox.Show(
                    "Счет успешно сформирован.\n\nОткрыть документ?",
                    "Готово",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes)
                {
                    service.OpenPdf(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при формировании счета-фактуры.\n\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
