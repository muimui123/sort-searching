using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1){
                Console.WriteLine("Sorry, could not find ");
            } else{
                //ask filename
                string filename = args[0];
                int n = 0;
                employee[] list = null;
                //try exception
                try
                {
                    var sr = new StreamReader(filename);
                    string firstLine = sr.ReadLine();
                    n = int.Parse(firstLine);
                    list = new employee[n];

                    for (int i = 0; i < n; i++)
                    {
                        string nextLine = sr.ReadLine();
                        list[i] = new employee(nextLine);
                    }
                    sr.Close();

                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("Sorry, could not find " + filename);
                }

                //write lines
                StreamWriter sw = new StreamWriter("k");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(list[i]);
                    sw.WriteLine(list[i]);
                }
                sw.Close();

            }
        }
    }
}
