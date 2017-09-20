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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "testi",
            "sub1"}, -1);
            this.RichTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.ChatPanel = new System.Windows.Forms.Panel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tcGroups = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lwAllGroups = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAddGroup = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddGroup = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SignInPanel = new System.Windows.Forms.Panel();
            this.lblAddUser = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddUser = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtAddUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBoxSelectUser = new System.Windows.Forms.ComboBox();
            this.StatusText = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.ChatPanel.SuspendLayout();
            this.tcGroups.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SignInPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RichTextBoxConsole
            // 
            this.RichTextBoxConsole.BackColor = System.Drawing.Color.GhostWhite;
            this.RichTextBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxConsole.Location = new System.Drawing.Point(818, 45);
            this.RichTextBoxConsole.Name = "RichTextBoxConsole";
            this.RichTextBoxConsole.ReadOnly = true;
            this.RichTextBoxConsole.Size = new System.Drawing.Size(264, 130);
            this.RichTextBoxConsole.TabIndex = 3;
            this.RichTextBoxConsole.Text = "";
            // 
            // ChatPanel
            // 
            this.ChatPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChatPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ChatPanel.Controls.Add(this.materialTabSelector1);
            this.ChatPanel.Controls.Add(this.tcGroups);
            this.ChatPanel.Controls.Add(this.RichTextBoxConsole);
            this.ChatPanel.Location = new System.Drawing.Point(0, 64);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(1094, 565);
            this.ChatPanel.TabIndex = 4;
            this.ChatPanel.Visible = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tcGroups;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1094, 20);
            this.materialTabSelector1.TabIndex = 10;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tcGroups
            // 
            this.tcGroups.Controls.Add(this.tabPage1);
            this.tcGroups.Depth = 0;
            this.tcGroups.Location = new System.Drawing.Point(3, 29);
            this.tcGroups.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcGroups.Name = "tcGroups";
            this.tcGroups.SelectedIndex = 0;
            this.tcGroups.Size = new System.Drawing.Size(557, 353);
            this.tcGroups.TabIndex = 9;
            this.tcGroups.SelectedIndexChanged += new System.EventHandler(this.tcGroups_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage1.Controls.Add(this.lwAllGroups);
            this.tabPage1.Controls.Add(this.txtAddGroup);
            this.tabPage1.Controls.Add(this.btnAddGroup);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(549, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Groups";
            // 
            // lwAllGroups
            // 
            this.lwAllGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lwAllGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lwAllGroups.Depth = 0;
            this.lwAllGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lwAllGroups.FullRowSelect = true;
            this.lwAllGroups.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lwAllGroups.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lwAllGroups.Location = new System.Drawing.Point(10, 4);
            this.lwAllGroups.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lwAllGroups.MouseState = MaterialSkin.MouseState.OUT;
            this.lwAllGroups.Name = "lwAllGroups";
            this.lwAllGroups.OwnerDraw = true;
            this.lwAllGroups.Size = new System.Drawing.Size(524, 263);
            this.lwAllGroups.TabIndex = 9;
            this.lwAllGroups.UseCompatibleStateImageBehavior = false;
            this.lwAllGroups.View = System.Windows.Forms.View.Details;
            this.lwAllGroups.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lwAllGroups_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Active";
            this.columnHeader2.Width = 300;
            // 
            // txtAddGroup
            // 
            this.txtAddGroup.Depth = 0;
            this.txtAddGroup.Hint = "";
            this.txtAddGroup.Location = new System.Drawing.Point(3, 287);
            this.txtAddGroup.MaxLength = 32767;
            this.txtAddGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddGroup.Name = "txtAddGroup";
            this.txtAddGroup.PasswordChar = '\0';
            this.txtAddGroup.SelectedText = "";
            this.txtAddGroup.SelectionLength = 0;
            this.txtAddGroup.SelectionStart = 0;
            this.txtAddGroup.Size = new System.Drawing.Size(402, 23);
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
            this.btnAddGroup.Location = new System.Drawing.Point(418, 273);
            this.btnAddGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Primary = true;
            this.btnAddGroup.Size = new System.Drawing.Size(110, 36);
            this.btnAddGroup.TabIndex = 8;
            this.btnAddGroup.Text = "+ New Group";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
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
            this.SignInPanel.Location = new System.Drawing.Point(0, 69);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(1094, 602);
            this.SignInPanel.TabIndex = 4;
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.BackColor = System.Drawing.Color.Transparent;
            this.lblAddUser.Depth = 0;
            this.lblAddUser.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddUser.Location = new System.Drawing.Point(13, 125);
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
            this.btnAddUser.Location = new System.Drawing.Point(206, 178);
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
            this.txtAddUser.Location = new System.Drawing.Point(10, 147);
            this.txtAddUser.MaxLength = 32767;
            this.txtAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddUser.Name = "txtAddUser";
            this.txtAddUser.PasswordChar = '\0';
            this.txtAddUser.SelectedText = "";
            this.txtAddUser.SelectionLength = 0;
            this.txtAddUser.SelectionStart = 0;
            this.txtAddUser.Size = new System.Drawing.Size(254, 23);
            this.txtAddUser.TabIndex = 8;
            this.txtAddUser.TabStop = false;
            this.txtAddUser.UseSystemPasswordChar = false;
            // 
            // comboBoxSelectUser
            // 
            this.comboBoxSelectUser.FormattingEnabled = true;
            this.comboBoxSelectUser.Location = new System.Drawing.Point(9, 37);
            this.comboBoxSelectUser.Name = "comboBoxSelectUser";
            this.comboBoxSelectUser.Size = new System.Drawing.Size(182, 21);
            this.comboBoxSelectUser.TabIndex = 7;
            // 
            // StatusText
            // 
            this.StatusText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusText.Location = new System.Drawing.Point(9, 72);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(500, 14);
            this.StatusText.TabIndex = 6;
            this.StatusText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StatusText.Visible = false;
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(197, 37);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(79, 22);
            this.SignInButton.TabIndex = 5;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter user name:";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(9, 117);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(267, 111);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // WinFormsClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1094, 629);
            this.Controls.Add(this.ChatPanel);
            this.Controls.Add(this.SignInPanel);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(542, 582);
            this.Name = "WinFormsClient";
            this.Text = "Chat App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinFormsClient_FormClosing);
            this.ChatPanel.ResumeLayout(false);
            this.tcGroups.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.SignInPanel.ResumeLayout(false);
            this.SignInPanel.PerformLayout();
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
        private MaterialSkin.Controls.MaterialRaisedButton btnAddGroup;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddGroup;
        private MaterialSkin.Controls.MaterialTabControl tcGroups;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialListView lwAllGroups;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

