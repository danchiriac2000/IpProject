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
        ValidProducts _validProducts = ValidProducts.GetInstance();
        public FormAddProduct()
        {
            InitializeComponent();
            foreach (var entry in _validProducts.Products)
            {
                comboBoxCategory.Items.Add(entry.Key);
            }

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string product = comboBoxProduct.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = comboBoxCategory.SelectedItem.ToString();
            List<string> products = _validProducts.Products[category];
            foreach (string product in products)
            {
                comboBoxProduct.Items.Add(product);
            }
        }
    }
}
