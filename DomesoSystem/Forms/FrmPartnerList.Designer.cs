namespace DomesoSystem.Forms
{
    partial class FrmPartnerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartnerList));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchPartner = new System.Windows.Forms.TextBox();
            this.btnEditPartner = new System.Windows.Forms.Button();
            this.btnDeletePartner = new System.Windows.Forms.Button();
            this.btnRefreshPartner = new System.Windows.Forms.Button();
            this.btnAddPartner = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbPartnerFilter = new System.Windows.Forms.ComboBox();
            this.vPartnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domesoSystemDBDataSet = new DomesoSystem.DomesoSystemDBDataSet();
            this.lblPartnerFilter = new System.Windows.Forms.Label();
            this.dgvPartners = new System.Windows.Forms.DataGridView();
            this.partnerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vPartnersTableAdapter = new DomesoSystem.DomesoSystemDBDataSetTableAdapters.vPartnersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vPartnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domesoSystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartners)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(25, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(217, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Контрагенты";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Location = new System.Drawing.Point(31, 92);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(72, 23);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Поиск";
            // 
            // txtSearchPartner
            // 
            this.txtSearchPartner.Location = new System.Drawing.Point(109, 89);
            this.txtSearchPartner.MaxLength = 100;
            this.txtSearchPartner.Name = "txtSearchPartner";
            this.txtSearchPartner.Size = new System.Drawing.Size(265, 32);
            this.txtSearchPartner.TabIndex = 5;
            this.txtSearchPartner.TextChanged += new System.EventHandler(this.txtSearchPartner_TextChanged);
            // 
            // btnEditPartner
            // 
            this.btnEditPartner.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEditPartner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPartner.Location = new System.Drawing.Point(181, 581);
            this.btnEditPartner.Name = "btnEditPartner";
            this.btnEditPartner.Size = new System.Drawing.Size(143, 37);
            this.btnEditPartner.TabIndex = 15;
            this.btnEditPartner.Text = "Изменить";
            this.btnEditPartner.UseVisualStyleBackColor = false;
            this.btnEditPartner.Click += new System.EventHandler(this.btnEditPartner_Click);
            // 
            // btnDeletePartner
            // 
            this.btnDeletePartner.BackColor = System.Drawing.Color.Linen;
            this.btnDeletePartner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePartner.Location = new System.Drawing.Point(330, 581);
            this.btnDeletePartner.Name = "btnDeletePartner";
            this.btnDeletePartner.Size = new System.Drawing.Size(143, 37);
            this.btnDeletePartner.TabIndex = 14;
            this.btnDeletePartner.Text = "Удалить";
            this.btnDeletePartner.UseVisualStyleBackColor = false;
            this.btnDeletePartner.Click += new System.EventHandler(this.btnDeletePartner_Click);
            // 
            // btnRefreshPartner
            // 
            this.btnRefreshPartner.BackColor = System.Drawing.Color.Linen;
            this.btnRefreshPartner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPartner.Location = new System.Drawing.Point(1251, 581);
            this.btnRefreshPartner.Name = "btnRefreshPartner";
            this.btnRefreshPartner.Size = new System.Drawing.Size(143, 37);
            this.btnRefreshPartner.TabIndex = 13;
            this.btnRefreshPartner.Text = "Обновить";
            this.btnRefreshPartner.UseVisualStyleBackColor = false;
            this.btnRefreshPartner.Click += new System.EventHandler(this.btnRefreshPartner_Click);
            // 
            // btnAddPartner
            // 
            this.btnAddPartner.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddPartner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPartner.Location = new System.Drawing.Point(32, 581);
            this.btnAddPartner.Name = "btnAddPartner";
            this.btnAddPartner.Size = new System.Drawing.Size(143, 37);
            this.btnAddPartner.TabIndex = 12;
            this.btnAddPartner.Text = "Добавить";
            this.btnAddPartner.UseVisualStyleBackColor = false;
            this.btnAddPartner.Click += new System.EventHandler(this.btnAddPartner_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Linen;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1251, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 37);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbPartnerFilter
            // 
            this.cmbPartnerFilter.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cmbPartnerFilter.DataSource = this.vPartnersBindingSource;
            this.cmbPartnerFilter.DisplayMember = "PartnerTypeName";
            this.cmbPartnerFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartnerFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPartnerFilter.FormattingEnabled = true;
            this.cmbPartnerFilter.Location = new System.Drawing.Point(591, 89);
            this.cmbPartnerFilter.Name = "cmbPartnerFilter";
            this.cmbPartnerFilter.Size = new System.Drawing.Size(264, 31);
            this.cmbPartnerFilter.TabIndex = 18;
            this.cmbPartnerFilter.ValueMember = "PartnerId";
            this.cmbPartnerFilter.SelectedIndexChanged += new System.EventHandler(this.cmbPartnerFilter_SelectedIndexChanged);
            // 
            // vPartnersBindingSource
            // 
            this.vPartnersBindingSource.DataMember = "vPartners";
            this.vPartnersBindingSource.DataSource = this.domesoSystemDBDataSet;
            // 
            // domesoSystemDBDataSet
            // 
            this.domesoSystemDBDataSet.DataSetName = "DomesoSystemDBDataSet";
            this.domesoSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblPartnerFilter
            // 
            this.lblPartnerFilter.AutoSize = true;
            this.lblPartnerFilter.BackColor = System.Drawing.Color.Transparent;
            this.lblPartnerFilter.Location = new System.Drawing.Point(412, 92);
            this.lblPartnerFilter.Name = "lblPartnerFilter";
            this.lblPartnerFilter.Size = new System.Drawing.Size(173, 23);
            this.lblPartnerFilter.TabIndex = 17;
            this.lblPartnerFilter.Text = "Тип контрагента";
            // 
            // dgvPartners
            // 
            this.dgvPartners.AllowUserToAddRows = false;
            this.dgvPartners.AllowUserToDeleteRows = false;
            this.dgvPartners.AllowUserToResizeRows = false;
            this.dgvPartners.AutoGenerateColumns = false;
            this.dgvPartners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartners.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partnerIdDataGridViewTextBoxColumn,
            this.partnerTypeDataGridViewTextBoxColumn,
            this.partnerTypeNameDataGridViewTextBoxColumn,
            this.partnerNameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contactPersonDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn});
            this.dgvPartners.DataSource = this.vPartnersBindingSource;
            this.dgvPartners.EnableHeadersVisualStyles = false;
            this.dgvPartners.Location = new System.Drawing.Point(35, 150);
            this.dgvPartners.MultiSelect = false;
            this.dgvPartners.Name = "dgvPartners";
            this.dgvPartners.ReadOnly = true;
            this.dgvPartners.RowHeadersVisible = false;
            this.dgvPartners.RowHeadersWidth = 51;
            this.dgvPartners.RowTemplate.Height = 24;
            this.dgvPartners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartners.Size = new System.Drawing.Size(1359, 408);
            this.dgvPartners.TabIndex = 23;
            // 
            // partnerIdDataGridViewTextBoxColumn
            // 
            this.partnerIdDataGridViewTextBoxColumn.DataPropertyName = "PartnerId";
            this.partnerIdDataGridViewTextBoxColumn.HeaderText = "PartnerId";
            this.partnerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partnerIdDataGridViewTextBoxColumn.Name = "partnerIdDataGridViewTextBoxColumn";
            this.partnerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.partnerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // partnerTypeDataGridViewTextBoxColumn
            // 
            this.partnerTypeDataGridViewTextBoxColumn.DataPropertyName = "PartnerType";
            this.partnerTypeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.partnerTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partnerTypeDataGridViewTextBoxColumn.Name = "partnerTypeDataGridViewTextBoxColumn";
            this.partnerTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.partnerTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // partnerTypeNameDataGridViewTextBoxColumn
            // 
            this.partnerTypeNameDataGridViewTextBoxColumn.DataPropertyName = "PartnerTypeName";
            this.partnerTypeNameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.partnerTypeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partnerTypeNameDataGridViewTextBoxColumn.Name = "partnerTypeNameDataGridViewTextBoxColumn";
            this.partnerTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partnerNameDataGridViewTextBoxColumn
            // 
            this.partnerNameDataGridViewTextBoxColumn.DataPropertyName = "PartnerName";
            this.partnerNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.partnerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partnerNameDataGridViewTextBoxColumn.Name = "partnerNameDataGridViewTextBoxColumn";
            this.partnerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactPersonDataGridViewTextBoxColumn
            // 
            this.contactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson";
            this.contactPersonDataGridViewTextBoxColumn.HeaderText = "Контактное лицо";
            this.contactPersonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactPersonDataGridViewTextBoxColumn.Name = "contactPersonDataGridViewTextBoxColumn";
            this.contactPersonDataGridViewTextBoxColumn.ReadOnly = true;
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
            // vPartnersTableAdapter
            // 
            this.vPartnersTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPartnerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DomesoSystem.Properties.Resources.bg4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1431, 653);
            this.Controls.Add(this.dgvPartners);
            this.Controls.Add(this.cmbPartnerFilter);
            this.Controls.Add(this.lblPartnerFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditPartner);
            this.Controls.Add(this.btnDeletePartner);
            this.Controls.Add(this.btnRefreshPartner);
            this.Controls.Add(this.btnAddPartner);
            this.Controls.Add(this.txtSearchPartner);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPartnerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контрагенты";
            this.Load += new System.EventHandler(this.FrmPartnerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vPartnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domesoSystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchPartner;
        private System.Windows.Forms.Button btnEditPartner;
        private System.Windows.Forms.Button btnDeletePartner;
        private System.Windows.Forms.Button btnRefreshPartner;
        private System.Windows.Forms.Button btnAddPartner;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbPartnerFilter;
        private System.Windows.Forms.Label lblPartnerFilter;
        private System.Windows.Forms.DataGridView dgvPartners;
        private DomesoSystemDBDataSet domesoSystemDBDataSet;
        private System.Windows.Forms.BindingSource vPartnersBindingSource;
        private DomesoSystemDBDataSetTableAdapters.vPartnersTableAdapter vPartnersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partnerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
    }
}