using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class Blackout : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("Blackout attack 40 power");
        }

        public override void Died()
        {
            Console.WriteLine("Blackout died");
        }

        public override void SpecialAttack()
        {
            Console.WriteLine("Blackout special attack 50 power");
        }

        public override string ToString()
        {
            return "Blackout Created";
        }
    }
}
