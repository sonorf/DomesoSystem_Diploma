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
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.cmbStorageLocation = new System.Windows.Forms.ComboBox();
            this.dtpReceiptDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStorageLocation
            // 
            this.lblStorageLocation.AutoSize = true;
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
            this.txtBatchNumber.Name = "txtBatchNumber";
            this.txtBatchNumber.Size = new System.Drawing.Size(400, 36);
            this.txtBatchNumber.TabIndex = 43;
            // 
            // lblBatchNumber
            // 
            this.lblBatchNumber.AutoSize = true;
            this.lblBatchNumber.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblBatchNumber.Location = new System.Drawing.Point(27, 281);
            this.lblBatchNumber.Name = "lblBatchNumber";
            this.lblBatchNumber.Size = new System.Drawing.Size(197, 30);
            this.lblBatchNumber.TabIndex = 42;
            this.lblBatchNumber.Text = "Номер партии:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(271, 733);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 41);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(32, 733);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 41);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(32, 226);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(400, 35);
            this.cmbSupplier.TabIndex = 37;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
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
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(25, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(407, 37);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Добавление поступления";
            // 
            // cmbProduct
            // 
            this.cmbProduct.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(32, 137);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(400, 35);
            this.cmbProduct.TabIndex = 52;
            // 
            // cmbStorageLocation
            // 
            this.cmbStorageLocation.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.cmbStorageLocation.FormattingEnabled = true;
            this.cmbStorageLocation.Location = new System.Drawing.Point(32, 665);
            this.cmbStorageLocation.Name = "cmbStorageLocation";
            this.cmbStorageLocation.Size = new System.Drawing.Size(400, 35);
            this.cmbStorageLocation.TabIndex = 53;
            // 
            // dtpReceiptDate
            // 
            this.dtpReceiptDate.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.dtpReceiptDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceiptDate.Location = new System.Drawing.Point(32, 403);
            this.dtpReceiptDate.Name = "dtpReceiptDate";
            this.dtpReceiptDate.Size = new System.Drawing.Size(400, 36);
            this.dtpReceiptDate.TabIndex = 54;
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpirationDate.Location = new System.Drawing.Point(32, 491);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.Size = new System.Drawing.Size(400, 36);
            this.dtpExpirationDate.TabIndex = 55;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.nudQuantity.Location = new System.Drawing.Point(32, 580);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(400, 36);
            this.nudQuantity.TabIndex = 56;
            // 
            // FrmBatchEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBatchEdit";
            this.Text = "Добавление поступления";
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
    }
}