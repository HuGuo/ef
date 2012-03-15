using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EF.Model;
using EF.Bll;

namespace efConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            FolderBll bll = new FolderBll();
            var folder = bll.Find(2);
            Console.WriteLine(string.Format("文件夹名：{0}", folder.Name));
            foreach (File file in folder.Files)
                Console.WriteLine(string.Format("  文件名：{0}", file.Name));
            if (folder.ParentFolder != null)
                Console.WriteLine(string.Format("父文件夹名：{0}", folder.ParentFolder.Name));
            foreach (Folder childFolder in folder.Folders)
                Console.WriteLine(string.Format("子文件夹名：{0}", childFolder.Name));
            Console.Read();
        }
    }
}
