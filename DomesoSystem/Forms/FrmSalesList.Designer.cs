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
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.txtSearchSale = new System.Windows.Forms.TextBox();
            this.дидSearchSale = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvProductItems = new System.Windows.Forms.DataGridView();
            this.lblProductItems = new System.Windows.Forms.Label();
            this.btnDeletePartner = new System.Windows.Forms.Button();
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
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(41, 157);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 24;
            this.dgvSales.Size = new System.Drawing.Size(789, 408);
            this.dgvSales.TabIndex = 37;
            // 
            // txtSearchSale
            // 
            this.txtSearchSale.Location = new System.Drawing.Point(115, 94);
            this.txtSearchSale.Name = "txtSearchSale";
            this.txtSearchSale.Size = new System.Drawing.Size(186, 32);
            this.txtSearchSale.TabIndex = 36;
            // 
            // дидSearchSale
            // 
            this.дидSearchSale.AutoSize = true;
            this.дидSearchSale.Location = new System.Drawing.Point(37, 97);
            this.дидSearchSale.Name = "дидSearchSale";
            this.дидSearchSale.Size = new System.Drawing.Size(72, 23);
            this.дидSearchSale.TabIndex = 35;
            this.дидSearchSale.Text = "Поиск";
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
            // dgvProductItems
            // 
            this.dgvProductItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductItems.Location = new System.Drawing.Point(859, 187);
            this.dgvProductItems.Name = "dgvProductItems";
            this.dgvProductItems.RowHeadersWidth = 51;
            this.dgvProductItems.RowTemplate.Height = 24;
            this.dgvProductItems.Size = new System.Drawing.Size(262, 378);
            this.dgvProductItems.TabIndex = 47;
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
            // btnDeletePartner
            // 
            this.btnDeletePartner.Location = new System.Drawing.Point(307, 586);
            this.btnDeletePartner.Name = "btnDeletePartner";
            this.btnDeletePartner.Size = new System.Drawing.Size(143, 37);
            this.btnDeletePartner.TabIndex = 49;
            this.btnDeletePartner.Text = "Удалить";
            this.btnDeletePartner.UseVisualStyleBackColor = true;
            // 
            // FrmSalesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 651);
            this.Controls.Add(this.btnDeletePartner);
            this.Controls.Add(this.lblProductItems);
            this.Controls.Add(this.dgvProductItems);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefreshSales);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.txtSearchSale);
            this.Controls.Add(this.дидSearchSale);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSalesList";
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
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.TextBox txtSearchSale;
        private System.Windows.Forms.Label дидSearchSale;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvProductItems;
        private System.Windows.Forms.Label lblProductItems;
        private System.Windows.Forms.Button btnDeletePartner;
    }
}