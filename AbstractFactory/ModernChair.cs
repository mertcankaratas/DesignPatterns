using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ModernChair : IChair
    {
        public void HasLegs()
        {
            Console.WriteLine($"Modern chair has 4 legs");
        }

        public void SitOn()
        {
            Console.WriteLine("Modern chair sitdown please");
        }
        public override string ToString()
        {
            return $"Modern Chair";
        }

    }
}
