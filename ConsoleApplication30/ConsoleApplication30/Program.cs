using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 30;
            double b = 0;
            try
            {
                if (b == 0) throw new DivideByZeroException();
                double c = a / b;
                Console.WriteLine(c);
            }
            catch
            {
                Console.WriteLine("Nie dziel przez zero");
            }

            Console.ReadKey();
            
        }
    }
}
