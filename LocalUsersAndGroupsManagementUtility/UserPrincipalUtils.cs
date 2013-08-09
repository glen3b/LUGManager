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
    public partial class UserPrincipalUtils : Form
    {
        UserPrincipal Principal;

        bool isInit = true;

        public UserPrincipalUtils(UserPrincipal up)
        {
            InitializeComponent();
            Text += up.Name;
            Principal = up;
            accountLockCheckBox.Checked = up.IsAccountLockedOut();
            MaximumSize = Size;
            MinimumSize = Size;
        }

        private void passwordChangeButton_Click(object sender, EventArgs e)
        {
            new PasswordChangeForm(Principal).ShowDialog(this);
        }

        private void accountLockCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!isInit)
            {
                Form1.Instance.saveAccountsButton.Enabled = true;
                if (accountLockCheckBox.Checked)
                {
                    MessageBox.Show("Cannot lock out the account.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    accountLockCheckBox.Checked = false;
                }
                else
                {
                    Principal.UnlockAccount();
                }
            }
        }

        private void UserPrincipalUtils_Load(object sender, EventArgs e)
        {
            isInit = false;
        }

        private void expirePwd_Click(object sender, EventArgs e)
        {
            Principal.ExpirePasswordNow();
        }

        private void refreshPwd_Click(object sender, EventArgs e)
        {
            Principal.RefreshExpiredPassword();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Principal.Context.ValidateCredentials(Principal.SamAccountName, testPwdTxtBox.Text) ? "Correct password." : "Incorrect password.");
            testPwdTxtBox.Clear();
        }

        private void groupMembershipButton_Click(object sender, EventArgs e)
        {
            new GroupList(Principal).ShowDialog(this);
        }
    }
}
