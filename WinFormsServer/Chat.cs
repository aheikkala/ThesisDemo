using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using static ThesisDemo.DatabaseConnection;

namespace ThesisDemo
{
    public class Chat
    {
        //Singleton instance
        private readonly static Lazy<Chat> _instance = new Lazy<Chat>(() => new Chat(GlobalHost.ConnectionManager.GetHubContext<ChatHub>().Clients));
        private readonly MeContext _db = new MeContext();

        private Chat(IHubConnectionContext<dynamic> clients)
        {
            Clients = clients;

        }
        public static Chat Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private IHubConnectionContext<dynamic> Clients
        {
            get;
            set;
        }

        //public IEnumerable<Stock> GetAllStocks()
        //{
        //    return _stocks.Values;
        //}

        public void Send(string name, string message)
        {
            var msg = new Message
            {
                Data = message
            };
            //var db = new MeContext();
            _db.Messages.Add(msg);
            _db.SaveChanges();

            Clients.All.addMessage(name, message);
        }
    }
}
