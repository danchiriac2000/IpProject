
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
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.labelNewUserName = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(275, 158);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(234, 22);
            this.textBoxDelete.TabIndex = 0;
            // 
            // labelNewUserName
            // 
            this.labelNewUserName.AutoSize = true;
            this.labelNewUserName.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.labelNewUserName.Location = new System.Drawing.Point(171, 159);
            this.labelNewUserName.Name = "labelNewUserName";
            this.labelNewUserName.Size = new System.Drawing.Size(98, 21);
            this.labelNewUserName.TabIndex = 4;
            this.labelNewUserName.Text = "Username:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(334, 199);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete!";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelNewUserName);
            this.Controls.Add(this.textBoxDelete);
            this.Name = "FormDeleteUser";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.Label labelNewUserName;
        private System.Windows.Forms.Button buttonDelete;
    }
}