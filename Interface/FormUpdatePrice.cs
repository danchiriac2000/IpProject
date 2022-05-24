/**************************************************************************
 *                                                                        *
 *  File:        FormUpdatePrice.cs                                       *
 *  Copyright:   (c) 2022, Cuptor Iuliana-Stefania                        *
 *  E-mail:      iuliana-stefania.cuptor@student.tuiasi.ro                *
 *  Description: This file contains the implementation of Update Price    *
 *        Interface where, based on its barcode, we can update the price  *
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class FormUpdatePrice : Form
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();

        public FormUpdatePrice()
        {
            InitializeComponent();
        }

        private void buttonUpdatePrice_Click(object sender, EventArgs e)
        {
            try
            {
                int barcode = Convert.ToInt32(textBoxBarcode.Text);
                double price = Convert.ToDouble(numericUpDownNewPrice.Value);

                _util.UpdateProductPrice(barcode, price);
                this.Close();
                MessageBox.Show("Price was successfuly updated!");
            }
            catch (PermissionDeniedException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Please insert valid number for barcode.");
            }
            catch (InvalidDataException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (RecordNotFoundException exc)
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
