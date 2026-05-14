using System;
using System.Collections.Generic;
using System.IO;

namespace FilePower1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Queue<string> stringToFile = new Queue<string>();

            while(true)
            {
                Console.WriteLine("\nWrite something to add to the file: ");
                Console.WriteLine("Or Press 'Enter' to finish");

                string input = Console.ReadLine();
                if(input == "")
                    break;
                else
                {
                    stringToFile.Enqueue(input);
                }
            }

            Console.WriteLine("\nSaving in the file...");
                foreach (string s in stringToFile)
                {
                    File.AppendAllText(args[0], s + "\n");
                }
        }
    }
}
