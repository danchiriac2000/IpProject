using DataBaseManager;
using Items.DataBaseObjects;
using PharmacyManagementDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form2 : Form
    {
        //private ProxyActionManager _util = new ProxyActionManager();
        private Permissions  _permissions = new Permissions();
        private DB _dbInstance = DB.GetInstance("IPpharma.db");

        public Form2()
        {
            InitializeComponent();
            label1.Text = "" + Form1.username.ToUpper(CultureInfo.CurrentCulture);
            if (Form1.username.Equals("admin")){
                buttonAddUser.Enabled = true;
                buttonDeleteUser.Enabled = true;
                buttonPassUpdate.Enabled = true;
            }
            else
            {
                buttonAddUser.Enabled = false;
                buttonDeleteUser.Enabled = false;
                buttonPassUpdate.Enabled = false;
            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form pagina = new Form1();
            this.Hide();
            pagina.Show();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //if(_permissions.Equals("")
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            Form pagina3 = new Form3();
            pagina3.Show();
        }

        private void buttonPassUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
