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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MaximumSize = Size;
            MinimumSize = Size;
        }

        PrincipalContext localMachine;
        internal List<UserPrincipal> AllUsers = new List<UserPrincipal>();
        internal List<GroupPrincipal> AllGroups = new List<GroupPrincipal>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Instance = this;
            localMachine = new PrincipalContext(ContextType.Machine);
            LoadUsers();

            lugViewTypeComboBox.SelectedIndex = 0;
        }

        void LoadUsers()
        {
            PrincipalSearcher findAllGroups = new PrincipalSearcher(new GroupPrincipal(localMachine, "*"));
            PrincipalSearcher findAllUsers = new PrincipalSearcher(new UserPrincipal(localMachine));

            itemsListBox.Items.Clear();

            AllUsers.Clear();
            AllGroups.Clear();

            foreach (UserPrincipal up in findAllUsers.FindAll())
            {
                if (up != null)
                {
                    AllUsers.Add(up);
                }
            }

            foreach (GroupPrincipal up in findAllGroups.FindAll())
            {
                if (up != null)
                {
                    AllGroups.Add(up);
                }
            }
            Reset();
        }

        private void lugViewTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lugViewTypeComboBox.SelectedIndex == 0)
            {
                typeSpecificOptionButton.Text = "Members";
            }
            else
            {
                typeSpecificOptionButton.Text = "More Options";

            }
            Reset(true, true);
        }

        Principal currentObj;

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to delete this item?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {



                currentObj.Delete();
                itemsListBox.Items.RemoveAt(lugViewTypeComboBox.SelectedIndex);


                if (lugViewTypeComboBox.SelectedIndex == 0)
                {
                    AllGroups.RemoveAt(itemsListBox.SelectedIndex);
                }
                else
                {
                    AllUsers.RemoveAt(itemsListBox.SelectedIndex);
                }

                currentObj = null;
                itemsListBox.SelectedIndex = -1;
                Reset(true, true);
            }
        }

        void Reset(bool reloadUsers = false, bool isMajor = false)
        {
            if (isMajor)
            {
                itemsListBox.Items.Clear();
                itemsListBox.SelectedIndex = -1;
            }

            deleteItemButton.Enabled = itemsListBox.SelectedIndex != -1;
            typeSpecificOptionButton.Enabled = deleteItemButton.Enabled;
            currentObj = deleteItemButton.Enabled ? (lugViewTypeComboBox.SelectedIndex == 0 ? AllGroups[itemsListBox.SelectedIndex] as Principal : AllUsers[itemsListBox.SelectedIndex] as Principal) : null;
            principalPropertyGrid.SelectedObject = currentObj == null ? null : (currentObj is UserPrincipal ? new UserPrincipalWrapper(currentObj as UserPrincipal) as PrincipalWrapper : new GroupPrincipalWrapper(currentObj as GroupPrincipal) as PrincipalWrapper);
            if (reloadUsers)
            {
                LoadUsers();
            }

            if (isMajor)
            {

                principalPropertyGrid.SelectedObject = null;
                if (lugViewTypeComboBox.SelectedIndex == 0)
                {
                    //Groups
                    foreach (GroupPrincipal up in AllGroups)
                    {
                        itemsListBox.Items.Add(up.Name);
                    }
                }
                else
                {
                    //Users
                    foreach (UserPrincipal up in AllUsers)
                    {
                        itemsListBox.Items.Add(up.Name);
                    }
                }
                itemsListBox.SelectedIndex = -1;
            }
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void reloadUsersButton_Click(object sender, EventArgs e)
        {
            Hide();
            lugViewTypeComboBox.SelectedIndex = 1;
            LoadUsers();
            lugViewTypeComboBox.SelectedIndex = 0;
            Show();
        }

        public static Form1 Instance;

        private void principalPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            saveAccountsButton.Enabled = true;
        }

        private void saveAccountsButton_Click(object sender, EventArgs e)
        {
            saveAccountsButton.Enabled = false;
            foreach (Principal p in AllUsers.Concat<Principal>(AllGroups))
            {
                p.Save();
            }
        }

        private void typeSpecificOptionButton_Click(object sender, EventArgs e)
        {
            if (lugViewTypeComboBox.SelectedIndex == 1)
            {
                new UserPrincipalUtils(currentObj as UserPrincipal).ShowDialog(this);
            }
            else
            {
                new UserList(currentObj as GroupPrincipal).ShowDialog(this);
            }
        }

        private void createItemButton_Click(object sender, EventArgs e)
        {
            if (lugViewTypeComboBox.SelectedIndex == 1)
            {
                new CreateUser(localMachine).ShowDialog(this);

            }

            Reset(true, true);
        }
    }
}
