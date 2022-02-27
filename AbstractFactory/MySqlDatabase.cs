using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MySqlDatabase : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new MySqlCommand();
        }

        public override Connection CreateConnection()
        {
            return new MySqlConnection();
        }
    }
}
