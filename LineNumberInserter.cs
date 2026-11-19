using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12.ex2
{
    internal class LineNumberInserter
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("proba.txt");
            StreamWriter writer = new StreamWriter("out.txt");

            int lineNumber = 0;
            string line = reader.ReadLine();

            while(line != null)
            {
                lineNumber++;
                writer.WriteLine("{0,5}{1}", lineNumber, line);
                line = reader.ReadLine();
            }

            writer.Close();
            reader.Close();

            reader = new StreamReader("out.txt");
            lineNumber = 0;
            line = reader.ReadLine();

            while(line != null)
            {
                lineNumber++;
                Console.WriteLine("{0}",line);
                line = reader.ReadLine();
            }

            reader.Close();
            Console.ReadLine();
        }
    }
}
