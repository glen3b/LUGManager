namespace LocalUsersAndGroupsManagementUtility
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lugViewTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.reloadUsersButton = new System.Windows.Forms.Button();
            this.principalPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.saveAccountsButton = new System.Windows.Forms.Button();
            this.typeSpecificOptionButton = new System.Windows.Forms.Button();
            this.createItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lugViewTypeComboBox
            // 
            this.lugViewTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lugViewTypeComboBox.FormattingEnabled = true;
            this.lugViewTypeComboBox.Items.AddRange(new object[] {
            "Group View",
            "User View"});
            this.lugViewTypeComboBox.Location = new System.Drawing.Point(51, 6);
            this.lugViewTypeComboBox.Name = "lugViewTypeComboBox";
            this.lugViewTypeComboBox.Size = new System.Drawing.Size(156, 21);
            this.lugViewTypeComboBox.TabIndex = 0;
            this.lugViewTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.lugViewTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "View:";
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(15, 48);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(219, 303);
            this.itemsListBox.TabIndex = 2;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.itemsListBox_SelectedIndexChanged);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Enabled = false;
            this.deleteItemButton.Location = new System.Drawing.Point(241, 48);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(229, 31);
            this.deleteItemButton.TabIndex = 3;
            this.deleteItemButton.Text = "Delete";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // reloadUsersButton
            // 
            this.reloadUsersButton.Location = new System.Drawing.Point(241, 9);
            this.reloadUsersButton.Name = "reloadUsersButton";
            this.reloadUsersButton.Size = new System.Drawing.Size(229, 33);
            this.reloadUsersButton.TabIndex = 4;
            this.reloadUsersButton.Text = "Reload";
            this.reloadUsersButton.UseVisualStyleBackColor = true;
            this.reloadUsersButton.Click += new System.EventHandler(this.reloadUsersButton_Click);
            // 
            // principalPropertyGrid
            // 
            this.principalPropertyGrid.Location = new System.Drawing.Point(241, 86);
            this.principalPropertyGrid.Name = "principalPropertyGrid";
            this.principalPropertyGrid.Size = new System.Drawing.Size(456, 330);
            this.principalPropertyGrid.TabIndex = 5;
            this.principalPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.principalPropertyGrid_PropertyValueChanged);
            // 
            // saveAccountsButton
            // 
            this.saveAccountsButton.Enabled = false;
            this.saveAccountsButton.Location = new System.Drawing.Point(476, 47);
            this.saveAccountsButton.Name = "saveAccountsButton";
            this.saveAccountsButton.Size = new System.Drawing.Size(221, 33);
            this.saveAccountsButton.TabIndex = 6;
            this.saveAccountsButton.Text = "Save All";
            this.saveAccountsButton.UseVisualStyleBackColor = true;
            this.saveAccountsButton.Click += new System.EventHandler(this.saveAccountsButton_Click);
            // 
            // typeSpecificOptionButton
            // 
            this.typeSpecificOptionButton.Enabled = false;
            this.typeSpecificOptionButton.Location = new System.Drawing.Point(15, 357);
            this.typeSpecificOptionButton.Name = "typeSpecificOptionButton";
            this.typeSpecificOptionButton.Size = new System.Drawing.Size(219, 59);
            this.typeSpecificOptionButton.TabIndex = 7;
            this.typeSpecificOptionButton.Text = "More Options";
            this.typeSpecificOptionButton.UseVisualStyleBackColor = true;
            this.typeSpecificOptionButton.Click += new System.EventHandler(this.typeSpecificOptionButton_Click);
            // 
            // createItemButton
            // 
            this.createItemButton.Location = new System.Drawing.Point(476, 10);
            this.createItemButton.Name = "createItemButton";
            this.createItemButton.Size = new System.Drawing.Size(221, 31);
            this.createItemButton.TabIndex = 8;
            this.createItemButton.Text = "Create";
            this.createItemButton.UseVisualStyleBackColor = true;
            this.createItemButton.Click += new System.EventHandler(this.createItemButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 431);
            this.Controls.Add(this.createItemButton);
            this.Controls.Add(this.typeSpecificOptionButton);
            this.Controls.Add(this.saveAccountsButton);
            this.Controls.Add(this.principalPropertyGrid);
            this.Controls.Add(this.reloadUsersButton);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lugViewTypeComboBox);
            this.Name = "Form1";
            this.Text = "Local Users and Groups Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lugViewTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button reloadUsersButton;
        private System.Windows.Forms.PropertyGrid principalPropertyGrid;
        private System.Windows.Forms.Button typeSpecificOptionButton;
        internal System.Windows.Forms.Button saveAccountsButton;
        private System.Windows.Forms.Button createItemButton;
    }
}

