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
        //public new WinFormsClient ParentForm { get; set; }
        private WebApi _webApi;
        private int _iUserID;
        private int _iGroupID;

        public ucChatWindow(int iUserID, int iGroupID)
        {
            InitializeComponent();
            _webApi = new WebApi();
            _iGroupID = iGroupID;
            _iUserID = iUserID;
            RichTextBoxConsole.BackColor = MaterialSkinManager.Instance.GetApplicationBackgroundColor();
            lvUsersInGroup.BackColor = MaterialSkinManager.Instance.GetApplicationBackgroundColor();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            //tämä paremmin...
            //ParentForm = this.ParentForm;
            //ParentForm.SendMessage(txtMessage.Text);

            if (txtMessage.Text != string.Empty)
            {
                await _webApi.AddMessage(_iUserID, _iGroupID, txtMessage.Text);
            }

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
            //var users = ParentForm.GetUsersToAdd(Parent.Name.ToString());

            var users = _webApi.GetAllUsers();

            //materialContextMenuStrip1.Show(this.btnAddUserToGroup.PointToScreen(btnAddUserToGroup.Bounds.Location));
            materialContextMenuStrip1.Items.Clear();
            foreach (var user in users.Where(x => !x.Groups.Exists(g=> g.ID == _iGroupID)).ToList())
            {
                materialContextMenuStrip1.Items.Add(new ToolStripMenuItem { Name = user.Name, Tag = user.ID, Text = user.Name});
            }
            materialContextMenuStrip1.Show(Control.MousePosition);
        }

        private async void materialContextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var iUserToAdd = (int)e.ClickedItem.Tag;
            await _webApi.AddUserToGroup(_iGroupID, iUserToAdd);
        }
    }
}
