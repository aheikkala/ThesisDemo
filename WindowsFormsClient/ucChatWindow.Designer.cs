namespace ThesisDemo
{
    partial class ucChatWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Online", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Offline", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Arttu");
            this.RichTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.txtMessage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSend = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCloseTabPage = new MaterialSkin.Controls.MaterialFlatButton();
            this.lvUsersInGroup = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddUserToGroup = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RichTextBoxConsole
            // 
            this.RichTextBoxConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBoxConsole.BackColor = System.Drawing.Color.GhostWhite;
            this.RichTextBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxConsole.Location = new System.Drawing.Point(218, 48);
            this.RichTextBoxConsole.Margin = new System.Windows.Forms.Padding(6);
            this.RichTextBoxConsole.Name = "RichTextBoxConsole";
            this.RichTextBoxConsole.ReadOnly = true;
            this.RichTextBoxConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichTextBoxConsole.Size = new System.Drawing.Size(414, 278);
            this.RichTextBoxConsole.TabIndex = 6;
            this.RichTextBoxConsole.Text = "";
            this.RichTextBoxConsole.Enter += new System.EventHandler(this.RichTextBoxConsole_Enter);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.BackColor = System.Drawing.SystemColors.Control;
            this.txtMessage.Depth = 0;
            this.txtMessage.Hint = "";
            this.txtMessage.Location = new System.Drawing.Point(218, 335);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(6);
            this.txtMessage.MaxLength = 32767;
            this.txtMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.SelectedText = "";
            this.txtMessage.SelectionLength = 0;
            this.txtMessage.SelectionStart = 0;
            this.txtMessage.Size = new System.Drawing.Size(327, 32);
            this.txtMessage.TabIndex = 8;
            this.txtMessage.TabStop = false;
            this.txtMessage.UseSystemPasswordChar = false;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.AutoSize = true;
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.BackColor = System.Drawing.Color.White;
            this.btnSend.Depth = 0;
            this.btnSend.Icon = null;
            this.btnSend.Location = new System.Drawing.Point(547, 335);
            this.btnSend.Margin = new System.Windows.Forms.Padding(6);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Primary = true;
            this.btnSend.Size = new System.Drawing.Size(75, 36);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCloseTabPage
            // 
            this.btnCloseTabPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseTabPage.AutoSize = true;
            this.btnCloseTabPage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCloseTabPage.Depth = 0;
            this.btnCloseTabPage.Icon = null;
            this.btnCloseTabPage.Location = new System.Drawing.Point(602, 6);
            this.btnCloseTabPage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCloseTabPage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCloseTabPage.Name = "btnCloseTabPage";
            this.btnCloseTabPage.Primary = false;
            this.btnCloseTabPage.Size = new System.Drawing.Size(36, 36);
            this.btnCloseTabPage.TabIndex = 9;
            this.btnCloseTabPage.Text = "X";
            this.btnCloseTabPage.UseVisualStyleBackColor = true;
            this.btnCloseTabPage.Click += new System.EventHandler(this.btnCloseTabPage_Click);
            // 
            // lvUsersInGroup
            // 
            this.lvUsersInGroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvUsersInGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvUsersInGroup.Depth = 0;
            this.lvUsersInGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lvUsersInGroup.FullRowSelect = true;
            listViewGroup1.Header = "Online";
            listViewGroup1.Name = "Online";
            listViewGroup2.Header = "Offline";
            listViewGroup2.Name = "Offline";
            this.lvUsersInGroup.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lvUsersInGroup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvUsersInGroup.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvUsersInGroup.Location = new System.Drawing.Point(4, 48);
            this.lvUsersInGroup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvUsersInGroup.MouseState = MaterialSkin.MouseState.OUT;
            this.lvUsersInGroup.MultiSelect = false;
            this.lvUsersInGroup.Name = "lvUsersInGroup";
            this.lvUsersInGroup.OwnerDraw = true;
            this.lvUsersInGroup.Size = new System.Drawing.Size(205, 278);
            this.lvUsersInGroup.TabIndex = 10;
            this.lvUsersInGroup.UseCompatibleStateImageBehavior = false;
            this.lvUsersInGroup.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 187;
            // 
            // btnAddUserToGroup
            // 
            this.btnAddUserToGroup.AutoSize = true;
            this.btnAddUserToGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddUserToGroup.Depth = 0;
            this.btnAddUserToGroup.Icon = null;
            this.btnAddUserToGroup.Location = new System.Drawing.Point(4, 290);
            this.btnAddUserToGroup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddUserToGroup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddUserToGroup.Name = "btnAddUserToGroup";
            this.btnAddUserToGroup.Primary = false;
            this.btnAddUserToGroup.Size = new System.Drawing.Size(80, 36);
            this.btnAddUserToGroup.TabIndex = 11;
            this.btnAddUserToGroup.Text = "+ Add";
            this.btnAddUserToGroup.UseVisualStyleBackColor = true;
            this.btnAddUserToGroup.Click += new System.EventHandler(this.btnAddUserToGroup_Click);
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(244, 64);
            this.materialContextMenuStrip1.Text = "Invite user:";
            this.materialContextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.materialContextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(243, 30);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            this.toolStripMenuItem1.ToolTipText = "Testi1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(243, 30);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            this.toolStripMenuItem2.ToolTipText = "Testi2";
            // 
            // ucChatWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddUserToGroup);
            this.Controls.Add(this.lvUsersInGroup);
            this.Controls.Add(this.btnCloseTabPage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.RichTextBoxConsole);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ucChatWindow";
            this.Size = new System.Drawing.Size(651, 385);
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox RichTextBoxConsole;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMessage;
        private MaterialSkin.Controls.MaterialRaisedButton btnSend;
        private MaterialSkin.Controls.MaterialFlatButton btnCloseTabPage;
        private MaterialSkin.Controls.MaterialListView lvUsersInGroup;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MaterialSkin.Controls.MaterialFlatButton btnAddUserToGroup;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}
