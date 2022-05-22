using Items.DataBaseObjects;
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
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string product = comboBoxProduct.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ValidProducts products = ValidProducts.GetInstance();
            Dictionary<String, List<String>> elemente = products.Products;
            foreach(KeyValuePair<String, List<String>> entry in elemente)
            {
                foreach(String drug in entry.Value)
                {
                    comboBox1.Items.Add(drug);
                }
            }*/
        }
    }
}
