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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockList));
            this.nudDaysBeforeExpire = new System.Windows.Forms.NumericUpDown();
            this.chkExpiringSoon = new System.Windows.Forms.CheckBox();
            this.cmbProductFilter = new System.Windows.Forms.ComboBox();
            this.vProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domesoSystemDBDataSet = new DomesoSystem.DomesoSystemDBDataSet();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefreshStock = new System.Windows.Forms.Button();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.batchIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageLocationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblProductFilter = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbStorageFilter = new System.Windows.Forms.ComboBox();
            this.vStorageLocationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblStorageFilter = new System.Windows.Forms.Label();
            this.vStockTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vStockTableAdapter();
            this.vProductsTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vProductsTableAdapter();
            this.vStorageLocationsTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vStorageLocationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysBeforeExpire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domesoSystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vStorageLocationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDaysBeforeExpire
            // 
            this.nudDaysBeforeExpire.Location = new System.Drawing.Point(1263, 97);
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
            this.nudDaysBeforeExpire.TabIndex = 40;
            this.nudDaysBeforeExpire.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDaysBeforeExpire.ValueChanged += new System.EventHandler(this.nudDaysBeforeExpire_ValueChanged);
            // 
            // chkExpiringSoon
            // 
            this.chkExpiringSoon.AutoSize = true;
            this.chkExpiringSoon.BackColor = System.Drawing.Color.Transparent;
            this.chkExpiringSoon.Location = new System.Drawing.Point(984, 99);
            this.chkExpiringSoon.Name = "chkExpiringSoon";
            this.chkExpiringSoon.Size = new System.Drawing.Size(273, 27);
            this.chkExpiringSoon.TabIndex = 39;
            this.chkExpiringSoon.Text = "Истекает в ближайшие:";
            this.chkExpiringSoon.UseVisualStyleBackColor = false;
            this.chkExpiringSoon.CheckedChanged += new System.EventHandler(this.chkExpiringSoon_CheckedChanged);
            // 
            // cmbProductFilter
            // 
            this.cmbProductFilter.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbProductFilter.DataSource = this.vProductsBindingSource;
            this.cmbProductFilter.DisplayMember = "ProductName";
            this.cmbProductFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProductFilter.FormattingEnabled = true;
            this.cmbProductFilter.Location = new System.Drawing.Point(112, 96);
            this.cmbProductFilter.Name = "cmbProductFilter";
            this.cmbProductFilter.Size = new System.Drawing.Size(228, 31);
            this.cmbProductFilter.TabIndex = 38;
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
            this.btnClose.Location = new System.Drawing.Point(1182, 35);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 37);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefreshStock
            // 
            this.btnRefreshStock.BackColor = System.Drawing.Color.Linen;
            this.btnRefreshStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshStock.Location = new System.Drawing.Point(1182, 586);
            this.btnRefreshStock.Name = "btnRefreshStock";
            this.btnRefreshStock.Size = new System.Drawing.Size(143, 37);
            this.btnRefreshStock.TabIndex = 36;
            this.btnRefreshStock.Text = "Обновить";
            this.btnRefreshStock.UseVisualStyleBackColor = false;
            this.btnRefreshStock.Click += new System.EventHandler(this.btnRefreshStock_Click);
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.BackColor = System.Drawing.Color.Linen;
            this.btnResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFilters.Location = new System.Drawing.Point(39, 586);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(231, 37);
            this.btnResetFilters.TabIndex = 35;
            this.btnResetFilters.Text = "Сбросить фильтры";
            this.btnResetFilters.UseVisualStyleBackColor = false;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToResizeRows = false;
            this.dgvStock.AutoGenerateColumns = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batchIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.manufacturerNameDataGridViewTextBoxColumn,
            this.supplierIdDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.batchNumberDataGridViewTextBoxColumn,
            this.currentQuantityDataGridViewTextBoxColumn,
            this.expirationDateDataGridViewTextBoxColumn,
            this.storageLocationIdDataGridViewTextBoxColumn,
            this.storageCodeDataGridViewTextBoxColumn,
            this.stockStatusDataGridViewTextBoxColumn});
            this.dgvStock.DataSource = this.vStockBindingSource;
            this.dgvStock.EnableHeadersVisualStyles = false;
            this.dgvStock.Location = new System.Drawing.Point(39, 154);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(1286, 408);
            this.dgvStock.TabIndex = 34;
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
            // manufacturerNameDataGridViewTextBoxColumn
            // 
            this.manufacturerNameDataGridViewTextBoxColumn.DataPropertyName = "ManufacturerName";
            this.manufacturerNameDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.manufacturerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerNameDataGridViewTextBoxColumn.Name = "manufacturerNameDataGridViewTextBoxColumn";
            this.manufacturerNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // currentQuantityDataGridViewTextBoxColumn
            // 
            this.currentQuantityDataGridViewTextBoxColumn.DataPropertyName = "CurrentQuantity";
            this.currentQuantityDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.currentQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currentQuantityDataGridViewTextBoxColumn.Name = "currentQuantityDataGridViewTextBoxColumn";
            this.currentQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expirationDateDataGridViewTextBoxColumn
            // 
            this.expirationDateDataGridViewTextBoxColumn.DataPropertyName = "ExpirationDate";
            this.expirationDateDataGridViewTextBoxColumn.HeaderText = "Срок годности";
            this.expirationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expirationDateDataGridViewTextBoxColumn.Name = "expirationDateDataGridViewTextBoxColumn";
            this.expirationDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // stockStatusDataGridViewTextBoxColumn
            // 
            this.stockStatusDataGridViewTextBoxColumn.DataPropertyName = "StockStatus";
            this.stockStatusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.stockStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockStatusDataGridViewTextBoxColumn.Name = "stockStatusDataGridViewTextBoxColumn";
            this.stockStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vStockBindingSource
            // 
            this.vStockBindingSource.DataMember = "vStock";
            this.vStockBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // lblProductFilter
            // 
            this.lblProductFilter.AutoSize = true;
            this.lblProductFilter.BackColor = System.Drawing.Color.Transparent;
            this.lblProductFilter.Location = new System.Drawing.Point(38, 99);
            this.lblProductFilter.Name = "lblProductFilter";
            this.lblProductFilter.Size = new System.Drawing.Size(68, 23);
            this.lblProductFilter.TabIndex = 33;
            this.lblProductFilter.Text = "Товар";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(32, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 37);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Остатки";
            // 
            // cmbStorageFilter
            // 
            this.cmbStorageFilter.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbStorageFilter.DataSource = this.vStorageLocationsBindingSource;
            this.cmbStorageFilter.DisplayMember = "StorageCode";
            this.cmbStorageFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStorageFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStorageFilter.FormattingEnabled = true;
            this.cmbStorageFilter.Location = new System.Drawing.Point(543, 96);
            this.cmbStorageFilter.Name = "cmbStorageFilter";
            this.cmbStorageFilter.Size = new System.Drawing.Size(220, 31);
            this.cmbStorageFilter.TabIndex = 42;
            this.cmbStorageFilter.ValueMember = "StorageLocationId";
            this.cmbStorageFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStorageFilter_SelectedIndexChanged);
            // 
            // vStorageLocationsBindingSource
            // 
            this.vStorageLocationsBindingSource.DataMember = "vStorageLocations";
            this.vStorageLocationsBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // lblStorageFilter
            // 
            this.lblStorageFilter.AutoSize = true;
            this.lblStorageFilter.BackColor = System.Drawing.Color.Transparent;
            this.lblStorageFilter.Location = new System.Drawing.Point(361, 99);
            this.lblStorageFilter.Name = "lblStorageFilter";
            this.lblStorageFilter.Size = new System.Drawing.Size(176, 23);
            this.lblStorageFilter.TabIndex = 41;
            this.lblStorageFilter.Text = "Место хранения";
            // 
            // vStockTableAdapter
            // 
            this.vStockTableAdapter.ClearBeforeFill = true;
            // 
            // vProductsTableAdapter
            // 
            this.vProductsTableAdapter.ClearBeforeFill = true;
            // 
            // vStorageLocationsTableAdapter
            // 
            this.vStorageLocationsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmStockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DomesoSystem.Properties.Resources.bg4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 653);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStockList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Остатки";
            this.Load += new System.EventHandler(this.FrmStockList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysBeforeExpire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domesoSystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vStorageLocationsBindingSource)).EndInit();
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
        private DomesoSystemDBDataSet domesoSystemDBDataSet;
        private System.Windows.Forms.BindingSource vStockBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vStockTableAdapter vStockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageLocationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vProductsBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vProductsTableAdapter vProductsTableAdapter;
        private System.Windows.Forms.BindingSource vStorageLocationsBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vStorageLocationsTableAdapter vStorageLocationsTableAdapter;
    }
}