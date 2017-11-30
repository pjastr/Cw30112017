using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = new int[2];
            try
            {
                int a =99395434;
                int b = 0;
                table[1] = a/b;
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Poza zakres tablicy");
            }
            catch
            {
                Console.WriteLine("inny wyjątek");
            }

            Console.ReadKey();

        }
    }
}
