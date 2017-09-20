using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThesisDemo
{
    public partial class ucChatWindow : UserControl
    {
        public new WinFormsClient ParentForm { get; set; }

        public ucChatWindow()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            ParentForm = this.ParentForm;
            ParentForm.SendMessage(txtMessage.Text);

            txtMessage.Text = String.Empty;
            txtMessage.Focus();
        }
    }
}
