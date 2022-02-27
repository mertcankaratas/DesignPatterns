using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MySqlCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine($"MySql {query} sorgusu çalıştırılıyor");
        }

                
    }
}
