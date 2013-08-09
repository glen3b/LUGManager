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
    public partial class UserList : Form
    {
        GroupPrincipal principal;
        bool showMemberOf = true;

        private void Init()
        {
            membersListBox.Items.Clear();
            List<Principal> showObjs = null;
            if (showMemberOf)
            {
                showObjs = principal.Members.ToList();
                Text += principal.Name;
            }
            else
            {
                showObjs = Form1.Instance.AllUsers.Cast<Principal>().ToList();
                showObjs.RemoveAll(p => p.IsMemberOf(principal));
                Text = "Add user to group";
            }
            membersListBox.Items.AddRange(showObjs.ToArray());
        }

        public UserList(GroupPrincipal up)
        {
            InitializeComponent();
            principal = up;
            MaximumSize = Size;
            MinimumSize = Size;
        }

        private void GroupList_Load(object sender, EventArgs e)
        {
            Init();
            if (!showMemberOf)
            {
                slectButton.Width += (removeGrpBtton.Location.X - (slectButton.Location.X + slectButton.Width) + removeGrpBtton.Width);
                removeGrpBtton.Enabled = false;
                removeGrpBtton.Visible = false;
                slectButton.Text = "Select";
                slectButton.Enabled = false;
            }
        }

        void groupsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!showMemberOf)
            {
                slectButton.Enabled = membersListBox.SelectedIndex != -1;
            }
            else
            {
                removeGrpBtton.Enabled = membersListBox.SelectedIndex != -1;
            }
        }

        private void slectButton_Click(object sender, EventArgs e)
        {
            if (showMemberOf)
            {
                UserList newGrp = new UserList(principal) { showMemberOf = false };
                newGrp.ShowDialog(this);
                if (newGrp.membersListBox.SelectedItem != null)
                {
                    principal.Members.Add(newGrp.membersListBox.SelectedItem as UserPrincipal);
                    principal.Save();
                    Init();
                }
            }
            else
            {
                Close();
            }
        }

        private void removeGrpBtton_Click(object sender, EventArgs e)
        {
            principal.Members.Remove(membersListBox.SelectedItem as UserPrincipal);
            principal.Save();
            Init();
            removeGrpBtton.Enabled = false;
        }
    }
}
