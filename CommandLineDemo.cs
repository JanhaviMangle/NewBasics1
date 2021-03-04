using System;
using System.Collections.Generic;
using System.Text;

namespace NewBasics1
{
    class CommandLineDemo
    {
        static void Main(String[] args)
        {
            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            Console.ReadKey();

            foreach(var a in args)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();

        }
    }
}
