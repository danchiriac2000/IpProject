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
    public partial class FormDeleteUser : Form
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();
        public FormDeleteUser()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string username= textBoxDelete.Text;
            try
            {
                _util.DeleteUser(username);
                this.Close();
            }
            catch(RecordNotFoundException exc)
            {
                MessageBox.Show(exc.Message);
            }
            
            
        }
    }
}
