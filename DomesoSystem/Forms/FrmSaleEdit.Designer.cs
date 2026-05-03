namespace DomesoSystem.Forms
{
    partial class FrmSaleEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaleEdit));
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSaleClient = new System.Windows.Forms.TextBox();
            this.lblSaleClient = new System.Windows.Forms.Label();
            this.lblProductItems = new System.Windows.Forms.Label();
            this.dgvProductItems = new System.Windows.Forms.DataGridView();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblAvailableQuantity = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSaleDate.Location = new System.Drawing.Point(32, 119);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(372, 36);
            this.dtpSaleDate.TabIndex = 66;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.nudQuantity.Location = new System.Drawing.Point(448, 313);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(370, 36);
            this.nudQuantity.TabIndex = 65;
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblSaleDate.Location = new System.Drawing.Point(29, 86);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(196, 30);
            this.lblSaleDate.TabIndex = 62;
            this.lblSaleDate.Text = "Дата продажи:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblQuantity.Location = new System.Drawing.Point(443, 280);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(157, 30);
            this.lblQuantity.TabIndex = 60;
            this.lblQuantity.Text = "Количество:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(657, 637);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 41);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(448, 637);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(161, 41);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Оформить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cmbProduct
            // 
            this.cmbProduct.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(448, 232);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(370, 35);
            this.cmbProduct.TabIndex = 57;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblPrice.Location = new System.Drawing.Point(443, 363);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(83, 30);
            this.lblPrice.TabIndex = 56;
            this.lblPrice.Text = "Цена:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblProduct.Location = new System.Drawing.Point(443, 199);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(90, 30);
            this.lblProduct.TabIndex = 55;
            this.lblProduct.Text = "Товар:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(27, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(371, 37);
            this.lblTitle.TabIndex = 54;
            this.lblTitle.Text = "Оформление продажи";
            // 
            // txtSaleClient
            // 
            this.txtSaleClient.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtSaleClient.Location = new System.Drawing.Point(448, 119);
            this.txtSaleClient.Name = "txtSaleClient";
            this.txtSaleClient.Size = new System.Drawing.Size(370, 36);
            this.txtSaleClient.TabIndex = 68;
            // 
            // lblSaleClient
            // 
            this.lblSaleClient.AutoSize = true;
            this.lblSaleClient.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblSaleClient.Location = new System.Drawing.Point(443, 86);
            this.lblSaleClient.Name = "lblSaleClient";
            this.lblSaleClient.Size = new System.Drawing.Size(101, 30);
            this.lblSaleClient.TabIndex = 67;
            this.lblSaleClient.Text = "Клиент:";
            // 
            // lblProductItems
            // 
            this.lblProductItems.AutoSize = true;
            this.lblProductItems.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblProductItems.Location = new System.Drawing.Point(27, 176);
            this.lblProductItems.Name = "lblProductItems";
            this.lblProductItems.Size = new System.Drawing.Size(244, 30);
            this.lblProductItems.TabIndex = 70;
            this.lblProductItems.Text = "Товарные позиции:";
            // 
            // dgvProductItems
            // 
            this.dgvProductItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductItems.Location = new System.Drawing.Point(34, 209);
            this.dgvProductItems.Name = "dgvProductItems";
            this.dgvProductItems.RowHeadersWidth = 51;
            this.dgvProductItems.RowTemplate.Height = 24;
            this.dgvProductItems.Size = new System.Drawing.Size(370, 469);
            this.dgvProductItems.TabIndex = 69;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(448, 494);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(152, 41);
            this.btnAddItem.TabIndex = 72;
            this.btnAddItem.Text = "Добавить";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(615, 494);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(203, 41);
            this.btnDeleteItem.TabIndex = 73;
            this.btnDeleteItem.Text = "Удалить позицию";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblTotalAmount.Location = new System.Drawing.Point(443, 556);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(253, 38);
            this.lblTotalAmount.TabIndex = 74;
            this.lblTotalAmount.Text = "Общая сумма:";
            // 
            // lblAvailableQuantity
            // 
            this.lblAvailableQuantity.AutoSize = true;
            this.lblAvailableQuantity.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblAvailableQuantity.Location = new System.Drawing.Point(443, 446);
            this.lblAvailableQuantity.Name = "lblAvailableQuantity";
            this.lblAvailableQuantity.Size = new System.Drawing.Size(252, 30);
            this.lblAvailableQuantity.TabIndex = 75;
            this.lblAvailableQuantity.Text = "Доступный остаток:";
            // 
            // nudPrice
            // 
            this.nudPrice.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.nudPrice.Location = new System.Drawing.Point(448, 396);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(370, 36);
            this.nudPrice.TabIndex = 76;
            // 
            // FrmSaleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 706);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.lblAvailableQuantity);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblProductItems);
            this.Controls.Add(this.dgvProductItems);
            this.Controls.Add(this.txtSaleClient);
            this.Controls.Add(this.lblSaleClient);
            this.Controls.Add(this.dtpSaleDate);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblSaleDate);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSaleEdit";
            this.Text = "Оформление продажи";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSaleClient;
        private System.Windows.Forms.Label lblSaleClient;
        private System.Windows.Forms.Label lblProductItems;
        private System.Windows.Forms.DataGridView dgvProductItems;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblAvailableQuantity;
        private System.Windows.Forms.NumericUpDown nudPrice;
    }
}