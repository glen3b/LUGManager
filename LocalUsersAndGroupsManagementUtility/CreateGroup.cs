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
    public partial class CreateGroup : Form
    {
        public CreateGroup(PrincipalContext local)
        {
            InitializeComponent();
            MinimumSize = Size;
            MaximumSize = Size;
            Machine = local;
        }

        PrincipalContext Machine;

        private void createGrpButton_Click(object sender, EventArgs e)
        {
            new GroupPrincipal(Machine, grpNameTextBox.Text).Save();
            Close();
        }
    }
}
