using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            object o1 = null;
            object o2 = new object();

            //Console.WriteLine(ReferenceEquals(o1, o1));
            //Console.WriteLine(ReferenceEquals(o1, o2));
            //Console.WriteLine(ReferenceEquals(o2, o1));
            //Console.WriteLine(ReferenceEquals(o2, o2));

            //try
            //{
            //    Console.WriteLine(o1.Equals(o1));
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //try
            //{
            //    Console.WriteLine(o1.Equals(o2));
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine(o2.Equals(o1));
            //Console.WriteLine(o2.Equals(o2));

            Console.WriteLine(o1 == o1);
            Console.WriteLine(o1 == o2);
            Console.WriteLine(o2 == o1);
            Console.WriteLine(o2 == o2);

            Console.ReadKey();
        }
    }
}
