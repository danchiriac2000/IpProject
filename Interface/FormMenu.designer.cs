
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
            this.dataGridViewDBInfo = new System.Windows.Forms.DataGridView();
            this.groupBoxRootAccess = new System.Windows.Forms.GroupBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonUsersList = new System.Windows.Forms.Button();
            this.buttonPassUpdate = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.groupBoxEmployeeAccess = new System.Windows.Forms.GroupBox();
            this.buttonUpdateProductPrice = new System.Windows.Forms.Button();
            this.buttonAddNewProduct = new System.Windows.Forms.Button();
            this.buttonSellProduct = new System.Windows.Forms.Button();
            this.buttonProductList = new System.Windows.Forms.Button();
            this.buttonAddStock = new System.Windows.Forms.Button();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelAuthenticatedUser = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBInfo)).BeginInit();
            this.groupBoxRootAccess.SuspendLayout();
            this.groupBoxEmployeeAccess.SuspendLayout();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDBInfo
            // 
            this.dataGridViewDBInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDBInfo.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewDBInfo.Location = new System.Drawing.Point(18, 198);
            this.dataGridViewDBInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewDBInfo.Name = "dataGridViewDBInfo";
            this.dataGridViewDBInfo.RowHeadersWidth = 51;
            this.dataGridViewDBInfo.RowTemplate.Height = 24;
            this.dataGridViewDBInfo.Size = new System.Drawing.Size(1013, 349);
            this.dataGridViewDBInfo.TabIndex = 14;
            // 
            // groupBoxRootAccess
            // 
            this.groupBoxRootAccess.Controls.Add(this.buttonDeleteUser);
            this.groupBoxRootAccess.Controls.Add(this.buttonUsersList);
            this.groupBoxRootAccess.Controls.Add(this.buttonPassUpdate);
            this.groupBoxRootAccess.Controls.Add(this.buttonAddUser);
            this.groupBoxRootAccess.Location = new System.Drawing.Point(211, 13);
            this.groupBoxRootAccess.Name = "groupBoxRootAccess";
            this.groupBoxRootAccess.Size = new System.Drawing.Size(339, 162);
            this.groupBoxRootAccess.TabIndex = 16;
            this.groupBoxRootAccess.TabStop = false;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteUser.Location = new System.Drawing.Point(172, 86);
            this.buttonDeleteUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(129, 68);
            this.buttonDeleteUser.TabIndex = 16;
            this.buttonDeleteUser.Text = "Delete user";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonUsersList
            // 
            this.buttonUsersList.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonUsersList.Location = new System.Drawing.Point(172, 10);
            this.buttonUsersList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUsersList.Name = "buttonUsersList";
            this.buttonUsersList.Size = new System.Drawing.Size(129, 68);
            this.buttonUsersList.TabIndex = 15;
            this.buttonUsersList.Text = "Users";
            this.buttonUsersList.UseVisualStyleBackColor = true;
            this.buttonUsersList.Click += new System.EventHandler(this.buttonUsersList_Click);
            // 
            // buttonPassUpdate
            // 
            this.buttonPassUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonPassUpdate.Location = new System.Drawing.Point(37, 86);
            this.buttonPassUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPassUpdate.Name = "buttonPassUpdate";
            this.buttonPassUpdate.Size = new System.Drawing.Size(129, 68);
            this.buttonPassUpdate.TabIndex = 14;
            this.buttonPassUpdate.Text = "Update password";
            this.buttonPassUpdate.UseVisualStyleBackColor = true;
            this.buttonPassUpdate.Click += new System.EventHandler(this.buttonPassUpdate_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonAddUser.Location = new System.Drawing.Point(37, 9);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(129, 68);
            this.buttonAddUser.TabIndex = 13;
            this.buttonAddUser.Text = "Add user";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // groupBoxEmployeeAccess
            // 
            this.groupBoxEmployeeAccess.Controls.Add(this.buttonUpdateProductPrice);
            this.groupBoxEmployeeAccess.Controls.Add(this.buttonAddNewProduct);
            this.groupBoxEmployeeAccess.Controls.Add(this.buttonSellProduct);
            this.groupBoxEmployeeAccess.Controls.Add(this.buttonProductList);
            this.groupBoxEmployeeAccess.Controls.Add(this.buttonAddStock);
            this.groupBoxEmployeeAccess.Location = new System.Drawing.Point(566, 12);
            this.groupBoxEmployeeAccess.Name = "groupBoxEmployeeAccess";
            this.groupBoxEmployeeAccess.Size = new System.Drawing.Size(465, 162);
            this.groupBoxEmployeeAccess.TabIndex = 17;
            this.groupBoxEmployeeAccess.TabStop = false;
            // 
            // buttonUpdateProductPrice
            // 
            this.buttonUpdateProductPrice.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonUpdateProductPrice.Location = new System.Drawing.Point(303, 9);
            this.buttonUpdateProductPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdateProductPrice.Name = "buttonUpdateProductPrice";
            this.buttonUpdateProductPrice.Size = new System.Drawing.Size(129, 68);
            this.buttonUpdateProductPrice.TabIndex = 25;
            this.buttonUpdateProductPrice.Text = "Update price";
            this.buttonUpdateProductPrice.UseVisualStyleBackColor = true;
            this.buttonUpdateProductPrice.Click += new System.EventHandler(this.buttonUpdateProductPrice_Click);
            // 
            // buttonAddNewProduct
            // 
            this.buttonAddNewProduct.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonAddNewProduct.Location = new System.Drawing.Point(33, 10);
            this.buttonAddNewProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddNewProduct.Name = "buttonAddNewProduct";
            this.buttonAddNewProduct.Size = new System.Drawing.Size(129, 68);
            this.buttonAddNewProduct.TabIndex = 24;
            this.buttonAddNewProduct.Text = "Add new product";
            this.buttonAddNewProduct.UseVisualStyleBackColor = true;
            this.buttonAddNewProduct.Click += new System.EventHandler(this.buttonAddNewProduct_Click);
            // 
            // buttonSellProduct
            // 
            this.buttonSellProduct.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonSellProduct.Location = new System.Drawing.Point(107, 86);
            this.buttonSellProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSellProduct.Name = "buttonSellProduct";
            this.buttonSellProduct.Size = new System.Drawing.Size(129, 68);
            this.buttonSellProduct.TabIndex = 23;
            this.buttonSellProduct.Text = "Sell Product";
            this.buttonSellProduct.UseVisualStyleBackColor = true;
            this.buttonSellProduct.Click += new System.EventHandler(this.buttonSellProduct_Click);
            // 
            // buttonProductList
            // 
            this.buttonProductList.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonProductList.Location = new System.Drawing.Point(242, 85);
            this.buttonProductList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonProductList.Name = "buttonProductList";
            this.buttonProductList.Size = new System.Drawing.Size(129, 68);
            this.buttonProductList.TabIndex = 22;
            this.buttonProductList.Text = "Product List";
            this.buttonProductList.UseVisualStyleBackColor = true;
            this.buttonProductList.Click += new System.EventHandler(this.buttonProductList_Click);
            // 
            // buttonAddStock
            // 
            this.buttonAddStock.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonAddStock.Location = new System.Drawing.Point(168, 10);
            this.buttonAddStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddStock.Name = "buttonAddStock";
            this.buttonAddStock.Size = new System.Drawing.Size(129, 68);
            this.buttonAddStock.TabIndex = 21;
            this.buttonAddStock.Text = "Add to stock";
            this.buttonAddStock.UseVisualStyleBackColor = true;
            this.buttonAddStock.Click += new System.EventHandler(this.buttonAddStock_Click);
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.buttonHelp);
            this.groupBoxLogin.Controls.Add(this.labelAuthenticatedUser);
            this.groupBoxLogin.Controls.Add(this.buttonLogOut);
            this.groupBoxLogin.Location = new System.Drawing.Point(5, 12);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(200, 162);
            this.groupBoxLogin.TabIndex = 18;
            this.groupBoxLogin.TabStop = false;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonHelp.Location = new System.Drawing.Point(36, 109);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(129, 39);
            this.buttonHelp.TabIndex = 16;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // labelAuthenticatedUser
            // 
            this.labelAuthenticatedUser.AutoSize = true;
            this.labelAuthenticatedUser.Font = new System.Drawing.Font("Sitka Subheading", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelAuthenticatedUser.Location = new System.Drawing.Point(50, 5);
            this.labelAuthenticatedUser.Name = "labelAuthenticatedUser";
            this.labelAuthenticatedUser.Size = new System.Drawing.Size(0, 32);
            this.labelAuthenticatedUser.TabIndex = 15;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold);
            this.buttonLogOut.Location = new System.Drawing.Point(36, 59);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(129, 42);
            this.buttonLogOut.TabIndex = 14;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1043, 561);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.groupBoxEmployeeAccess);
            this.Controls.Add(this.groupBoxRootAccess);
            this.Controls.Add(this.dataGridViewDBInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMenu";
            this.Text = "Menu:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBInfo)).EndInit();
            this.groupBoxRootAccess.ResumeLayout(false);
            this.groupBoxEmployeeAccess.ResumeLayout(false);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDBInfo;
        private System.Windows.Forms.GroupBox groupBoxRootAccess;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonUsersList;
        private System.Windows.Forms.Button buttonPassUpdate;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.GroupBox groupBoxEmployeeAccess;
        private System.Windows.Forms.Button buttonUpdateProductPrice;
        private System.Windows.Forms.Button buttonAddNewProduct;
        private System.Windows.Forms.Button buttonSellProduct;
        private System.Windows.Forms.Button buttonProductList;
        private System.Windows.Forms.Button buttonAddStock;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelAuthenticatedUser;
        private System.Windows.Forms.Button buttonLogOut;
    }
}