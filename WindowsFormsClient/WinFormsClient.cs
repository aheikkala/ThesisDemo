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

            //theme:
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green600, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE);
            //Primary.BlueGrey900 vakio

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
            Connection.Reconnecting += Connection_Reconnecting;
            Connection.Reconnected += Connection_Reconnected;

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
            lblUserName.Text = UserName;
            lblUserName.Font = new System.Drawing.Font("Arial", 20);

            SignInPanel.Visible = false;
            ChatPanel.Visible = true;
            //btnSend.Enabled = true;
            //txtMessage.Focus();
            RichTextBoxConsole.AppendText("Connected to server at " + ServerURI + Environment.NewLine);

            //var user = _db.Users.Include("Groups").SingleOrDefault(u => u.ID == UserID);

            UpdateGroups();

            lblUserStatus.ForeColor = System.Drawing.Color.Green;
            //VAIHDA
            //foreach (var item in user.Groups)
            //{
            //    //TabPage tp = new TabPage(item.GroupName) { Name = item.GroupName , Tag = item.ID};
            //    //tcGroups.TabPages.Add(tp);
            //    //tp.Controls.Add(new ucChatWindow() {ParentForm = this});

            //    await HubProxy.Invoke("JoinGroup", item.GroupName);
            //}
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

        private async void UpdateGroups()
        {
            lvAllGroups.Items.Clear();
            ///lwAllGroups.Items.AddRange(GetStuff());

            var user = _db.Users.Include("Groups").SingleOrDefault(u => u.ID == UserID);

            foreach (var item in user.Groups)
            {
                lvAllGroups.Items.Add(new ListViewItem { Text = item.GroupName, Tag = item.ID.ToString() });
                await HubProxy.Invoke("JoinGroup", item.GroupName); //JoinGroup returns void so no need to await?
            }
        }

        //TÄMÄ PITÄÄ VAIHTAA ID:LLE! MUUALTAKIN...
        private void UpdateUsersInGroup(string groupName)
        {
            UserControl uc = tcGroups.TabPages[groupName].Controls["ucChatWindow"] as UserControl;
            ListView lv = uc.Controls["lvUsersInGroup"] as ListView;
            //MaterialContextMenuStrip cms = uc.ContextMenuStrip as MaterialContextMenuStrip;

            lv.Items.Clear();
            //VARMAAN PITÄÄ MUUTTAA DB MALLIA
            //var users = _db.Users.Include("Groups").Where(u => u.Groups.Find(g => g.GroupName == groupName));
            //var group = _db.Groups.i.Where(g => g.GroupName == groupName);

            var group = _db.Groups.Include("Users").SingleOrDefault(x => x.GroupName == groupName);


            foreach (var item in group.Users)
            {
                lv.Items.Add(new ListViewItem { Text = item.UserName, Tag = item.ID.ToString() });
            }
        }

        // If the server is stopped, the connection will time out after 30 seconds (default), and the 
        // Closed event will fire.
        private void Connection_Closed()
        {
            //Deactivate chat UI; show login UI. 
            Invoke((Action)(() => ChatPanel.Visible = false));
            //this.Invoke((Action)(() => btnSend.Enabled = false));
            Invoke((Action)(() => StatusText.Text = "You have been disconnected."));
            Invoke((Action)(() => SignInPanel.Visible = true));
        }

        private void Connection_Reconnecting()
        {
            Invoke((Action)(() => RichTextBoxConsole.AppendText("Reconnecting...")));
            Invoke((Action)(() => lblUserStatus.ForeColor = System.Drawing.Color.Yellow));
            Invoke((Action)(() => lblUserStatus.Text = "Reconnecting..."));
        }

        private void Connection_Reconnected()
        {
            Invoke((Action)(() => RichTextBoxConsole.AppendText("Reconnected")));
            Invoke((Action)(() => lblUserStatus.ForeColor = System.Drawing.Color.Green));
            Invoke((Action)(() => lblUserStatus.Text = "Online"));
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            UserID = (int)comboBoxSelectUser.SelectedValue;
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

                UpdateGroups();
            }
        }

        private void tcGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tab = sender as TabControl;
            HubProxy["currentGroup"] = tab.SelectedTab.Text;

            //Button btn = tab.SelectedTab.Controls["ucChatWindow"].Controls["btnSend"] as Button;
            //this.AcceptButton = btn;

            
            //set accept button to selected tab
            if (tab.SelectedTab.Controls.Find("ucChatWindow", true).Length != 0) {
                this.AcceptButton = tab.SelectedTab.Controls["ucChatWindow"].Controls["btnSend"] as Button;
            }
        }

        private void WriteMessage(string name, string message, string group)
        {
            UserControl uc = tcGroups.TabPages[group].Controls["ucChatWindow"] as UserControl;

            if (uc != null) {
                RichTextBox rtb = uc.Controls["RichTextBoxConsole"] as RichTextBox;
                rtb.SelectionColor = SkinManager.GetPrimaryTextColor();
                if (name == UserName)
                {
                    rtb.SelectionAlignment = HorizontalAlignment.Right;
                    rtb.SelectionColor = SkinManager.GetPrimaryTextColor();
                    rtb.SelectionRightIndent = 20;
                    rtb.AppendText(string.Format("{0}" + Environment.NewLine, message));
                    rtb.ScrollToCaret();
                }
                else
                {
                    rtb.SelectionAlignment = HorizontalAlignment.Left;
                    rtb.SelectionColor = System.Drawing.Color.LightGreen;
                    rtb.SelectionIndent = 20;
                    rtb.AppendText(string.Format("{0}: {1}" + Environment.NewLine, name, message));
                    rtb.ScrollToCaret();
                }
            }

        }

        private void GetAllMessages(int groupID, string groupName)
        {
            TabPage tp = new TabPage(groupName) { Name = groupName, Tag = groupID };

            if (tcGroups.TabPages.ContainsKey(groupName)) { return; }

            tcGroups.TabPages.Add(tp);
            tp.Controls.Add(new ucChatWindow() { ParentForm = this, BackColor = SkinManager.GetApplicationBackgroundColor(), Dock = DockStyle.Fill });

            tcGroups.SelectedTab = tp;

            var currentGroup = _db.Groups
                                    .Include("Messages.User")
                                    .SingleOrDefault(g => g.ID == groupID);

            foreach (var item in currentGroup.Messages.OrderBy(m => m.Timestamp))
            {
                WriteMessage(item.User.UserName, item.Data, groupName);
            }


            UpdateUsersInGroup(groupName);
        }

        private void lvAllGroups_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.SelectedItems.Count == 1)
            {
                ListViewItem item = lv.SelectedItems[0] as ListViewItem;
                GetAllMessages(int.Parse(item.Tag.ToString()), item.Text);
            }
        }

        public List<User> GetUsersToAdd(string groupName)
        {
            //var users = _db.Users.Include("Groups").SingleOrDefault(u => u.ID == UserID);
            var group = _db.Groups.SingleOrDefault(x => x.GroupName == groupName);
            //var users = _db.Users.Where(x => !group.Users.Contains(x)).ToList();
            //var users = _db.Users.Except(group.Users);
            var users = _db.Users;
            return users.ToList();
            
        }

    }
}
