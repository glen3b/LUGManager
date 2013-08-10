namespace LocalUsersAndGroupsManagementUtility
{
    partial class CreateGroup
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
            this.grpNameTextBox = new System.Windows.Forms.TextBox();
            this.createGrpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // grpNameTextBox
            // 
            this.grpNameTextBox.Location = new System.Drawing.Point(56, 6);
            this.grpNameTextBox.Name = "grpNameTextBox";
            this.grpNameTextBox.Size = new System.Drawing.Size(223, 20);
            this.grpNameTextBox.TabIndex = 1;
            // 
            // createGrpButton
            // 
            this.createGrpButton.Location = new System.Drawing.Point(15, 45);
            this.createGrpButton.Name = "createGrpButton";
            this.createGrpButton.Size = new System.Drawing.Size(264, 85);
            this.createGrpButton.TabIndex = 2;
            this.createGrpButton.Text = "Create Group";
            this.createGrpButton.UseVisualStyleBackColor = true;
            this.createGrpButton.Click += new System.EventHandler(this.createGrpButton_Click);
            // 
            // CreateGroup
            // 
            this.AcceptButton = this.createGrpButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 142);
            this.Controls.Add(this.createGrpButton);
            this.Controls.Add(this.grpNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateGroup";
            this.Text = "Create Group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox grpNameTextBox;
        private System.Windows.Forms.Button createGrpButton;
    }
}