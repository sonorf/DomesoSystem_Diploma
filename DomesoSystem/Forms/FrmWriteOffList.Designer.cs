namespace DomesoSystem.Forms
{
    partial class FrmWriteOffList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWriteOffList));
            this.cmbReasonFilter = new System.Windows.Forms.ComboBox();
            this.lblReasonFilter = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefreshWriteOffs = new System.Windows.Forms.Button();
            this.btnAddWriteOff = new System.Windows.Forms.Button();
            this.dgvWriteOffs = new System.Windows.Forms.DataGridView();
            this.txtSearchWriteOff = new System.Windows.Forms.TextBox();
            this.lblSearchWriteOff = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriteOffs)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbReasonFilter
            // 
            this.cmbReasonFilter.FormattingEnabled = true;
            this.cmbReasonFilter.Location = new System.Drawing.Point(419, 93);
            this.cmbReasonFilter.Name = "cmbReasonFilter";
            this.cmbReasonFilter.Size = new System.Drawing.Size(203, 31);
            this.cmbReasonFilter.TabIndex = 29;
            // 
            // lblReasonFilter
            // 
            this.lblReasonFilter.AutoSize = true;
            this.lblReasonFilter.Location = new System.Drawing.Point(316, 96);
            this.lblReasonFilter.Name = "lblReasonFilter";
            this.lblReasonFilter.Size = new System.Drawing.Size(97, 23);
            this.lblReasonFilter.TabIndex = 28;
            this.lblReasonFilter.Text = "Причина";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(978, 34);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 37);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRefreshWriteOffs
            // 
            this.btnRefreshWriteOffs.Location = new System.Drawing.Point(978, 585);
            this.btnRefreshWriteOffs.Name = "btnRefreshWriteOffs";
            this.btnRefreshWriteOffs.Size = new System.Drawing.Size(143, 37);
            this.btnRefreshWriteOffs.TabIndex = 24;
            this.btnRefreshWriteOffs.Text = "Обновить";
            this.btnRefreshWriteOffs.UseVisualStyleBackColor = true;
            // 
            // btnAddWriteOff
            // 
            this.btnAddWriteOff.Location = new System.Drawing.Point(38, 585);
            this.btnAddWriteOff.Name = "btnAddWriteOff";
            this.btnAddWriteOff.Size = new System.Drawing.Size(263, 37);
            this.btnAddWriteOff.TabIndex = 23;
            this.btnAddWriteOff.Text = "Добавить списание";
            this.btnAddWriteOff.UseVisualStyleBackColor = true;
            // 
            // dgvWriteOffs
            // 
            this.dgvWriteOffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWriteOffs.Location = new System.Drawing.Point(41, 156);
            this.dgvWriteOffs.Name = "dgvWriteOffs";
            this.dgvWriteOffs.RowHeadersWidth = 51;
            this.dgvWriteOffs.RowTemplate.Height = 24;
            this.dgvWriteOffs.Size = new System.Drawing.Size(1080, 408);
            this.dgvWriteOffs.TabIndex = 22;
            // 
            // txtSearchWriteOff
            // 
            this.txtSearchWriteOff.Location = new System.Drawing.Point(115, 93);
            this.txtSearchWriteOff.Name = "txtSearchWriteOff";
            this.txtSearchWriteOff.Size = new System.Drawing.Size(186, 32);
            this.txtSearchWriteOff.TabIndex = 21;
            // 
            // lblSearchWriteOff
            // 
            this.lblSearchWriteOff.AutoSize = true;
            this.lblSearchWriteOff.Location = new System.Drawing.Point(37, 96);
            this.lblSearchWriteOff.Name = "lblSearchWriteOff";
            this.lblSearchWriteOff.Size = new System.Drawing.Size(72, 23);
            this.lblSearchWriteOff.TabIndex = 20;
            this.lblSearchWriteOff.Text = "Поиск";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(31, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 46);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Списания";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(725, 96);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(80, 23);
            this.lblDateFrom.TabIndex = 30;
            this.lblDateFrom.Text = "Дата с";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(811, 93);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(129, 32);
            this.dtpDateFrom.TabIndex = 31;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(992, 92);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(129, 32);
            this.dtpDateTo.TabIndex = 32;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(951, 96);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(35, 23);
            this.lblDateTo.TabIndex = 33;
            this.lblDateTo.Text = "по";
            // 
            // FrmWriteOffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 650);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.cmbReasonFilter);
            this.Controls.Add(this.lblReasonFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefreshWriteOffs);
            this.Controls.Add(this.btnAddWriteOff);
            this.Controls.Add(this.dgvWriteOffs);
            this.Controls.Add(this.txtSearchWriteOff);
            this.Controls.Add(this.lblSearchWriteOff);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmWriteOffList";
            this.Text = "Списания";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriteOffs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbReasonFilter;
        private System.Windows.Forms.Label lblReasonFilter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefreshWriteOffs;
        private System.Windows.Forms.Button btnAddWriteOff;
        private System.Windows.Forms.DataGridView dgvWriteOffs;
        private System.Windows.Forms.TextBox txtSearchWriteOff;
        private System.Windows.Forms.Label lblSearchWriteOff;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblDateTo;
    }
}