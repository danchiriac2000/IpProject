using Exceptions.DataBaseExceptions;
using PharmacyManagementDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form3 : Form
    {
        private ProxyActionManager _util = new ProxyActionManager();

        public Form3()
        {
            InitializeComponent();
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        { 
            try
            {
                string newUsername = textBoxNewUserName.Text;
                string newPassword = textBoxNewUserPassword.Text;
                int newOccupation = Convert.ToInt32(textBoxNewUserOccupation.Text);
                _util.AddUser(newUsername, newPassword,newOccupation);
                //MessageBox.Show("" + (_util == null));
                this.Close(); 
            }
            catch(ConstraintViolatedException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
