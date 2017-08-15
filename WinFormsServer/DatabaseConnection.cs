using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ThesisDemo
{
    public class DatabaseConnection
    {
        public class Message
        {
            public int ID { get; set; }
            public string Data { get; set; }
        }

        public class MeContext : DbContext
        {
            public MeContext() : base(@"Data Source=DESKTOP-542OICS\SQLEXPRESS;Initial Catalog=ThesisDemoDb;Integrated Security=True") {}
            public DbSet<Message> Messages { get; set; }

            //model
            //fuent interface      .HasRequired(x => ...)
        }
    }
}
