using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    class Osoba: ISport, IMuzyka
    {
        //public string Gra()
        //{
        //    return "gra";
        //}

        string IMuzyka.Gra()
        {
            return "muzyka";
        }

        string ISport.Gra()
        {
            return "sport";
        }
    }
}
