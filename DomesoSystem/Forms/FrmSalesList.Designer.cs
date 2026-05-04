namespace DomesoSystem.Forms
{
    partial class FrmSalesList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalesList));
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefreshSales = new System.Windows.Forms.Button();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.txtSearchSale = new System.Windows.Forms.TextBox();
            this.lblSearchSale = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblProductItems = new System.Windows.Forms.Label();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.dgvProductItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(951, 97);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(35, 23);
            this.lblDateTo.TabIndex = 46;
            this.lblDateTo.Text = "по";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(992, 93);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(129, 32);
            this.dtpDateTo.TabIndex = 45;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(811, 94);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(129, 32);
            this.dtpDateFrom.TabIndex = 44;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(725, 97);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(80, 23);
            this.lblDateFrom.TabIndex = 43;
            this.lblDateFrom.Text = "Дата с";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(978, 35);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 37);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRefreshSales
            // 
            this.btnRefreshSales.Location = new System.Drawing.Point(978, 586);
            this.btnRefreshSales.Name = "btnRefreshSales";
            this.btnRefreshSales.Size = new System.Drawing.Size(143, 37);
            this.btnRefreshSales.TabIndex = 39;
            this.btnRefreshSales.Text = "Обновить";
            this.btnRefreshSales.UseVisualStyleBackColor = true;
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(38, 586);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(263, 37);
            this.btnAddSale.TabIndex = 38;
            this.btnAddSale.Text = "Оформить продажу";
            this.btnAddSale.UseVisualStyleBackColor = true;
            // 
            // txtSearchSale
            // 
            this.txtSearchSale.Location = new System.Drawing.Point(115, 94);
            this.txtSearchSale.MaxLength = 100;
            this.txtSearchSale.Name = "txtSearchSale";
            this.txtSearchSale.Size = new System.Drawing.Size(186, 32);
            this.txtSearchSale.TabIndex = 36;
            // 
            // lblSearchSale
            // 
            this.lblSearchSale.AutoSize = true;
            this.lblSearchSale.Location = new System.Drawing.Point(37, 97);
            this.lblSearchSale.Name = "lblSearchSale";
            this.lblSearchSale.Size = new System.Drawing.Size(72, 23);
            this.lblSearchSale.TabIndex = 35;
            this.lblSearchSale.Text = "Поиск";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(31, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 46);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Продажи";
            // 
            // lblProductItems
            // 
            this.lblProductItems.AutoSize = true;
            this.lblProductItems.Location = new System.Drawing.Point(855, 155);
            this.lblProductItems.Name = "lblProductItems";
            this.lblProductItems.Size = new System.Drawing.Size(194, 23);
            this.lblProductItems.TabIndex = 48;
            this.lblProductItems.Text = "Товарные позиции";
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Location = new System.Drawing.Point(307, 586);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(263, 37);
            this.btnCancelSale.TabIndex = 49;
            this.btnCancelSale.Text = "Отменить продажу";
            this.btnCancelSale.UseVisualStyleBackColor = true;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AllowUserToResizeRows = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.EnableHeadersVisualStyles = false;
            this.dgvSales.Location = new System.Drawing.Point(41, 157);
            this.dgvSales.MultiSelect = false;
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(789, 408);
            this.dgvSales.TabIndex = 50;
            // 
            // dgvProductItems
            // 
            this.dgvProductItems.AllowUserToAddRows = false;
            this.dgvProductItems.AllowUserToDeleteRows = false;
            this.dgvProductItems.AllowUserToResizeRows = false;
            this.dgvProductItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductItems.EnableHeadersVisualStyles = false;
            this.dgvProductItems.Location = new System.Drawing.Point(859, 187);
            this.dgvProductItems.MultiSelect = false;
            this.dgvProductItems.Name = "dgvProductItems";
            this.dgvProductItems.ReadOnly = true;
            this.dgvProductItems.RowHeadersVisible = false;
            this.dgvProductItems.RowHeadersWidth = 51;
            this.dgvProductItems.RowTemplate.Height = 24;
            this.dgvProductItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductItems.Size = new System.Drawing.Size(262, 378);
            this.dgvProductItems.TabIndex = 51;
            // 
            // FrmSalesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 651);
            this.Controls.Add(this.dgvProductItems);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.btnCancelSale);
            this.Controls.Add(this.lblProductItems);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefreshSales);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.txtSearchSale);
            this.Controls.Add(this.lblSearchSale);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSalesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продажи";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefreshSales;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.TextBox txtSearchSale;
        private System.Windows.Forms.Label lblSearchSale;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProductItems;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DataGridView dgvProductItems;
    }
}