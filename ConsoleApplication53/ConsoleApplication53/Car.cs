using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication53
{
    class Car:IComparable<Car>
    {
        private int year;
        private string brand;

        public Car(int year, string brand)
        { 
            this.year = year;
            this.brand = brand;
        }

        public int CompareTo(Car other)
        {
            return this.brand.CompareTo(other.brand);
        }

        public string Info()
        { 
            return brand+" "+year;
        }
    }
}
