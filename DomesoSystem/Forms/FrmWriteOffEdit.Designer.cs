namespace DomesoSystem.Forms
{
    partial class FrmWriteOffEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWriteOffEdit));
            this.lblWriteOffDate = new System.Windows.Forms.Label();
            this.lblWriteOffReason = new System.Windows.Forms.Label();
            this.lblWriteOffQuantity = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblBatch = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbBatch = new System.Windows.Forms.ComboBox();
            this.cmbWriteOffReason = new System.Windows.Forms.ComboBox();
            this.nudWriteOffQuantity = new System.Windows.Forms.NumericUpDown();
            this.dtpWriteOffDate = new System.Windows.Forms.DateTimePicker();
            this.lblAvailableQuantity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudWriteOffQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWriteOffDate
            // 
            this.lblWriteOffDate.AutoSize = true;
            this.lblWriteOffDate.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblWriteOffDate.Location = new System.Drawing.Point(31, 470);
            this.lblWriteOffDate.Name = "lblWriteOffDate";
            this.lblWriteOffDate.Size = new System.Drawing.Size(203, 30);
            this.lblWriteOffDate.TabIndex = 48;
            this.lblWriteOffDate.Text = "Дата списания:";
            // 
            // lblWriteOffReason
            // 
            this.lblWriteOffReason.AutoSize = true;
            this.lblWriteOffReason.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblWriteOffReason.Location = new System.Drawing.Point(31, 386);
            this.lblWriteOffReason.Name = "lblWriteOffReason";
            this.lblWriteOffReason.Size = new System.Drawing.Size(123, 30);
            this.lblWriteOffReason.TabIndex = 46;
            this.lblWriteOffReason.Text = "Причина:";
            // 
            // lblWriteOffQuantity
            // 
            this.lblWriteOffQuantity.AutoSize = true;
            this.lblWriteOffQuantity.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblWriteOffQuantity.Location = new System.Drawing.Point(31, 268);
            this.lblWriteOffQuantity.Name = "lblWriteOffQuantity";
            this.lblWriteOffQuantity.Size = new System.Drawing.Size(157, 30);
            this.lblWriteOffQuantity.TabIndex = 44;
            this.lblWriteOffQuantity.Text = "Количество:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(275, 702);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 41);
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Location = new System.Drawing.Point(36, 702);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 41);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtComment.Location = new System.Drawing.Point(36, 593);
            this.txtComment.MaxLength = 300;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(400, 84);
            this.txtComment.TabIndex = 39;
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(36, 212);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(400, 35);
            this.cmbProduct.TabIndex = 37;
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblBatch.Location = new System.Drawing.Point(31, 96);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(103, 30);
            this.lblBatch.TabIndex = 36;
            this.lblBatch.Text = "Партия:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblProductName.Location = new System.Drawing.Point(31, 179);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(90, 30);
            this.lblProductName.TabIndex = 35;
            this.lblProductName.Text = "Товар:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblComment.Location = new System.Drawing.Point(31, 560);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(193, 30);
            this.lblComment.TabIndex = 34;
            this.lblComment.Text = "Комментарий:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(29, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(359, 37);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Добавление списания";
            // 
            // cmbBatch
            // 
            this.cmbBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatch.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Location = new System.Drawing.Point(36, 129);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(400, 35);
            this.cmbBatch.TabIndex = 50;
            // 
            // cmbWriteOffReason
            // 
            this.cmbWriteOffReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWriteOffReason.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.cmbWriteOffReason.FormattingEnabled = true;
            this.cmbWriteOffReason.Location = new System.Drawing.Point(36, 419);
            this.cmbWriteOffReason.Name = "cmbWriteOffReason";
            this.cmbWriteOffReason.Size = new System.Drawing.Size(400, 35);
            this.cmbWriteOffReason.TabIndex = 51;
            // 
            // nudWriteOffQuantity
            // 
            this.nudWriteOffQuantity.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.nudWriteOffQuantity.Location = new System.Drawing.Point(36, 301);
            this.nudWriteOffQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWriteOffQuantity.Name = "nudWriteOffQuantity";
            this.nudWriteOffQuantity.Size = new System.Drawing.Size(400, 36);
            this.nudWriteOffQuantity.TabIndex = 52;
            this.nudWriteOffQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpWriteOffDate
            // 
            this.dtpWriteOffDate.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.dtpWriteOffDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWriteOffDate.Location = new System.Drawing.Point(34, 503);
            this.dtpWriteOffDate.Name = "dtpWriteOffDate";
            this.dtpWriteOffDate.Size = new System.Drawing.Size(402, 36);
            this.dtpWriteOffDate.TabIndex = 53;
            // 
            // lblAvailableQuantity
            // 
            this.lblAvailableQuantity.AutoSize = true;
            this.lblAvailableQuantity.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblAvailableQuantity.Location = new System.Drawing.Point(31, 340);
            this.lblAvailableQuantity.Name = "lblAvailableQuantity";
            this.lblAvailableQuantity.Size = new System.Drawing.Size(272, 30);
            this.lblAvailableQuantity.TabIndex = 54;
            this.lblAvailableQuantity.Text = "Доступный остаток: 0";
            // 
            // FrmWriteOffEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(465, 783);
            this.Controls.Add(this.lblAvailableQuantity);
            this.Controls.Add(this.dtpWriteOffDate);
            this.Controls.Add(this.nudWriteOffQuantity);
            this.Controls.Add(this.cmbWriteOffReason);
            this.Controls.Add(this.cmbBatch);
            this.Controls.Add(this.lblWriteOffDate);
            this.Controls.Add(this.lblWriteOffReason);
            this.Controls.Add(this.lblWriteOffQuantity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblBatch);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWriteOffEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление списания";
            ((System.ComponentModel.ISupportInitialize)(this.nudWriteOffQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWriteOffDate;
        private System.Windows.Forms.Label lblWriteOffReason;
        private System.Windows.Forms.Label lblWriteOffQuantity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbBatch;
        private System.Windows.Forms.ComboBox cmbWriteOffReason;
        private System.Windows.Forms.NumericUpDown nudWriteOffQuantity;
        private System.Windows.Forms.DateTimePicker dtpWriteOffDate;
        private System.Windows.Forms.Label lblAvailableQuantity;
    }
}