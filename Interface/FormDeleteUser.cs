/**************************************************************************
 *                                                                        *
 *  File:        FormDeleteUser.cs                                        *
 *  Copyright:   (c) 2022, Cuptor Iuliana-Stefania                        *
 *  E-mail:      iuliana-stefania.cuptor@student.tuiasi.ro                *
 *  Description: This file contains the implementation of Delete User     *
 *                 Interface where we can delete from database an user    *
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
    public partial class FormDeleteUser : Form
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();
        public FormDeleteUser()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string username= textBoxDeletedUsername.Text;
            if (username == "")
            {
                MessageBox.Show("Username field is mandatory!");
                return;
            }

            try
            {
                _util.DeleteUser(username);
                this.Close();
                MessageBox.Show("Successfuly deleted user '" + username + "'");
            }
            catch (PermissionDeniedException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (RecordNotFoundException exc)
            {
                MessageBox.Show(exc.Message);
            }






        }
    }
}
