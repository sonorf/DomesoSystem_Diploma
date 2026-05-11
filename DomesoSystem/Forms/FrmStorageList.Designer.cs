namespace DomesoSystem.Forms
{
    partial class FrmStorageList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStorageList));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditStorage = new System.Windows.Forms.Button();
            this.btnDeleteStorage = new System.Windows.Forms.Button();
            this.btnRefreshStorage = new System.Windows.Forms.Button();
            this.btnAddStorage = new System.Windows.Forms.Button();
            this.txtSearchStorage = new System.Windows.Forms.TextBox();
            this.lblSearchStorage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.domesoSystemDBDataSet = new DomesoSystem.DomesoSystemDBDataSet();
            this.vStorageLocationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vStorageLocationsTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vStorageLocationsTableAdapter();
            this.dgvStorageLocations = new System.Windows.Forms.DataGridView();
            this.storageLocationIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.domesoSystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vStorageLocationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Linen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(762, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 37);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEditStorage
            // 
            this.btnEditStorage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEditStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStorage.Location = new System.Drawing.Point(184, 577);
            this.btnEditStorage.Name = "btnEditStorage";
            this.btnEditStorage.Size = new System.Drawing.Size(143, 37);
            this.btnEditStorage.TabIndex = 26;
            this.btnEditStorage.Text = "Изменить";
            this.btnEditStorage.UseVisualStyleBackColor = false;
            this.btnEditStorage.Click += new System.EventHandler(this.btnEditStorage_Click);
            // 
            // btnDeleteStorage
            // 
            this.btnDeleteStorage.BackColor = System.Drawing.Color.Linen;
            this.btnDeleteStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStorage.Location = new System.Drawing.Point(333, 577);
            this.btnDeleteStorage.Name = "btnDeleteStorage";
            this.btnDeleteStorage.Size = new System.Drawing.Size(143, 37);
            this.btnDeleteStorage.TabIndex = 25;
            this.btnDeleteStorage.Text = "Удалить";
            this.btnDeleteStorage.UseVisualStyleBackColor = false;
            this.btnDeleteStorage.Click += new System.EventHandler(this.btnDeleteStorage_Click);
            // 
            // btnRefreshStorage
            // 
            this.btnRefreshStorage.BackColor = System.Drawing.Color.Linen;
            this.btnRefreshStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshStorage.Location = new System.Drawing.Point(762, 577);
            this.btnRefreshStorage.Name = "btnRefreshStorage";
            this.btnRefreshStorage.Size = new System.Drawing.Size(143, 37);
            this.btnRefreshStorage.TabIndex = 24;
            this.btnRefreshStorage.Text = "Обновить";
            this.btnRefreshStorage.UseVisualStyleBackColor = false;
            this.btnRefreshStorage.Click += new System.EventHandler(this.btnRefreshStorage_Click);
            // 
            // btnAddStorage
            // 
            this.btnAddStorage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStorage.Location = new System.Drawing.Point(35, 577);
            this.btnAddStorage.Name = "btnAddStorage";
            this.btnAddStorage.Size = new System.Drawing.Size(143, 37);
            this.btnAddStorage.TabIndex = 23;
            this.btnAddStorage.Text = "Добавить";
            this.btnAddStorage.UseVisualStyleBackColor = false;
            this.btnAddStorage.Click += new System.EventHandler(this.btnAddStorage_Click);
            // 
            // txtSearchStorage
            // 
            this.txtSearchStorage.Location = new System.Drawing.Point(112, 85);
            this.txtSearchStorage.MaxLength = 100;
            this.txtSearchStorage.Name = "txtSearchStorage";
            this.txtSearchStorage.Size = new System.Drawing.Size(265, 32);
            this.txtSearchStorage.TabIndex = 21;
            this.txtSearchStorage.TextChanged += new System.EventHandler(this.txtSearchStorage_TextChanged);
            // 
            // lblSearchStorage
            // 
            this.lblSearchStorage.AutoSize = true;
            this.lblSearchStorage.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchStorage.Location = new System.Drawing.Point(34, 88);
            this.lblSearchStorage.Name = "lblSearchStorage";
            this.lblSearchStorage.Size = new System.Drawing.Size(72, 23);
            this.lblSearchStorage.TabIndex = 20;
            this.lblSearchStorage.Text = "Поиск";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(28, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(272, 37);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Места хранения";
            // 
            // domesoSystemDBDataSet
            // 
            this.domesoSystemDBDataSet.DataSetName = "DomesoSystemDBDataSet";
            this.domesoSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vStorageLocationsBindingSource
            // 
            this.vStorageLocationsBindingSource.DataMember = "vStorageLocations";
            this.vStorageLocationsBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // vStorageLocationsTableAdapter
            // 
            this.vStorageLocationsTableAdapter.ClearBeforeFill = true;
            // 
            // dgvStorageLocations
            // 
            this.dgvStorageLocations.AllowUserToAddRows = false;
            this.dgvStorageLocations.AllowUserToDeleteRows = false;
            this.dgvStorageLocations.AllowUserToResizeRows = false;
            this.dgvStorageLocations.AutoGenerateColumns = false;
            this.dgvStorageLocations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStorageLocations.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvStorageLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorageLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storageLocationIdDataGridViewTextBoxColumn,
            this.storageCodeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.dgvStorageLocations.DataSource = this.vStorageLocationsBindingSource;
            this.dgvStorageLocations.EnableHeadersVisualStyles = false;
            this.dgvStorageLocations.Location = new System.Drawing.Point(38, 147);
            this.dgvStorageLocations.MultiSelect = false;
            this.dgvStorageLocations.Name = "dgvStorageLocations";
            this.dgvStorageLocations.ReadOnly = true;
            this.dgvStorageLocations.RowHeadersVisible = false;
            this.dgvStorageLocations.RowHeadersWidth = 51;
            this.dgvStorageLocations.RowTemplate.Height = 24;
            this.dgvStorageLocations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStorageLocations.Size = new System.Drawing.Size(867, 409);
            this.dgvStorageLocations.TabIndex = 28;
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
            this.storageCodeDataGridViewTextBoxColumn.HeaderText = "Код";
            this.storageCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.storageCodeDataGridViewTextBoxColumn.Name = "storageCodeDataGridViewTextBoxColumn";
            this.storageCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
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
            // FrmStorageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DomesoSystem.Properties.Resources.bg4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 653);
            this.Controls.Add(this.dgvStorageLocations);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditStorage);
            this.Controls.Add(this.btnDeleteStorage);
            this.Controls.Add(this.btnRefreshStorage);
            this.Controls.Add(this.btnAddStorage);
            this.Controls.Add(this.txtSearchStorage);
            this.Controls.Add(this.lblSearchStorage);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStorageList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Места хранения";
            this.Load += new System.EventHandler(this.FrmStorageList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.domesoSystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vStorageLocationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageLocations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEditStorage;
        private System.Windows.Forms.Button btnDeleteStorage;
        private System.Windows.Forms.Button btnRefreshStorage;
        private System.Windows.Forms.Button btnAddStorage;
        private System.Windows.Forms.TextBox txtSearchStorage;
        private System.Windows.Forms.Label lblSearchStorage;
        private System.Windows.Forms.Label lblTitle;
        private DomesoSystemDBDataSet domesoSystemDBDataSet;
        private System.Windows.Forms.BindingSource vStorageLocationsBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vStorageLocationsTableAdapter vStorageLocationsTableAdapter;
        private System.Windows.Forms.DataGridView dgvStorageLocations;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageLocationIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storageCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
    }
}