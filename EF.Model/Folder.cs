using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel.DataAnnotations;

namespace EF.Model
{
    public class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int UserId { get; set; }

        public int? ParentFolderId { get; set; }
        public virtual Folder ParentFolder { get; set; }

        public virtual ICollection<Folder> Folders { get; set; }
        public virtual ICollection<File> Files { get; set; }
    }
}