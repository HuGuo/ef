using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Entity;
using EF.Model;

namespace EF.Dal
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<Content>
    {
        protected override void Seed(Content context)
        {
            base.Seed(context);

            var fils = new List<File> { 
                new File{ Name="年度总结"},
                new File{ Name="未来规划"}
            };
            var parentFolder = new Folder
            {
                Name = "1"
            };
            var chidren = new List<Folder> {
               new Folder{ Name="1.1.1"},
               new Folder{ Name="1.1.2"}
            };
            var folder = new Folder
            {
                Name = "1.1",
                ParentFolder = parentFolder,
                Folders = chidren,
                Files = fils
            };
            context.Folders.Add(folder);

            context.SaveChanges();
        }

    }
}
