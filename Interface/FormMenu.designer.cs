
namespace Interface
{
    partial class FormMenu
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
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonAddStock = new System.Windows.Forms.Button();
            this.buttonProductList = new System.Windows.Forms.Button();
            this.buttonSellProduct = new System.Windows.Forms.Button();
            this.buttonAddNewProduct = new System.Windows.Forms.Button();
            this.buttonPassUpdate = new System.Windows.Forms.Button();
            this.buttonUsersList = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonAddUser.Location = new System.Drawing.Point(246, 25);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(115, 54);
            this.buttonAddUser.TabIndex = 3;
            this.buttonAddUser.Text = "Add user";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonAddStock
            // 
            this.buttonAddStock.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonAddStock.Location = new System.Drawing.Point(667, 25);
            this.buttonAddStock.Name = "buttonAddStock";
            this.buttonAddStock.Size = new System.Drawing.Size(115, 54);
            this.buttonAddStock.TabIndex = 4;
            this.buttonAddStock.Text = "Add to stock";
            this.buttonAddStock.UseVisualStyleBackColor = true;
            this.buttonAddStock.Click += new System.EventHandler(this.buttonAddStock_Click);
            // 
            // buttonProductList
            // 
            this.buttonProductList.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonProductList.Location = new System.Drawing.Point(667, 91);
            this.buttonProductList.Name = "buttonProductList";
            this.buttonProductList.Size = new System.Drawing.Size(115, 54);
            this.buttonProductList.TabIndex = 5;
            this.buttonProductList.Text = "Product List";
            this.buttonProductList.UseVisualStyleBackColor = true;
            this.buttonProductList.Click += new System.EventHandler(this.buttonProductList_Click);
            // 
            // buttonSellProduct
            // 
            this.buttonSellProduct.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonSellProduct.Location = new System.Drawing.Point(546, 91);
            this.buttonSellProduct.Name = "buttonSellProduct";
            this.buttonSellProduct.Size = new System.Drawing.Size(115, 54);
            this.buttonSellProduct.TabIndex = 6;
            this.buttonSellProduct.Text = "Sell Product";
            this.buttonSellProduct.UseVisualStyleBackColor = true;
            this.buttonSellProduct.Click += new System.EventHandler(this.buttonSellProduct_Click);
            // 
            // buttonAddNewProduct
            // 
            this.buttonAddNewProduct.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonAddNewProduct.Location = new System.Drawing.Point(546, 25);
            this.buttonAddNewProduct.Name = "buttonAddNewProduct";
            this.buttonAddNewProduct.Size = new System.Drawing.Size(115, 54);
            this.buttonAddNewProduct.TabIndex = 7;
            this.buttonAddNewProduct.Text = "Add new product";
            this.buttonAddNewProduct.UseVisualStyleBackColor = true;
            this.buttonAddNewProduct.Click += new System.EventHandler(this.buttonAddNewProduct_Click);
            // 
            // buttonPassUpdate
            // 
            this.buttonPassUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonPassUpdate.Location = new System.Drawing.Point(246, 85);
            this.buttonPassUpdate.Name = "buttonPassUpdate";
            this.buttonPassUpdate.Size = new System.Drawing.Size(115, 54);
            this.buttonPassUpdate.TabIndex = 8;
            this.buttonPassUpdate.Text = "Update password";
            this.buttonPassUpdate.UseVisualStyleBackColor = true;
            this.buttonPassUpdate.Click += new System.EventHandler(this.buttonPassUpdate_Click);
            // 
            // buttonUsersList
            // 
            this.buttonUsersList.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonUsersList.Location = new System.Drawing.Point(367, 25);
            this.buttonUsersList.Name = "buttonUsersList";
            this.buttonUsersList.Size = new System.Drawing.Size(115, 54);
            this.buttonUsersList.TabIndex = 9;
            this.buttonUsersList.Text = "Users";
            this.buttonUsersList.UseVisualStyleBackColor = true;
            this.buttonUsersList.Click += new System.EventHandler(this.buttonUsersList_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonLogOut.Location = new System.Drawing.Point(16, 56);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(115, 40);
            this.buttonLogOut.TabIndex = 10;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "labelName";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteUser.Location = new System.Drawing.Point(367, 85);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(115, 54);
            this.buttonDeleteUser.TabIndex = 12;
            this.buttonDeleteUser.Text = "Delete user";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonHelp.Location = new System.Drawing.Point(16, 102);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(115, 37);
            this.buttonHelp.TabIndex = 13;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.Location = new System.Drawing.Point(16, 158);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(766, 279);
            this.dataGridView.TabIndex = 14;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(797, 449);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonUsersList);
            this.Controls.Add(this.buttonPassUpdate);
            this.Controls.Add(this.buttonAddNewProduct);
            this.Controls.Add(this.buttonSellProduct);
            this.Controls.Add(this.buttonProductList);
            this.Controls.Add(this.buttonAddStock);
            this.Controls.Add(this.buttonAddUser);
            this.Name = "FormMenu";
            this.Text = "Menu:";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonAddStock;
        private System.Windows.Forms.Button buttonProductList;
        private System.Windows.Forms.Button buttonSellProduct;
        private System.Windows.Forms.Button buttonAddNewProduct;
        private System.Windows.Forms.Button buttonPassUpdate;
        private System.Windows.Forms.Button buttonUsersList;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}