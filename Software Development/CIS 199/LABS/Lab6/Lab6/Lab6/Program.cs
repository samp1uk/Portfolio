using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Pattern A");

            for (int write = 1; write <= 10; ++write)
            {
                for (int stars = 0; stars < write; ++stars)
                {
                    Console.Write('*');
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\nPattern B");
            Console.WriteLine();

            for (int write = 1; write <= 10; ++write)
            {
                for (int stars = 0; stars <= 10 - write; ++stars)
                {
                    Console.Write('*');
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\nPattern C");
            Console.WriteLine("");

            for (int write = 0; write <= 10; ++write)
            {
                for (int space = 1; space <= write; ++space)
                {
                    Console.Write(' ');

                }
                for (int stars = 1; stars <= 10 - write; ++stars)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPattern D");
            Console.WriteLine();

            for (int write = 0; write <= 10; ++write)
            {
                for (int space = 1; space <= 10 - write; ++space)
                {
                    Console.Write(' ');

                }
                for (int stars = 1; stars <= write; ++stars)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
    
    }
    }
}
