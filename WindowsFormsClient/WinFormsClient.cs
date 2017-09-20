using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using static ThesisDemo.DatabaseConnection;
using System.Linq;

namespace ThesisDemo
{
    public partial class WinFormsClient : MaterialForm
    {

        private Int32 UserID { get; set; }
        private String UserName { get; set; }
        //private String[] Users = new String[] { "User 1", "User 2", "User 3" };
        private IHubProxy HubProxy { get; set; }
        const string ServerURI = "http://localhost:8080/signalr";
        private HubConnection Connection { get; set; }
        private readonly MeContext _db = new MeContext();

        public WinFormsClient()
        {
            InitializeComponent();

            var lstUsers = (from u in _db.Users select new { u.ID, u.UserName }).ToList();
            comboBoxSelectUser.DataSource = lstUsers;
            comboBoxSelectUser.DisplayMember = "UserName";
            comboBoxSelectUser.ValueMember = "ID";
            //comboBoxSelectUser.SelectedIndex = 0;
        }

        //private void btnSend_Click(object sender, EventArgs e)
        //{
        //    var msg = new DatabaseConnection.Message
        //    {
        //        Data = txtMessage.Text,
        //        Timestamp = DateTime.Now,
        //        User = _db.Users.Find(UserID)
        //    };

        //    var group = _db.Groups.Find(tcGroups.SelectedTab.Tag);

        //    _db.Messages.Add(msg);
        //    group.Messages.Add(msg);
        //    _db.SaveChanges();

        //    HubProxy.Invoke("Send", txtMessage.Text);
        //    txtMessage.Text = String.Empty;
        //    txtMessage.Focus();
        //}

        public void SendMessage(string message)
        {
            var msg = new DatabaseConnection.Message
            {
                Data = message,
                Timestamp = DateTime.Now,
                User = _db.Users.Find(UserID)
            };

            var group = _db.Groups.Find(tcGroups.SelectedTab.Tag);

            _db.Messages.Add(msg);
            group.Messages.Add(msg);
            _db.SaveChanges();

            HubProxy.Invoke("Send", message);
        }

        //Creates and connects the hub connection and hub proxy. 
        //This method is called asynchronously from SignInButton_Click.
        private async void ConnectAsync()
        {
            Connection = new HubConnection(ServerURI, new Dictionary<string, string>
            {
                 { "UserName", UserName }
            });

            Connection.Closed += Connection_Closed;
            HubProxy = Connection.CreateHubProxy("ChatHub");

            //Handle incoming event from server: use Invoke to write to console from SignalR's thread
            HubProxy.On<string, string, string>("AddMessage", (name, message, group) =>
                this.Invoke((Action)(() =>
                    //RichTextBoxConsole.AppendText(String.Format("{0}: {1}" + Environment.NewLine, name, message))
                    WriteMessage(name, message, group)
                ))
            );
            try
            {
                await Connection.Start();
            }
            catch (HttpRequestException)
            {
                StatusText.Text = "Unable to connect to server: Start server before connecting clients.";
                //No connection: Don't enable Send button or show chat UI
                return;
            }
            //State oject stores data to be transmitted to the server 
            HubProxy["userName"] = UserName;

            //Activate UI
            this.Text += " - " + UserName;
            SignInPanel.Visible = false;
            ChatPanel.Visible = true;
            //btnSend.Enabled = true;
            //txtMessage.Focus();
            RichTextBoxConsole.AppendText("Connected to server at " + ServerURI + Environment.NewLine);

            var user = _db.Users.Include("Groups").SingleOrDefault(u => u.ID == UserID);

            lwAllGroups.Items.AddRange(GetStuff());


            //VAIHDA
            foreach (var item in user.Groups)
            {
                //TabPage tp = new TabPage(item.GroupName) { Name = item.GroupName , Tag = item.ID};
                //tcGroups.TabPages.Add(tp);
                //tp.Controls.Add(new ucChatWindow() {ParentForm = this});

                await HubProxy.Invoke("JoinGroup", item.GroupName);
            }
        }

        public ListViewItem[] GetStuff()
        {
            var results = from g in _db.Groups
                          select new ListViewItem
                          {
                              Text = g.GroupName,
                              Tag = g.ID.ToString()
                          };

            return results.ToArray();
        }

        // If the server is stopped, the connection will time out after 30 seconds (default), and the 
        // Closed event will fire.
        private void Connection_Closed()
        {
            //Deactivate chat UI; show login UI. 
            this.Invoke((Action)(() => ChatPanel.Visible = false));
            //this.Invoke((Action)(() => btnSend.Enabled = false));
            this.Invoke((Action)(() => StatusText.Text = "You have been disconnected."));
            this.Invoke((Action)(() => SignInPanel.Visible = true));
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            UserID = (Int32)comboBoxSelectUser.SelectedValue;
            UserName = comboBoxSelectUser.GetItemText(comboBoxSelectUser.SelectedItem);
            //Connect to server (use async method to avoid blocking UI thread)
            if (!String.IsNullOrEmpty(UserName))
            {
                StatusText.Visible = true;
                StatusText.Text = "Connecting to server...";
                ConnectAsync();
            }
        }

        private void WinFormsClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Connection != null)
            {
                Connection.Stop();
                Connection.Dispose();
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (txtAddGroup.Text != "")
            {
                var group = new DatabaseConnection.Group
                {
                    GroupName = txtAddGroup.Text,
                    CreationDate = DateTime.Now
                };

                var user = _db.Users.Find(UserID);

                _db.Groups.Add(group);
                //group.Users.Add(user);

                user.Groups.Add(group);
                _db.SaveChanges();

                HubProxy.Invoke("JoinGroup", txtAddGroup.Text);

                txtAddGroup.Text = String.Empty;
                txtAddGroup.Focus();
            }
        }

        private void tcGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tab = sender as TabControl;
            HubProxy["currentGroup"] = tab.SelectedTab.Text;

            //Button btn = tab.SelectedTab.Controls["ucChatWindow"].Controls["btnSend"] as Button;
            //this.AcceptButton = btn;

            

            if (tab.SelectedTab.Controls.Find("ucChatWindow", true).Length != 0) {
                this.AcceptButton = tab.SelectedTab.Controls["ucChatWindow"].Controls["btnSend"] as Button;
            }
        }

        private void WriteMessage(string name, string message, string group)
        {
            UserControl uc = tcGroups.TabPages[group].Controls["ucChatWindow"] as UserControl;

            if (uc != null) {
                RichTextBox rtb = uc.Controls["RichTextBoxConsole"] as RichTextBox;
                rtb.AppendText(string.Format("{0}: {1}" + Environment.NewLine, name, message));
            }

        }

        private void GetAllMessages(int groupID, string groupName)
        {
            TabPage tp = new TabPage(groupName) { Name = groupName, Tag = groupID };
            tcGroups.TabPages.Add(tp);
            tp.Controls.Add(new ucChatWindow() { ParentForm = this });

            //TÄSSÄ HAETAAN KESKUSTELUN VIESTIT

            tcGroups.SelectedTab = tp;

        }

        private void lwAllGroups_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView lw = sender as ListView;
            if (lw.SelectedItems.Count == 1)
            {
                ListViewItem item = lw.SelectedItems[0] as ListViewItem;
                GetAllMessages(int.Parse(item.Tag.ToString()), item.Text);
            }
        }

    }
}
