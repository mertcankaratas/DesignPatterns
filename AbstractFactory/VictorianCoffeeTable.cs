using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class VictorianCoffeeTable : ICoffeeTable
    {
        public void HasLegs()
        {
            Console.WriteLine("Victorian Coffee Table has 4 legs");
        }

        public void WoodType()
        {
            Console.WriteLine("Victorian Coffee Table wood type Chery");
        }
        public override string ToString()
        {
            return "Victorian Coffee Table";
        }
    }
}
