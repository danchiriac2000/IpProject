
namespace ip_proiect
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.TextBox();
            this.addUser = new System.Windows.Forms.Button();
            this.addStock = new System.Windows.Forms.Button();
            this.productList = new System.Windows.Forms.Button();
            this.sellProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.passUpdate = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 166);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(825, 272);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.name.Location = new System.Drawing.Point(68, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // addUser
            // 
            this.addUser.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser.Location = new System.Drawing.Point(3, 84);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(115, 53);
            this.addUser.TabIndex = 3;
            this.addUser.Text = "Add user";
            this.addUser.UseVisualStyleBackColor = true;
            // 
            // addStock
            // 
            this.addStock.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStock.Location = new System.Drawing.Point(608, 84);
            this.addStock.Name = "addStock";
            this.addStock.Size = new System.Drawing.Size(115, 53);
            this.addStock.TabIndex = 4;
            this.addStock.Text = "Add to stock";
            this.addStock.UseVisualStyleBackColor = true;
            // 
            // productList
            // 
            this.productList.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productList.Location = new System.Drawing.Point(729, 84);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(115, 53);
            this.productList.TabIndex = 5;
            this.productList.Text = "Product List";
            this.productList.UseVisualStyleBackColor = true;
            // 
            // sellProduct
            // 
            this.sellProduct.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellProduct.Location = new System.Drawing.Point(487, 84);
            this.sellProduct.Name = "sellProduct";
            this.sellProduct.Size = new System.Drawing.Size(115, 53);
            this.sellProduct.TabIndex = 6;
            this.sellProduct.Text = "Sell Product";
            this.sellProduct.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(366, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add new product";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // passUpdate
            // 
            this.passUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passUpdate.Location = new System.Drawing.Point(124, 84);
            this.passUpdate.Name = "passUpdate";
            this.passUpdate.Size = new System.Drawing.Size(115, 53);
            this.passUpdate.TabIndex = 8;
            this.passUpdate.Text = "Update password";
            this.passUpdate.UseVisualStyleBackColor = true;
            // 
            // deleteUser
            // 
            this.deleteUser.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUser.Location = new System.Drawing.Point(245, 84);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(115, 53);
            this.deleteUser.TabIndex = 9;
            this.deleteUser.Text = "Delete user";
            this.deleteUser.UseVisualStyleBackColor = true;
            // 
            // logOut
            // 
            this.logOut.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.Location = new System.Drawing.Point(729, 9);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(115, 53);
            this.logOut.TabIndex = 10;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.passUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sellProduct);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.addStock);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button addStock;
        private System.Windows.Forms.Button productList;
        private System.Windows.Forms.Button sellProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button passUpdate;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button logOut;
    }
}