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
    public partial class CreateUser : Form
    {
        PrincipalContext Context;
        public CreateUser(PrincipalContext pc)
        {
            Context = pc;
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (confirmPwdTextBox.Text != pwdTextBox.Text)
            {
                MessageBox.Show("The password does not match the password confirmation.", "Error creating user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                UserPrincipal newUp = new UserPrincipal(Context, usernameTextBox.Text, this.pwdTextBox.Text, enabledCheckBox.Checked);
                if (userChangePwdCheckBox.Checked)
                {
                    newUp.ExpirePasswordNow();
                }
                newUp.Save();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error creating user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
