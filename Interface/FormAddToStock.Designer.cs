
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
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonAddToStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(266, 118);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(249, 22);
            this.textBoxBarcode.TabIndex = 0;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(266, 177);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(249, 22);
            this.textBoxQuantity.TabIndex = 1;
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.labelBarcode.Location = new System.Drawing.Point(165, 119);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(83, 21);
            this.labelBarcode.TabIndex = 9;
            this.labelBarcode.Text = "Barcode:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.labelQuantity.Location = new System.Drawing.Point(165, 176);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(87, 21);
            this.labelQuantity.TabIndex = 10;
            this.labelQuantity.Text = "Quantity:";
            // 
            // buttonAddToStock
            // 
            this.buttonAddToStock.Location = new System.Drawing.Point(358, 228);
            this.buttonAddToStock.Name = "buttonAddToStock";
            this.buttonAddToStock.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToStock.TabIndex = 11;
            this.buttonAddToStock.Text = "Add!";
            this.buttonAddToStock.UseVisualStyleBackColor = true;
            this.buttonAddToStock.Click += new System.EventHandler(this.buttonAddToStock_Click);
            // 
            // FormAddToStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddToStock);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelBarcode);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxBarcode);
            this.Name = "FormAddToStock";
            this.Text = "Add to stock:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonAddToStock;
    }
}