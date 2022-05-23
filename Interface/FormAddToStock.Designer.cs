
namespace Interface
{
    partial class FormAddToStock
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
            this.buttonAddToStock = new System.Windows.Forms.Button();
            this.groupBoxUpdateStock = new System.Windows.Forms.GroupBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.groupBoxUpdateStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddToStock
            // 
            this.buttonAddToStock.Location = new System.Drawing.Point(770, 520);
            this.buttonAddToStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddToStock.Name = "buttonAddToStock";
            this.buttonAddToStock.Size = new System.Drawing.Size(84, 29);
            this.buttonAddToStock.TabIndex = 11;
            this.buttonAddToStock.Text = "Add";
            this.buttonAddToStock.UseVisualStyleBackColor = true;
            this.buttonAddToStock.Click += new System.EventHandler(this.buttonAddToStock_Click);
            // 
            // groupBoxUpdateStock
            // 
            this.groupBoxUpdateStock.Controls.Add(this.numericUpDownQuantity);
            this.groupBoxUpdateStock.Controls.Add(this.labelQuantity);
            this.groupBoxUpdateStock.Controls.Add(this.labelBarcode);
            this.groupBoxUpdateStock.Controls.Add(this.textBoxBarcode);
            this.groupBoxUpdateStock.Location = new System.Drawing.Point(41, 37);
            this.groupBoxUpdateStock.Name = "groupBoxUpdateStock";
            this.groupBoxUpdateStock.Size = new System.Drawing.Size(813, 447);
            this.groupBoxUpdateStock.TabIndex = 13;
            this.groupBoxUpdateStock.TabStop = false;
            this.groupBoxUpdateStock.Text = "ADD TO PRODUCT STOCK";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(323, 247);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(280, 26);
            this.numericUpDownQuantity.TabIndex = 16;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.labelQuantity.Location = new System.Drawing.Point(210, 245);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(103, 25);
            this.labelQuantity.TabIndex = 15;
            this.labelQuantity.Text = "Quantity:";
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.labelBarcode.Location = new System.Drawing.Point(210, 174);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(99, 25);
            this.labelBarcode.TabIndex = 14;
            this.labelBarcode.Text = "Barcode:";
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(323, 173);
            this.textBoxBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(280, 26);
            this.textBoxBarcode.TabIndex = 13;
            // 
            // FormAddToStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.groupBoxUpdateStock);
            this.Controls.Add(this.buttonAddToStock);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAddToStock";
            this.Text = "Add to stock:";
            this.groupBoxUpdateStock.ResumeLayout(false);
            this.groupBoxUpdateStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddToStock;
        private System.Windows.Forms.GroupBox groupBoxUpdateStock;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.TextBox textBoxBarcode;
    }
}