
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
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.groupBoxAddUser = new System.Windows.Forms.GroupBox();
            this.labelNewUserOccupation = new System.Windows.Forms.Label();
            this.labelNewUserPass = new System.Windows.Forms.Label();
            this.labelNewUserName = new System.Windows.Forms.Label();
            this.textBoxNewUserOccupation = new System.Windows.Forms.TextBox();
            this.textBoxNewUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewUserName = new System.Windows.Forms.TextBox();
            this.groupBoxAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.Location = new System.Drawing.Point(756, 410);
            this.buttonAddNewUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(106, 29);
            this.buttonAddNewUser.TabIndex = 6;
            this.buttonAddNewUser.Text = "Add";
            this.buttonAddNewUser.UseVisualStyleBackColor = true;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // groupBoxAddUser
            // 
            this.groupBoxAddUser.Controls.Add(this.labelNewUserOccupation);
            this.groupBoxAddUser.Controls.Add(this.labelNewUserPass);
            this.groupBoxAddUser.Controls.Add(this.labelNewUserName);
            this.groupBoxAddUser.Controls.Add(this.textBoxNewUserOccupation);
            this.groupBoxAddUser.Controls.Add(this.textBoxNewUserPassword);
            this.groupBoxAddUser.Controls.Add(this.textBoxNewUserName);
            this.groupBoxAddUser.Location = new System.Drawing.Point(54, 32);
            this.groupBoxAddUser.Name = "groupBoxAddUser";
            this.groupBoxAddUser.Size = new System.Drawing.Size(808, 373);
            this.groupBoxAddUser.TabIndex = 7;
            this.groupBoxAddUser.TabStop = false;
            this.groupBoxAddUser.Text = "ADD NEW USER";
            // 
            // labelNewUserOccupation
            // 
            this.labelNewUserOccupation.AutoSize = true;
            this.labelNewUserOccupation.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.labelNewUserOccupation.Location = new System.Drawing.Point(172, 234);
            this.labelNewUserOccupation.Name = "labelNewUserOccupation";
            this.labelNewUserOccupation.Size = new System.Drawing.Size(182, 25);
            this.labelNewUserOccupation.TabIndex = 11;
            this.labelNewUserOccupation.Text = "Occupation code:";
            // 
            // labelNewUserPass
            // 
            this.labelNewUserPass.AutoSize = true;
            this.labelNewUserPass.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.labelNewUserPass.Location = new System.Drawing.Point(201, 173);
            this.labelNewUserPass.Name = "labelNewUserPass";
            this.labelNewUserPass.Size = new System.Drawing.Size(110, 25);
            this.labelNewUserPass.TabIndex = 10;
            this.labelNewUserPass.Text = "Password:";
            // 
            // labelNewUserName
            // 
            this.labelNewUserName.AutoSize = true;
            this.labelNewUserName.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.labelNewUserName.Location = new System.Drawing.Point(201, 114);
            this.labelNewUserName.Name = "labelNewUserName";
            this.labelNewUserName.Size = new System.Drawing.Size(116, 25);
            this.labelNewUserName.TabIndex = 9;
            this.labelNewUserName.Text = "Username:";
            // 
            // textBoxNewUserOccupation
            // 
            this.textBoxNewUserOccupation.Location = new System.Drawing.Point(360, 233);
            this.textBoxNewUserOccupation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewUserOccupation.Name = "textBoxNewUserOccupation";
            this.textBoxNewUserOccupation.Size = new System.Drawing.Size(276, 26);
            this.textBoxNewUserOccupation.TabIndex = 8;
            // 
            // textBoxNewUserPassword
            // 
            this.textBoxNewUserPassword.Location = new System.Drawing.Point(360, 172);
            this.textBoxNewUserPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewUserPassword.Name = "textBoxNewUserPassword";
            this.textBoxNewUserPassword.Size = new System.Drawing.Size(276, 26);
            this.textBoxNewUserPassword.TabIndex = 7;
            // 
            // textBoxNewUserName
            // 
            this.textBoxNewUserName.Location = new System.Drawing.Point(360, 113);
            this.textBoxNewUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewUserName.Name = "textBoxNewUserName";
            this.textBoxNewUserName.Size = new System.Drawing.Size(276, 26);
            this.textBoxNewUserName.TabIndex = 6;
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.groupBoxAddUser);
            this.Controls.Add(this.buttonAddNewUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddUser";
            this.Text = "Add new user:";
            this.groupBoxAddUser.ResumeLayout(false);
            this.groupBoxAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddNewUser;
        private System.Windows.Forms.GroupBox groupBoxAddUser;
        private System.Windows.Forms.Label labelNewUserOccupation;
        private System.Windows.Forms.Label labelNewUserPass;
        private System.Windows.Forms.Label labelNewUserName;
        private System.Windows.Forms.TextBox textBoxNewUserOccupation;
        private System.Windows.Forms.TextBox textBoxNewUserPassword;
        private System.Windows.Forms.TextBox textBoxNewUserName;
    }
}