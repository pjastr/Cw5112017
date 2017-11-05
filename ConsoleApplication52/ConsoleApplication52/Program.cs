using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication52
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
            throw new NotImplementedException();
        }

        public int Liczba()
        {
            throw new NotImplementedException();
        }
    }

    interface IAaa
    {
        int Liczba();
    }

    interface IBbb : IAaa
    {
        string Wyraz();
    }
}
