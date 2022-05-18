using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ip_proiect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form pagina = new Form1();
            this.Hide();
            pagina.Show();
        }

        private void name_TextChanged(object sender, EventArgs e)
        { }
        
    }
}
