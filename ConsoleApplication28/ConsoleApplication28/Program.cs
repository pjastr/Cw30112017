using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba1 = 30;
            int liczba2 = 0;
            try
            { 
                int liczba3 = liczba1 / liczba2;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.TargetSite);
            }
            finally
            {
                Console.WriteLine("FINALLY");
            }
            Console.ReadKey();
        }
    }
}
