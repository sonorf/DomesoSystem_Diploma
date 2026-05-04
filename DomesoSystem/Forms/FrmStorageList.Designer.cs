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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStorageList));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditStorage = new System.Windows.Forms.Button();
            this.btnDeleteStorage = new System.Windows.Forms.Button();
            this.btnRefreshStorage = new System.Windows.Forms.Button();
            this.btnAddStorage = new System.Windows.Forms.Button();
            this.dgvStorageLocations = new System.Windows.Forms.DataGridView();
            this.txtSearchStorage = new System.Windows.Forms.TextBox();
            this.lblSearchStorage = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(975, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 37);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnEditStorage
            // 
            this.btnEditStorage.Location = new System.Drawing.Point(184, 577);
            this.btnEditStorage.Name = "btnEditStorage";
            this.btnEditStorage.Size = new System.Drawing.Size(143, 37);
            this.btnEditStorage.TabIndex = 26;
            this.btnEditStorage.Text = "Изменить";
            this.btnEditStorage.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStorage
            // 
            this.btnDeleteStorage.Location = new System.Drawing.Point(333, 577);
            this.btnDeleteStorage.Name = "btnDeleteStorage";
            this.btnDeleteStorage.Size = new System.Drawing.Size(143, 37);
            this.btnDeleteStorage.TabIndex = 25;
            this.btnDeleteStorage.Text = "Удалить";
            this.btnDeleteStorage.UseVisualStyleBackColor = true;
            // 
            // btnRefreshStorage
            // 
            this.btnRefreshStorage.Location = new System.Drawing.Point(975, 577);
            this.btnRefreshStorage.Name = "btnRefreshStorage";
            this.btnRefreshStorage.Size = new System.Drawing.Size(143, 37);
            this.btnRefreshStorage.TabIndex = 24;
            this.btnRefreshStorage.Text = "Обновить";
            this.btnRefreshStorage.UseVisualStyleBackColor = true;
            // 
            // btnAddStorage
            // 
            this.btnAddStorage.Location = new System.Drawing.Point(35, 577);
            this.btnAddStorage.Name = "btnAddStorage";
            this.btnAddStorage.Size = new System.Drawing.Size(143, 37);
            this.btnAddStorage.TabIndex = 23;
            this.btnAddStorage.Text = "Добавить";
            this.btnAddStorage.UseVisualStyleBackColor = true;
            // 
            // dgvStorageLocations
            // 
            this.dgvStorageLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorageLocations.Location = new System.Drawing.Point(38, 148);
            this.dgvStorageLocations.Name = "dgvStorageLocations";
            this.dgvStorageLocations.RowHeadersWidth = 51;
            this.dgvStorageLocations.RowTemplate.Height = 24;
            this.dgvStorageLocations.Size = new System.Drawing.Size(1080, 408);
            this.dgvStorageLocations.TabIndex = 22;
            // 
            // txtSearchStorage
            // 
            this.txtSearchStorage.Location = new System.Drawing.Point(112, 85);
            this.txtSearchStorage.MaxLength = 100;
            this.txtSearchStorage.Name = "txtSearchStorage";
            this.txtSearchStorage.Size = new System.Drawing.Size(265, 32);
            this.txtSearchStorage.TabIndex = 21;
            // 
            // lblSearchStorage
            // 
            this.lblSearchStorage.AutoSize = true;
            this.lblSearchStorage.Location = new System.Drawing.Point(34, 88);
            this.lblSearchStorage.Name = "lblSearchStorage";
            this.lblSearchStorage.Size = new System.Drawing.Size(72, 23);
            this.lblSearchStorage.TabIndex = 20;
            this.lblSearchStorage.Text = "Поиск";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(28, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(272, 37);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Места хранения";
            // 
            // FrmStorageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 653);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditStorage);
            this.Controls.Add(this.btnDeleteStorage);
            this.Controls.Add(this.btnRefreshStorage);
            this.Controls.Add(this.btnAddStorage);
            this.Controls.Add(this.dgvStorageLocations);
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
        private System.Windows.Forms.DataGridView dgvStorageLocations;
        private System.Windows.Forms.TextBox txtSearchStorage;
        private System.Windows.Forms.Label lblSearchStorage;
        private System.Windows.Forms.Label lblTitle;
    }
}