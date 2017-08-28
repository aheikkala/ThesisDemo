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
            this.txtMessage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSend = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RichTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Depth = 0;
            this.txtMessage.Hint = "";
            this.txtMessage.Location = new System.Drawing.Point(11, 267);
            this.txtMessage.MaxLength = 32767;
            this.txtMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.SelectedText = "";
            this.txtMessage.SelectionLength = 0;
            this.txtMessage.SelectionStart = 0;
            this.txtMessage.Size = new System.Drawing.Size(415, 23);
            this.txtMessage.TabIndex = 8;
            this.txtMessage.TabStop = false;
            this.txtMessage.UseSystemPasswordChar = false;
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSend.Depth = 0;
            this.btnSend.Icon = null;
            this.btnSend.Location = new System.Drawing.Point(430, 267);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Primary = true;
            this.btnSend.Size = new System.Drawing.Size(56, 36);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // RichTextBoxConsole
            // 
            this.RichTextBoxConsole.BackColor = System.Drawing.Color.GhostWhite;
            this.RichTextBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxConsole.Location = new System.Drawing.Point(9, 38);
            this.RichTextBoxConsole.Name = "RichTextBoxConsole";
            this.RichTextBoxConsole.ReadOnly = true;
            this.RichTextBoxConsole.Size = new System.Drawing.Size(481, 223);
            this.RichTextBoxConsole.TabIndex = 6;
            this.RichTextBoxConsole.Text = "";
            // 
            // ucChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.RichTextBoxConsole);
            this.Name = "ucChatWindow";
            this.Size = new System.Drawing.Size(499, 341);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtMessage;
        private MaterialSkin.Controls.MaterialRaisedButton btnSend;
        private System.Windows.Forms.RichTextBox RichTextBoxConsole;
    }
}
