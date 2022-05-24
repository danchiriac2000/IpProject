/**************************************************************************
 *                                                                        *
 *  File:        FormAddToStock.cs                                        *
 *  Copyright:   (c) 2022, Cuptor Iuliana-Stefania                        *
 *  E-mail:      iuliana-stefania.cuptor@student.tuiasi.ro                *
 *  Description: This file contains the implementation of Add To Stock    *
 *      Interface where we can add new stocks of a specific product       *
 *                                                                        *
 **************************************************************************/

using Exceptions.AccessRightsExceptions;
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
    public partial class FormAddToStock : Form
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();

        public FormAddToStock()
        {
            InitializeComponent();
        }

        private void buttonAddToStock_Click(object sender, EventArgs e)
        {
            try
            {
                int barcode = Convert.ToInt32(textBoxBarcode.Text);
                int quantity = Convert.ToInt32(numericUpDownQuantity.Value);
                

                _util.AddToStock(barcode, quantity);
                this.Close();
                MessageBox.Show("Stock was successfuly updated");
            }
            catch (PermissionDeniedException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Please insert valid number for barcode.");
            }
            catch (RecordNotFoundException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch(InvalidStockException exc)
            {
                MessageBox.Show(exc.Message);
            }           
            catch (OverflowException exc)
            {
                MessageBox.Show("Insert only numerical values in range (0-2147483647)");
            }
            

        }
    }
}
