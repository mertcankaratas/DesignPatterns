using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ModernCoffeeTable : ICoffeeTable
    {
        public void HasLegs()
        {
            Console.WriteLine("Modern Coffee Table has 4 legs");
        }

        public void WoodType()
        {
            Console.WriteLine("Modern Coffee Table wood type Walnut");
        }

        public override string ToString()
        {
            return "Modern Coffee Table";
        }
    }
}
