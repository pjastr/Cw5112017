using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication57
{
    class Gruszka:Owoc, IJedzenie
    {
        public void Jedzenie()
        {
            Console.WriteLine("gruszka");
        }

        void IJedzenie.Jedzenie()
        {
            Console.WriteLine("gruszka jawna");
        }
    }
}
