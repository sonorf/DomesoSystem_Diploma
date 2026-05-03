namespace DomesoSystem.Forms
{
    partial class FrmStorageEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStorageEdit));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStorageDescription = new System.Windows.Forms.TextBox();
            this.txtStorageCode = new System.Windows.Forms.TextBox();
            this.lblStorageCode = new System.Windows.Forms.Label();
            this.lblStorageDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(254, 425);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 41);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(35, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 41);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtStorageDescription
            // 
            this.txtStorageDescription.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtStorageDescription.Location = new System.Drawing.Point(35, 241);
            this.txtStorageDescription.Multiline = true;
            this.txtStorageDescription.Name = "txtStorageDescription";
            this.txtStorageDescription.Size = new System.Drawing.Size(370, 139);
            this.txtStorageDescription.TabIndex = 15;
            // 
            // txtStorageCode
            // 
            this.txtStorageCode.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtStorageCode.Location = new System.Drawing.Point(35, 155);
            this.txtStorageCode.Name = "txtStorageCode";
            this.txtStorageCode.Size = new System.Drawing.Size(370, 36);
            this.txtStorageCode.TabIndex = 14;
            // 
            // lblStorageCode
            // 
            this.lblStorageCode.AutoSize = true;
            this.lblStorageCode.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblStorageCode.Location = new System.Drawing.Point(30, 122);
            this.lblStorageCode.Name = "lblStorageCode";
            this.lblStorageCode.Size = new System.Drawing.Size(150, 30);
            this.lblStorageCode.TabIndex = 13;
            this.lblStorageCode.Text = "Код места:";
            // 
            // lblStorageDescription
            // 
            this.lblStorageDescription.AutoSize = true;
            this.lblStorageDescription.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblStorageDescription.Location = new System.Drawing.Point(30, 208);
            this.lblStorageDescription.Name = "lblStorageDescription";
            this.lblStorageDescription.Size = new System.Drawing.Size(147, 30);
            this.lblStorageDescription.TabIndex = 12;
            this.lblStorageDescription.Text = "Описание:";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(28, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(301, 82);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Добавление места хранения";
            // 
            // FrmStorageEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 496);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtStorageDescription);
            this.Controls.Add(this.txtStorageCode);
            this.Controls.Add(this.lblStorageCode);
            this.Controls.Add(this.lblStorageDescription);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmStorageEdit";
            this.Text = "Добавление места хранения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtStorageDescription;
        private System.Windows.Forms.TextBox txtStorageCode;
        private System.Windows.Forms.Label lblStorageCode;
        private System.Windows.Forms.Label lblStorageDescription;
        private System.Windows.Forms.Label lblTitle;
    }
}