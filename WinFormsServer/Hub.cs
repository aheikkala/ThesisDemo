using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using System.Data.Entity;
//using static ThesisDemo.DatabaseConnection;

namespace ThesisDemo
{
    //Echoes messages sent using the Send message by calling the addMessage method on the client. 
    //Also reports to the console when clients connect and disconnect.
    public class ChatHub : Hub
    {
        private readonly static ConnectionMapping<string> _connections = new ConnectionMapping<string>();

        private readonly Chat _chat;

        public ChatHub() : this(Chat.Instance) { }

        public ChatHub(Chat chat)
        {
            _chat = chat;
        }


        public void Send(string message)
        {
            //var msg = new Message
            //{
            //    Data = message
            //};
            //var db = new MeContext();
            //db.Messages.Add(msg);
            //db.SaveChanges();

            //Clients.Group(Clients.Caller.currentGroup).addMessage(Clients.Caller.userName, message);
            Clients.All.addMessage(Clients.Caller.userName, message);

            //_chat.Send(Clients.Caller.userName, message);

        }

        public void JoinGroup(string groupName)
        {
            Groups.Add(Context.ConnectionId, groupName);
            //Clients.Group(groupName).addMessage(Clients.Caller.userName + " joined.");
        }

        public void LeaveGroup(string groupName)
        {
            Groups.Remove(Context.ConnectionId, groupName);
            //Clients.Group(groupName).addMessage(Clients.Caller.userName + " joined.");
        }

        public override Task OnConnected()
        {
            //Context property returns a HubCallerContext
            string name = Context.QueryString["UserName"];
            _connections.Add(name, Context.ConnectionId);

            Program.MainForm.WriteToConsole("Client connected: " + Context.ConnectionId);
            return base.OnConnected();
        }
        public override Task OnDisconnected()
        {
            string name = Context.QueryString["UserName"];
            _connections.Remove(name, Context.ConnectionId);

            Program.MainForm.WriteToConsole("Client disconnected: " + Context.ConnectionId);
            return base.OnDisconnected();
        }
    }
}
