using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace LocalUsersAndGroupsManagementUtility
{
    public partial class PasswordChangeForm : Form
    {
        UserPrincipal changing;
        public PasswordChangeForm(UserPrincipal up)
        {
            changing = up;
            InitializeComponent();
            accountNameTextBox.Text = changing.Name;
            MaximumSize = Size;
            MinimumSize = Size;
        }

        private void changePwdButton_Click(object sender, EventArgs e)
        {
            if (newPasswordTxt.TextLength == 0 && cfrmPwdTxt.TextLength == 0)
            {
                changing.PasswordNotRequired = true;
                changing.Save();
                MessageBox.Show("Successfully removed the password requirement for this account.", "Password change successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                return;
            }
            if (!newPasswordTxt.Text.Equals(cfrmPwdTxt.Text))
            {
                MessageBox.Show("The new password does not match the confirmed password.", "Could not change password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newPasswordTxt.Clear();
                cfrmPwdTxt.Clear();
                newPasswordTxt.Focus();
                return;
            }


            changing.PasswordNotRequired = false;
            try
            {
                changing.ChangePassword(oldPasswordTextBox.Text, newPasswordTxt.Text);
                changing.Save();
            }
            catch (PrincipalOperationException po)
            {
                MessageBox.Show(po.Message, "Could not change password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                oldPasswordTextBox.Clear();
                newPasswordTxt.Clear();
                cfrmPwdTxt.Clear();
                oldPasswordTextBox.Focus();
                return;
            }
            catch (PasswordException ex)
            {
                MessageBox.Show(ex.Message, "Could not change password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                oldPasswordTextBox.Clear();
                newPasswordTxt.Clear();
                cfrmPwdTxt.Clear();
                oldPasswordTextBox.Focus();
                return;
            }

            MessageBox.Show("Successfully changed the password of this account.", "Password change successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void PasswordChangeForm_Shown(object sender, EventArgs e)
        {
            oldPasswordTextBox.Focus();
        }
    }
}
