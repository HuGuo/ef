using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity;
using EF.Model;

namespace EF.Dal
{
    public class Content : DbContext
    {
        public IDbSet<Folder> Folders { get; set; }
        public IDbSet<File> Files { get; set; }
        public IDbSet<User> Users { get; set; }

        public Content(): base("ef")
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public Content(string connStr):base(connStr)
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
