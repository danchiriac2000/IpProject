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
                buttonDeleteUser.Enabled = true;
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
                buttonDeleteUser.Enabled = false;
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
            float scaleX = 1.30f;
            float scaleY = 1.15f;
           int size = 10;
            for(int i = 0; i < size*size; i++)
            {
                int x = i % size;
                int y = i / size;
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            Form pagina3 = new FormAddUser();
            pagina3.Show();
        }

        private void buttonPassUpdate_Click(object sender, EventArgs e)
        {
            Form pagina5 = new FormUpdatePass();
            pagina5.Show();
        }

        private void buttonUsersList_Click(object sender, EventArgs e)
        {
            List<User> users = _util.GetUsers();
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("ID", "ID");
            dataGridView.Columns.Add("Username", "Username");
            dataGridView.Columns.Add("Rights", "Rights");

            for(int i = 0; i < users.Count; i++)
            {
                dataGridView.Rows.Add(users[i].Id.ToString(), users[i].Username, users[i].Rights.ToString());
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            Form pagina4 = new FormDeleteUser();
            pagina4.Show();
        }

        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            Form pagina6 = new FormAddProduct();
            pagina6.Show();
        }

        private void buttonAddStock_Click(object sender, EventArgs e)
        {
            Form pagina7 = new FormAddToStock();
            pagina7.Show();
        }

        private void buttonSellProduct_Click(object sender, EventArgs e)
        {
            Form pagina8 = new FormSell();
            pagina8.Show();
        }

        private void buttonProductList_Click(object sender, EventArgs e)
        {
            List<Product> products = _util.GetProducts();
            
        }
    }
}
