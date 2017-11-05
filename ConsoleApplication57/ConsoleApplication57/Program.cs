using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication57
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gruszka gruszka1 = new Gruszka();
            Owoc gruszka2 = new Gruszka();
            //IJedzenie gruszka3 = new Gruszka();
            //gruszka1.Jedzenie(); //gruszka
            //((Owoc)gruszka1).Jedzenie(); //owoc
            //((Gruszka)gruszka1).Jedzenie(); //gruszka
            //((IJedzenie)gruszka1).Jedzenie(); //gruszka
            //Console.WriteLine("---");
            //gruszka2.Jedzenie(); //owoc
            //((Owoc)gruszka2).Jedzenie(); //owoc
            //((Gruszka)gruszka2).Jedzenie();  //gruszka
            ((IJedzenie)gruszka2).Jedzenie();  //owoc, gruszka
            //Console.WriteLine("---");
            //gruszka3.Jedzenie();//gruszka
            //((Owoc)gruszka3).Jedzenie(); //owoc
            //((Gruszka)gruszka3).Jedzenie(); //gruszka
            //((IJedzenie)gruszka3).Jedzenie(); //gruszka
            Console.ReadKey();
        }
    }
}
