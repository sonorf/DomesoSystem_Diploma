using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DomesoSystem.Data;
using DomesoSystem.Models;
using System.Windows.Forms;

namespace DomesoSystem.Forms
{
    public partial class FrmBatchList : Form
    {
        private bool isLoading = false;
        public FrmBatchList()
        {
            InitializeComponent();
        }

        private void ConfigureAccessByRole()
        {
            btnAddBatch.Visible = CurrentUser.IsStorekeeper;
        }

        private void LoadProductFilter()
        {
            string query = @"
        SELECT
            0 AS ProductId,
            N'Все товары' AS ProductName,
            0 AS SortOrder
        UNION ALL
        SELECT
            ProductId,
            ProductName,
            1 AS SortOrder
        FROM dbo.vProducts
        ORDER BY SortOrder, ProductName";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbProductFilter.DataSource = table;
                cmbProductFilter.DisplayMember = "ProductName";
                cmbProductFilter.ValueMember = "ProductId";
                cmbProductFilter.DropDownStyle = ComboBoxStyle.DropDownList;

                if (cmbProductFilter.Items.Count > 0)
                {
                    cmbProductFilter.SelectedIndex = 0;
                }
            }
        }
        private void LoadBatches()
        {
            int productId = 0;

            if (cmbProductFilter.SelectedValue != null)
            {
                int.TryParse(cmbProductFilter.SelectedValue.ToString(), out productId);
            }

            bool expiringOnly = chkExpiringSoon.Checked;
            int daysBeforeExpire = Convert.ToInt32(nudDaysBeforeExpire.Value);

            string query = @"
        SELECT
            BatchId,
            ProductName,
            SupplierName,
            BatchNumber,
            ReceiptDate,
            ExpirationDate,
            InitialQuantity,
            CurrentQuantity,
            StorageCode,
            BatchStatus
        FROM dbo.vBatches
        WHERE
            (@ProductId = 0 OR ProductId = @ProductId)
            AND
            (
                @ExpiringOnly = 0
                OR ExpirationDate <= DATEADD(DAY, @DaysBeforeExpire, CAST(GETDATE() AS DATE))
            )
        ORDER BY ExpirationDate, ProductName, BatchNumber";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ProductId", SqlDbType.Int).Value = productId;
                command.Parameters.Add("@ExpiringOnly", SqlDbType.Bit).Value = expiringOnly;
                command.Parameters.Add("@DaysBeforeExpire", SqlDbType.Int).Value = daysBeforeExpire;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvBatches.DataSource = table;
                }
            }
        }
        private void FrmBatchList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vProducts". При необходимости она может быть перемещена или удалена.
            this.vProductsTableAdapter.Fill(this.domesoSystemDBDataSet.vProducts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vBatches". При необходимости она может быть перемещена или удалена.
            this.vBatchesTableAdapter.Fill(this.domesoSystemDBDataSet.vBatches);

            isLoading = true;
            ConfigureAccessByRole();
            //ConfigureBatchesGrid();
            nudDaysBeforeExpire.Enabled = chkExpiringSoon.Checked;
            LoadProductFilter();
            isLoading = false;
            LoadBatches();
        }

        private void btnAddBatch_Click(object sender, EventArgs e)
        {
            FrmBatchEdit frmBatchEdit = new FrmBatchEdit();
            if (frmBatchEdit.ShowDialog() == DialogResult.OK)
            {
                LoadBatches();
            }
        }

        private void cmbProductFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }

            LoadBatches();
        }

        private void chkExpiringSoon_CheckedChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            nudDaysBeforeExpire.Enabled = chkExpiringSoon.Checked;
            LoadBatches();
        }

        private void nudDaysBeforeExpire_ValueChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            if (chkExpiringSoon.Checked)
            {
                LoadBatches();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefreshBatches_Click(object sender, EventArgs e)
        {
            LoadBatches();
        }
    }
}
