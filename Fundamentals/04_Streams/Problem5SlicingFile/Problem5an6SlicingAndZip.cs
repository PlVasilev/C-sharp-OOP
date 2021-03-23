using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace Problem5SlicingFile
{
    class Problem5an6SlicingAndZip
    {
        static List<string> paths;

        static void Main(string[] args)
        {
            paths = new List<string>();
            string destination = "../../../../files";
            string fileName = "sliceMe.mp4";
            string path = Path.Combine(destination, fileName);
            int parts = 4;
            string pathToWrite = Path.Combine(destination, "assemble.mp4");
            Slice(path, destination, parts);
            Assemble(paths, pathToWrite);
        }
        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (FileStream readFile = new FileStream(sourceFile, FileMode.Open))
            {
                long size = readFile.Length / parts + readFile.Length % parts;

                byte[] buffer = new byte[size];
                for (int i = 0; i < parts; i++)
                {
                    string path2 = Path.Combine(destinationDirectory, $"Path{i}.mp4");
                    paths.Add(path2);

                    using (FileStream writeFile = new FileStream(path2, FileMode.Create))
                    {
                        int bytesCount = readFile.Read(buffer, 0, buffer.Length);
                        writeFile.Write(buffer, 0, buffer.Length);
                    }
                    using (GZipStream gz = new GZipStream(new FileStream(path2 + ".gz", FileMode.Create),
                                                                         CompressionMode.Compress, false))
                    {
                        gz.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }

        static void Assemble(List<string> paths, string destinationFile)
        {
            using (FileStream writeFile = new FileStream(destinationFile, FileMode.Create))
            {
                byte[] buffer = new byte[4096];

                foreach (var path in paths)
                {
                    using (FileStream readFile = new FileStream(path, FileMode.Open))
                    {
                        while (true)
                        {
                            int bytesCount = readFile.Read(buffer, 0, buffer.Length);

                            if (bytesCount == 0)
                            {
                                break;
                            }
                            writeFile.Write(buffer, 0, bytesCount);
                        }
                    }
                }
            }
        }
    }

}
