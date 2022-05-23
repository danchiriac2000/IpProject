using Exceptions.AccessRightsExceptions;
using Exceptions.DataBaseExceptions;
using Items.DataBaseObjects;
using PharmacyManagementDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FormAddProduct : Form
    {
        private ValidProducts _validProducts = ValidProducts.GetInstance();
        private ProxyActionManager _util = ProxyActionManager.GetInstance();

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
            try
            {
                int barcode = Convert.ToInt32(textBoxBarcode.Text);
                string product = comboBoxProduct.Text;
                string category = comboBoxCategory.Text;

                if (!comboBoxCategory.Items.Contains(category))
                {
                    MessageBox.Show("Please select a valid product category.");
                    return;
                }

                if (!comboBoxProduct.Items.Contains(product))
                {
                    MessageBox.Show("Please select a valid product name.");
                    return;
                }


                double price = Convert.ToDouble(numericUpDownPrice.Value);
                int stock = Convert.ToInt32(numericUpDownStock.Value);

                

                _util.AddNewProduct(new Product(barcode, product, category, price, stock));
                this.Close();
                MessageBox.Show("Product successfuly added!");
            }
            catch (PermissionDeniedException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Please insert valid number for barcode.");
            }
            catch (ConstraintViolatedException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (InvalidStockException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (InvalidDataException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch(OverflowException exc)
            {
                MessageBox.Show("Insert only numerical values in range (0-2147483647)");
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

     

        private void comboBoxCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string category = comboBoxCategory.SelectedItem.ToString();
            List<string> products = _validProducts.Products[category];
            comboBoxProduct.Items.Clear();
            foreach (string product in products)
            {
                comboBoxProduct.Items.Add(product);
            }
        }
    }
}
