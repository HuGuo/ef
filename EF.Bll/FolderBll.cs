using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EF.Model;
using EF.Dal;
using System.Data.Entity;

namespace EF.Bll
{
    public class FolderBll : Repository<Folder>
    {
        public override Folder Find(object obj)
        {
            var db = new Content();
            return db.Folders
                    .Find(obj);
        }
    }
}
