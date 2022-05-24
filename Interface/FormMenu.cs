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
    public partial class FormMenu : Form
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();


        public FormMenu()
        {
            InitializeComponent();

            //spatiul de afisare se initializeaza doar o singura data, la autentificare, 
            //in functie de tipul de utilizator autentificat
            InitializeDataGrid();
            labelAuthenticatedUser.Text = "Welcome, " + _util.CurrentUser.Username.ToUpper(CultureInfo.CurrentCulture); 
            
            if (_util.RootAccess()){
                buttonAddUser.Enabled = true;
                buttonUsersList.Enabled = true;
                buttonPassUpdate.Enabled = true;
                buttonDeleteUser.Enabled = true;
                buttonAddNewProduct.Enabled = false;
                buttonAddStock.Enabled = false;
                buttonProductList.Enabled = false;
                buttonSellProduct.Enabled = false;
                buttonUpdateProductPrice.Enabled = false;
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
                buttonUpdateProductPrice.Enabled = true;
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
            this.DisplayUsers();
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
            this.DisplayProducts();
        }

        private void InitializeDataGrid()
        {
            dataGridViewDBInfo.AllowUserToAddRows = false;
            
       
            if (_util.RootAccess())
            {
                dataGridViewDBInfo.Columns.Clear();
                //dataGridView.AutoResizeColumns();
                //dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewDBInfo.AutoResizeRows();
                dataGridViewDBInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                dataGridViewDBInfo.Columns.Add("ID", "ID");
                dataGridViewDBInfo.Columns.Add("Username", "Username");
                dataGridViewDBInfo.Columns.Add("Rights", "Rights");
            }
            else
            {
                dataGridViewDBInfo.Columns.Clear();
                dataGridViewDBInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                dataGridViewDBInfo.Columns.Add("Barcode", "Barcode");
                dataGridViewDBInfo.Columns.Add("Name", "Name");
                dataGridViewDBInfo.Columns.Add("Category", "Category");
                dataGridViewDBInfo.Columns.Add("Price", "Price");
                dataGridViewDBInfo.Columns.Add("Stock", "Stock");
            }
        }

        private void DisplayProducts()
        {
            List<Product> products = _util.GetProducts();
            dataGridViewDBInfo.Rows.Clear();

            for (int i = 0; i < products.Count; i++)
            {
                dataGridViewDBInfo.Rows.Add(products[i].Id.ToString(), products[i].Name, products[i].Category, products[i].Price.ToString(), products[i].Stock.ToString());
            }
        }

        private void DisplayUsers()
        {
            List<User> users = _util.GetUsers();
            dataGridViewDBInfo.Rows.Clear();

            for (int i = 0; i < users.Count; i++)
            {
                dataGridViewDBInfo.Rows.Add(users[i].Id.ToString(), users[i].Username, users[i].Rights.ToString());
            }
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonUpdateProductPrice_Click(object sender, EventArgs e)
        {
            Form pagina9 = new FormUpdatePrice();
            pagina9.Show();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "HelpPharmacy.chm");
        }
    }
}
