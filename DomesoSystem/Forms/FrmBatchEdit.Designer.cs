namespace DomesoSystem.Forms
{
    partial class FrmBatchEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBatchEdit));
            this.lblStorageLocation = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblReceiptDate = new System.Windows.Forms.Label();
            this.txtBatchNumber = new System.Windows.Forms.TextBox();
            this.lblBatchNumber = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.vSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domesoSystemDBDataSet = new DomesoSystem.DomesoSystemDBDataSet();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.vProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbStorageLocation = new System.Windows.Forms.ComboBox();
            this.vStorageLocationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.vProductsTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vProductsTableAdapter();
            this.vSuppliersTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vSuppliersTableAdapter();
            this.vStorageLocationsTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vStorageLocationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domesoSystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vStorageLocationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStorageLocation
            // 
            this.lblStorageLocation.AutoSize = true;
            this.lblStorageLocation.BackColor = System.Drawing.Color.Transparent;
            this.lblStorageLocation.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblStorageLocation.Location = new System.Drawing.Point(27, 632);
            this.lblStorageLocation.Name = "lblStorageLocation";
            this.lblStorageLocation.Size = new System.Drawing.Size(221, 30);
            this.lblStorageLocation.TabIndex = 50;
            this.lblStorageLocation.Text = "Место хранения:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblQuantity.Location = new System.Drawing.Point(27, 547);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(157, 30);
            this.lblQuantity.TabIndex = 48;
            this.lblQuantity.Text = "Количество:";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblExpirationDate.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblExpirationDate.Location = new System.Drawing.Point(27, 458);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(201, 30);
            this.lblExpirationDate.TabIndex = 46;
            this.lblExpirationDate.Text = "Срок годности:";
            // 
            // lblReceiptDate
            // 
            this.lblReceiptDate.AutoSize = true;
            this.lblReceiptDate.BackColor = System.Drawing.Color.Transparent;
            this.lblReceiptDate.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblReceiptDate.Location = new System.Drawing.Point(27, 370);
            this.lblReceiptDate.Name = "lblReceiptDate";
            this.lblReceiptDate.Size = new System.Drawing.Size(237, 30);
            this.lblReceiptDate.TabIndex = 44;
            this.lblReceiptDate.Text = "Дата поступления:";
            // 
            // txtBatchNumber
            // 
            this.txtBatchNumber.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtBatchNumber.Location = new System.Drawing.Point(32, 314);
            this.txtBatchNumber.MaxLength = 50;
            this.txtBatchNumber.Name = "txtBatchNumber";
            this.txtBatchNumber.Size = new System.Drawing.Size(400, 36);
            this.txtBatchNumber.TabIndex = 43;
            // 
            // lblBatchNumber
            // 
            this.lblBatchNumber.AutoSize = true;
            this.lblBatchNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblBatchNumber.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblBatchNumber.Location = new System.Drawing.Point(27, 281);
            this.lblBatchNumber.Name = "lblBatchNumber";
            this.lblBatchNumber.Size = new System.Drawing.Size(197, 30);
            this.lblBatchNumber.TabIndex = 42;
            this.lblBatchNumber.Text = "Номер партии:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Linen;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(271, 733);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 41);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(32, 733);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 41);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbSupplier.DataSource = this.vSuppliersBindingSource;
            this.cmbSupplier.DisplayMember = "PartnerName";
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSupplier.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(32, 226);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(400, 35);
            this.cmbSupplier.TabIndex = 37;
            this.cmbSupplier.ValueMember = "PartnerId";
            // 
            // vSuppliersBindingSource
            // 
            this.vSuppliersBindingSource.DataMember = "vSuppliers";
            this.vSuppliersBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // domesoSystemDBDataSet
            // 
            this.domesoSystemDBDataSet.DataSetName = "DomesoSystemDBDataSet";
            this.domesoSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblProduct.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblProduct.Location = new System.Drawing.Point(27, 104);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(90, 30);
            this.lblProduct.TabIndex = 36;
            this.lblProduct.Text = "Товар:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblSupplier.Location = new System.Drawing.Point(27, 193);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(155, 30);
            this.lblSupplier.TabIndex = 35;
            this.lblSupplier.Text = "Поставщик:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(25, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(407, 37);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Добавление поступления";
            // 
            // cmbProduct
            // 
            this.cmbProduct.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbProduct.DataSource = this.vProductsBindingSource;
            this.cmbProduct.DisplayMember = "ProductName";
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProduct.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(32, 137);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(400, 35);
            this.cmbProduct.TabIndex = 52;
            this.cmbProduct.ValueMember = "ProductId";
            // 
            // vProductsBindingSource
            // 
            this.vProductsBindingSource.DataMember = "vProducts";
            this.vProductsBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // cmbStorageLocation
            // 
            this.cmbStorageLocation.BackColor = System.Drawing.Color.Linen;
            this.cmbStorageLocation.DataSource = this.vStorageLocationsBindingSource;
            this.cmbStorageLocation.DisplayMember = "StorageCode";
            this.cmbStorageLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStorageLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStorageLocation.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.cmbStorageLocation.FormattingEnabled = true;
            this.cmbStorageLocation.Location = new System.Drawing.Point(32, 665);
            this.cmbStorageLocation.Name = "cmbStorageLocation";
            this.cmbStorageLocation.Size = new System.Drawing.Size(400, 35);
            this.cmbStorageLocation.TabIndex = 53;
            this.cmbStorageLocation.ValueMember = "StorageLocationId";
            // 
            // vStorageLocationsBindingSource
            // 
            this.vStorageLocationsBindingSource.DataMember = "vStorageLocations";
            this.vStorageLocationsBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.Checked = false;
            this.dtpReceiptDate.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.dtpReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceiptDate.Location = new System.Drawing.Point(32, 403);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Size = new System.Drawing.Size(400, 36);
            this.dtpReceiptDate.TabIndex = 54;
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Checked = false;
            this.dtpExpirationDate.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpirationDate.Location = new System.Drawing.Point(32, 491);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(400, 36);
            this.dtpExpirationDate.TabIndex = 55;
            // 
            // nudQuantity
            // 
            this.nudQuantity.BackColor = System.Drawing.Color.Linen;
            this.nudQuantity.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.nudQuantity.Location = new System.Drawing.Point(32, 580);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(400, 36);
            this.nudQuantity.TabIndex = 56;
            this.nudQuantity.ThousandsSeparator = true;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // vProductsTableAdapter
            // 
            this.vProductsTableAdapter.ClearBeforeFill = true;
            // 
            // vSuppliersTableAdapter
            // 
            this.vSuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // vStorageLocationsTableAdapter
            // 
            this.vStorageLocationsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBatchEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DomesoSystem.Properties.Resources.bg4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(460, 800);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.dtpExpirationDate);
            this.Controls.Add(this.dtpReceiptDate);
            this.Controls.Add(this.cmbStorageLocation);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblStorageLocation);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.lblReceiptDate);
            this.Controls.Add(this.txtBatchNumber);
            this.Controls.Add(this.lblBatchNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(478, 847);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(478, 847);
            this.Name = "FrmBatchEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление поступления";
            this.Load += new System.EventHandler(this.FrmBatchEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domesoSystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vStorageLocationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStorageLocation;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblReceiptDate;
        private System.Windows.Forms.TextBox txtBatchNumber;
        private System.Windows.Forms.Label lblBatchNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbStorageLocation;
        private System.Windows.Forms.DateTimePicker dtpReceiptDate;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private DomesoSystemDBDataSet domesoSystemDBDataSet;
        private System.Windows.Forms.BindingSource vProductsBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vProductsTableAdapter vProductsTableAdapter;
        private System.Windows.Forms.BindingSource vSuppliersBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vSuppliersTableAdapter vSuppliersTableAdapter;
        private System.Windows.Forms.BindingSource vStorageLocationsBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vStorageLocationsTableAdapter vStorageLocationsTableAdapter;
    }
}