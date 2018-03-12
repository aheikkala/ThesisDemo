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
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "testi",
            "sub1"}, -1);
            this.RichTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.ChatPanel = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblUserStatus = new MaterialSkin.Controls.MaterialLabel();
            this.lblUserName = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tcGroups = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvAllGroups = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAddGroup = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddGroup = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SignInPanel = new System.Windows.Forms.Panel();
            this.comboBoxSelectUser = new System.Windows.Forms.ComboBox();
            this.StatusText = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
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
            this.RichTextBoxConsole.Location = new System.Drawing.Point(0, 807);
            this.RichTextBoxConsole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RichTextBoxConsole.Name = "RichTextBoxConsole";
            this.RichTextBoxConsole.ReadOnly = true;
            this.RichTextBoxConsole.Size = new System.Drawing.Size(1640, 31);
            this.RichTextBoxConsole.TabIndex = 3;
            this.RichTextBoxConsole.Text = "";
            // 
            // ChatPanel
            // 
            this.ChatPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChatPanel.BackColor = System.Drawing.Color.Transparent;
            this.ChatPanel.Controls.Add(this.materialProgressBar1);
            this.ChatPanel.Controls.Add(this.materialDivider1);
            this.ChatPanel.Controls.Add(this.lblUserStatus);
            this.ChatPanel.Controls.Add(this.lblUserName);
            this.ChatPanel.Controls.Add(this.materialTabSelector1);
            this.ChatPanel.Controls.Add(this.tcGroups);
            this.ChatPanel.Controls.Add(this.RichTextBoxConsole);
            this.ChatPanel.Location = new System.Drawing.Point(0, 96);
            this.ChatPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(1641, 843);
            this.ChatPanel.TabIndex = 4;
            this.ChatPanel.Visible = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(32, 110);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1575, 9);
            this.materialDivider1.TabIndex = 11;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.Depth = 0;
            this.lblUserStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUserStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserStatus.Location = new System.Drawing.Point(39, 63);
            this.lblUserStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(73, 27);
            this.lblUserStatus.TabIndex = 13;
            this.lblUserStatus.Text = "Online";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Depth = 0;
            this.lblUserName.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserName.Location = new System.Drawing.Point(39, 39);
            this.lblUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(137, 27);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "lblUserName";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tcGroups;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(32, 134);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1575, 30);
            this.materialTabSelector1.TabIndex = 10;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tcGroups
            // 
            this.tcGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcGroups.Controls.Add(this.tabPage1);
            this.tcGroups.Depth = 0;
            this.tcGroups.Location = new System.Drawing.Point(32, 164);
            this.tcGroups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcGroups.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcGroups.Name = "tcGroups";
            this.tcGroups.SelectedIndex = 0;
            this.tcGroups.Size = new System.Drawing.Size(1578, 640);
            this.tcGroups.TabIndex = 9;
            this.tcGroups.SelectedIndexChanged += new System.EventHandler(this.tcGroups_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage1.Controls.Add(this.lvAllGroups);
            this.tabPage1.Controls.Add(this.txtAddGroup);
            this.tabPage1.Controls.Add(this.btnAddGroup);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1570, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Groups";
            // 
            // lvAllGroups
            // 
            this.lvAllGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvAllGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvAllGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvAllGroups.Depth = 0;
            this.lvAllGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lvAllGroups.FullRowSelect = true;
            this.lvAllGroups.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAllGroups.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9});
            this.lvAllGroups.Location = new System.Drawing.Point(0, 0);
            this.lvAllGroups.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvAllGroups.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvAllGroups.MouseState = MaterialSkin.MouseState.OUT;
            this.lvAllGroups.MultiSelect = false;
            this.lvAllGroups.Name = "lvAllGroups";
            this.lvAllGroups.OwnerDraw = true;
            this.lvAllGroups.Size = new System.Drawing.Size(1571, 533);
            this.lvAllGroups.TabIndex = 9;
            this.lvAllGroups.UseCompatibleStateImageBehavior = false;
            this.lvAllGroups.View = System.Windows.Forms.View.Details;
            this.lvAllGroups.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvAllGroups_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Active";
            this.columnHeader2.Width = 1633;
            // 
            // txtAddGroup
            // 
            this.txtAddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAddGroup.Depth = 0;
            this.txtAddGroup.Hint = "";
            this.txtAddGroup.Location = new System.Drawing.Point(8, 567);
            this.txtAddGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddGroup.MaxLength = 32767;
            this.txtAddGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddGroup.Name = "txtAddGroup";
            this.txtAddGroup.PasswordChar = '\0';
            this.txtAddGroup.SelectedText = "";
            this.txtAddGroup.SelectionLength = 0;
            this.txtAddGroup.SelectionStart = 0;
            this.txtAddGroup.Size = new System.Drawing.Size(592, 32);
            this.txtAddGroup.TabIndex = 7;
            this.txtAddGroup.TabStop = false;
            this.txtAddGroup.UseSystemPasswordChar = false;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddGroup.AutoSize = true;
            this.btnAddGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddGroup.Depth = 0;
            this.btnAddGroup.Icon = null;
            this.btnAddGroup.Location = new System.Drawing.Point(602, 574);
            this.btnAddGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Primary = true;
            this.btnAddGroup.Size = new System.Drawing.Size(157, 36);
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
            this.SignInPanel.BackColor = System.Drawing.Color.Transparent;
            this.SignInPanel.Controls.Add(this.comboBoxSelectUser);
            this.SignInPanel.Controls.Add(this.StatusText);
            this.SignInPanel.Controls.Add(this.SignInButton);
            this.SignInPanel.Controls.Add(this.label1);
            this.SignInPanel.Location = new System.Drawing.Point(0, 96);
            this.SignInPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(1641, 843);
            this.SignInPanel.TabIndex = 4;
            // 
            // comboBoxSelectUser
            // 
            this.comboBoxSelectUser.FormattingEnabled = true;
            this.comboBoxSelectUser.Location = new System.Drawing.Point(14, 56);
            this.comboBoxSelectUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSelectUser.Name = "comboBoxSelectUser";
            this.comboBoxSelectUser.Size = new System.Drawing.Size(271, 28);
            this.comboBoxSelectUser.TabIndex = 7;
            // 
            // StatusText
            // 
            this.StatusText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusText.Location = new System.Drawing.Point(14, 108);
            this.StatusText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(750, 21);
            this.StatusText.TabIndex = 6;
            this.StatusText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StatusText.Visible = false;
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(296, 56);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(118, 33);
            this.SignInButton.TabIndex = 5;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter user name:";
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.BackColor = System.Drawing.Color.Red;
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialProgressBar1.Location = new System.Drawing.Point(638, 29);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(948, 5);
            this.materialProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.materialProgressBar1.TabIndex = 14;
            this.materialProgressBar1.Visible = false;
            // 
            // WinFormsClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1641, 936);
            this.Controls.Add(this.ChatPanel);
            this.Controls.Add(this.SignInPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(813, 873);
            this.Name = "WinFormsClient";
            this.Text = "Chat App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WinFormsClient_FormClosing);
            this.ChatPanel.ResumeLayout(false);
            this.ChatPanel.PerformLayout();
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
        private MaterialSkin.Controls.MaterialRaisedButton btnAddGroup;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAddGroup;
        private MaterialSkin.Controls.MaterialTabControl tcGroups;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialListView lvAllGroups;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lblUserName;
        private MaterialSkin.Controls.MaterialLabel lblUserStatus;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
    }
}

