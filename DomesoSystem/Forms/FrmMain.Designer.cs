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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.lblCurrentRole = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblManufacturerFilter = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.cmbManufacturerFilter = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Location = new System.Drawing.Point(16, 9);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(147, 23);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "Пользователь:";
            // 
            // lblCurrentRole
            // 
            this.lblCurrentRole.AutoSize = true;
            this.lblCurrentRole.Location = new System.Drawing.Point(16, 39);
            this.lblCurrentRole.Name = "lblCurrentRole";
            this.lblCurrentRole.Size = new System.Drawing.Size(60, 23);
            this.lblCurrentRole.TabIndex = 1;
            this.lblCurrentRole.Text = "Роль:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(14, 93);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(72, 23);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Поиск";
            // 
            // lblManufacturerFilter
            // 
            this.lblManufacturerFilter.AutoSize = true;
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
            // 
            // cmbManufacturerFilter
            // 
            this.cmbManufacturerFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManufacturerFilter.FormattingEnabled = true;
            this.cmbManufacturerFilter.Location = new System.Drawing.Point(548, 91);
            this.cmbManufacturerFilter.Name = "cmbManufacturerFilter";
            this.cmbManufacturerFilter.Size = new System.Drawing.Size(264, 31);
            this.cmbManufacturerFilter.TabIndex = 5;
            // 
            // btnResetProductFilters
            // 
            this.btnResetProductFilters.Location = new System.Drawing.Point(883, 86);
            this.btnResetProductFilters.Name = "btnResetProductFilters";
            this.btnResetProductFilters.Size = new System.Drawing.Size(232, 36);
            this.btnResetProductFilters.TabIndex = 6;
            this.btnResetProductFilters.Text = "Сбросить фильтры";
            this.btnResetProductFilters.UseVisualStyleBackColor = true;
            this.btnResetProductFilters.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(18, 600);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(143, 37);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Добавить";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnRefreshProducts
            // 
            this.btnRefreshProducts.Location = new System.Drawing.Point(669, 600);
            this.btnRefreshProducts.Name = "btnRefreshProducts";
            this.btnRefreshProducts.Size = new System.Drawing.Size(143, 37);
            this.btnRefreshProducts.TabIndex = 9;
            this.btnRefreshProducts.Text = "Обновить";
            this.btnRefreshProducts.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(316, 600);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(143, 37);
            this.btnDeleteProduct.TabIndex = 10;
            this.btnDeleteProduct.Text = "Удалить";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(167, 600);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(143, 37);
            this.btnEditProduct.TabIndex = 11;
            this.btnEditProduct.Text = "Изменить";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(986, 25);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(143, 37);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Выйти";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnPartners
            // 
            this.btnPartners.Location = new System.Drawing.Point(854, 171);
            this.btnPartners.Name = "btnPartners";
            this.btnPartners.Size = new System.Drawing.Size(275, 44);
            this.btnPartners.TabIndex = 13;
            this.btnPartners.Text = "Контрагенты";
            this.btnPartners.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(854, 479);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(275, 44);
            this.btnStock.TabIndex = 15;
            this.btnStock.Text = "Остатки";
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(854, 416);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(275, 44);
            this.btnSales.TabIndex = 16;
            this.btnSales.Text = "Продажи";
            this.btnSales.UseVisualStyleBackColor = true;
            // 
            // btnWriteOffs
            // 
            this.btnWriteOffs.Location = new System.Drawing.Point(854, 355);
            this.btnWriteOffs.Name = "btnWriteOffs";
            this.btnWriteOffs.Size = new System.Drawing.Size(275, 44);
            this.btnWriteOffs.TabIndex = 17;
            this.btnWriteOffs.Text = "Списания";
            this.btnWriteOffs.UseVisualStyleBackColor = true;
            // 
            // btnBatches
            // 
            this.btnBatches.Location = new System.Drawing.Point(854, 295);
            this.btnBatches.Name = "btnBatches";
            this.btnBatches.Size = new System.Drawing.Size(275, 44);
            this.btnBatches.TabIndex = 18;
            this.btnBatches.Text = "Партии/поступления";
            this.btnBatches.UseVisualStyleBackColor = true;
            // 
            // btnStorageLocations
            // 
            this.btnStorageLocations.Location = new System.Drawing.Point(854, 233);
            this.btnStorageLocations.Name = "btnStorageLocations";
            this.btnStorageLocations.Size = new System.Drawing.Size(275, 44);
            this.btnStorageLocations.TabIndex = 19;
            this.btnStorageLocations.Text = "Места хранения";
            this.btnStorageLocations.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 662);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
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
    }
}

