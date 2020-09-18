using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace scada_bitirme
{
    /*
          we need to download the mysql connector
          * add the connector to our project
          * ( watch the video to see how ) 
          * create a connection now with mysql
          * open xampp and start mysql & apache
          * go to phpmyadmin and create the users database
          */

    class DB
    {

        private MySqlConnection connection = new MySqlConnection("Server=localhost;Database=scada;Uid=root;Pwd='';AllowUserVariables=True;UseCompression=True;");


        // create a function to open the connection
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // create a function to close the connection
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // create a function to return the connection
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
