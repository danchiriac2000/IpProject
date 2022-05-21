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
    public partial class FormPaginaPrincipala : Form
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();


        public FormPaginaPrincipala()
        {
            InitializeComponent();

            label1.Text = "" + _util.CurrentUser.Username.ToUpper(CultureInfo.CurrentCulture); 
            
            if (_util.RootAccess()){
                buttonAddUser.Enabled = true;
                buttonDeleteUser.Enabled = true;
                buttonPassUpdate.Enabled = true;
                buttonAddNewProduct.Enabled = false;
                buttonAddStock.Enabled = false;
                buttonProductList.Enabled = false;
                buttonSellProduct.Enabled = false;
            }
            else
            {
                buttonAddUser.Enabled = false;
                buttonDeleteUser.Enabled = false;
                buttonPassUpdate.Enabled = false;
                buttonAddNewProduct.Enabled = true;
                buttonAddStock.Enabled = true;
                buttonProductList.Enabled = true;
                buttonSellProduct.Enabled = true;
            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form pagina = new FormLogIn();
            this.Hide();
            pagina.Show();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //if(_permissions.Equals("")
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            Form pagina3 = new FormAddUser();
            pagina3.Show();
        }

        private void buttonPassUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
