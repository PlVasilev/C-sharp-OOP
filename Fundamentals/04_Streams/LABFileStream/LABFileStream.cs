using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace LABFileStream
{
    class LABFileStream
    {
        static void Main(string[] args)
        {
            //Inherits the Stream class and supports all its methodsand properties
            //Supports reading, writing, positioning operations, etc.
            //The constructor contains parameters for:
            //File name
            //File open mode
            //File access mode
            //Concurrent users access mode

            //var fs = new FileStream(string fileName, FileMode, [FileAccess], [FileShare]);
            //FileMode – opening file mode
            //    Open, Append, Create, CreateNew, OpenOrCreate, Truncate
            //FileAccess – operations mode for the file
            //    Read, Write, ReadWrite
            //FileShare – access rules for other users while file is opened
            //    None , Read, Write, ReadWrite

            //Writing Text to File – Example
            string text = "Кирилица";
            var fileStream = new FileStream("../../log.txt",
                                                FileMode.Create);
            try
            {
                byte[] bytes1 = Encoding.UTF8.GetBytes(text);
                fileStream.Write(bytes1, 0, bytes1.Length);
            }
            finally
            { fileStream.Close(); }

            //Copying File – Example(1)
            //var source = new FileStream(SheepImagePath, FileMode.Open)
            //using (source)
            //{
            //    var destination =
            //          new FileStream(DestinationPath, FileMode.Create);
            //    using (destination)
            //    {
            //        while (true)
            //      {
            //          byte[] buffer = new byte[4096];
            //          int readBytes = source.Read(buffer, 0, buffer.Length);
            //          if (readBytes == 0)
            //          {
            //              break;
            //          }
            //          destination.Write(buffer, 0, readBytes);
            //      }
            //
            //    }
            //}

            //Reading In-Memory String – Example
            string text1 = "In-memory text.";
            byte[] bytes = Encoding.UTF8.GetBytes(text1);
            using (var memoryStream = new MemoryStream(bytes))
            {
                while (true)
                {
                    int readByte = memoryStream.ReadByte();
                    if (readByte == -1)
                        break;
                    Console.WriteLine((char)readByte);
                }
            }

            //Simple TCP Server – Example

            int PortNumber = 1500;
            var tcpListener = new TcpListener(IPAddress.Any, PortNumber);
            tcpListener.Start();
            Console.WriteLine("Listening on port {0}...", PortNumber);
            while (true)
            {
                using (var stream = tcpListener.AcceptTcpClient().GetStream())
                {
                    byte[] request = new byte[4096];
                    stream.Read(request, 0, 4096);
                    Console.WriteLine(Encoding.UTF8.GetString(request));

                    string html = string.Format("{0}{1}{2}{3} - {4}{2}{1}{0}",
                    "<html>", "<body>", "<h1>", "Welcome to my awesome site!", DateTime.Now);
                    byte[] htmlBytes = Encoding.UTF8.GetBytes(html);
                    stream.Write(htmlBytes, 0, htmlBytes.Length);

                }
            }

        }
    }
}
