
namespace Interface
{
    partial class FormAddUser
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
            this.textBoxNewUserName = new System.Windows.Forms.TextBox();
            this.textBoxNewUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewUserOccupation = new System.Windows.Forms.TextBox();
            this.labelNewUserName = new System.Windows.Forms.Label();
            this.labelNewUserPass = new System.Windows.Forms.Label();
            this.labelNewUserOccupation = new System.Windows.Forms.Label();
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNewUserName
            // 
            this.textBoxNewUserName.Location = new System.Drawing.Point(279, 101);
            this.textBoxNewUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewUserName.Name = "textBoxNewUserName";
            this.textBoxNewUserName.Size = new System.Drawing.Size(246, 22);
            this.textBoxNewUserName.TabIndex = 0;
            // 
            // textBoxNewUserPassword
            // 
            this.textBoxNewUserPassword.Location = new System.Drawing.Point(279, 148);
            this.textBoxNewUserPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewUserPassword.Name = "textBoxNewUserPassword";
            this.textBoxNewUserPassword.Size = new System.Drawing.Size(246, 22);
            this.textBoxNewUserPassword.TabIndex = 1;
            // 
            // textBoxNewUserOccupation
            // 
            this.textBoxNewUserOccupation.Location = new System.Drawing.Point(279, 197);
            this.textBoxNewUserOccupation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewUserOccupation.Name = "textBoxNewUserOccupation";
            this.textBoxNewUserOccupation.Size = new System.Drawing.Size(246, 22);
            this.textBoxNewUserOccupation.TabIndex = 2;
            // 
            // labelNewUserName
            // 
            this.labelNewUserName.AutoSize = true;
            this.labelNewUserName.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.labelNewUserName.Location = new System.Drawing.Point(164, 101);
            this.labelNewUserName.Name = "labelNewUserName";
            this.labelNewUserName.Size = new System.Drawing.Size(98, 21);
            this.labelNewUserName.TabIndex = 3;
            this.labelNewUserName.Text = "Username:";
            // 
            // labelNewUserPass
            // 
            this.labelNewUserPass.AutoSize = true;
            this.labelNewUserPass.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.labelNewUserPass.Location = new System.Drawing.Point(164, 148);
            this.labelNewUserPass.Name = "labelNewUserPass";
            this.labelNewUserPass.Size = new System.Drawing.Size(93, 21);
            this.labelNewUserPass.TabIndex = 4;
            this.labelNewUserPass.Text = "Password:";
            // 
            // labelNewUserOccupation
            // 
            this.labelNewUserOccupation.AutoSize = true;
            this.labelNewUserOccupation.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.labelNewUserOccupation.Location = new System.Drawing.Point(164, 198);
            this.labelNewUserOccupation.Name = "labelNewUserOccupation";
            this.labelNewUserOccupation.Size = new System.Drawing.Size(109, 21);
            this.labelNewUserOccupation.TabIndex = 5;
            this.labelNewUserOccupation.Text = "Occupation:";
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.Location = new System.Drawing.Point(343, 238);
            this.buttonAddNewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(94, 23);
            this.buttonAddNewUser.TabIndex = 6;
            this.buttonAddNewUser.Text = "Add!";
            this.buttonAddNewUser.UseVisualStyleBackColor = true;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.buttonAddNewUser);
            this.Controls.Add(this.labelNewUserOccupation);
            this.Controls.Add(this.labelNewUserPass);
            this.Controls.Add(this.labelNewUserName);
            this.Controls.Add(this.textBoxNewUserOccupation);
            this.Controls.Add(this.textBoxNewUserPassword);
            this.Controls.Add(this.textBoxNewUserName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddUser";
            this.Text = "Adaugare utilizator:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewUserName;
        private System.Windows.Forms.TextBox textBoxNewUserPassword;
        private System.Windows.Forms.TextBox textBoxNewUserOccupation;
        private System.Windows.Forms.Label labelNewUserName;
        private System.Windows.Forms.Label labelNewUserPass;
        private System.Windows.Forms.Label labelNewUserOccupation;
        private System.Windows.Forms.Button buttonAddNewUser;
    }
}