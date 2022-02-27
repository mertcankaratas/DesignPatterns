using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SqlConnection : Connection
    {

        public override string State =>"Open";

        public override bool Connect()
        {
            Console.WriteLine("SqlConnection Bağlantısı Kuruluyor.");
            return true;
        }

        public override bool DisConnect()
        {
            Console.WriteLine("SqlConnection Bağlantısı Kesiliyor.");
            return false;
        }
    }
}
