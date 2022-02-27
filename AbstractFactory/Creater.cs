using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
   public class Creater
    {
        DatabaseFactory _databaseFactory;
        Connection _connection;
        Command _command;

        public Creater(DatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _connection = databaseFactory.CreateConnection();
            _command = databaseFactory.CreateCommand();
            Start();
        }


        public void Start()
        {
            if(_connection.State == "Open")
            {
                _connection.Connect();
                _command.Execute("Select * from TABLE where .....");
                _connection.DisConnect();
            }
        }
    }
}
