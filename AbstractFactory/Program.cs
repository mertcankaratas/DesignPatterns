using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
           
           FurnitureFactory furnitureFactory = new FurnitureFactory();

            //chair
            furnitureFactory.CreateChair("Modern");
            furnitureFactory.CreateChair("Victorian");
            //Coffee table 
            Console.WriteLine("----------------------");
            furnitureFactory.CreateCoffeeTable("Modern");
            furnitureFactory.CreateCoffeeTable("Victorian");


            //Sofa 
            Console.WriteLine("----------------------");
            furnitureFactory.CreateSofa("Modern");
            furnitureFactory.CreateSofa("Victorian");


        }
    }
}
