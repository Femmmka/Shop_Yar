﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Shop_Yar.Data.Common
{
    public class Connection
    {
        readonly static string ConnectionData = "server=127.0.0.1;port=3306;database=Shop;uid=root;pwd;";

        public static MySqlConnection MySqlOpen()
        {
            MySqlConnection NewMySqlConnection = new MySqlConnection(ConnectionData);
            NewMySqlConnection.Open();
        }
        public static MySqlDataReader MySqlQuery(string Query, MySqlConnection Connection)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(Query, Connection);
            return NewMySqlCommand.ExecuteReader();
        }
        public static void MySqlClose(MySqlConnection connection)
        {
            connection.Close();
        }
    }
}
