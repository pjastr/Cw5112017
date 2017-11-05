using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication56
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba();
            IMuzyka osoba2 = new Osoba();
            ISport osoba3 = new Osoba();

            Console.WriteLine(((IMuzyka)osoba1).Gra());
            Console.WriteLine(osoba2.Gra());
            Console.WriteLine(osoba3.Gra());

            Console.ReadKey();
        }
    }
}
