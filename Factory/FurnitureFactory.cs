using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public  class FurnitureFactory : IFurnitureFactory
    {
        
        public  IChair CreateChair(string chairType)
        {
            IChair chair;
            switch (chairType)
            {
                case "Modern":
                    chair = new ModernChair();
                    Console.WriteLine(chair);
                    return chair;

                case "Victorian":
                    chair = new VictorianChair();
                    Console.WriteLine(chair);
                    return chair;
                default:
                    break;
            }

            return null;
        }

        public ICoffeeTable CreateCoffeeTable(string coffeeTableType)
        {
            ICoffeeTable coffeeTable;
            switch (coffeeTableType)
            {
                case "Modern":
                    coffeeTable= new ModernCoffeeTable();
                    Console.WriteLine(coffeeTable);
                    return coffeeTable;

                case "Victorian":
                    coffeeTable = new VictorianCoffeeTable();
                    Console.WriteLine(coffeeTable);
                    return coffeeTable;
                default:
                    break;
            }

            return null;

        }

        public ISofa CreateSofa(string sofaType)
        {
            ISofa sofa;
            switch (sofaType)
            {
                case "Modern":
                    sofa = new ModernSofa();
                    Console.WriteLine(sofa);
                    return sofa;

                case "Victorian":
                    sofa = new VictorianSofa();
                    Console.WriteLine(sofa);
                    return sofa;
                default:
                    break;
            }

            return null;
        }
    }
}
