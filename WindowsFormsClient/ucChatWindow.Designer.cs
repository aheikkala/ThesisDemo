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
            this.RichTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.txtMessage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSend = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCloseTabPage = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.RichTextBoxConsole.Location = new System.Drawing.Point(17, 73);
            this.RichTextBoxConsole.Margin = new System.Windows.Forms.Padding(6);
            this.RichTextBoxConsole.Name = "RichTextBoxConsole";
            this.RichTextBoxConsole.ReadOnly = true;
            this.RichTextBoxConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichTextBoxConsole.Size = new System.Drawing.Size(423, 264);
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
            this.txtMessage.Location = new System.Drawing.Point(17, 361);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(6);
            this.txtMessage.MaxLength = 32767;
            this.txtMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.SelectedText = "";
            this.txtMessage.SelectionLength = 0;
            this.txtMessage.SelectionStart = 0;
            this.txtMessage.Size = new System.Drawing.Size(363, 23);
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
            this.btnSend.Location = new System.Drawing.Point(384, 348);
            this.btnSend.Margin = new System.Windows.Forms.Padding(6);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Primary = true;
            this.btnSend.Size = new System.Drawing.Size(56, 36);
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
            this.btnCloseTabPage.Location = new System.Drawing.Point(410, 25);
            this.btnCloseTabPage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCloseTabPage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCloseTabPage.Name = "btnCloseTabPage";
            this.btnCloseTabPage.Primary = false;
            this.btnCloseTabPage.Size = new System.Drawing.Size(30, 36);
            this.btnCloseTabPage.TabIndex = 9;
            this.btnCloseTabPage.Text = "X";
            this.btnCloseTabPage.UseVisualStyleBackColor = true;
            this.btnCloseTabPage.Click += new System.EventHandler(this.btnCloseTabPage_Click);
            // 
            // ucChatWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCloseTabPage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.RichTextBoxConsole);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ucChatWindow";
            this.Size = new System.Drawing.Size(459, 396);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox RichTextBoxConsole;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMessage;
        private MaterialSkin.Controls.MaterialRaisedButton btnSend;
        private MaterialSkin.Controls.MaterialFlatButton btnCloseTabPage;
    }
}
