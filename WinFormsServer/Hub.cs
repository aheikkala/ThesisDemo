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
    /// <summary>
    /// Echoes messages sent using the Send message by calling the
    /// addMessage method on the client. Also reports to the console
    /// when clients connect and disconnect.
    /// </summary>
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

            //Clients.All.addMessage(name, message);

            _chat.Send(Clients.Caller.userName, message);

        }

        //public List<User> GetAllUsers()
        //{
        //    return _chat.GetAllUsers();
        //}

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
