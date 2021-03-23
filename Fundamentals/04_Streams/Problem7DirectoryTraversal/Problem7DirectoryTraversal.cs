using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Problem7DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> dirInfo = new Dictionary<string, Dictionary<string, decimal>>();
            string[] files = Directory.GetFiles("../../../../files", "*.*", SearchOption.TopDirectoryOnly);

            foreach (var file in files)
            {
                FileStream currentFile = File.Open(file, FileMode.Open);
                string fullname = Path.GetFileName(file); // geting justfile name
                string extension = Path.GetExtension(file); // getting just file ext
                decimal filesize = decimal.Divide(currentFile.Length, 1024); // getting exact file size
                if (!dirInfo.ContainsKey(extension))
                {
                    dirInfo.Add(extension, new Dictionary<string, decimal>());
                }
                if (!dirInfo[extension].ContainsKey(fullname))
                {
                    dirInfo[extension].Add(fullname, filesize);
                }
            }

            string pathToDesctop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\report.txt";
            using (StreamWriter write = new StreamWriter(pathToDesctop))
            {
                foreach (var kvp in dirInfo.OrderByDescending(x => x.Value.Count).ThenBy(k => k.Key))
                {
                    write.WriteLine(kvp.Key);
                    foreach (var f in kvp.Value.OrderBy(x => x.Value))
                    {
                        write.WriteLine($"--{f.Key} - {f.Value:F2}kb");
                    }
                }
            }
        }
    }
}
