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
        }
        public class Group
        {
            public int ID { get; set; }
            public string GroupName { get; set; }
            public DateTime CreationDate { get; set; }
        }
        public class Message
        {
            public int ID { get; set; }
            public string Data { get; set; }
            public DateTime Timestamp { get; set; }
        }

        public class MeContext : DbContext
        {
            protected override void OnModelCreating(DbModelBuilder modelBuilder) { }

            //public MeContext() : base(@"Data Source=DESKTOP-542OICS\SQLEXPRESS;Initial Catalog=ThesisDemoDb;Integrated Security=True") {}
            public MeContext() : base(@"Data Source=PII-PARTJUH\SQLEXPRESS;Initial Catalog=ThesisDemoDb;Integrated Security=True") { }

            //Entity set:
            public DbSet<Message> Messages { get; set; }
            public DbSet<User> Users { get; set; }
            public DbSet<Group> Groups { get; set; }

            //model
            //fuent interface      .HasRequired(x => ...)
           

         //modelBuilder.Entity<Course>() 
         //.HasMany(t => t.Instructors)
         //.WithMany(t => t.Courses)
        }
    }
}
