namespace DomesoSystem.Forms
{
    partial class FrmStockList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockList));
            this.nudDaysBeforeExpire = new System.Windows.Forms.NumericUpDown();
            this.chkExpiringSoon = new System.Windows.Forms.CheckBox();
            this.cmbProductFilter = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefreshStock = new System.Windows.Forms.Button();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.lblProductFilter = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbStorageFilter = new System.Windows.Forms.ComboBox();
            this.lblStorageFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysBeforeExpire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDaysBeforeExpire
            // 
            this.nudDaysBeforeExpire.Location = new System.Drawing.Point(1060, 97);
            this.nudDaysBeforeExpire.Name = "nudDaysBeforeExpire";
            this.nudDaysBeforeExpire.Size = new System.Drawing.Size(62, 32);
            this.nudDaysBeforeExpire.TabIndex = 40;
            // 
            // chkExpiringSoon
            // 
            this.chkExpiringSoon.AutoSize = true;
            this.chkExpiringSoon.Location = new System.Drawing.Point(781, 99);
            this.chkExpiringSoon.Name = "chkExpiringSoon";
            this.chkExpiringSoon.Size = new System.Drawing.Size(273, 27);
            this.chkExpiringSoon.TabIndex = 39;
            this.chkExpiringSoon.Text = "Истекает в ближайшие:";
            this.chkExpiringSoon.UseVisualStyleBackColor = true;
            // 
            // cmbProductFilter
            // 
            this.cmbProductFilter.FormattingEnabled = true;
            this.cmbProductFilter.Location = new System.Drawing.Point(112, 96);
            this.cmbProductFilter.Name = "cmbProductFilter";
            this.cmbProductFilter.Size = new System.Drawing.Size(228, 31);
            this.cmbProductFilter.TabIndex = 38;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(979, 35);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 37);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRefreshStock
            // 
            this.btnRefreshStock.Location = new System.Drawing.Point(979, 586);
            this.btnRefreshStock.Name = "btnRefreshStock";
            this.btnRefreshStock.Size = new System.Drawing.Size(143, 37);
            this.btnRefreshStock.TabIndex = 36;
            this.btnRefreshStock.Text = "Обновить";
            this.btnRefreshStock.UseVisualStyleBackColor = true;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Location = new System.Drawing.Point(39, 586);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(231, 37);
            this.btnResetFilters.TabIndex = 35;
            this.btnResetFilters.Text = "Сбросить фильтры";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(42, 157);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.Size = new System.Drawing.Size(1080, 408);
            this.dgvStock.TabIndex = 34;
            // 
            // lblProductFilter
            // 
            this.lblProductFilter.AutoSize = true;
            this.lblProductFilter.Location = new System.Drawing.Point(38, 99);
            this.lblProductFilter.Name = "lblProductFilter";
            this.lblProductFilter.Size = new System.Drawing.Size(68, 23);
            this.lblProductFilter.TabIndex = 33;
            this.lblProductFilter.Text = "Товар";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(32, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 46);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Остатки";
            // 
            // cmbStorageFilter
            // 
            this.cmbStorageFilter.FormattingEnabled = true;
            this.cmbStorageFilter.Location = new System.Drawing.Point(543, 96);
            this.cmbStorageFilter.Name = "cmbStorageFilter";
            this.cmbStorageFilter.Size = new System.Drawing.Size(97, 31);
            this.cmbStorageFilter.TabIndex = 42;
            // 
            // lblStorageFilter
            // 
            this.lblStorageFilter.AutoSize = true;
            this.lblStorageFilter.Location = new System.Drawing.Point(361, 99);
            this.lblStorageFilter.Name = "lblStorageFilter";
            this.lblStorageFilter.Size = new System.Drawing.Size(176, 23);
            this.lblStorageFilter.TabIndex = 41;
            this.lblStorageFilter.Text = "Место хранения";
            // 
            // FrmStockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 653);
            this.Controls.Add(this.cmbStorageFilter);
            this.Controls.Add(this.lblStorageFilter);
            this.Controls.Add(this.nudDaysBeforeExpire);
            this.Controls.Add(this.chkExpiringSoon);
            this.Controls.Add(this.cmbProductFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefreshStock);
            this.Controls.Add(this.btnResetFilters);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.lblProductFilter);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStockList";
            this.Text = "Остатки";
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysBeforeExpire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDaysBeforeExpire;
        private System.Windows.Forms.CheckBox chkExpiringSoon;
        private System.Windows.Forms.ComboBox cmbProductFilter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefreshStock;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label lblProductFilter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbStorageFilter;
        private System.Windows.Forms.Label lblStorageFilter;
    }
}