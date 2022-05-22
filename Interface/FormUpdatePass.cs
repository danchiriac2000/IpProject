using PharmacyManagementDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FormUpdatePass : Form
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();

        public FormUpdatePass()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxUser.Text;
                string oldPass = textBoxOldPass.Text;
                string newPass = textBoxNewPass.Text;
                if (username == "" || oldPass == "" || newPass == "")
                {
                    throw new InvalidDataException();
                }
                _util.UpdateUserPassword(username, oldPass, newPass);
                this.Close();
            }
            catch (InvalidDataException exc)
            {
                MessageBox.Show("Please insert a valid data!");
            }

        }
    }
}
