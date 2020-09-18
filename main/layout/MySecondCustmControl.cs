using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace scada_bitirme
{
    public partial class MySecondCustmControl : UserControl
    {
        databaseConfig database = new databaseConfig();
        CurrentUser crrUser = new CurrentUser();

        public MySecondCustmControl()
        {
            InitializeComponent();
        }
        private void MySecondCustmControl_Load(object sender, EventArgs e)
        {
            database.connection.Open();
            string sql = "SELECT username FROM users WHERE username != 'admin'";
            var rdr = database.select(sql);
            while (rdr.Read())
            {
                comboBox_users.Items.Add(rdr.GetString(0));
            }
            database.connection.Close();
            comboBox_users.SelectedIndex = 0;


            ComboBox_users_SelectedIndexChanged(sender, e);
        }

        private void ComboBox_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            database.connection.Open();
            string sql = "SELECT permission FROM users WHERE username = '" + comboBox_users.Text + "'";
            var rdr = database.select(sql);
            if (rdr.Read())
            {
                if (rdr.GetBoolean(0) == false)
                {
                    radioButton_izleyici.Checked = true;
                }
                else
                {
                    radioButton_kontrol.Checked = true;
                }
            }
            database.connection.Close();
        }

        private void Button_kaydet_Click(object sender, EventArgs e)
        {
            string usernameCB = comboBox_users.Text;
            var permissionRB = radioButton_izleyici.Checked;
            if(permissionRB == true) // eger true ise izleyicidir
            {
                string sql = "UPDATE users SET permission = false WHERE username = '" + usernameCB + "'";
                database.update(sql);
            }
            else // kontrolcudur
            {
                string sql = "UPDATE users SET permission = true WHERE username = '" + usernameCB + "'";
                database.update(sql);
            }
        }
    }
}
