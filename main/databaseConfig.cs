using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace scada_bitirme
{
    class databaseConfig
    {
        public MySqlConnection connection;
        public databaseConfig()
        {
            connection = new MySqlConnection("Server=localhost;Database=scada;Uid=root;Pwd='';AllowUserVariables=True;UseCompression=True;");
        }
        public MySqlDataReader select(string sql)
        {
            var cmd = new MySqlCommand(sql, connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }
        public void insert(string sql)
        {
            try
            {
                var cmd = new MySqlCommand();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd.Connection = connection;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex) // This will catch all SQL exceptions
            {
                MessageBox.Show("Execute exception issue: " + ex.Message);
            }
            finally // don't forget to close your connection when exception occurs.
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public void update(string sql)
        {
            try
            {
                var cmd = new MySqlCommand();
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                cmd.Connection = connection;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex) // This will catch all SQL exceptions
            {
                MessageBox.Show("Execute exception issue: " + ex.Message);
            }
            finally // don't forget to close your connection when exception occurs.
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    }
}
