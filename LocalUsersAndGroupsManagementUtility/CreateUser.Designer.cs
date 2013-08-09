namespace LocalUsersAndGroupsManagementUtility
{
    partial class CreateUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.confirmPwdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enabledCheckBox = new System.Windows.Forms.CheckBox();
            this.userChangePwdCheckBox = new System.Windows.Forms.CheckBox();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(77, 10);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(195, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Location = new System.Drawing.Point(77, 40);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.Size = new System.Drawing.Size(195, 20);
            this.pwdTextBox.TabIndex = 3;
            this.pwdTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPwdTextBox
            // 
            this.confirmPwdTextBox.Location = new System.Drawing.Point(77, 66);
            this.confirmPwdTextBox.Name = "confirmPwdTextBox";
            this.confirmPwdTextBox.Size = new System.Drawing.Size(195, 20);
            this.confirmPwdTextBox.TabIndex = 4;
            this.confirmPwdTextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm:";
            // 
            // enabledCheckBox
            // 
            this.enabledCheckBox.AutoSize = true;
            this.enabledCheckBox.Checked = true;
            this.enabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enabledCheckBox.Location = new System.Drawing.Point(18, 98);
            this.enabledCheckBox.Name = "enabledCheckBox";
            this.enabledCheckBox.Size = new System.Drawing.Size(65, 17);
            this.enabledCheckBox.TabIndex = 6;
            this.enabledCheckBox.Text = "Enabled";
            this.enabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // userChangePwdCheckBox
            // 
            this.userChangePwdCheckBox.AutoSize = true;
            this.userChangePwdCheckBox.Location = new System.Drawing.Point(18, 121);
            this.userChangePwdCheckBox.Name = "userChangePwdCheckBox";
            this.userChangePwdCheckBox.Size = new System.Drawing.Size(163, 17);
            this.userChangePwdCheckBox.TabIndex = 7;
            this.userChangePwdCheckBox.Text = "User Must Change Password";
            this.userChangePwdCheckBox.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(16, 145);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(256, 104);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // CreateUser
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.userChangePwdCheckBox);
            this.Controls.Add(this.enabledCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmPwdTextBox);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateUser";
            this.Text = "Create User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.TextBox confirmPwdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox enabledCheckBox;
        private System.Windows.Forms.CheckBox userChangePwdCheckBox;
        private System.Windows.Forms.Button createButton;
    }
}