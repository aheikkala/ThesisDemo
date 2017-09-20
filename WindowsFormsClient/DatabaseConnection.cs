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
        public class User
        {
            public int ID { get; set; }
            public string UserName { get; set; }
            public virtual List<Group> Groups { get; set; }
        }
        public class Group
        {
            public int ID { get; set; }
            public string GroupName { get; set; }
            public DateTime CreationDate { get; set; }
            //public virtual List<User> Users { get; set; }
            public virtual List<Message> Messages { get; set; }
        }
        public class Message
        {
            public int ID { get; set; }
            public string Data { get; set; }
            public DateTime Timestamp { get; set; }
            public User User { get; set; }
            //public Group Group { get; set; }
        }

        public class MeContext : DbContext
        {

            //public MeContext() : base(@"Data Source=DESKTOP-542OICS\SQLEXPRESS;Initial Catalog=ThesisDemoDb;Integrated Security=True") {}
            public MeContext() : base(@"Data Source=PII-PARTJUH\SQLEXPRESS;Initial Catalog=ThesisDemoDb;Integrated Security=True") {}

            //Entity set:
            public DbSet<Message> Messages { get; set; }
            public DbSet<User> Users { get; set; }
            public DbSet<Group> Groups { get; set; }

            //Model:
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<User>().HasMany(x => x.Groups).WithMany();
                //modelBuilder.Entity<Group>().HasMany(x => x.Users).WithMany();
                modelBuilder.Entity<Group>().HasMany(x => x.Messages).WithMany();
                //modelBuilder.Entity<Group>().HasMany(x => x.Messages).WithMany();
                modelBuilder.Entity<Message>().HasRequired(x => x.User).WithMany();
            }
        }
    }
}
