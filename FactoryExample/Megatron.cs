using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class Megatron : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("Megatron Attack 50 power");
        }

        public override void Died()
        {
            Console.WriteLine("Megathron died ");
        }

        public override void SpecialAttack()
        {
            Console.WriteLine("Megatron Special Attack 75 power");
        }

        public override string ToString()
        {
            return "Megatron Created";
        }
    }
}
