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
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ThesisDemo
{
    public partial class WinFormsClient : MaterialForm
    {
        private int _userID;
        private string _userName;
        private IHubProxy _hubProxy;
        //const string ServerURI = "http://localhost:8080/signalr";
        private const string _serverURI = "http://localhost:19216/signalr";
        private HubConnection _connection;
        //private readonly MeContext _db = new MeContext(); //VÄLIAIKAISESTI
        private WebApi _webApi;

        public WinFormsClient()
        {
            InitializeComponent();
            _webApi = new WebApi();

            //theme:
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green600, Primary.BlueGrey500, Accent.Orange700, TextShade.WHITE);
            //Primary.BlueGrey900 vakio

            //var lstUsers = (from u in _db.Users select new { u.ID, u.UserName }).ToList();
            //comboBoxSelectUser.DataSource = lstUsers;

            comboBoxSelectUser.DataSource = _webApi.GetAllUsers();
            comboBoxSelectUser.DisplayMember = "Name";
            comboBoxSelectUser.ValueMember = "ID";

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

        //public async void SendMessage(string message)
        //{
        //    await _webApi.AddMessage(_userID, (int)tcGroups.SelectedTab.Tag, message);
        //}

        //Creates and connects the hub connection and hub proxy. 
        //This method is called asynchronously from SignInButton_Click.
        private async void ConnectAsync()
        {
            _connection = new HubConnection(_serverURI, new Dictionary<string, string>
            {
                 { "UserID", _userID.ToString() }
            });

            _connection.Closed += Connection_Closed;
            _connection.Reconnecting += Connection_Reconnecting;
            _connection.Reconnected += Connection_Reconnected;

            _hubProxy = _connection.CreateHubProxy("ChatHub");

            //Handle incoming event from server: use Invoke to write to console from SignalR's thread
            _hubProxy.On<string, string, string>("AddMessage", (name, message, group) =>
                Invoke((Action)(() =>
                    WriteMessage(name, message, group)
                ))
            );

            _hubProxy.On("UpdateGroups", () =>
                Invoke((Action)(() =>
                    UpdateGroups()
                ))
            );

            _hubProxy.On<int>("UpdateUsersInGroup", (groupID) =>
                Invoke((Action)(() =>
                    UpdateUsersInGroup(groupID)
                ))
            );

            // Start the server connection asynchronously to avoid blocking UI thread.
            try
            {
                await _connection.Start();
            }
            catch (HttpRequestException)
            {
                StatusText.Text = "Unable to connect to server: Start server before connecting clients.";
                //No connection: Don't enable Send button or show chat UI
                return;
            }
            //State object stores data to be transmitted to the server 
            _hubProxy["userName"] = _userName;

            //Activate UI
            lblUserName.Text = _userName;
            lblUserName.Font = new System.Drawing.Font("Arial", 20);

            SignInPanel.Visible = false;
            ChatPanel.Visible = true;
            //btnSend.Enabled = true;
            //txtMessage.Focus();
            RichTextBoxConsole.AppendText("Connected to server at " + _serverURI + Environment.NewLine);

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

        private async void UpdateGroups()
        {
            lvAllGroups.Items.Clear();

            var user = await _webApi.GetUser(_userID);

            if (user == null) { return; }

            foreach (var item in user.Groups)
            {
                lvAllGroups.Items.Add(new ListViewItem { Text = item.Name, Tag = item.ID });
                await _hubProxy.Invoke("JoinGroup", item.ID.ToString());
            }
        }

        private async void UpdateUsersInGroup(int groupID)
        {
            var tp = tcGroups.TabPages[groupID.ToString()] as TabPage;

            if (tp == null) { return; }

            var uc = tp.Controls["ucChatWindow"] as UserControl;
            var lv = uc.Controls["lvUsersInGroup"] as ListView;

            lv.Items.Clear();

            var group = await _webApi.GetGroup(groupID);

            foreach (var item in group.Users)
            {
                lv.Items.Add(new ListViewItem { Text = item.Name, Tag = item.ID.ToString(), Group = ((item.Online == true) ? lv.Groups["Online"] : lv.Groups["Offline"]) });
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
            _userID = (int)comboBoxSelectUser.SelectedValue;
            _userName = comboBoxSelectUser.GetItemText(comboBoxSelectUser.SelectedItem);
            if (_userID != 0 && !string.IsNullOrEmpty(_userName))
            {
                StatusText.Visible = true;
                StatusText.Text = "Connecting to server...";
                ConnectAsync();
            }
        }

        private void WinFormsClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_connection != null)
            {
                _connection.Stop();
                _connection.Dispose();
            }
        }

        private async void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (txtAddGroup.Text != "")
            {
                //var group = new DatabaseConnection.Group
                //{
                //    GroupName = txtAddGroup.Text,
                //    CreationDate = DateTime.Now
                //};

                //var user = _db.Users.Find(_userID);

                //_db.Groups.Add(group);

                //user.Groups.Add(group);
                //_db.SaveChanges();

                //HttpStatusCode x = await AddGroup(_userID, txtAddGroup.Text);

                await _webApi.AddGroup(_userID, txtAddGroup.Text);

                await _hubProxy.Invoke("JoinGroup", txtAddGroup.Text);

                txtAddGroup.Text = String.Empty;
                txtAddGroup.Focus();

                UpdateGroups();
            }
        }

        private void tcGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tab = sender as TabControl;
            _hubProxy["currentGroup"] = tab.SelectedTab.Text;

            //Button btn = tab.SelectedTab.Controls["ucChatWindow"].Controls["btnSend"] as Button;
            //this.AcceptButton = btn;


            //set accept button to selected tab
            if (tab.SelectedTab.Controls.Find("ucChatWindow", true).Length != 0)
            {
                this.AcceptButton = tab.SelectedTab.Controls["ucChatWindow"].Controls["btnSend"] as Button;
            }
        }

        private void WriteMessage(string name, string message, string group)
        {
            var tp = tcGroups.TabPages[group] as TabPage;

            if (tp == null) { return; }

            var uc = tp.Controls["ucChatWindow"] as UserControl;

            if (uc != null)
            {
                RichTextBox rtb = uc.Controls["RichTextBoxConsole"] as RichTextBox;
                rtb.SelectionColor = SkinManager.GetPrimaryTextColor();
                if (name == _userName)
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

        private async void GetAllMessages(int groupID)
        {
            //TabPage tp = new TabPage(groupName) { Name = groupID.ToString(), Tag = groupID };

            //if (tcGroups.TabPages.ContainsKey(groupName)) { return; }

            //tcGroups.TabPages.Add(tp);
            //tp.Controls.Add(new ucChatWindow() { ParentForm = this, BackColor = SkinManager.GetApplicationBackgroundColor(), Dock = DockStyle.Fill });

            //tcGroups.SelectedTab = tp;

            //var currentGroup = _db.Groups
            //                        .Include("Messages.User")
            //                        .SingleOrDefault(g => g.ID == groupID);

            var currentGroup = await _webApi.GetGroup(groupID);

            foreach (var item in currentGroup.Messages.OrderBy(m => m.TimeStamp))
            {
                WriteMessage(item.UserName, item.Message, groupID.ToString());
            }


            //UpdateUsersInGroup(groupID);
        }

        private void lvAllGroups_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.SelectedItems.Count == 0) { return; }
            //    if (lv.SelectedItems.Count == 1)
            //{
            //    ListViewItem item = lv.SelectedItems[0] as ListViewItem;
            //    GetAllMessages(int.Parse(item.Tag.ToString()), item.Text);
            //}

            var item = lv.SelectedItems[0] as ListViewItem;


            var tp = new TabPage(item.Text) { Name = item.Tag.ToString(), Tag = item.Tag };

            if (tcGroups.TabPages.ContainsKey(item.Text)) { return; }

            tcGroups.TabPages.Add(tp);
            tp.Controls.Add(new ucChatWindow(_userID, (int)item.Tag) { BackColor = SkinManager.GetApplicationBackgroundColor(), Dock = DockStyle.Fill });

            tcGroups.SelectedTab = tp;

            UpdateUsersInGroup(int.Parse(item.Tag.ToString()));
            GetAllMessages(int.Parse(item.Tag.ToString()));
        }

        //public List<User> GetUsersToAdd(string groupName)
        //{
        //    //var users = _db.Users.Include("Groups").SingleOrDefault(u => u.ID == UserID);
        //    var group = _db.Groups.SingleOrDefault(x => x.GroupName == groupName);
        //    //var users = _db.Users.Where(x => !group.Users.Contains(x)).ToList();
        //    //var users = _db.Users.Except(group.Users);
        //    var users = _db.Users;
        //    return users.ToList();

        //}

    }
}
