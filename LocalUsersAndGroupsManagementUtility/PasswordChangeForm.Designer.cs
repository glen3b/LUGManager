namespace LocalUsersAndGroupsManagementUtility
{
    partial class PasswordChangeForm
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
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.accountNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cfrmPwdTxt = new System.Windows.Forms.TextBox();
            this.newPasswordTxt = new System.Windows.Forms.TextBox();
            this.changePwdButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accountNameLabel
            // 
            this.accountNameLabel.AutoSize = true;
            this.accountNameLabel.Location = new System.Drawing.Point(12, 9);
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Size = new System.Drawing.Size(50, 13);
            this.accountNameLabel.TabIndex = 0;
            this.accountNameLabel.Text = "Account:";
            // 
            // accountNameTextBox
            // 
            this.accountNameTextBox.Location = new System.Drawing.Point(71, 6);
            this.accountNameTextBox.Name = "accountNameTextBox";
            this.accountNameTextBox.ReadOnly = true;
            this.accountNameTextBox.Size = new System.Drawing.Size(201, 20);
            this.accountNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Old password:";
            // 
            // oldPasswordTextBox
            // 
            this.oldPasswordTextBox.Location = new System.Drawing.Point(98, 30);
            this.oldPasswordTextBox.Name = "oldPasswordTextBox";
            this.oldPasswordTextBox.Size = new System.Drawing.Size(174, 20);
            this.oldPasswordTextBox.TabIndex = 1;
            this.oldPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "New password:";
            // 
            // cfrmPwdTxt
            // 
            this.cfrmPwdTxt.Location = new System.Drawing.Point(98, 82);
            this.cfrmPwdTxt.Name = "cfrmPwdTxt";
            this.cfrmPwdTxt.Size = new System.Drawing.Size(174, 20);
            this.cfrmPwdTxt.TabIndex = 3;
            this.cfrmPwdTxt.UseSystemPasswordChar = true;
            // 
            // newPasswordTxt
            // 
            this.newPasswordTxt.Location = new System.Drawing.Point(98, 56);
            this.newPasswordTxt.Name = "newPasswordTxt";
            this.newPasswordTxt.Size = new System.Drawing.Size(174, 20);
            this.newPasswordTxt.TabIndex = 2;
            this.newPasswordTxt.UseSystemPasswordChar = true;
            // 
            // changePwdButton
            // 
            this.changePwdButton.Location = new System.Drawing.Point(15, 111);
            this.changePwdButton.Name = "changePwdButton";
            this.changePwdButton.Size = new System.Drawing.Size(257, 138);
            this.changePwdButton.TabIndex = 4;
            this.changePwdButton.Text = "Change Password";
            this.changePwdButton.UseVisualStyleBackColor = true;
            this.changePwdButton.Click += new System.EventHandler(this.changePwdButton_Click);
            // 
            // PasswordChangeForm
            // 
            this.AcceptButton = this.changePwdButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.changePwdButton);
            this.Controls.Add(this.newPasswordTxt);
            this.Controls.Add(this.cfrmPwdTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldPasswordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accountNameTextBox);
            this.Controls.Add(this.accountNameLabel);
            this.Name = "PasswordChangeForm";
            this.Text = "Change Password";
            this.Shown += new System.EventHandler(this.PasswordChangeForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.TextBox accountNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cfrmPwdTxt;
        private System.Windows.Forms.TextBox newPasswordTxt;
        private System.Windows.Forms.Button changePwdButton;
    }
}