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
    public partial class FrmWriteOffList : Form
    {
        public FrmWriteOffList()
        {
            InitializeComponent();
        }

        private void ConfigureAccessByRole()
        {
            btnAddWriteOff.Visible = CurrentUser.IsStorekeeper;
        }

        private void LoadReasonFilter()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Reason", typeof(string));
            table.Columns.Add("ReasonName", typeof(string));

            table.Rows.Add("", "Все причины");
            table.Rows.Add("Истек срок годности", "Истек срок годности");
            table.Rows.Add("Повреждена упаковка", "Повреждена упаковка");
            table.Rows.Add("Брак", "Брак");
            table.Rows.Add("Порча товара", "Порча товара");
            table.Rows.Add("Другое", "Другое");

            cmbReasonFilter.DataSource = table;
            cmbReasonFilter.DisplayMember = "ReasonName";
            cmbReasonFilter.ValueMember = "Reason";
            cmbReasonFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadWriteOffs()
        {
            string searchText = txtSearchWriteOff.Text.Trim();
            string reason = "";

            if (cmbReasonFilter.SelectedValue != null)
            {
                reason = cmbReasonFilter.SelectedValue.ToString();
            }

            DateTime dateFrom = dtpDateFrom.Value.Date;
            DateTime dateTo = dtpDateTo.Value.Date;

            string query = @"
        SELECT
            WriteOffId,
            ProductName,
            BatchNumber,
            Quantity,
            Reason,
            WriteOffDate,
            Comment,
            CreatedByUser
        FROM dbo.vWriteOffs
        WHERE
            (@SearchText = N'' OR ProductName LIKE N'%' + @SearchText + N'%')
            AND (@Reason = N'' OR Reason = @Reason)
            AND WriteOffDate >= @DateFrom
            AND WriteOffDate <= @DateTo
        ORDER BY WriteOffDate DESC, WriteOffId DESC";

            using (SqlConnection connection = DbConnectionFactory.CreateConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.Add("@SearchText", SqlDbType.NVarChar, 150).Value = searchText;
                command.Parameters.Add("@Reason", SqlDbType.NVarChar, 100).Value = reason;
                command.Parameters.Add("@DateFrom", SqlDbType.Date).Value = dateFrom;
                command.Parameters.Add("@DateTo", SqlDbType.Date).Value = dateTo;

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvWriteOffs.DataSource = table;
                }
            }
        }


        private void FrmWriteOffList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "domesoSystemDBDataSet.vWriteOffs". При необходимости она может быть перемещена или удалена.
            this.vWriteOffsTableAdapter.Fill(this.domesoSystemDBDataSet.vWriteOffs);
            ConfigureAccessByRole();
            //ConfigureWriteOffsGrid();
            LoadReasonFilter();

            dtpDateFrom.Value = DateTime.Today.AddMonths(-1);
            dtpDateTo.Value = DateTime.Today;

            LoadWriteOffs();
        }

        private void btnAddWriteOff_Click(object sender, EventArgs e)
        {
            FrmWriteOffEdit frmWriteOffEdit = new FrmWriteOffEdit();
            if (frmWriteOffEdit.ShowDialog() == DialogResult.OK)
            {
                LoadWriteOffs();
            }
        }

        private void txtSearchWriteOff_TextChanged(object sender, EventArgs e)
        {
            LoadWriteOffs();
        }

        private void cmbReasonFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReasonFilter.SelectedValue != null)
            {
                LoadWriteOffs();
            }
        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadWriteOffs();
        }

        private void dtpDateTo_ValueChanged(object sender, EventArgs e)
        {
            LoadWriteOffs();
        }

        private void btnRefreshWriteOffs_Click(object sender, EventArgs e)
        {
            LoadWriteOffs();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
