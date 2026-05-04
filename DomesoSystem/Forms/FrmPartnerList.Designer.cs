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
            this.lblPartnerFilter = new System.Windows.Forms.Label();
            this.dgvPartners = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartners)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
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
            // 
            // btnEditPartner
            // 
            this.btnEditPartner.Location = new System.Drawing.Point(181, 581);
            this.btnEditPartner.Name = "btnEditPartner";
            this.btnEditPartner.Size = new System.Drawing.Size(143, 37);
            this.btnEditPartner.TabIndex = 15;
            this.btnEditPartner.Text = "Изменить";
            this.btnEditPartner.UseVisualStyleBackColor = true;
            // 
            // btnDeletePartner
            // 
            this.btnDeletePartner.Location = new System.Drawing.Point(330, 581);
            this.btnDeletePartner.Name = "btnDeletePartner";
            this.btnDeletePartner.Size = new System.Drawing.Size(143, 37);
            this.btnDeletePartner.TabIndex = 14;
            this.btnDeletePartner.Text = "Удалить";
            this.btnDeletePartner.UseVisualStyleBackColor = true;
            // 
            // btnRefreshPartner
            // 
            this.btnRefreshPartner.Location = new System.Drawing.Point(972, 581);
            this.btnRefreshPartner.Name = "btnRefreshPartner";
            this.btnRefreshPartner.Size = new System.Drawing.Size(143, 37);
            this.btnRefreshPartner.TabIndex = 13;
            this.btnRefreshPartner.Text = "Обновить";
            this.btnRefreshPartner.UseVisualStyleBackColor = true;
            // 
            // btnAddPartner
            // 
            this.btnAddPartner.Location = new System.Drawing.Point(32, 581);
            this.btnAddPartner.Name = "btnAddPartner";
            this.btnAddPartner.Size = new System.Drawing.Size(143, 37);
            this.btnAddPartner.TabIndex = 12;
            this.btnAddPartner.Text = "Добавить";
            this.btnAddPartner.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(972, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 37);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // cmbPartnerFilter
            // 
            this.cmbPartnerFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartnerFilter.FormattingEnabled = true;
            this.cmbPartnerFilter.Location = new System.Drawing.Point(591, 89);
            this.cmbPartnerFilter.Name = "cmbPartnerFilter";
            this.cmbPartnerFilter.Size = new System.Drawing.Size(264, 31);
            this.cmbPartnerFilter.TabIndex = 18;
            // 
            // lblPartnerFilter
            // 
            this.lblPartnerFilter.AutoSize = true;
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
            this.dgvPartners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartners.EnableHeadersVisualStyles = false;
            this.dgvPartners.Location = new System.Drawing.Point(35, 150);
            this.dgvPartners.MultiSelect = false;
            this.dgvPartners.Name = "dgvPartners";
            this.dgvPartners.ReadOnly = true;
            this.dgvPartners.RowHeadersVisible = false;
            this.dgvPartners.RowHeadersWidth = 51;
            this.dgvPartners.RowTemplate.Height = 24;
            this.dgvPartners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartners.Size = new System.Drawing.Size(1080, 408);
            this.dgvPartners.TabIndex = 23;
            // 
            // FrmPartnerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 653);
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
    }
}