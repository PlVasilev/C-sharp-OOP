using System;
using System.IO;
using System.Linq;

namespace LABStreams
{
    class LABStreams
    {
        static void Main(string[] args)
        {
            string path = "../../../";
            string fileName = "LABStreams.cs";
            string outputFileName = "reverse.txt";


            path = Path.Combine(path,fileName); // !!събира стрингове конкатениран по такъв начи че пътя де да е ОК за дадения ОС 
            
            using (StreamReader reader = new StreamReader(path)) // пътя към файла който подаваме файла за четене
                // работи се с реадара само в Юзинг извън него не може да се работи
            {
                using (StreamWriter writer = new StreamWriter(outputFileName)) // подаваме фаила в който ще пишем
                {
                    string textLine = reader.ReadLine(); // reads one line from the file
                    int count = 1;

                    while (textLine != null) // свършат ли редовете рийдъра връща null
                    {
                        Console.WriteLine($"Line {count}: {textLine}");
                        Console.WriteLine($"Line {count}: {string.Join("", textLine.Reverse())}"); // събира обратния чарАрр
                        writer.WriteLine($"Line {count}: {string.Join("", textLine.Reverse())}"); // пише във файл
                        textLine = reader.ReadLine();
                        count++;

                    } // когато се затваря юзинга тогава се записва във файла
                }
              
            }
            //The base class for all streams is System.IO.Stream
            //There are defined methods for the main operations with streams in it
            //Some streams do not support read, write or positioning operations
            //Properties CanRead, CanWrite and CanSeek are provided - провека дали има този метод дадения стрийм;
            //Streams which support positioning have the properties Position and Length


            //int Read(byte[] buffer, int offset, int count);
            //Read as many as count bytes from input stream, starting from the given offset position
            //Returns the number of read bytes or 0 if end of stream is reached
            //Can freeze for undefined time while reading at least 1 byte
            //Can read less than the claimed number of bytes

            //Write(byte[] buffer, int offset, int count);
            //Writes a sequence of count bytes to an output stream, starting from the given offset position
            //Can freeze for undefined time, until it sends all bytes to their destination

            //Flush()
            //Sends the internal buffers data to its destination(data storage, I/O device, etc.)

            //Close()
            //Calls Flush()
            //Closes the connection to the device(mechanism)
            //Releases the used resources

            //Seek(offset, SeekOrigin)
            //Moves the position(if supported) with given offset towards the beginning, the end or the current position

            //Buffered Streams(1)
            //Buffer the data and effectively increase performance
            //Call for read of even 1 byte makes read of more kilobytes in advance
            //The stream keeps them in an internal buffer
            //Next read returns data from the internal buffer
            //Very fast operation
            //Written data is stored in internal buffer
            //Very fast operation
            //When buffer overloads:
            //Flush() is called
            //The data is sent to its destination
            //In.NET we use the System.IO.BufferedStream class



        }
}
}
