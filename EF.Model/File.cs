using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF.Model
{
    public class File
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int UserId { get; set; }

        public int FolderId { get; set; }
        public virtual Folder Folder { get; set; }
    }
}
