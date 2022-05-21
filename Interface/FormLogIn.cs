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
    public partial class Form1 : Form
    {
        private DB _dbInstance;
        private Permissions _permissions;
        private ProxyActionManager _util;
        public static string username;
        public static string password;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            username = textBoxUser.Text;
            password = textBoxPass.Text;
            _util = new ProxyActionManager();
            if (_util.Login(username, password)==true){

                Form pagina2 = new Form2();
                this.Hide();
                pagina2.Show();
            }
        }
    }
}
