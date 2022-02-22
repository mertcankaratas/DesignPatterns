using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public abstract class Enemy
    {
        public abstract void Attack();
        public abstract void SpecialAttack();
        public abstract void Died();
    }
}
