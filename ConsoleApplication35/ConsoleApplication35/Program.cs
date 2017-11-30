using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringLiczba = "245232";
            string stringPusty = null;
            string blednyFormat = "5.287";
            string pozaZakres = "9876225432123456";
            int liczba;

            liczba = int.Parse(stringLiczba);
            //liczba = int.Parse(stringPusty); ArgumentNullException 
            //liczba = int.Parse(blednyFormat); FormatException
            //liczba = int.Parse(pozaZakres); poza zakres

            //liczba = Convert.ToInt32(stringLiczba);
            //liczba = Convert.ToInt32(stringPusty);
            //liczba = Convert.ToInt32(blednyFormat); niepoprawy format
            //liczba = Convert.ToInt32(pozaZakres); wartosc poza zakresem

            bool wynik;
            wynik = int.TryParse(stringLiczba, out liczba);
            wynik = int.TryParse(stringPusty, out liczba);
            wynik = int.TryParse(blednyFormat, out liczba);
            wynik = int.TryParse(pozaZakres, out liczba);

            Console.ReadKey();
        }
    }
}
