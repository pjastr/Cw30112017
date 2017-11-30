using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int a = int.MaxValue;
                Console.WriteLine(a);
                try
                {
                    Console.WriteLine(++a);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
