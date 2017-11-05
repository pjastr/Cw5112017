using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication58
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class WlasnaKlasa:IBbb
    {

        public string Wyraz()
        {
            return "sss";
        }

        public int Liczba()
        {
            return 6;
        }
    }

    interface IAaa
    {
        int Liczba();
    }

    interface IBbb:IAaa
    {
        string Wyraz();
    }
}
