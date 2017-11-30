using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication32
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new NaszWyjatekException("ddddd");
            }
            catch(Exception e)
            {
                Console.WriteLine("Więcej pomocy na {0}", e.HelpLink);
            }
            Console.ReadKey();
        }
    }

    class NaszWyjatekException:Exception
    {
        public NaszWyjatekException()
        {

        }

        public NaszWyjatekException(string message)
            : base(message) 
        {
            HelpLink = "http://www.google.pl/";
        }

        public NaszWyjatekException(String message, Exception innerException)
            : base(message, innerException) { }

    }
}
