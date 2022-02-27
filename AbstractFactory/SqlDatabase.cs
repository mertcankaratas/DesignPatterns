using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SqlDatabase : DatabaseFactory
    {
        public override Command CreateCommand()
        {
            return new SqlCommand();
        }

        public override Connection CreateConnection()
        {
            return new SqlConnection();
        }
    }
}
