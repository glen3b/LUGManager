namespace LocalUsersAndGroupsManagementUtility
{
    partial class UserPrincipalUtils
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
            this.accountLockCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordChangeButton = new System.Windows.Forms.Button();
            this.expirePwd = new System.Windows.Forms.Button();
            this.refreshPwd = new System.Windows.Forms.Button();
            this.testPwdLabel = new System.Windows.Forms.Label();
            this.testPwdTxtBox = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.groupMembershipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountLockCheckBox
            // 
            this.accountLockCheckBox.AutoSize = true;
            this.accountLockCheckBox.Location = new System.Drawing.Point(12, 12);
            this.accountLockCheckBox.Name = "accountLockCheckBox";
            this.accountLockCheckBox.Size = new System.Drawing.Size(125, 17);
            this.accountLockCheckBox.TabIndex = 0;
            this.accountLockCheckBox.Text = "Account Locked Out";
            this.accountLockCheckBox.UseVisualStyleBackColor = true;
            this.accountLockCheckBox.CheckedChanged += new System.EventHandler(this.accountLockCheckBox_CheckedChanged);
            // 
            // passwordChangeButton
            // 
            this.passwordChangeButton.Location = new System.Drawing.Point(12, 36);
            this.passwordChangeButton.Name = "passwordChangeButton";
            this.passwordChangeButton.Size = new System.Drawing.Size(125, 24);
            this.passwordChangeButton.TabIndex = 1;
            this.passwordChangeButton.Text = "Change Password";
            this.passwordChangeButton.UseVisualStyleBackColor = true;
            this.passwordChangeButton.Click += new System.EventHandler(this.passwordChangeButton_Click);
            // 
            // expirePwd
            // 
            this.expirePwd.Location = new System.Drawing.Point(12, 66);
            this.expirePwd.Name = "expirePwd";
            this.expirePwd.Size = new System.Drawing.Size(125, 23);
            this.expirePwd.TabIndex = 2;
            this.expirePwd.Text = "Expire Password";
            this.expirePwd.UseVisualStyleBackColor = true;
            this.expirePwd.Click += new System.EventHandler(this.expirePwd_Click);
            // 
            // refreshPwd
            // 
            this.refreshPwd.Location = new System.Drawing.Point(12, 95);
            this.refreshPwd.Name = "refreshPwd";
            this.refreshPwd.Size = new System.Drawing.Size(125, 23);
            this.refreshPwd.TabIndex = 3;
            this.refreshPwd.Text = "Refresh Password";
            this.refreshPwd.UseVisualStyleBackColor = true;
            this.refreshPwd.Click += new System.EventHandler(this.refreshPwd_Click);
            // 
            // testPwdLabel
            // 
            this.testPwdLabel.AutoSize = true;
            this.testPwdLabel.Location = new System.Drawing.Point(12, 162);
            this.testPwdLabel.Name = "testPwdLabel";
            this.testPwdLabel.Size = new System.Drawing.Size(80, 13);
            this.testPwdLabel.TabIndex = 4;
            this.testPwdLabel.Text = "Test Password:";
            // 
            // testPwdTxtBox
            // 
            this.testPwdTxtBox.Location = new System.Drawing.Point(12, 178);
            this.testPwdTxtBox.Name = "testPwdTxtBox";
            this.testPwdTxtBox.Size = new System.Drawing.Size(126, 20);
            this.testPwdTxtBox.TabIndex = 5;
            this.testPwdTxtBox.UseSystemPasswordChar = true;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(12, 204);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(126, 23);
            this.okBtn.TabIndex = 6;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // groupMembershipButton
            // 
            this.groupMembershipButton.Location = new System.Drawing.Point(12, 124);
            this.groupMembershipButton.Name = "groupMembershipButton";
            this.groupMembershipButton.Size = new System.Drawing.Size(125, 23);
            this.groupMembershipButton.TabIndex = 7;
            this.groupMembershipButton.Text = "Groups";
            this.groupMembershipButton.UseVisualStyleBackColor = true;
            this.groupMembershipButton.Click += new System.EventHandler(this.groupMembershipButton_Click);
            // 
            // UserPrincipalUtils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 261);
            this.Controls.Add(this.groupMembershipButton);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.testPwdTxtBox);
            this.Controls.Add(this.testPwdLabel);
            this.Controls.Add(this.refreshPwd);
            this.Controls.Add(this.expirePwd);
            this.Controls.Add(this.passwordChangeButton);
            this.Controls.Add(this.accountLockCheckBox);
            this.Name = "UserPrincipalUtils";
            this.Text = "User Utilities: ";
            this.Load += new System.EventHandler(this.UserPrincipalUtils_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox accountLockCheckBox;
        private System.Windows.Forms.Button passwordChangeButton;
        private System.Windows.Forms.Button expirePwd;
        private System.Windows.Forms.Button refreshPwd;
        private System.Windows.Forms.Label testPwdLabel;
        private System.Windows.Forms.TextBox testPwdTxtBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button groupMembershipButton;
    }
}