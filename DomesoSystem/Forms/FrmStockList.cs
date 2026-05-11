using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DomesoSystem.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomesoSystem.Forms
{
    public partial class FrmStockList : Form
    {
        private bool isLoading = false;
        public FrmStockList()
        {
            InitializeComponent();
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

        private void LoadStorageFilter()
        {
            string query = @"
        SELECT
            0 AS StorageLocationId,
            N'Все места' AS StorageCode,
            0 AS SortOrder
        UNION ALL
        SELECT
            StorageLocationId,
            StorageCode,
            1 AS SortOrder
        FROM dbo.vStorageLocations
        ORDER BY SortOrder, StorageCode";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbStorageFilter.DataSource = table;
                cmbStorageFilter.DisplayMember = "StorageCode";
                cmbStorageFilter.ValueMember = "StorageLocationId";
                cmbStorageFilter.DropDownStyle = ComboBoxStyle.DropDownList;

                if (cmbStorageFilter.Items.Count > 0)
                {
                    cmbStorageFilter.SelectedIndex = 0;
                }
            }
        }

        private void LoadStock()
        {
            int productId = 0;
            int storageLocationId = 0;

            if (cmbProductFilter.SelectedValue != null)
            {
                int.TryParse(cmbProductFilter.SelectedValue.ToString(), out productId);
            }

            if (cmbStorageFilter.SelectedValue != null)
            {
                int.TryParse(cmbStorageFilter.SelectedValue.ToString(), out storageLocationId);
            }

            bool expiringOnly = chkExpiringSoon.Checked;
            int expireDays = Convert.ToInt32(nudDaysBeforeExpire.Value);

            string query = @"
        SELECT
            BatchId,
            ProductName,
            ManufacturerName,
            SupplierName,
            BatchNumber,
            CurrentQuantity,
            ExpirationDate,
            StorageCode,
            StockStatus
        FROM dbo.vStock
        WHERE
            (@ProductId = 0 OR ProductId = @ProductId)
            AND (@StorageLocationId = 0 OR StorageLocationId = @StorageLocationId)
            AND
            (
                @ExpiringOnly = 0
                OR ExpirationDate <= DATEADD(DAY, @ExpireDays, CAST(GETDATE() AS DATE))
            )
        ORDER BY ExpirationDate, ProductName, BatchNumber";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@ProductId", SqlDbType.Int).Value = productId;
                command.Parameters.Add("@StorageLocationId", SqlDbType.Int).Value = storageLocationId;
                command.Parameters.Add("@ExpiringOnly", SqlDbType.Bit).Value = expiringOnly;
                command.Parameters.Add("@ExpireDays", SqlDbType.Int).Value = expireDays;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvStock.DataSource = table;
                }
            }
        }


        private void FrmStockList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vStorageLocations". При необходимости она может быть перемещена или удалена.
            this.vStorageLocationsTableAdapter.Fill(this.domesoSystemDBDataSet.vStorageLocations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vProducts". При необходимости она может быть перемещена или удалена.
            this.vProductsTableAdapter.Fill(this.domesoSystemDBDataSet.vProducts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vStock". При необходимости она может быть перемещена или удалена.
            this.vStockTableAdapter.Fill(this.domesoSystemDBDataSet.vStock);


            //ConfigureStockGrid();
            isLoading = true;

            nudDaysBeforeExpire.Enabled = chkExpiringSoon.Checked;

            LoadProductFilter();
            LoadStorageFilter();

            isLoading = false;

            LoadStock();
        }

        private void cmbProductFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading && cmbProductFilter.SelectedValue != null)
            {
                LoadStock();
            }
            LoadStock();
        }

        private void cmbStorageFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading && cmbStorageFilter.SelectedValue != null)
            {
                LoadStock();
            }
            LoadStock();
        }

        private void chkExpiringSoon_CheckedChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            nudDaysBeforeExpire.Enabled = chkExpiringSoon.Checked;
            LoadStock();
        }

        private void nudDaysBeforeExpire_ValueChanged(object sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }

            if (chkExpiringSoon.Checked)
            {
                LoadStock();
            }
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            isLoading = true;

            if (cmbProductFilter.Items.Count > 0)
            {
                cmbProductFilter.SelectedIndex = 0;
            }

            if (cmbStorageFilter.Items.Count > 0)
            {
                cmbStorageFilter.SelectedIndex = 0;
            }

            chkExpiringSoon.Checked = false;
            nudDaysBeforeExpire.Value = 30;
            nudDaysBeforeExpire.Enabled = false;

            isLoading = false;

            LoadStock();
        }

        private void btnRefreshStock_Click(object sender, EventArgs e)
        {
            LoadStock();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
