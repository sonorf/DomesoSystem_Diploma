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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWriteOffList));
            this.cmbReasonFilter = new System.Windows.Forms.ComboBox();
            this.lblReasonFilter = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefreshWriteOffs = new System.Windows.Forms.Button();
            this.btnAddWriteOff = new System.Windows.Forms.Button();
            this.txtSearchWriteOff = new System.Windows.Forms.TextBox();
            this.lblSearchWriteOff = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.domesoSystemDBDataSet = new DomesoSystem.DomesoSystemDBDataSet();
            this.vWriteOffsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vWriteOffsTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vWriteOffsTableAdapter();
            this.dgvWriteOffs = new System.Windows.Forms.DataGridView();
            this.writeOffIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.writeOffDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.domesoSystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWriteOffsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWriteOffs)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbReasonFilter
            // 
            this.cmbReasonFilter.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbReasonFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReasonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbReasonFilter.FormattingEnabled = true;
            this.cmbReasonFilter.Location = new System.Drawing.Point(419, 93);
            this.cmbReasonFilter.Name = "cmbReasonFilter";
            this.cmbReasonFilter.Size = new System.Drawing.Size(203, 31);
            this.cmbReasonFilter.TabIndex = 29;
            this.cmbReasonFilter.SelectedIndexChanged += new System.EventHandler(this.cmbReasonFilter_SelectedIndexChanged);
            // 
            // lblReasonFilter
            // 
            this.lblReasonFilter.AutoSize = true;
            this.lblReasonFilter.BackColor = System.Drawing.Color.Transparent;
            this.lblReasonFilter.Location = new System.Drawing.Point(316, 96);
            this.lblReasonFilter.Name = "lblReasonFilter";
            this.lblReasonFilter.Size = new System.Drawing.Size(97, 23);
            this.lblReasonFilter.TabIndex = 28;
            this.lblReasonFilter.Text = "Причина";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Linen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1184, 34);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 37);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefreshWriteOffs
            // 
            this.btnRefreshWriteOffs.BackColor = System.Drawing.Color.Linen;
            this.btnRefreshWriteOffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshWriteOffs.Location = new System.Drawing.Point(1184, 585);
            this.btnRefreshWriteOffs.Name = "btnRefreshWriteOffs";
            this.btnRefreshWriteOffs.Size = new System.Drawing.Size(143, 37);
            this.btnRefreshWriteOffs.TabIndex = 24;
            this.btnRefreshWriteOffs.Text = "Обновить";
            this.btnRefreshWriteOffs.UseVisualStyleBackColor = false;
            this.btnRefreshWriteOffs.Click += new System.EventHandler(this.btnRefreshWriteOffs_Click);
            // 
            // btnAddWriteOff
            // 
            this.btnAddWriteOff.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddWriteOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWriteOff.Location = new System.Drawing.Point(38, 585);
            this.btnAddWriteOff.Name = "btnAddWriteOff";
            this.btnAddWriteOff.Size = new System.Drawing.Size(263, 37);
            this.btnAddWriteOff.TabIndex = 23;
            this.btnAddWriteOff.Text = "Добавить списание";
            this.btnAddWriteOff.UseVisualStyleBackColor = false;
            this.btnAddWriteOff.Click += new System.EventHandler(this.btnAddWriteOff_Click);
            // 
            // txtSearchWriteOff
            // 
            this.txtSearchWriteOff.Location = new System.Drawing.Point(115, 93);
            this.txtSearchWriteOff.MaxLength = 100;
            this.txtSearchWriteOff.Name = "txtSearchWriteOff";
            this.txtSearchWriteOff.Size = new System.Drawing.Size(186, 32);
            this.txtSearchWriteOff.TabIndex = 21;
            this.txtSearchWriteOff.TextChanged += new System.EventHandler(this.txtSearchWriteOff_TextChanged);
            // 
            // lblSearchWriteOff
            // 
            this.lblSearchWriteOff.AutoSize = true;
            this.lblSearchWriteOff.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchWriteOff.Location = new System.Drawing.Point(37, 96);
            this.lblSearchWriteOff.Name = "lblSearchWriteOff";
            this.lblSearchWriteOff.Size = new System.Drawing.Size(72, 23);
            this.lblSearchWriteOff.TabIndex = 20;
            this.lblSearchWriteOff.Text = "Поиск";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(31, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 37);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Списания";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblDateFrom.Location = new System.Drawing.Point(931, 96);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(80, 23);
            this.lblDateFrom.TabIndex = 30;
            this.lblDateFrom.Text = "Дата с";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(1017, 93);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(129, 32);
            this.dtpDateFrom.TabIndex = 31;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(1198, 92);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(129, 32);
            this.dtpDateTo.TabIndex = 32;
            this.dtpDateTo.ValueChanged += new System.EventHandler(this.dtpDateTo_ValueChanged);
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTo.Location = new System.Drawing.Point(1157, 96);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(35, 23);
            this.lblDateTo.TabIndex = 33;
            this.lblDateTo.Text = "по";
            // 
            // domesoSystemDBDataSet
            // 
            this.domesoSystemDBDataSet.DataSetName = "DomesoSystemDBDataSet";
            this.domesoSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWriteOffsBindingSource
            // 
            this.vWriteOffsBindingSource.DataMember = "vWriteOffs";
            this.vWriteOffsBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // vWriteOffsTableAdapter
            // 
            this.vWriteOffsTableAdapter.ClearBeforeFill = true;
            // 
            // dgvWriteOffs
            // 
            this.dgvWriteOffs.AllowUserToAddRows = false;
            this.dgvWriteOffs.AllowUserToDeleteRows = false;
            this.dgvWriteOffs.AllowUserToResizeRows = false;
            this.dgvWriteOffs.AutoGenerateColumns = false;
            this.dgvWriteOffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWriteOffs.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvWriteOffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWriteOffs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.writeOffIdDataGridViewTextBoxColumn,
            this.batchIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.batchNumberDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.writeOffDateDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.createdByUserDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn});
            this.dgvWriteOffs.DataSource = this.vWriteOffsBindingSource;
            this.dgvWriteOffs.EnableHeadersVisualStyles = false;
            this.dgvWriteOffs.Location = new System.Drawing.Point(41, 149);
            this.dgvWriteOffs.MultiSelect = false;
            this.dgvWriteOffs.Name = "dgvWriteOffs";
            this.dgvWriteOffs.ReadOnly = true;
            this.dgvWriteOffs.RowHeadersVisible = false;
            this.dgvWriteOffs.RowHeadersWidth = 51;
            this.dgvWriteOffs.RowTemplate.Height = 24;
            this.dgvWriteOffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWriteOffs.Size = new System.Drawing.Size(1286, 408);
            this.dgvWriteOffs.TabIndex = 35;
            // 
            // writeOffIdDataGridViewTextBoxColumn
            // 
            this.writeOffIdDataGridViewTextBoxColumn.DataPropertyName = "WriteOffId";
            this.writeOffIdDataGridViewTextBoxColumn.HeaderText = "WriteOffId";
            this.writeOffIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.writeOffIdDataGridViewTextBoxColumn.Name = "writeOffIdDataGridViewTextBoxColumn";
            this.writeOffIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.writeOffIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // batchIdDataGridViewTextBoxColumn
            // 
            this.batchIdDataGridViewTextBoxColumn.DataPropertyName = "BatchId";
            this.batchIdDataGridViewTextBoxColumn.HeaderText = "BatchId";
            this.batchIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.batchIdDataGridViewTextBoxColumn.Name = "batchIdDataGridViewTextBoxColumn";
            this.batchIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.batchIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchNumberDataGridViewTextBoxColumn
            // 
            this.batchNumberDataGridViewTextBoxColumn.DataPropertyName = "BatchNumber";
            this.batchNumberDataGridViewTextBoxColumn.HeaderText = "Партия";
            this.batchNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.batchNumberDataGridViewTextBoxColumn.Name = "batchNumberDataGridViewTextBoxColumn";
            this.batchNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Причина";
            this.reasonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // writeOffDateDataGridViewTextBoxColumn
            // 
            this.writeOffDateDataGridViewTextBoxColumn.DataPropertyName = "WriteOffDate";
            this.writeOffDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.writeOffDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.writeOffDateDataGridViewTextBoxColumn.Name = "writeOffDateDataGridViewTextBoxColumn";
            this.writeOffDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdByUserDataGridViewTextBoxColumn
            // 
            this.createdByUserDataGridViewTextBoxColumn.DataPropertyName = "CreatedByUser";
            this.createdByUserDataGridViewTextBoxColumn.HeaderText = "Оформил";
            this.createdByUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdByUserDataGridViewTextBoxColumn.Name = "createdByUserDataGridViewTextBoxColumn";
            this.createdByUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdAtDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmWriteOffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DomesoSystem.Properties.Resources.bg4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1356, 650);
            this.Controls.Add(this.dgvWriteOffs);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.cmbReasonFilter);
            this.Controls.Add(this.lblReasonFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefreshWriteOffs);
            this.Controls.Add(this.btnAddWriteOff);
            this.Controls.Add(this.txtSearchWriteOff);
            this.Controls.Add(this.lblSearchWriteOff);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWriteOffList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Списания";
            this.Load += new System.EventHandler(this.FrmWriteOffList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.domesoSystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWriteOffsBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txtSearchWriteOff;
        private System.Windows.Forms.Label lblSearchWriteOff;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblDateTo;
        private DomesoSystemDBDataSet domesoSystemDBDataSet;
        private System.Windows.Forms.BindingSource vWriteOffsBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vWriteOffsTableAdapter vWriteOffsTableAdapter;
        private System.Windows.Forms.DataGridView dgvWriteOffs;
        private System.Windows.Forms.DataGridViewTextBoxColumn writeOffIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn writeOffDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
    }
}