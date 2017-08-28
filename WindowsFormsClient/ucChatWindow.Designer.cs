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
            this.SuspendLayout();
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
            this.Controls.Add(this.RichTextBoxConsole);
            this.Name = "ucChatWindow";
            this.Size = new System.Drawing.Size(499, 341);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox RichTextBoxConsole;
    }
}
