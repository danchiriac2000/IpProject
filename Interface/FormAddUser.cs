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
    public partial class FormAddUser : Form
    {
        private ProxyActionManager _util = ProxyActionManager.GetInstance();

        public FormAddUser()
        {
            InitializeComponent();
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                string newUsername = textBoxNewUserName.Text;
                string newPassword = textBoxNewUserPassword.Text;
                int newOccupation = Convert.ToInt32(textBoxNewUserOccupation.Text);

                if(newUsername=="" || newPassword == "")
                {
                    throw new FormatException();
                }

                //se considera ca se pot adauga doar farmacisti si asistenti
                if (newOccupation != Constants.AssistantPharmacist || newOccupation != Constants.Pharmacist)
                {
                    throw new FormatException();
                }
                _util.AddUser(newUsername, newPassword, newOccupation);
                this.Close();
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Please insert a valid data : \n " +
                    "Occupational code : 0(pharmacist) or 1(assistant); \n" +
                    "Username and password cannot be empty.");
            }
            catch (ConstraintViolatedException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch(PermissionDeniedException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
