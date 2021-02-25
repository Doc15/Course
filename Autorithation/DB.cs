using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorithation
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; port=3307; user=root; password=root; database=itproger ");

        public void openConnection()//открытие соединения
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()//закрытие соединения
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }

    }
}
