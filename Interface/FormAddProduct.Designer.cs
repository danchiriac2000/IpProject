
namespace Interface
{
    partial class FormAddProduct
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
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.groupBoxAddProduct = new System.Windows.Forms.GroupBox();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStock = new System.Windows.Forms.NumericUpDown();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.labelInitialStock = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelNewProduct = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.groupBoxAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(730, 522);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(84, 29);
            this.buttonAddProduct.TabIndex = 7;
            this.buttonAddProduct.Text = "Add!";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // groupBoxAddProduct
            // 
            this.groupBoxAddProduct.Controls.Add(this.numericUpDownPrice);
            this.groupBoxAddProduct.Controls.Add(this.numericUpDownStock);
            this.groupBoxAddProduct.Controls.Add(this.textBoxBarcode);
            this.groupBoxAddProduct.Controls.Add(this.labelInitialStock);
            this.groupBoxAddProduct.Controls.Add(this.labelPrice);
            this.groupBoxAddProduct.Controls.Add(this.labelBarcode);
            this.groupBoxAddProduct.Controls.Add(this.comboBoxCategory);
            this.groupBoxAddProduct.Controls.Add(this.labelCategory);
            this.groupBoxAddProduct.Controls.Add(this.labelNewProduct);
            this.groupBoxAddProduct.Controls.Add(this.comboBoxProduct);
            this.groupBoxAddProduct.Font = new System.Drawing.Font("Mongolian Baiti", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAddProduct.Location = new System.Drawing.Point(49, 27);
            this.groupBoxAddProduct.Name = "groupBoxAddProduct";
            this.groupBoxAddProduct.Size = new System.Drawing.Size(752, 477);
            this.groupBoxAddProduct.TabIndex = 18;
            this.groupBoxAddProduct.TabStop = false;
            this.groupBoxAddProduct.Text = "NEW PRODUCT";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new System.Drawing.Point(323, 286);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(281, 26);
            this.numericUpDownPrice.TabIndex = 39;
            // 
            // numericUpDownStock
            // 
            this.numericUpDownStock.Location = new System.Drawing.Point(323, 353);
            this.numericUpDownStock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownStock.Name = "numericUpDownStock";
            this.numericUpDownStock.Size = new System.Drawing.Size(281, 26);
            this.numericUpDownStock.TabIndex = 38;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(323, 82);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(281, 26);
            this.textBoxBarcode.TabIndex = 37;
            // 
            // labelInitialStock
            // 
            this.labelInitialStock.AutoSize = true;
            this.labelInitialStock.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInitialStock.Location = new System.Drawing.Point(160, 353);
            this.labelInitialStock.Name = "labelInitialStock";
            this.labelInitialStock.Size = new System.Drawing.Size(138, 25);
            this.labelInitialStock.TabIndex = 36;
            this.labelInitialStock.Text = "Initial stock :";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(192, 281);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(74, 25);
            this.labelPrice.TabIndex = 35;
            this.labelPrice.Text = "Price :";
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarcode.Location = new System.Drawing.Point(179, 83);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(111, 25);
            this.labelBarcode.TabIndex = 34;
            this.labelBarcode.Text = "Barcode : ";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(323, 146);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(281, 24);
            this.comboBoxCategory.TabIndex = 33;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged_1);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.labelCategory.Location = new System.Drawing.Point(177, 145);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(114, 25);
            this.labelCategory.TabIndex = 32;
            this.labelCategory.Text = "Category :";
            // 
            // labelNewProduct
            // 
            this.labelNewProduct.AutoSize = true;
            this.labelNewProduct.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.labelNewProduct.Location = new System.Drawing.Point(177, 216);
            this.labelNewProduct.Name = "labelNewProduct";
            this.labelNewProduct.Size = new System.Drawing.Size(100, 25);
            this.labelNewProduct.TabIndex = 31;
            this.labelNewProduct.Text = "Product :";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(323, 213);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(281, 24);
            this.comboBoxProduct.TabIndex = 30;
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.groupBoxAddProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.Name = "FormAddProduct";
            this.Text = "Add new product:";
            this.groupBoxAddProduct.ResumeLayout(false);
            this.groupBoxAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.GroupBox groupBoxAddProduct;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownStock;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label labelInitialStock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelNewProduct;
        private System.Windows.Forms.ComboBox comboBoxProduct;
    }
}