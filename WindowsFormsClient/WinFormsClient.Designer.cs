namespace ThesisDemo
{
    partial class WinFormsClient 
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
            this.RichTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.ChatPanel = new System.Windows.Forms.Panel();
            this.txtMessage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSend = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SignInPanel = new System.Windows.Forms.Panel();
            this.lblAddUser = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddUser = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtAddUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBoxSelectUser = new System.Windows.Forms.ComboBox();
            this.StatusText = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtAddGroup = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddGroup = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tcGroups = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.ChatPanel.SuspendLayout();
            this.SignInPanel.SuspendLayout();
            this.tcGroups.SuspendLayout();
            this.SuspendLayout();
            // 
            // RichTextBoxConsole
            // 
            this.RichTextBoxConsole.BackColor = System.Drawing.Color.GhostWhite;
            this.RichTextBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxConsole.Location = new System.Drawing.Point(540, 281);
            this.RichTextBoxConsole.Name = "RichTextBoxConsole";
            this.RichTextBoxConsole.ReadOnly = true;
            this.RichTextBoxConsole.Size = new System.Drawing.Size(481, 223);
            this.RichTextBoxConsole.TabIndex = 3;
            this.RichTextBoxConsole.Text = "";
            // 
            // ChatPanel
            // 
            this.ChatPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ChatPanel.Controls.Add(this.materialTabSelector1);
            this.ChatPanel.Controls.Add(this.tcGroups);
            this.ChatPanel.Controls.Add(this.btnAddGroup);
            this.ChatPanel.Controls.Add(this.txtAddGroup);
            this.ChatPanel.Controls.Add(this.txtMessage);
            this.ChatPanel.Controls.Add(this.btnSend);
            this.ChatPanel.Controls.Add(this.RichTextBoxConsole);
            this.ChatPanel.Location = new System.Drawing.Point(0, 65);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(1044, 571);
            this.ChatPanel.TabIndex = 4;
            this.ChatPanel.Visible = false;
            // 
            // txtMessage
            // 
            this.txtMessage.Depth = 0;
            this.txtMessage.Hint = "";
            this.txtMessage.Location = new System.Drawing.Point(542, 510);
            this.txtMessage.MaxLength = 32767;
            this.txtMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.SelectedText = "";
            this.txtMessage.SelectionLength = 0;
            this.txtMessage.SelectionStart = 0;
            this.txtMessage.Size = new System.Drawing.Size(415, 23);
            this.txtMessage.TabIndex = 5;
            this.txtMessage.TabStop = false;
            this.txtMessage.UseSystemPasswordChar = false;
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.Depth = 0;
            this.btnSend.Icon = null;
            this.btnSend.Location = new System.Drawing.Point(961, 510);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Primary = true;
            this.btnSend.Size = new System.Drawing.Size(56, 36);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // SignInPanel
            // 
            this.SignInPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignInPanel.BackColor = System.Drawing.SystemColors.Control;
            this.SignInPanel.Controls.Add(this.lblAddUser);
            this.SignInPanel.Controls.Add(this.btnAddUser);
            this.SignInPanel.Controls.Add(this.txtAddUser);
            this.SignInPanel.Controls.Add(this.comboBoxSelectUser);
            this.SignInPanel.Controls.Add(this.StatusText);
            this.SignInPanel.Controls.Add(this.SignInButton);
            this.SignInPanel.Controls.Add(this.label1);
            this.SignInPanel.Controls.Add(this.materialDivider1);
            this.SignInPanel.Location = new System.Drawing.Point(0, 65);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(1044, 571);
            this.SignInPanel.TabIndex = 4;
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.BackColor = System.Drawing.Color.Transparent;
            this.lblAddUser.Depth = 0;
            this.lblAddUser.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddUser.Location = new System.Drawing.Point(12, 118);
            this.lblAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(103, 19);
            this.lblAddUser.TabIndex = 11;
            this.lblAddUser.Text = "Add new user:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoSize = true;
            this.btnAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUser.Depth = 0;
            this.btnAddUser.Icon = null;
            this.btnAddUser.Location = new System.Drawing.Point(197, 169);
            this.btnAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Primary = true;
            this.btnAddUser.Size = new System.Drawing.Size(55, 36);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Save";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // txtAddUser
            // 
            this.txtAddUser.Depth = 0;
            this.txtAddUser.Hint = "";
            this.txtAddUser.Location = new System.Drawing.Point(10, 140);
            this.txtAddUser.MaxLength = 32767;
            this.txtAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddUser.Name = "txtAddUser";
            this.txtAddUser.PasswordChar = '\0';
            this.txtAddUser.SelectedText = "";
            this.txtAddUser.SelectionLength = 0;
            this.txtAddUser.SelectionStart = 0;
            this.txtAddUser.Size = new System.Drawing.Size(242, 23);
            this.txtAddUser.TabIndex = 8;
            this.txtAddUser.TabStop = false;
            this.txtAddUser.UseSystemPasswordChar = false;
            // 
            // comboBoxSelectUser
            // 
            this.comboBoxSelectUser.FormattingEnabled = true;
            this.comboBoxSelectUser.Location = new System.Drawing.Point(8, 35);
            this.comboBoxSelectUser.Name = "comboBoxSelectUser";
            this.comboBoxSelectUser.Size = new System.Drawing.Size(174, 21);
            this.comboBoxSelectUser.TabIndex = 7;
            // 
            // StatusText
            // 
            this.StatusText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusText.Location = new System.Drawing.Point(8, 68);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(477, 13);
            this.StatusText.TabIndex = 6;
            this.StatusText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StatusText.Visible = false;
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(188, 35);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(75, 21);
            this.SignInButton.TabIndex = 5;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter user name:";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(8, 111);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(255, 105);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txtAddGroup
            // 
            this.txtAddGroup.Depth = 0;
            this.txtAddGroup.Hint = "";
            this.txtAddGroup.Location = new System.Drawing.Point(563, 26);
            this.txtAddGroup.MaxLength = 32767;
            this.txtAddGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddGroup.Name = "txtAddGroup";
            this.txtAddGroup.PasswordChar = '\0';
            this.txtAddGroup.SelectedText = "";
            this.txtAddGroup.SelectionLength = 0;
            this.txtAddGroup.SelectionStart = 0;
            this.txtAddGroup.Size = new System.Drawing.Size(217, 23);
            this.txtAddGroup.TabIndex = 7;
            this.txtAddGroup.TabStop = false;
            this.txtAddGroup.UseSystemPasswordChar = false;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.AutoSize = true;
            this.btnAddGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddGroup.Depth = 0;
            this.btnAddGroup.Icon = null;
            this.btnAddGroup.Location = new System.Drawing.Point(670, 55);
            this.btnAddGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Primary = true;
            this.btnAddGroup.Size = new System.Drawing.Size(110, 36);
            this.btnAddGroup.TabIndex = 8;
            this.btnAddGroup.Text = "+ New Group";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // tcGroups
            // 
            this.tcGroups.Controls.Add(this.tabPage1);
            this.tcGroups.Depth = 0;
            this.tcGroups.Location = new System.Drawing.Point(3, 55);
            this.tcGroups.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcGroups.Name = "tcGroups";
            this.tcGroups.SelectedIndex = 0;
            this.tcGroups.Size = new System.Drawing.Size(531, 335);
            this.tcGroups.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(523, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "No Messages";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tcGroups;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(10, 25);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(520, 23);
            this.materialTabSelector1.TabIndex = 10;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // WinFormsClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1044, 635);
            this.Controls.Add(this.ChatPanel);
            this.Controls.Add(this.SignInPanel);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(517, 552);
            this.Name = "WinFormsClient";
            this.Text = "Chat App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinFormsClient_FormClosing);
            this.ChatPanel.ResumeLayout(false);
            this.ChatPanel.PerformLayout();
            this.SignInPanel.ResumeLayout(false);
            this.SignInPanel.PerformLayout();
            this.tcGroups.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox RichTextBoxConsole;
        private System.Windows.Forms.Panel ChatPanel;
        private System.Windows.Forms.Panel SignInPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.ComboBox comboBoxSelectUser;
        private MaterialSkin.Controls.MaterialLabel lblAddUser;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddUser;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMessage;
        private MaterialSkin.Controls.MaterialRaisedButton btnSend;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddGroup;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddGroup;
        private MaterialSkin.Controls.MaterialTabControl tcGroups;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
    }
}

