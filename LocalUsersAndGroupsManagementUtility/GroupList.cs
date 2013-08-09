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
    public partial class GroupList : Form
    {
        UserPrincipal principal;
        bool showMemberOf = true;

        private void Init()
        {
            groupsListBox.Items.Clear();
            List<GroupPrincipal> allgrp = Form1.Instance.AllGroups;
            foreach (GroupPrincipal grp in allgrp)
            {
                if (showMemberOf && principal.IsMemberOf(grp))
                {
                    groupsListBox.Items.Add(grp);
                }
                else if (!showMemberOf && !principal.IsMemberOf(grp))
                {
                    groupsListBox.Items.Add(grp);
                }
            }
        }

        public GroupList(UserPrincipal up)
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
                slectButton.Enabled = groupsListBox.SelectedIndex != -1;
            }
            else
            {
                removeGrpBtton.Enabled = groupsListBox.SelectedIndex != -1;
            }
        }

        private void slectButton_Click(object sender, EventArgs e)
        {
            if (showMemberOf)
            {
                GroupList newGrp = new GroupList(principal) { showMemberOf = false };
                newGrp.ShowDialog(this);
                if (newGrp.groupsListBox.SelectedItem != null)
                {
                    (newGrp.groupsListBox.SelectedItem as GroupPrincipal).Members.Add(principal);
                    (newGrp.groupsListBox.SelectedItem as GroupPrincipal).Save();
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
            (groupsListBox.SelectedItem as GroupPrincipal).Members.Remove(principal);
            (groupsListBox.SelectedItem as GroupPrincipal).Save();
            Init();
            removeGrpBtton.Enabled = false;
        }
    }
}
