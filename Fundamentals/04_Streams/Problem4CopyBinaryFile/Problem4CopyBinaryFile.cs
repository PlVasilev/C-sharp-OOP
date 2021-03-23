using System;
using System.IO;

namespace Problem4CopyBinaryFile
{
    class Problem4CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string path = "../../../../files";
            string fileName = "copyMe.png";
            string path1 = Path.Combine(path, fileName);
            string path2 = Path.Combine(path, "copyMe-copy.png");
            using (FileStream fileStream = new FileStream(path1, FileMode.Open)) // we open the file
            {
                long size = fileStream.Length;

                byte[] buffer = new byte[size];
                fileStream.Read(buffer, 0, buffer.Length);

                using (FileStream write = new FileStream(path2, FileMode.Create))
                {
                    write.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
