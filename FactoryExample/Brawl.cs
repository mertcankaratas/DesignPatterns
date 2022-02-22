using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class Brawl : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("Brawl Attack 35 power");
        }

        public override void Died()
        {
            Console.WriteLine("Brawl died");
        }

        public override void SpecialAttack()
        {
            Console.WriteLine("Brawl SpecailAttack");
        }

        public override string ToString()
        {
            return "Brawl Created";
        }
    }
}
