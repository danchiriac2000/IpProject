
namespace Interface
{
    partial class FormDeleteUser
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxDeleteUser = new System.Windows.Forms.GroupBox();
            this.labelNewUserName = new System.Windows.Forms.Label();
            this.textBoxDeletedUsername = new System.Windows.Forms.TextBox();
            this.groupBoxDeleteUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(615, 326);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(84, 29);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxDeleteUser
            // 
            this.groupBoxDeleteUser.Controls.Add(this.labelNewUserName);
            this.groupBoxDeleteUser.Controls.Add(this.textBoxDeletedUsername);
            this.groupBoxDeleteUser.Location = new System.Drawing.Point(35, 32);
            this.groupBoxDeleteUser.Name = "groupBoxDeleteUser";
            this.groupBoxDeleteUser.Size = new System.Drawing.Size(655, 268);
            this.groupBoxDeleteUser.TabIndex = 6;
            this.groupBoxDeleteUser.TabStop = false;
            this.groupBoxDeleteUser.Text = "DELETE USER WITH GIVEN USERNAME";
            // 
            // labelNewUserName
            // 
            this.labelNewUserName.AutoSize = true;
            this.labelNewUserName.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.labelNewUserName.Location = new System.Drawing.Point(137, 123);
            this.labelNewUserName.Name = "labelNewUserName";
            this.labelNewUserName.Size = new System.Drawing.Size(116, 25);
            this.labelNewUserName.TabIndex = 6;
            this.labelNewUserName.Text = "Username:";
            // 
            // textBoxDeletedUsername
            // 
            this.textBoxDeletedUsername.Location = new System.Drawing.Point(254, 121);
            this.textBoxDeletedUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDeletedUsername.Name = "textBoxDeletedUsername";
            this.textBoxDeletedUsername.Size = new System.Drawing.Size(263, 26);
            this.textBoxDeletedUsername.TabIndex = 5;
            // 
            // FormDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 368);
            this.Controls.Add(this.groupBoxDeleteUser);
            this.Controls.Add(this.buttonDelete);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDeleteUser";
            this.Text = "Delete user:";
            this.groupBoxDeleteUser.ResumeLayout(false);
            this.groupBoxDeleteUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxDeleteUser;
        private System.Windows.Forms.Label labelNewUserName;
        private System.Windows.Forms.TextBox textBoxDeletedUsername;
    }
}