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
                buttonUsersList.Enabled = true;
                buttonPassUpdate.Enabled = true;
                buttonUsersList.Enabled = true;
                buttonAddNewProduct.Enabled = false;
                buttonAddStock.Enabled = false;
                buttonProductList.Enabled = false;
                buttonSellProduct.Enabled = false;
            }
            else
            {
                buttonAddUser.Enabled = false;
                buttonUsersList.Enabled = false;
                buttonPassUpdate.Enabled = false;
                buttonUsersList.Enabled = false;
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
            /*StringBuilder table = new StringBuilder();
            table.Append("{\rtf1");
            for (int i = 0; i <= 2; i++)
            {
                table.Append(@"\trowd"); //start the row
                table.Append(@"\cellx200"); //first cell with width 200
                table.Append(@"\cellx400"); //second cell with width 200
                table.Append(@"\cellx600"); //third cell with width 200
                table.Append(@"\intbl \cell \row"); //appent the row in StringBuilder
            }
            table.Append(@"\pard");

            table.Append(@"}");

            this.richTextBox.Rtf = table.ToString();*/
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            Form pagina3 = new FormAddUser();
            pagina3.Show();
        }

        private void buttonPassUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonUsersList_Click(object sender, EventArgs e)
        {
            /*StringBuilder table = new StringBuilder();
            table.Append("{\rtf1");
            for (int i = 0; i <= 2; i++)
            {
                table.Append(@"\trowd"); //start the row
                table.Append(@"\cellx200"); //first cell with width 200
                table.Append(@"\cellx400"); //second cell with width 200
                table.Append(@"\intbl \cell \row"); //appent the row in StringBuilder
            }
            table.Append(@"\pard");

            table.Append(@"}");

            richTextBox.Text=*/
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            Form pagina4 = new FormDeleteUser();
            pagina4.Show();
        }
    }
}
