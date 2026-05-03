namespace DomesoSystem.Forms
{
    partial class FrmBatchList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBatchList));
            this.cmbProductFilter = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefreshBatches = new System.Windows.Forms.Button();
            this.btnAddBatch = new System.Windows.Forms.Button();
            this.dgvBatches = new System.Windows.Forms.DataGridView();
            this.lblProductFilter = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkExpiringSoon = new System.Windows.Forms.CheckBox();
            this.nudDaysBeforeExpire = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysBeforeExpire)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProductFilter
            // 
            this.cmbProductFilter.FormattingEnabled = true;
            this.cmbProductFilter.Location = new System.Drawing.Point(110, 96);
            this.cmbProductFilter.Name = "cmbProductFilter";
            this.cmbProductFilter.Size = new System.Drawing.Size(264, 31);
            this.cmbProductFilter.TabIndex = 29;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(977, 35);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 37);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRefreshBatches
            // 
            this.btnRefreshBatches.Location = new System.Drawing.Point(977, 586);
            this.btnRefreshBatches.Name = "btnRefreshBatches";
            this.btnRefreshBatches.Size = new System.Drawing.Size(143, 37);
            this.btnRefreshBatches.TabIndex = 24;
            this.btnRefreshBatches.Text = "Обновить";
            this.btnRefreshBatches.UseVisualStyleBackColor = true;
            // 
            // btnAddBatch
            // 
            this.btnAddBatch.Location = new System.Drawing.Point(37, 586);
            this.btnAddBatch.Name = "btnAddBatch";
            this.btnAddBatch.Size = new System.Drawing.Size(277, 37);
            this.btnAddBatch.TabIndex = 23;
            this.btnAddBatch.Text = "Добавить поступление";
            this.btnAddBatch.UseVisualStyleBackColor = true;
            // 
            // dgvBatches
            // 
            this.dgvBatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatches.Location = new System.Drawing.Point(40, 157);
            this.dgvBatches.Name = "dgvBatches";
            this.dgvBatches.RowHeadersWidth = 51;
            this.dgvBatches.RowTemplate.Height = 24;
            this.dgvBatches.Size = new System.Drawing.Size(1080, 408);
            this.dgvBatches.TabIndex = 22;
            // 
            // lblProductFilter
            // 
            this.lblProductFilter.AutoSize = true;
            this.lblProductFilter.Location = new System.Drawing.Point(36, 99);
            this.lblProductFilter.Name = "lblProductFilter";
            this.lblProductFilter.Size = new System.Drawing.Size(68, 23);
            this.lblProductFilter.TabIndex = 20;
            this.lblProductFilter.Text = "Товар";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(30, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(421, 46);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Партии/поступления";
            // 
            // chkExpiringSoon
            // 
            this.chkExpiringSoon.AutoSize = true;
            this.chkExpiringSoon.Location = new System.Drawing.Point(415, 98);
            this.chkExpiringSoon.Name = "chkExpiringSoon";
            this.chkExpiringSoon.Size = new System.Drawing.Size(273, 27);
            this.chkExpiringSoon.TabIndex = 30;
            this.chkExpiringSoon.Text = "Истекает в ближайшие:";
            this.chkExpiringSoon.UseVisualStyleBackColor = true;
            // 
            // nudDaysBeforeExpire
            // 
            this.nudDaysBeforeExpire.Location = new System.Drawing.Point(694, 96);
            this.nudDaysBeforeExpire.Name = "nudDaysBeforeExpire";
            this.nudDaysBeforeExpire.Size = new System.Drawing.Size(62, 32);
            this.nudDaysBeforeExpire.TabIndex = 31;
            // 
            // FrmBatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 653);
            this.Controls.Add(this.nudDaysBeforeExpire);
            this.Controls.Add(this.chkExpiringSoon);
            this.Controls.Add(this.cmbProductFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefreshBatches);
            this.Controls.Add(this.btnAddBatch);
            this.Controls.Add(this.dgvBatches);
            this.Controls.Add(this.lblProductFilter);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBatchList";
            this.Text = "Партии/поступления";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysBeforeExpire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProductFilter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefreshBatches;
        private System.Windows.Forms.Button btnAddBatch;
        private System.Windows.Forms.DataGridView dgvBatches;
        private System.Windows.Forms.Label lblProductFilter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkExpiringSoon;
        private System.Windows.Forms.NumericUpDown nudDaysBeforeExpire;
    }
}