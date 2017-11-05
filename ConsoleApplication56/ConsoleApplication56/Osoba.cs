using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication56
{
    class Osoba:ISport, IMuzyka
    {
        //public string Gra() //implementacja niejawna
        //{
        //    return "gra";
        //}

        string IMuzyka.Gra() //jawna implentacja metody z interfejsu IMuzyka
        {
            return "muzyka";
        }

        string ISport.Gra()
        {
            return "sport";
        }
    }
}
