
namespace Interface
{
    partial class FormUpdatePrice
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
            this.groupBoxUpdatePrice = new System.Windows.Forms.GroupBox();
            this.buttonUpdatePrice = new System.Windows.Forms.Button();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.labelNewPrice = new System.Windows.Forms.Label();
            this.numericUpDownNewPrice = new System.Windows.Forms.NumericUpDown();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.groupBoxUpdatePrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUpdatePrice
            // 
            this.groupBoxUpdatePrice.Controls.Add(this.labelBarcode);
            this.groupBoxUpdatePrice.Controls.Add(this.labelNewPrice);
            this.groupBoxUpdatePrice.Controls.Add(this.numericUpDownNewPrice);
            this.groupBoxUpdatePrice.Controls.Add(this.textBoxBarcode);
            this.groupBoxUpdatePrice.Location = new System.Drawing.Point(64, 12);
            this.groupBoxUpdatePrice.Name = "groupBoxUpdatePrice";
            this.groupBoxUpdatePrice.Size = new System.Drawing.Size(688, 366);
            this.groupBoxUpdatePrice.TabIndex = 4;
            this.groupBoxUpdatePrice.TabStop = false;
            this.groupBoxUpdatePrice.Text = "UPDATE PRODUCT PRICE";
            // 
            // buttonUpdatePrice
            // 
            this.buttonUpdatePrice.Location = new System.Drawing.Point(655, 399);
            this.buttonUpdatePrice.Name = "buttonUpdatePrice";
            this.buttonUpdatePrice.Size = new System.Drawing.Size(97, 39);
            this.buttonUpdatePrice.TabIndex = 5;
            this.buttonUpdatePrice.Text = "Update";
            this.buttonUpdatePrice.UseVisualStyleBackColor = true;
            this.buttonUpdatePrice.Click += new System.EventHandler(this.buttonUpdatePrice_Click);
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarcode.Location = new System.Drawing.Point(120, 130);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(105, 25);
            this.labelBarcode.TabIndex = 7;
            this.labelBarcode.Text = "Barcode :";
            // 
            // labelNewPrice
            // 
            this.labelNewPrice.AutoSize = true;
            this.labelNewPrice.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPrice.Location = new System.Drawing.Point(120, 209);
            this.labelNewPrice.Name = "labelNewPrice";
            this.labelNewPrice.Size = new System.Drawing.Size(124, 25);
            this.labelNewPrice.TabIndex = 6;
            this.labelNewPrice.Text = "New price :";
            // 
            // numericUpDownNewPrice
            // 
            this.numericUpDownNewPrice.DecimalPlaces = 2;
            this.numericUpDownNewPrice.Location = new System.Drawing.Point(282, 211);
            this.numericUpDownNewPrice.Name = "numericUpDownNewPrice";
            this.numericUpDownNewPrice.Size = new System.Drawing.Size(286, 26);
            this.numericUpDownNewPrice.TabIndex = 5;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(282, 129);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(286, 26);
            this.textBoxBarcode.TabIndex = 4;
            // 
            // FormUpdatePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdatePrice);
            this.Controls.Add(this.groupBoxUpdatePrice);
            this.Name = "FormUpdatePrice";
            this.Text = "FormUpdatePrice";
            this.groupBoxUpdatePrice.ResumeLayout(false);
            this.groupBoxUpdatePrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxUpdatePrice;
        private System.Windows.Forms.Button buttonUpdatePrice;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.Label labelNewPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownNewPrice;
        private System.Windows.Forms.TextBox textBoxBarcode;
    }
}