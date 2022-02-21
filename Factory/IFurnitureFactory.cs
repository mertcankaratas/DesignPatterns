using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IFurnitureFactory
    {
        IChair  CreateChair(string chairType);
        ICoffeeTable CreateCoffeeTable(string coffeeTableType);
        ISofa CreateSofa(string sofaType);
    }
}
