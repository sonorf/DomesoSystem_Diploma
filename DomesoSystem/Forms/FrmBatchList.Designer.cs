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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBatchList));
            this.cmbProductFilter = new System.Windows.Forms.ComboBox();
            this.vProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domesoSystemDBDataSet = new DomesoSystem.DomesoSystemDBDataSet();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefreshBatches = new System.Windows.Forms.Button();
            this.btnAddBatch = new System.Windows.Forms.Button();
            this.dgvBatches = new System.Windows.Forms.DataGridView();
            this.batchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageLocationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vBatchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProductFilter = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkExpiringSoon = new System.Windows.Forms.CheckBox();
            this.nudDaysBeforeExpire = new System.Windows.Forms.NumericUpDown();
            this.vBatchesTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vBatchesTableAdapter();
            this.vProductsTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domesoSystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBatchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysBeforeExpire)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProductFilter
            // 
            this.cmbProductFilter.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbProductFilter.DataSource = this.vProductsBindingSource;
            this.cmbProductFilter.DisplayMember = "ProductName";
            this.cmbProductFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProductFilter.FormattingEnabled = true;
            this.cmbProductFilter.Location = new System.Drawing.Point(110, 96);
            this.cmbProductFilter.Name = "cmbProductFilter";
            this.cmbProductFilter.Size = new System.Drawing.Size(264, 31);
            this.cmbProductFilter.TabIndex = 29;
            this.cmbProductFilter.ValueMember = "ProductId";
            this.cmbProductFilter.SelectedIndexChanged += new System.EventHandler(this.cmbProductFilter_SelectedIndexChanged);
            // 
            // vProductsBindingSource
            // 
            this.vProductsBindingSource.DataMember = "vProducts";
            this.vProductsBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // domesoSystemDBDataSet
            // 
            this.domesoSystemDBDataSet.DataSetName = "DomesoSystemDBDataSet";
            this.domesoSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Linen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1078, 35);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 37);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefreshBatches
            // 
            this.btnRefreshBatches.BackColor = System.Drawing.Color.Linen;
            this.btnRefreshBatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshBatches.Location = new System.Drawing.Point(1078, 586);
            this.btnRefreshBatches.Name = "btnRefreshBatches";
            this.btnRefreshBatches.Size = new System.Drawing.Size(143, 37);
            this.btnRefreshBatches.TabIndex = 24;
            this.btnRefreshBatches.Text = "Обновить";
            this.btnRefreshBatches.UseVisualStyleBackColor = false;
            this.btnRefreshBatches.Click += new System.EventHandler(this.btnRefreshBatches_Click);
            // 
            // btnAddBatch
            // 
            this.btnAddBatch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBatch.Location = new System.Drawing.Point(37, 586);
            this.btnAddBatch.Name = "btnAddBatch";
            this.btnAddBatch.Size = new System.Drawing.Size(277, 37);
            this.btnAddBatch.TabIndex = 23;
            this.btnAddBatch.Text = "Добавить поступление";
            this.btnAddBatch.UseVisualStyleBackColor = false;
            this.btnAddBatch.Click += new System.EventHandler(this.btnAddBatch_Click);
            // 
            // dgvBatches
            // 
            this.dgvBatches.AllowUserToAddRows = false;
            this.dgvBatches.AllowUserToDeleteRows = false;
            this.dgvBatches.AllowUserToResizeRows = false;
            this.dgvBatches.AutoGenerateColumns = false;
            this.dgvBatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBatches.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvBatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.supplierIdDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.batchNumberDataGridViewTextBoxColumn,
            this.receiptDateDataGridViewTextBoxColumn,
            this.expirationDateDataGridViewTextBoxColumn,
            this.initialQuantityDataGridViewTextBoxColumn,
            this.currentQuantityDataGridViewTextBoxColumn,
            this.storageLocationIdDataGridViewTextBoxColumn,
            this.storageCodeDataGridViewTextBoxColumn,
            this.batchStatusDataGridViewTextBoxColumn});
            this.dgvBatches.DataSource = this.vBatchesBindingSource;
            this.dgvBatches.EnableHeadersVisualStyles = false;
            this.dgvBatches.Location = new System.Drawing.Point(40, 157);
            this.dgvBatches.MultiSelect = false;
            this.dgvBatches.Name = "dgvBatches";
            this.dgvBatches.ReadOnly = true;
            this.dgvBatches.RowHeadersVisible = false;
            this.dgvBatches.RowHeadersWidth = 51;
            this.dgvBatches.RowTemplate.Height = 24;
            this.dgvBatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBatches.Size = new System.Drawing.Size(1181, 408);
            this.dgvBatches.TabIndex = 22;
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
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Товар";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            this.supplierIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.supplierNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchNumberDataGridViewTextBoxColumn
            // 
            this.batchNumberDataGridViewTextBoxColumn.DataPropertyName = "BatchNumber";
            this.batchNumberDataGridViewTextBoxColumn.HeaderText = "Партия";
            this.batchNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.batchNumberDataGridViewTextBoxColumn.Name = "batchNumberDataGridViewTextBoxColumn";
            this.batchNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receiptDateDataGridViewTextBoxColumn
            // 
            this.receiptDateDataGridViewTextBoxColumn.DataPropertyName = "ReceiptDate";
            this.receiptDateDataGridViewTextBoxColumn.HeaderText = "Принято";
            this.receiptDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receiptDateDataGridViewTextBoxColumn.Name = "receiptDateDataGridViewTextBoxColumn";
            this.receiptDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            this.expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            this.expirationDateDataGridViewTextBoxColumn.HeaderText = "Срок годности";
            this.expirationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            this.expirationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // initialQuantityDataGridViewTextBoxColumn
            // 
            this.initialQuantityDataGridViewTextBoxColumn.DataPropertyName = "InitialQuantity";
            this.initialQuantityDataGridViewTextBoxColumn.HeaderText = "Кол-во принятого";
            this.initialQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.initialQuantityDataGridViewTextBoxColumn.Name = "initialQuantityDataGridViewTextBoxColumn";
            this.initialQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentQuantityDataGridViewTextBoxColumn
            // 
            this.currentQuantityDataGridViewTextBoxColumn.DataPropertyName = "CurrentQuantity";
            this.currentQuantityDataGridViewTextBoxColumn.HeaderText = "Остаток";
            this.currentQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentQuantityDataGridViewTextBoxColumn.Name = "currentQuantityDataGridViewTextBoxColumn";
            this.currentQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storageLocationIdDataGridViewTextBoxColumn
            // 
            this.storageLocationIdDataGridViewTextBoxColumn.DataPropertyName = "StorageLocationId";
            this.storageLocationIdDataGridViewTextBoxColumn.HeaderText = "StorageLocationId";
            this.storageLocationIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.storageLocationIdDataGridViewTextBoxColumn.Name = "storageLocationIdDataGridViewTextBoxColumn";
            this.storageLocationIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.storageLocationIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // storageCodeDataGridViewTextBoxColumn
            // 
            this.storageCodeDataGridViewTextBoxColumn.DataPropertyName = "StorageCode";
            this.storageCodeDataGridViewTextBoxColumn.HeaderText = "Место хранения";
            this.storageCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.storageCodeDataGridViewTextBoxColumn.Name = "storageCodeDataGridViewTextBoxColumn";
            this.storageCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchStatusDataGridViewTextBoxColumn
            // 
            this.batchStatusDataGridViewTextBoxColumn.DataPropertyName = "BatchStatus";
            this.batchStatusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.batchStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.batchStatusDataGridViewTextBoxColumn.Name = "batchStatusDataGridViewTextBoxColumn";
            this.batchStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vBatchesBindingSource
            // 
            this.vBatchesBindingSource.DataMember = "vBatches";
            this.vBatchesBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // lblProductFilter
            // 
            this.lblProductFilter.AutoSize = true;
            this.lblProductFilter.BackColor = System.Drawing.Color.Transparent;
            this.lblProductFilter.Location = new System.Drawing.Point(36, 99);
            this.lblProductFilter.Name = "lblProductFilter";
            this.lblProductFilter.Size = new System.Drawing.Size(68, 23);
            this.lblProductFilter.TabIndex = 20;
            this.lblProductFilter.Text = "Товар";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(30, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(337, 37);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Партии/поступления";
            // 
            // chkExpiringSoon
            // 
            this.chkExpiringSoon.AutoSize = true;
            this.chkExpiringSoon.BackColor = System.Drawing.Color.Transparent;
            this.chkExpiringSoon.Location = new System.Drawing.Point(415, 98);
            this.chkExpiringSoon.Name = "chkExpiringSoon";
            this.chkExpiringSoon.Size = new System.Drawing.Size(273, 27);
            this.chkExpiringSoon.TabIndex = 30;
            this.chkExpiringSoon.Text = "Истекает в ближайшие:";
            this.chkExpiringSoon.UseVisualStyleBackColor = false;
            this.chkExpiringSoon.CheckedChanged += new System.EventHandler(this.chkExpiringSoon_CheckedChanged);
            // 
            // nudDaysBeforeExpire
            // 
            this.nudDaysBeforeExpire.Location = new System.Drawing.Point(694, 96);
            this.nudDaysBeforeExpire.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.nudDaysBeforeExpire.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDaysBeforeExpire.Name = "nudDaysBeforeExpire";
            this.nudDaysBeforeExpire.Size = new System.Drawing.Size(62, 32);
            this.nudDaysBeforeExpire.TabIndex = 31;
            this.nudDaysBeforeExpire.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDaysBeforeExpire.ValueChanged += new System.EventHandler(this.nudDaysBeforeExpire_ValueChanged);
            // 
            // vBatchesTableAdapter
            // 
            this.vBatchesTableAdapter.ClearBeforeFill = true;
            // 
            // vProductsTableAdapter
            // 
            this.vProductsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DomesoSystem.Properties.Resources.bg4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 653);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBatchList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Партии/поступления";
            this.Load += new System.EventHandler(this.FrmBatchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domesoSystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBatchesBindingSource)).EndInit();
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
        private DomesoSystemDBDataSet domesoSystemDBDataSet;
        private System.Windows.Forms.BindingSource vBatchesBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vBatchesTableAdapter vBatchesTableAdapter;
        private System.Windows.Forms.BindingSource vProductsBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vProductsTableAdapter vProductsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageLocationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchStatusDataGridViewTextBoxColumn;
    }
}