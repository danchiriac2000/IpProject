using DataBaseManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyManagementDLL;
using Items;
using Exceptions;
using System.Data.SqlClient;
using Items.DataBaseObjects;
using Items.Commons;

namespace Interface
{
    public partial class FormLogIn : Form
    {
 
        private ProxyActionManager _util=ProxyActionManager.GetInstance();


        public FormLogIn()
        {
            InitializeComponent();        

        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text;
            string password = textBoxPass.Text;
            
            
            if (_util.Login(username, password)==true){

                Form pagina2 = new FormMenu();
                this.Hide();
                pagina2.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!","ERROR");
            }


        }
    }
}
