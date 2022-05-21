
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
            this.textBoxNewUserName.Location = new System.Drawing.Point(279, 126);
            this.textBoxNewUserName.Name = "textBoxNewUserName";
            this.textBoxNewUserName.Size = new System.Drawing.Size(246, 27);
            this.textBoxNewUserName.TabIndex = 0;
            // 
            // textBoxNewUserPassword
            // 
            this.textBoxNewUserPassword.Location = new System.Drawing.Point(279, 185);
            this.textBoxNewUserPassword.Name = "textBoxNewUserPassword";
            this.textBoxNewUserPassword.Size = new System.Drawing.Size(246, 27);
            this.textBoxNewUserPassword.TabIndex = 1;
            // 
            // textBoxNewUserOccupation
            // 
            this.textBoxNewUserOccupation.Location = new System.Drawing.Point(279, 246);
            this.textBoxNewUserOccupation.Name = "textBoxNewUserOccupation";
            this.textBoxNewUserOccupation.Size = new System.Drawing.Size(246, 27);
            this.textBoxNewUserOccupation.TabIndex = 2;
            // 
            // labelNewUserName
            // 
            this.labelNewUserName.AutoSize = true;
            this.labelNewUserName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNewUserName.Location = new System.Drawing.Point(164, 126);
            this.labelNewUserName.Name = "labelNewUserName";
            this.labelNewUserName.Size = new System.Drawing.Size(98, 21);
            this.labelNewUserName.TabIndex = 3;
            this.labelNewUserName.Text = "Username:";
            // 
            // labelNewUserPass
            // 
            this.labelNewUserPass.AutoSize = true;
            this.labelNewUserPass.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNewUserPass.Location = new System.Drawing.Point(164, 185);
            this.labelNewUserPass.Name = "labelNewUserPass";
            this.labelNewUserPass.Size = new System.Drawing.Size(93, 21);
            this.labelNewUserPass.TabIndex = 4;
            this.labelNewUserPass.Text = "Password:";
            // 
            // labelNewUserOccupation
            // 
            this.labelNewUserOccupation.AutoSize = true;
            this.labelNewUserOccupation.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNewUserOccupation.Location = new System.Drawing.Point(164, 248);
            this.labelNewUserOccupation.Name = "labelNewUserOccupation";
            this.labelNewUserOccupation.Size = new System.Drawing.Size(109, 21);
            this.labelNewUserOccupation.TabIndex = 5;
            this.labelNewUserOccupation.Text = "Occupation:";
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.Location = new System.Drawing.Point(343, 298);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(94, 29);
            this.buttonAddNewUser.TabIndex = 6;
            this.buttonAddNewUser.Text = "Add!";
            this.buttonAddNewUser.UseVisualStyleBackColor = true;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddNewUser);
            this.Controls.Add(this.labelNewUserOccupation);
            this.Controls.Add(this.labelNewUserPass);
            this.Controls.Add(this.labelNewUserName);
            this.Controls.Add(this.textBoxNewUserOccupation);
            this.Controls.Add(this.textBoxNewUserPassword);
            this.Controls.Add(this.textBoxNewUserName);
            this.Name = "Form3";
            this.Text = "Form3";
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