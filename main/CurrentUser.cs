using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace scada_bitirme
{
    class CurrentUser
    {
        databaseConfig database = new databaseConfig();
        public string username;
        public Boolean permission;
        public CurrentUser()
        {
            string mac = GetMACAddress();
            database.connection.Open();
            string sql = "SELECT username FROM currentuser WHERE id = '" + mac + "'";
            var rdr = database.select(sql);
            if (rdr.Read())
            {
                username = rdr.GetString(0);
            }
            database.connection.Close();

            database.connection.Open();
            sql = "SELECT permission FROM users WHERE username = '" + username + "'";
            rdr = database.select(sql);
            if (rdr.Read())
            {
                permission = rdr.GetBoolean(0);
            }
            database.connection.Close();
        }
        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;
            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();
                }
            }
            return sMacAddress;
        }
    }
}
