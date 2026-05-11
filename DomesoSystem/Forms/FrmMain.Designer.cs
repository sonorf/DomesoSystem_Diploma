namespace DomesoSystem
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblCurrentRole = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblManufacturerFilter = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.cmbManufacturerFilter = new System.Windows.Forms.ComboBox();
            this.vManufacturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domesoSystemDBDataSet = new DomesoSystem.DomesoSystemDBDataSet();
            this.btnResetProductFilters = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRefreshProducts = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPartners = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnWriteOffs = new System.Windows.Forms.Button();
            this.btnBatches = new System.Windows.Forms.Button();
            this.btnStorageLocations = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vPartnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vPartnersTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vPartnersTableAdapter();
            this.vManufacturersTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vManufacturersTableAdapter();
            this.vProductsTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vProductsTableAdapter();
            this.pbIconLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.vManufacturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domesoSystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPartnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentUser.Location = new System.Drawing.Point(77, 9);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(147, 23);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "Пользователь:";
            // 
            // lblCurrentRole
            // 
            this.lblCurrentRole.AutoSize = true;
            this.lblCurrentRole.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentRole.Location = new System.Drawing.Point(77, 39);
            this.lblCurrentRole.Name = "lblCurrentRole";
            this.lblCurrentRole.Size = new System.Drawing.Size(60, 23);
            this.lblCurrentRole.TabIndex = 1;
            this.lblCurrentRole.Text = "Роль:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Location = new System.Drawing.Point(14, 93);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(72, 23);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Поиск";
            // 
            // lblManufacturerFilter
            // 
            this.lblManufacturerFilter.AutoSize = true;
            this.lblManufacturerFilter.BackColor = System.Drawing.Color.Transparent;
            this.lblManufacturerFilter.Location = new System.Drawing.Point(384, 93);
            this.lblManufacturerFilter.Name = "lblManufacturerFilter";
            this.lblManufacturerFilter.Size = new System.Drawing.Size(158, 23);
            this.lblManufacturerFilter.TabIndex = 3;
            this.lblManufacturerFilter.Text = "Производитель";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(92, 90);
            this.txtSearchProduct.MaxLength = 100;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(265, 32);
            this.txtSearchProduct.TabIndex = 4;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged_1);
            // 
            // cmbManufacturerFilter
            // 
            this.cmbManufacturerFilter.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbManufacturerFilter.DataSource = this.vManufacturersBindingSource;
            this.cmbManufacturerFilter.DisplayMember = "PartnerName";
            this.cmbManufacturerFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManufacturerFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbManufacturerFilter.FormattingEnabled = true;
            this.cmbManufacturerFilter.Location = new System.Drawing.Point(548, 91);
            this.cmbManufacturerFilter.Name = "cmbManufacturerFilter";
            this.cmbManufacturerFilter.Size = new System.Drawing.Size(264, 31);
            this.cmbManufacturerFilter.TabIndex = 5;
            this.cmbManufacturerFilter.ValueMember = "PartnerId";
            this.cmbManufacturerFilter.SelectedIndexChanged += new System.EventHandler(this.cmbManufacturerFilter_SelectedIndexChanged);
            // 
            // vManufacturersBindingSource
            // 
            this.vManufacturersBindingSource.DataMember = "vManufacturers";
            this.vManufacturersBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // domesoSystemDBDataSet
            // 
            this.domesoSystemDBDataSet.DataSetName = "DomesoSystemDBDataSet";
            this.domesoSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnResetProductFilters
            // 
            this.btnResetProductFilters.BackColor = System.Drawing.Color.Linen;
            this.btnResetProductFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetProductFilters.Location = new System.Drawing.Point(883, 86);
            this.btnResetProductFilters.Name = "btnResetProductFilters";
            this.btnResetProductFilters.Size = new System.Drawing.Size(232, 36);
            this.btnResetProductFilters.TabIndex = 6;
            this.btnResetProductFilters.Text = "Сбросить фильтры";
            this.btnResetProductFilters.UseVisualStyleBackColor = false;
            this.btnResetProductFilters.Click += new System.EventHandler(this.btnResetProductFilters_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Location = new System.Drawing.Point(18, 600);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(143, 37);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Добавить";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRefreshProducts
            // 
            this.btnRefreshProducts.BackColor = System.Drawing.Color.Linen;
            this.btnRefreshProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshProducts.Location = new System.Drawing.Point(669, 600);
            this.btnRefreshProducts.Name = "btnRefreshProducts";
            this.btnRefreshProducts.Size = new System.Drawing.Size(143, 37);
            this.btnRefreshProducts.TabIndex = 9;
            this.btnRefreshProducts.Text = "Обновить";
            this.btnRefreshProducts.UseVisualStyleBackColor = false;
            this.btnRefreshProducts.Click += new System.EventHandler(this.btnRefreshProducts_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Linen;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Location = new System.Drawing.Point(316, 600);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(143, 37);
            this.btnDeleteProduct.TabIndex = 10;
            this.btnDeleteProduct.Text = "Удалить";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Location = new System.Drawing.Point(167, 600);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(143, 37);
            this.btnEditProduct.TabIndex = 11;
            this.btnEditProduct.Text = "Изменить";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Linen;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(986, 25);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(143, 37);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Выйти";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPartners
            // 
            this.btnPartners.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPartners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartners.Location = new System.Drawing.Point(854, 171);
            this.btnPartners.Name = "btnPartners";
            this.btnPartners.Size = new System.Drawing.Size(275, 44);
            this.btnPartners.TabIndex = 13;
            this.btnPartners.Text = "Контрагенты";
            this.btnPartners.UseVisualStyleBackColor = false;
            this.btnPartners.Click += new System.EventHandler(this.btnPartners_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Location = new System.Drawing.Point(854, 479);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(275, 44);
            this.btnStock.TabIndex = 15;
            this.btnStock.Text = "Остатки";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Location = new System.Drawing.Point(854, 416);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(275, 44);
            this.btnSales.TabIndex = 16;
            this.btnSales.Text = "Продажи";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnWriteOffs
            // 
            this.btnWriteOffs.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnWriteOffs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWriteOffs.Location = new System.Drawing.Point(854, 355);
            this.btnWriteOffs.Name = "btnWriteOffs";
            this.btnWriteOffs.Size = new System.Drawing.Size(275, 44);
            this.btnWriteOffs.TabIndex = 17;
            this.btnWriteOffs.Text = "Списания";
            this.btnWriteOffs.UseVisualStyleBackColor = false;
            this.btnWriteOffs.Click += new System.EventHandler(this.btnWriteOffs_Click);
            // 
            // btnBatches
            // 
            this.btnBatches.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatches.Location = new System.Drawing.Point(854, 295);
            this.btnBatches.Name = "btnBatches";
            this.btnBatches.Size = new System.Drawing.Size(275, 44);
            this.btnBatches.TabIndex = 18;
            this.btnBatches.Text = "Партии/поступления";
            this.btnBatches.UseVisualStyleBackColor = false;
            this.btnBatches.Click += new System.EventHandler(this.btnBatches_Click);
            // 
            // btnStorageLocations
            // 
            this.btnStorageLocations.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnStorageLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorageLocations.Location = new System.Drawing.Point(854, 233);
            this.btnStorageLocations.Name = "btnStorageLocations";
            this.btnStorageLocations.Size = new System.Drawing.Size(275, 44);
            this.btnStorageLocations.TabIndex = 19;
            this.btnStorageLocations.Text = "Места хранения";
            this.btnStorageLocations.UseVisualStyleBackColor = false;
            this.btnStorageLocations.Click += new System.EventHandler(this.btnStorageLocations_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.manufacturerIdDataGridViewTextBoxColumn,
            this.manufacturerNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.dgvProducts.DataSource = this.vProductsBindingSource;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Location = new System.Drawing.Point(18, 146);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(794, 424);
            this.dgvProducts.TabIndex = 23;
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
            // manufacturerIdDataGridViewTextBoxColumn
            // 
            this.manufacturerIdDataGridViewTextBoxColumn.DataPropertyName = "ManufacturerId";
            this.manufacturerIdDataGridViewTextBoxColumn.HeaderText = "ManufacturerId";
            this.manufacturerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerIdDataGridViewTextBoxColumn.Name = "manufacturerIdDataGridViewTextBoxColumn";
            this.manufacturerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufacturerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // manufacturerNameDataGridViewTextBoxColumn
            // 
            this.manufacturerNameDataGridViewTextBoxColumn.DataPropertyName = "ManufacturerName";
            this.manufacturerNameDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.manufacturerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerNameDataGridViewTextBoxColumn.Name = "manufacturerNameDataGridViewTextBoxColumn";
            this.manufacturerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Visible = false;
            // 
            // vProductsBindingSource
            // 
            this.vProductsBindingSource.DataMember = "vProducts";
            this.vProductsBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // vPartnersBindingSource
            // 
            this.vPartnersBindingSource.DataMember = "vPartners";
            this.vPartnersBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // vPartnersTableAdapter
            // 
            this.vPartnersTableAdapter.ClearBeforeFill = true;
            // 
            // vManufacturersTableAdapter
            // 
            this.vManufacturersTableAdapter.ClearBeforeFill = true;
            // 
            // vProductsTableAdapter
            // 
            this.vProductsTableAdapter.ClearBeforeFill = true;
            // 
            // pbIconLogin
            // 
            this.pbIconLogin.BackColor = System.Drawing.Color.Transparent;
            this.pbIconLogin.Image = global::DomesoSystem.Properties.Resources.compound_icon_125484;
            this.pbIconLogin.Location = new System.Drawing.Point(6, 3);
            this.pbIconLogin.Name = "pbIconLogin";
            this.pbIconLogin.Size = new System.Drawing.Size(65, 59);
            this.pbIconLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIconLogin.TabIndex = 24;
            this.pbIconLogin.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DomesoSystem.Properties.Resources.bg4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1152, 662);
            this.Controls.Add(this.pbIconLogin);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnStorageLocations);
            this.Controls.Add(this.btnBatches);
            this.Controls.Add(this.btnWriteOffs);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnPartners);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnRefreshProducts);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnResetProductFilters);
            this.Controls.Add(this.cmbManufacturerFilter);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.lblManufacturerFilter);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblCurrentRole);
            this.Controls.Add(this.lblCurrentUser);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vManufacturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domesoSystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPartnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblCurrentRole;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblManufacturerFilter;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.ComboBox cmbManufacturerFilter;
        private System.Windows.Forms.Button btnResetProductFilters;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRefreshProducts;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPartners;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnWriteOffs;
        private System.Windows.Forms.Button btnBatches;
        private System.Windows.Forms.Button btnStorageLocations;
        private System.Windows.Forms.DataGridView dgvProducts;
        private DomesoSystemDBDataSet domesoSystemDBDataSet;
        private System.Windows.Forms.BindingSource vPartnersBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vPartnersTableAdapter vPartnersTableAdapter;
        private System.Windows.Forms.BindingSource vManufacturersBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vManufacturersTableAdapter vManufacturersTableAdapter;
        private System.Windows.Forms.BindingSource vProductsBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vProductsTableAdapter vProductsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.PictureBox pbIconLogin;
    }
}

