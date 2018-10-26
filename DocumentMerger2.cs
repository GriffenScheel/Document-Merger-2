using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DocumentMerger2
{
    class Program
    {
      

        static void Main(string[] args)
        {
            // The arguments to the application is provided as a string array
            // called args passed to Main()
            string command1 = args[0];
            string command2 = args[1];
            string command3 = args[2];
                        if (args.Length < 4 && args.Length>2)
                        {
           
                             string filepath1 = @"A:\Users\Griffen Monster\textfiles\hello.txt";
                                       string filepath2 = @"A:\Users\Griffen Monster\textfiles\world.txt";

                                                string[] file1 = File.ReadAllLines(filepath1);
                                                        string[] file2 = File.ReadAllLines(filepath2);

          using (StreamWriter writer = File.CreateText(@"A:\Users\Griffen Monster\textfiles\" + command3))
              {
                 int lineNum = 0;
                   while (lineNum < file1.Length || lineNum < file2.Length)
              {
                        if (lineNum < file1.Length)
                            writer.WriteLine(file1[lineNum]);
                        if (lineNum < file2.Length)
                            writer.WriteLine(file2[lineNum]);
                        lineNum++;
              }
              }

              }
                                else if(args.Length<3) { 
                                Console.WriteLine("Not enough arguments were provided.");
                }

            Console.WriteLine("DocumentMerger2: " + command1 + " and " + command2 + " are now merged into " + command3);
            Console.ReadKey();
        }
    }
}

                
  