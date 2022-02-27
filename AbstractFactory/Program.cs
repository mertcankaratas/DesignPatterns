using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Creater creater = new Creater(new SqlDatabase());
            Console.WriteLine("------------------------------");
            creater = new Creater(new MySqlDatabase());


        }
    }
}
