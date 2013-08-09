namespace LocalUsersAndGroupsManagementUtility
{
    partial class GroupList
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
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.slectButton = new System.Windows.Forms.Button();
            this.removeGrpBtton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupsListBox
            // 
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.Location = new System.Drawing.Point(12, 12);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(187, 251);
            this.groupsListBox.TabIndex = 0;
            this.groupsListBox.SelectedIndexChanged += new System.EventHandler(this.groupsListBox_SelectedIndexChanged);
            // 
            // slectButton
            // 
            this.slectButton.Location = new System.Drawing.Point(12, 269);
            this.slectButton.Name = "slectButton";
            this.slectButton.Size = new System.Drawing.Size(90, 23);
            this.slectButton.TabIndex = 1;
            this.slectButton.Text = "Add";
            this.slectButton.UseVisualStyleBackColor = true;
            this.slectButton.Click += new System.EventHandler(this.slectButton_Click);
            // 
            // removeGrpBtton
            // 
            this.removeGrpBtton.Enabled = false;
            this.removeGrpBtton.Location = new System.Drawing.Point(108, 269);
            this.removeGrpBtton.Name = "removeGrpBtton";
            this.removeGrpBtton.Size = new System.Drawing.Size(91, 23);
            this.removeGrpBtton.TabIndex = 2;
            this.removeGrpBtton.Text = "Remove";
            this.removeGrpBtton.UseVisualStyleBackColor = true;
            this.removeGrpBtton.Click += new System.EventHandler(this.removeGrpBtton_Click);
            // 
            // GroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 301);
            this.Controls.Add(this.removeGrpBtton);
            this.Controls.Add(this.slectButton);
            this.Controls.Add(this.groupsListBox);
            this.Name = "GroupList";
            this.Text = "Group List";
            this.Load += new System.EventHandler(this.GroupList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button slectButton;
        private System.Windows.Forms.Button removeGrpBtton;
        internal System.Windows.Forms.ListBox groupsListBox;
    }
}