using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class VictorianChair : IChair
    {
        public void HasLegs()
        {
            Console.WriteLine("Victorian has chair 4 legs");
        }

        public void SitOn()
        {
            Console.WriteLine("Victorian chair sitdown please"); ;
        }


        public override string ToString()
        {
            return $"Victorian Chair";
        }
    }
}
