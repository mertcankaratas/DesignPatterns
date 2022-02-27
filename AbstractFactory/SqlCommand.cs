using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SqlCommand : Command
    {
        public override void Execute(string query)
        {
            Console.WriteLine($"Sql {query} sorgusu çalıştırılıyor");
        }
    }
}
