
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
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.labelNewProduct = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Items.AddRange(new object[] {
            "ValidProducts products = ValidProducts.GetInstance();",
            "            Dictionary<String, List<String>> elemente = products.Products;",
            "            foreach (KeyValuePair<String, List<String>> entry in elemente)",
            "            {",
            "                foreach (String drug in entry.Value)",
            "                {",
            "                    comboBox1.Items.Add(drug);",
            "                }",
            "            }"});
            this.comboBoxProduct.Location = new System.Drawing.Point(277, 216);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(247, 24);
            this.comboBoxProduct.TabIndex = 0;
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelNewProduct
            // 
            this.labelNewProduct.AutoSize = true;
            this.labelNewProduct.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.labelNewProduct.Location = new System.Drawing.Point(183, 216);
            this.labelNewProduct.Name = "labelNewProduct";
            this.labelNewProduct.Size = new System.Drawing.Size(79, 21);
            this.labelNewProduct.TabIndex = 6;
            this.labelNewProduct.Text = "Product:";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(360, 259);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProduct.TabIndex = 7;
            this.buttonAddProduct.Text = "Add!";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label1.Location = new System.Drawing.Point(183, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "ValidProducts products = ValidProducts.GetInstance();",
            "            Dictionary<String, List<String>> elemente = products.Products;",
            "            foreach (KeyValuePair<String, List<String>> entry in elemente)",
            "            {",
            "                foreach (String drug in entry.Value)",
            "                {",
            "                    comboBox1.Items.Add(drug);",
            "                }",
            "            }"});
            this.comboBoxCategory.Location = new System.Drawing.Point(279, 170);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(247, 24);
            this.comboBoxCategory.TabIndex = 9;
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.labelNewProduct);
            this.Controls.Add(this.comboBoxProduct);
            this.Name = "FormAddProduct";
            this.Text = "FormAddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label labelNewProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategory;
    }
}