using System;
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
    public partial class FrmCancelReason : Form
    {
        public string CancelReason { get; private set; }

        public FrmCancelReason()
        {
            InitializeComponent();

            this.Text = "Отмена продажи";
            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;

            btnCancel.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string reason = txtReason.Text.Trim();

            if (string.IsNullOrWhiteSpace(reason))
            {
                MessageBox.Show(
                    "Введите причину отмены продажи.",
                    "Проверка данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtReason.Focus();
                return;
            }

            CancelReason = reason;
            DialogResult = DialogResult.OK;
            Close();
        }

        
    }
}

