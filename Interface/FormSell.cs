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
    public partial class FormSell : Form
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();

        public FormSell()
        {
            InitializeComponent();
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            try
            {
                int barcode = Convert.ToInt32(textBoxBarcode.Text);
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
                if (barcode <= 0)
                {
                    throw new RecordNotFoundException();
                }
                if (quantity <= 0)
                {
                    throw new InvalidStockException();
                }
                _util.SellProduct(barcode, quantity);
            }
            catch (RecordNotFoundException exc)
            {
                MessageBox.Show("Please insert a valid barcode!");
            }
            catch (InvalidStockException exc)
            {
                MessageBox.Show("Please insert a valid quantity!");

            }
            this.Close();
        }
    }
}
