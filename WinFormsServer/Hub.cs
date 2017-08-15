using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using System.Data.Entity;
using static ThesisDemo.DatabaseConnection;

namespace ThesisDemo
{
    /// <summary>
    /// Echoes messages sent using the Send message by calling the
    /// addMessage method on the client. Also reports to the console
    /// when clients connect and disconnect.
    /// </summary>
    public class MyHub : Hub
    {
        
        //class Message
        //{
        //    public int ID { get; set; }
        //    public string Data { get; set; }
        //}

        //class MeContext : DbContext
        //{
        //    //public MeContext() : base(@"Data Source=DESKTOP-542OICS\SQLEXPRESS;Initial Catalog=ThesisDemoDb;Integrated Security=True") { }
        //    public DbSet<Message> Messages { get; set; }
        //}


        public void Send(string name, string message)
        {
            var msg = new Message
            {
                Data = message
            };
            var db = new MeContext();
            db.Messages.Add(msg);
            db.SaveChanges();

            Clients.All.addMessage(name, message);
        }
        public override Task OnConnected()
        {
            Program.MainForm.WriteToConsole("Client connected: " + Context.ConnectionId);
            return base.OnConnected();
        }
        public override Task OnDisconnected()
        {
            Program.MainForm.WriteToConsole("Client disconnected: " + Context.ConnectionId);
            return base.OnDisconnected();
        }
    }
}
