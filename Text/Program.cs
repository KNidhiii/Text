using System;
using System.Collections.Generic;
using System.IO;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Kumarin\Documents\text.txt";
            Console.WriteLine("Enter the input string: ");

            var input = Console.ReadLine();

            string line;
            int counter = 0;
            int count = 0;
            int lineNum = 0;
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                var a = line.Split(" ");
                foreach (var x in a)
                {
                    if (x.Equals(input))
                    {
                        count++;
                        if (count == 2)
                        {
                            lineNum = counter + 1;
                        }
                    }
                }
                counter++;
            }
            Console.WriteLine("Total occurance of {0} is {1}", input, count);
            Console.WriteLine("2nd occurance of {0} is in line {1}", input, lineNum);

            file.Close();



        }
    }
}
