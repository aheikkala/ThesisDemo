using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace ThesisDemo
{
    public partial class ucChatWindow : UserControl
    {
        public new WinFormsClient ParentForm { get; set; }

        public ucChatWindow()
        {

            InitializeComponent();
            //SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.BackColor = Color.Transparent
            //Dock = DockStyle.Fill;
            RichTextBoxConsole.BackColor = MaterialSkinManager.Instance.GetApplicationBackgroundColor();
            lvUsersInGroup.BackColor = MaterialSkinManager.Instance.GetApplicationBackgroundColor();

            

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //tämä paremmin...
            ParentForm = this.ParentForm;
            ParentForm.SendMessage(txtMessage.Text);

            txtMessage.Text = String.Empty;
            txtMessage.Focus();
        }

        private void RichTextBoxConsole_Enter(object sender, EventArgs e)
        {
            txtMessage.Focus();
        }

        private void btnCloseTabPage_Click(object sender, EventArgs e)
        {
            Parent.Dispose();
        }

        private void btnAddUserToGroup_Click(object sender, EventArgs e)
        {
            //ParentForm = this.ParentForm;
            var users = ParentForm.GetUsersToAdd(Parent.Name.ToString());

            //materialContextMenuStrip1.Show(this.btnAddUserToGroup.PointToScreen(btnAddUserToGroup.Bounds.Location));
            materialContextMenuStrip1.Items.Clear();
            foreach (var user in users)
            {
                materialContextMenuStrip1.Items.Add(new ToolStripMenuItem { Name = user.UserName, Tag = user.ID, Text = user.UserName});
            }
            materialContextMenuStrip1.Show(Control.MousePosition);
        }

        private void materialContextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
    }
}
