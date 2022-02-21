using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ModernSofa : ISofa
    {
        public void FabricType()
        {
            Console.WriteLine("Modern sofa fabrictype leather");
        }

        public void HasLegs()
        {
            Console.WriteLine("Modern sofa has 4 legs");
        }

        public override string ToString()
        {
            return "Modern Sofa";
        }
    }
}
