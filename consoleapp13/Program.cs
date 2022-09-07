using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleapp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd Numbers From 0 to 100");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();



                
        }
    }
}
