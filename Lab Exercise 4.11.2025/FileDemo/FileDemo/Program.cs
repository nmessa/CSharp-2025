using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create FileStream and StreamWriter
            FileStream fs = new FileStream("data.txt", FileMode.Create, FileAccess.Write);
            StreamWriter textfile = new StreamWriter(fs);

            textfile.WriteLine("This is line 1");
            textfile.WriteLine("This is line 2");
            textfile.WriteLine("This is line 3");

            //Close StreamWriter and FileStream
            textfile.Close();
            fs.Close();

            //Create FileStream and StreamReader
            FileStream fs2 = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            StreamReader textfile2 = new StreamReader(fs2);

            while (!textfile2.EndOfStream)
            {
                Console.WriteLine(textfile2.ReadLine());
            }

            //Close StreamReader and FileStream
            textfile.Close();
            fs.Close();

        }
    }
}
