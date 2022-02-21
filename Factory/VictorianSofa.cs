using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class VictorianSofa : ISofa
    {
        public void FabricType()
        {
            Console.WriteLine("Victorian sofa fabrictype Linen");
        }

        public void HasLegs()
        {
            Console.WriteLine("Victorian sofa has 4 legs");
        }


        public override string ToString()
        {
            return "Victorian Sofa";
        }
    }
}
