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
            this.comboBoxSelectUser = new System.Windows.Forms.ComboBox();
            this.StatusText = new System.Windows.Forms.Label();
            this.SignInButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.RichTextBoxConsole.Location = new System.Drawing.Point(0, 1003);
            this.RichTextBoxConsole.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.RichTextBoxConsole.Name = "RichTextBoxConsole";
            this.RichTextBoxConsole.ReadOnly = true;
            this.RichTextBoxConsole.Size = new System.Drawing.Size(1914, 35);
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
            this.ChatPanel.Controls.Add(this.materialTabSelector1);
            this.ChatPanel.Controls.Add(this.tcGroups);
            this.ChatPanel.Controls.Add(this.RichTextBoxConsole);
            this.ChatPanel.Location = new System.Drawing.Point(0, 63);
            this.ChatPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(1914, 1038);
            this.ChatPanel.TabIndex = 4;
            this.ChatPanel.Visible = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tcGroups;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1914, 35);
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
            this.tcGroups.Location = new System.Drawing.Point(5, 45);
            this.tcGroups.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tcGroups.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcGroups.Name = "tcGroups";
            this.tcGroups.SelectedIndex = 0;
            this.tcGroups.Size = new System.Drawing.Size(1904, 948);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1896, 911);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Groups";
            // 
            // lwAllGroups
            // 
            this.lwAllGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lwAllGroups.Location = new System.Drawing.Point(7, 7);
            this.lwAllGroups.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lwAllGroups.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lwAllGroups.MouseState = MaterialSkin.MouseState.OUT;
            this.lwAllGroups.MultiSelect = false;
            this.lwAllGroups.Name = "lwAllGroups";
            this.lwAllGroups.OwnerDraw = true;
            this.lwAllGroups.Size = new System.Drawing.Size(1884, 814);
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
            this.columnHeader2.Width = 1684;
            // 
            // txtAddGroup
            // 
            this.txtAddGroup.Depth = 0;
            this.txtAddGroup.Hint = "";
            this.txtAddGroup.Location = new System.Drawing.Point(0, 875);
            this.txtAddGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtAddGroup.MaxLength = 32767;
            this.txtAddGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAddGroup.Name = "txtAddGroup";
            this.txtAddGroup.PasswordChar = '\0';
            this.txtAddGroup.SelectedText = "";
            this.txtAddGroup.SelectionLength = 0;
            this.txtAddGroup.SelectionStart = 0;
            this.txtAddGroup.Size = new System.Drawing.Size(704, 36);
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
            this.btnAddGroup.Location = new System.Drawing.Point(702, 875);
            this.btnAddGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAddGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Primary = true;
            this.btnAddGroup.Size = new System.Drawing.Size(180, 36);
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
            this.SignInPanel.Location = new System.Drawing.Point(0, 63);
            this.SignInPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SignInPanel.Name = "SignInPanel";
            this.SignInPanel.Size = new System.Drawing.Size(1914, 1038);
            this.SignInPanel.TabIndex = 4;
            // 
            // comboBoxSelectUser
            // 
            this.comboBoxSelectUser.FormattingEnabled = true;
            this.comboBoxSelectUser.Location = new System.Drawing.Point(16, 65);
            this.comboBoxSelectUser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBoxSelectUser.Name = "comboBoxSelectUser";
            this.comboBoxSelectUser.Size = new System.Drawing.Size(316, 32);
            this.comboBoxSelectUser.TabIndex = 7;
            // 
            // StatusText
            // 
            this.StatusText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusText.Location = new System.Drawing.Point(16, 126);
            this.StatusText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(875, 24);
            this.StatusText.TabIndex = 6;
            this.StatusText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StatusText.Visible = false;
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(345, 65);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(138, 38);
            this.SignInButton.TabIndex = 5;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter user name:";
            // 
            // WinFormsClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1914, 1101);
            this.Controls.Add(this.ChatPanel);
            this.Controls.Add(this.SignInPanel);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(948, 1018);
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

