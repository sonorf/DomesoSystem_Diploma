namespace DomesoSystem.Forms
{
    partial class FrmPartnerEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartnerEdit));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPartnerName = new System.Windows.Forms.TextBox();
            this.cmbPartnerType = new System.Windows.Forms.ComboBox();
            this.lblPartnerName = new System.Windows.Forms.Label();
            this.lblPartnerType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.lblContactPerson = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(277, 903);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 41);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(38, 903);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 41);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtDescription.Location = new System.Drawing.Point(38, 768);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 105);
            this.txtDescription.TabIndex = 18;
            // 
            // txtPartnerName
            // 
            this.txtPartnerName.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtPartnerName.Location = new System.Drawing.Point(38, 139);
            this.txtPartnerName.Name = "txtPartnerName";
            this.txtPartnerName.Size = new System.Drawing.Size(400, 36);
            this.txtPartnerName.TabIndex = 17;
            // 
            // cmbPartnerType
            // 
            this.cmbPartnerType.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.cmbPartnerType.FormattingEnabled = true;
            this.cmbPartnerType.Location = new System.Drawing.Point(38, 228);
            this.cmbPartnerType.Name = "cmbPartnerType";
            this.cmbPartnerType.Size = new System.Drawing.Size(400, 35);
            this.cmbPartnerType.TabIndex = 16;
            // 
            // lblPartnerName
            // 
            this.lblPartnerName.AutoSize = true;
            this.lblPartnerName.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblPartnerName.Location = new System.Drawing.Point(33, 106);
            this.lblPartnerName.Name = "lblPartnerName";
            this.lblPartnerName.Size = new System.Drawing.Size(206, 30);
            this.lblPartnerName.TabIndex = 15;
            this.lblPartnerName.Text = "Наименование:";
            // 
            // lblPartnerType
            // 
            this.lblPartnerType.AutoSize = true;
            this.lblPartnerType.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblPartnerType.Location = new System.Drawing.Point(33, 195);
            this.lblPartnerType.Name = "lblPartnerType";
            this.lblPartnerType.Size = new System.Drawing.Size(60, 30);
            this.lblPartnerType.TabIndex = 14;
            this.lblPartnerType.Text = "Тип:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblDescription.Location = new System.Drawing.Point(33, 735);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(147, 30);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Описание:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(31, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(407, 37);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Добавление контрагента";
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtCountry.Location = new System.Drawing.Point(38, 316);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(400, 36);
            this.txtCountry.TabIndex = 24;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblCountry.Location = new System.Drawing.Point(33, 283);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(111, 30);
            this.lblCountry.TabIndex = 23;
            this.lblCountry.Text = "Страна:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtPhone.Location = new System.Drawing.Point(38, 405);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(400, 36);
            this.txtPhone.TabIndex = 26;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblPhone.Location = new System.Drawing.Point(33, 372);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(132, 30);
            this.lblPhone.TabIndex = 25;
            this.lblPhone.Text = "Телефон:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtEmail.Location = new System.Drawing.Point(38, 582);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 36);
            this.txtEmail.TabIndex = 30;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblEmail.Location = new System.Drawing.Point(33, 549);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(93, 30);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtAddress.Location = new System.Drawing.Point(38, 493);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(400, 36);
            this.txtAddress.TabIndex = 28;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblAddress.Location = new System.Drawing.Point(33, 460);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 30);
            this.lblAddress.TabIndex = 27;
            this.lblAddress.Text = "Адрес:";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtContactPerson.Location = new System.Drawing.Point(38, 675);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(400, 36);
            this.txtContactPerson.TabIndex = 32;
            // 
            // lblContactPerson
            // 
            this.lblContactPerson.AutoSize = true;
            this.lblContactPerson.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblContactPerson.Location = new System.Drawing.Point(33, 642);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(223, 30);
            this.lblContactPerson.TabIndex = 31;
            this.lblContactPerson.Text = "Контактное лицо:";
            // 
            // FrmPartnerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 972);
            this.Controls.Add(this.txtContactPerson);
            this.Controls.Add(this.lblContactPerson);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPartnerName);
            this.Controls.Add(this.cmbPartnerType);
            this.Controls.Add(this.lblPartnerName);
            this.Controls.Add(this.lblPartnerType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPartnerEdit";
            this.Text = "Добавление контрагента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPartnerName;
        private System.Windows.Forms.ComboBox cmbPartnerType;
        private System.Windows.Forms.Label lblPartnerName;
        private System.Windows.Forms.Label lblPartnerType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label lblContactPerson;
    }
}