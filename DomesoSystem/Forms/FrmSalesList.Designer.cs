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
            this.components = new System.ComponentModel.Container();
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
            this.vSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domesoSystemDBDataSet = new DomesoSystem.DomesoSystemDBDataSet();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvSaleItems = new System.Windows.Forms.DataGridView();
            this.saleIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSaleItemsGroupedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.SalesTableAdapter();
            this.vSaleItemsGroupedTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vSaleItemsGroupedTableAdapter();
            this.vSalesTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vSalesTableAdapter();
            this.vSaleItemsDetailedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vSaleItemsDetailedTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vSaleItemsDetailedTableAdapter();
            this.saleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleStatusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canceledAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canceledByUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domesoSystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSaleItemsGroupedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSaleItemsDetailedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDateTo.Location = new System.Drawing.Point(1068, 97);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(35, 23);
            this.lblDateTo.TabIndex = 46;
            this.lblDateTo.Text = "по";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateTo.Location = new System.Drawing.Point(1109, 93);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(129, 32);
            this.dtpDateTo.TabIndex = 45;
            this.dtpDateTo.ValueChanged += new System.EventHandler(this.dtpDateTo_ValueChanged);
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateFrom.Location = new System.Drawing.Point(928, 94);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(129, 32);
            this.dtpDateFrom.TabIndex = 44;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblDateFrom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDateFrom.Location = new System.Drawing.Point(842, 97);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(80, 23);
            this.lblDateFrom.TabIndex = 43;
            this.lblDateFrom.Text = "Дата с";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Linen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1095, 35);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 37);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefreshSales
            // 
            this.btnRefreshSales.BackColor = System.Drawing.Color.Linen;
            this.btnRefreshSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshSales.Location = new System.Drawing.Point(1095, 586);
            this.btnRefreshSales.Name = "btnRefreshSales";
            this.btnRefreshSales.Size = new System.Drawing.Size(143, 37);
            this.btnRefreshSales.TabIndex = 39;
            this.btnRefreshSales.Text = "Обновить";
            this.btnRefreshSales.UseVisualStyleBackColor = false;
            this.btnRefreshSales.Click += new System.EventHandler(this.btnRefreshSales_Click);
            // 
            // btnAddSale
            // 
            this.btnAddSale.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSale.Location = new System.Drawing.Point(38, 586);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(263, 37);
            this.btnAddSale.TabIndex = 38;
            this.btnAddSale.Text = "Оформить продажу";
            this.btnAddSale.UseVisualStyleBackColor = false;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // txtSearchSale
            // 
            this.txtSearchSale.Location = new System.Drawing.Point(115, 94);
            this.txtSearchSale.MaxLength = 100;
            this.txtSearchSale.Name = "txtSearchSale";
            this.txtSearchSale.Size = new System.Drawing.Size(186, 32);
            this.txtSearchSale.TabIndex = 36;
            this.txtSearchSale.TextChanged += new System.EventHandler(this.txtSearchSale_TextChanged);
            // 
            // lblSearchSale
            // 
            this.lblSearchSale.AutoSize = true;
            this.lblSearchSale.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchSale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSearchSale.Location = new System.Drawing.Point(37, 97);
            this.lblSearchSale.Name = "lblSearchSale";
            this.lblSearchSale.Size = new System.Drawing.Size(72, 23);
            this.lblSearchSale.TabIndex = 35;
            this.lblSearchSale.Text = "Поиск";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(31, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 37);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Продажи";
            // 
            // lblProductItems
            // 
            this.lblProductItems.AutoSize = true;
            this.lblProductItems.BackColor = System.Drawing.Color.Transparent;
            this.lblProductItems.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProductItems.Location = new System.Drawing.Point(855, 155);
            this.lblProductItems.Name = "lblProductItems";
            this.lblProductItems.Size = new System.Drawing.Size(194, 23);
            this.lblProductItems.TabIndex = 48;
            this.lblProductItems.Text = "Товарные позиции";
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.BackColor = System.Drawing.Color.Linen;
            this.btnCancelSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSale.Location = new System.Drawing.Point(307, 586);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(263, 37);
            this.btnCancelSale.TabIndex = 49;
            this.btnCancelSale.Text = "Отменить продажу";
            this.btnCancelSale.UseVisualStyleBackColor = false;
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AllowUserToResizeRows = false;
            this.dgvSales.AutoGenerateColumns = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIdDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.saleStatusDataGridViewTextBoxColumn,
            this.saleStatusNameDataGridViewTextBoxColumn,
            this.createdByUserDataGridViewTextBoxColumn,
            this.createdAtDataGridViewTextBoxColumn,
            this.canceledAtDataGridViewTextBoxColumn,
            this.canceledByUserDataGridViewTextBoxColumn,
            this.cancelReasonDataGridViewTextBoxColumn});
            this.dgvSales.DataSource = this.vSalesBindingSource;
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
            this.dgvSales.SelectionChanged += new System.EventHandler(this.dgvSales_SelectionChanged);
            // 
            // vSalesBindingSource
            // 
            this.vSalesBindingSource.DataMember = "vSales";
            this.vSalesBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // domesoSystemDBDataSet
            // 
            this.domesoSystemDBDataSet.DataSetName = "DomesoSystemDBDataSet";
            this.domesoSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // dgvSaleItems
            // 
            this.dgvSaleItems.AllowUserToAddRows = false;
            this.dgvSaleItems.AllowUserToDeleteRows = false;
            this.dgvSaleItems.AllowUserToResizeRows = false;
            this.dgvSaleItems.AutoGenerateColumns = false;
            this.dgvSaleItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaleItems.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvSaleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIdDataGridViewTextBoxColumn1,
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.lineTotalDataGridViewTextBoxColumn});
            this.dgvSaleItems.DataSource = this.vSaleItemsGroupedBindingSource;
            this.dgvSaleItems.EnableHeadersVisualStyles = false;
            this.dgvSaleItems.Location = new System.Drawing.Point(859, 187);
            this.dgvSaleItems.MultiSelect = false;
            this.dgvSaleItems.Name = "dgvSaleItems";
            this.dgvSaleItems.ReadOnly = true;
            this.dgvSaleItems.RowHeadersVisible = false;
            this.dgvSaleItems.RowHeadersWidth = 51;
            this.dgvSaleItems.RowTemplate.Height = 24;
            this.dgvSaleItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleItems.Size = new System.Drawing.Size(379, 378);
            this.dgvSaleItems.TabIndex = 51;
            // 
            // saleIdDataGridViewTextBoxColumn1
            // 
            this.saleIdDataGridViewTextBoxColumn1.DataPropertyName = "SaleId";
            this.saleIdDataGridViewTextBoxColumn1.HeaderText = "SaleId";
            this.saleIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.saleIdDataGridViewTextBoxColumn1.Name = "saleIdDataGridViewTextBoxColumn1";
            this.saleIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.saleIdDataGridViewTextBoxColumn1.Visible = false;
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
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineTotalDataGridViewTextBoxColumn
            // 
            this.lineTotalDataGridViewTextBoxColumn.DataPropertyName = "LineTotal";
            this.lineTotalDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.lineTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lineTotalDataGridViewTextBoxColumn.Name = "lineTotalDataGridViewTextBoxColumn";
            this.lineTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vSaleItemsGroupedBindingSource
            // 
            this.vSaleItemsGroupedBindingSource.DataMember = "vSaleItemsGrouped";
            this.vSaleItemsGroupedBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // vSaleItemsGroupedTableAdapter
            // 
            this.vSaleItemsGroupedTableAdapter.ClearBeforeFill = true;
            // 
            // vSalesTableAdapter
            // 
            this.vSalesTableAdapter.ClearBeforeFill = true;
            // 
            // vSaleItemsDetailedBindingSource
            // 
            this.vSaleItemsDetailedBindingSource.DataMember = "vSaleItemsDetailed";
            this.vSaleItemsDetailedBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // vSaleItemsDetailedTableAdapter
            // 
            this.vSaleItemsDetailedTableAdapter.ClearBeforeFill = true;
            // 
            // saleIdDataGridViewTextBoxColumn
            // 
            this.saleIdDataGridViewTextBoxColumn.DataPropertyName = "SaleId";
            this.saleIdDataGridViewTextBoxColumn.HeaderText = "SaleId";
            this.saleIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleIdDataGridViewTextBoxColumn.Name = "saleIdDataGridViewTextBoxColumn";
            this.saleIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.saleDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            this.saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.clientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.totalAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleStatusDataGridViewTextBoxColumn
            // 
            this.saleStatusDataGridViewTextBoxColumn.DataPropertyName = "SaleStatus";
            this.saleStatusDataGridViewTextBoxColumn.HeaderText = "SaleStatus";
            this.saleStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleStatusDataGridViewTextBoxColumn.Name = "saleStatusDataGridViewTextBoxColumn";
            this.saleStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.saleStatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // saleStatusNameDataGridViewTextBoxColumn
            // 
            this.saleStatusNameDataGridViewTextBoxColumn.DataPropertyName = "SaleStatusName";
            this.saleStatusNameDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.saleStatusNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleStatusNameDataGridViewTextBoxColumn.Name = "saleStatusNameDataGridViewTextBoxColumn";
            this.saleStatusNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // canceledAtDataGridViewTextBoxColumn
            // 
            this.canceledAtDataGridViewTextBoxColumn.DataPropertyName = "CanceledAt";
            this.canceledAtDataGridViewTextBoxColumn.HeaderText = "CanceledAt";
            this.canceledAtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.canceledAtDataGridViewTextBoxColumn.Name = "canceledAtDataGridViewTextBoxColumn";
            this.canceledAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.canceledAtDataGridViewTextBoxColumn.Visible = false;
            // 
            // canceledByUserDataGridViewTextBoxColumn
            // 
            this.canceledByUserDataGridViewTextBoxColumn.DataPropertyName = "CanceledByUser";
            this.canceledByUserDataGridViewTextBoxColumn.HeaderText = "CanceledByUser";
            this.canceledByUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.canceledByUserDataGridViewTextBoxColumn.Name = "canceledByUserDataGridViewTextBoxColumn";
            this.canceledByUserDataGridViewTextBoxColumn.ReadOnly = true;
            this.canceledByUserDataGridViewTextBoxColumn.Visible = false;
            // 
            // cancelReasonDataGridViewTextBoxColumn
            // 
            this.cancelReasonDataGridViewTextBoxColumn.DataPropertyName = "CancelReason";
            this.cancelReasonDataGridViewTextBoxColumn.HeaderText = "Причина отмены";
            this.cancelReasonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cancelReasonDataGridViewTextBoxColumn.Name = "cancelReasonDataGridViewTextBoxColumn";
            this.cancelReasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackColor = System.Drawing.Color.Linen;
            this.btnPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintInvoice.Location = new System.Drawing.Point(576, 586);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(254, 37);
            this.btnPrintInvoice.TabIndex = 52;
            this.btnPrintInvoice.Text = "Документ продажи";
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            // 
            // FrmSalesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DomesoSystem.Properties.Resources.bg4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1267, 651);
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.dgvSaleItems);
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
            this.Load += new System.EventHandler(this.FrmSalesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domesoSystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSaleItemsGroupedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSaleItemsDetailedBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvSaleItems;
        private DomesoSystemDBDataSet domesoSystemDBDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private DomesoSystemDBDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.BindingSource vSaleItemsGroupedBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vSaleItemsGroupedTableAdapter vSaleItemsGroupedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vSalesBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vSalesTableAdapter vSalesTableAdapter;
        private System.Windows.Forms.BindingSource vSaleItemsDetailedBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vSaleItemsDetailedTableAdapter vSaleItemsDetailedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleStatusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn canceledAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn canceledByUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancelReasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPrintInvoice;
    }
}