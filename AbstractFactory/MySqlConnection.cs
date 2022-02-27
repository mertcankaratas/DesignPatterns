using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MySqlConnection : Connection
    {
        public override string State => "Open";

        public override bool Connect()
        {
            Console.WriteLine("MySqlConnection Bağlantısı Kuruluyor.");
            return true;
        }

        public override bool DisConnect()
        {
            Console.WriteLine("MySqlConnection Bağlantısı Kesiliyor.");
            return false;
        }
    }
}
