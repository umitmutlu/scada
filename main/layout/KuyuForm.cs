using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MySql.Data.MySqlClient;

namespace scada_bitirme
{
    public partial class KuyuForm : Form
    {
        Boolean muslukKazan1, muslukKuyu1, muslukKuyu1Kazan1, muslukKuyu1Kazan2;
        String valueKazan1 = "0", valueKazan1_forimg, value2 = "0", valueKuyu1 = "0";
        private string sql, data;

        int btn_start = 0, sayac_forGETdata = 0;

        databaseConfig database = new databaseConfig();
        CurrentUser crrUser = new CurrentUser();

        public KuyuForm()
        {
            InitializeComponent();
        }

        private void KuyuForm_Load(object sender, EventArgs e)
        {
            // Arduino baglantisi
            if (crrUser.username == "admin")
            {
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                    serialPort_Arduino.PortName = port;  //COM3 veya COM4 gibi portları algılayıp baglantiyi sagliyor. PC'ye 1 den fazla arduino bagli ise bu durum geçersizdir.
                serialPort_Arduino.Open();
            }

            picture_rightMusluk.Enabled = false;
            picture_kuyuMusluk.Enabled = false;
            if (crrUser.permission != true) // izleyici girdi ise sistem direkt olarak baslar ve sadece izler.
            {
                button_start.PerformClick();
                button_start.Enabled = false;
            }
        }

        private void KuyuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*if (crrUser.username == "admin")
            {
                // Admin Çıkarsa - > STOP KAZAN1
                serialPort_Arduino.Write("0"); // arduino da kazan1 motorunu durdur
                string sql = "UPDATE kazanlar SET kazan_musluk = false WHERE kazan_ad = 'Kazan1'";
                database.update(sql);
                // Admin Çıkarsa - > STOP KUYU1
                serialPort_Arduino.Write("2"); // arduino da kuyu1 motorunu durdur
                sql = "UPDATE kuyular SET kuyu_musluk = false WHERE kuyu_ad = 'Kuyu1'";
                database.update(sql);
            }*/
        }

        // KAZAN1 GRAFIK
        private void Picture_rightKazan_Click(object sender, EventArgs e)
        {
            LogsForm kuyu1 = new LogsForm("Kazan1");
            kuyu1.StartPosition = FormStartPosition.CenterScreen;
            kuyu1.FormBorderStyle = FormBorderStyle.FixedSingle;
            kuyu1.MaximizeBox = false;
            kuyu1.Show();
        }
        private void Button_kazan1_Click(object sender, EventArgs e)
        {
            Picture_rightKazan_Click(sender, e);
        }

        // KAZAN1 MUSLUK
        private void Picture_rightMusluk_Click(object sender, EventArgs e)
        {
            if (muslukKazan1 == false)
            {
                sql = "UPDATE kazanlar SET kazan_musluk = true WHERE kazan_ad = 'Kazan1'";
                database.update(sql);
                if (crrUser.username == "admin")
                    serialPort_Arduino.Write("1"); // arduino da kuyu1 motorunu calistir
            }
            else
            {
                string sql = "UPDATE kazanlar SET kazan_musluk = false WHERE kazan_ad = 'Kazan1'";
                database.update(sql);
                if (crrUser.username == "admin")
                    serialPort_Arduino.Write("0"); // arduino da kuyu1 motorunu calistir
            }
        }

        // KUYU1 GRAFIK 
        private void Picture_kuyu_Click(object sender, EventArgs e)
        {
            LogsForm kuyu1 = new LogsForm("Kuyu1");
            kuyu1.StartPosition = FormStartPosition.CenterScreen;
            kuyu1.FormBorderStyle = FormBorderStyle.FixedSingle;
            kuyu1.MaximizeBox = false;
            kuyu1.Show();
        }

        private void SerialPort_Arduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (crrUser.username == "admin") // Eger kullanıcı adminse cihaz onun pc ye baglidir ve arduinodan verileri çekip database'e kaydetmesi gerekmektedir.
            {
                char[] ayrac = { '=' };
                data = serialPort_Arduino.ReadLine();
                //if (data != null)
                //{
                Console.WriteLine("girdi : " + data);
                string[] parcalar = data.Split(ayrac);
                if (parcalar[0] == "KAZAN1")
                {
                    sql = "UPDATE kazanlar SET kazan_value = '" + parcalar[1] + "' WHERE kazan_ad = 'Kazan1'";
                    database.update(sql);
                    //valueKazan1 = parcalar[1].Trim();
                }
                if (parcalar[0] == "KUYU1")
                {
                    sql = "UPDATE kuyular SET kuyu_value = '" + parcalar[1] + "' WHERE kuyu_ad = 'Kuyu1'";
                    database.update(sql);
                    //valueKuyu1 = parcalar[1].Trim();
                }
                //}
            }
        }

        private void Picture_kuyuDolu_Click(object sender, EventArgs e)
        {
            Picture_kuyu_Click(sender, e);
        }

        private void Button_kuyu1_Click(object sender, EventArgs e)
        {
            Picture_kuyu_Click(sender, e);
        }

        // KUYU1 MUSLUK
        private void Picture_kuyuMusluk_Click(object sender, EventArgs e)
        {
            if (muslukKuyu1 == false)
            {
                sql = "UPDATE kuyular SET kuyu_musluk = true WHERE kuyu_ad = 'Kuyu1'";
                database.update(sql);
                if (crrUser.username == "admin")
                    serialPort_Arduino.Write("3"); // arduino da kuyu1 motorunu calistir
            }
            else
            {
                sql = "UPDATE kuyular SET kuyu_musluk = false WHERE kuyu_ad = 'Kuyu1'";
                database.update(sql);
                if (crrUser.username == "admin")
                    serialPort_Arduino.Write("2"); // arduino da kuyu1 motorunu calistir
            }
        }

        // TUM GRAFIKLER
        private void Button1_Click(object sender, EventArgs e)
        {
            LogsForm kuyu1 = new LogsForm("all");
            kuyu1.StartPosition = FormStartPosition.CenterScreen;
            kuyu1.FormBorderStyle = FormBorderStyle.FixedSingle;
            kuyu1.MaximizeBox = false;
            kuyu1.Show();
        }

        // KAZAN2 GRAFIK
        private void Picture_leftKazan_Click(object sender, EventArgs e)
        {
            LogsForm kuyu1 = new LogsForm("Kuyu2");
            kuyu1.StartPosition = FormStartPosition.CenterScreen;
            kuyu1.FormBorderStyle = FormBorderStyle.FixedSingle;
            kuyu1.MaximizeBox = false;
            kuyu1.Show();
        }
        private void Button_kazan2_Click(object sender, EventArgs e)
        {
            Picture_leftKazan_Click(sender, e);
        }


        private void Button_start_Click(object sender, EventArgs e)
        {
            if (btn_start == 0)
            {
                button_start.Image = Properties.Resources.icons8_stop_64;
                btn_start = 1;
                // Butonları veya diger elementleri aktif ediyoruz
                if (crrUser.permission == true) // eger kullanicinin yetkisi varsa
                {
                    picture_rightMusluk.Enabled = true;
                    picture_kuyuMusluk.Enabled = true;
                }
                // timer baslattik
                timer_forGETdata.Interval = 250;
                timer_forGETdata.Start();
            }
            else if (btn_start == 1)
            {
                button_start.Image = Properties.Resources.icons8_start_64;
                btn_start = 0;
                // Butonları veya diger elementleri pasif ediyoruz
                if (crrUser.permission == true) //eger kullanicinin yetkisi varsa
                {
                    picture_rightMusluk.Enabled = false;
                    picture_kuyuMusluk.Enabled = false;
                }
                // timer durdurduk
                timer_forGETdata.Stop();
            }
        }

        private void Timer_forGETdata(object sender, EventArgs e)
        {
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            sayac_forGETdata++;

            // GET - KAZAN1     
            if (database.connection.State == System.Data.ConnectionState.Closed)
            {
                database.connection.Open();
            }
            //database.connection.Open();
            sql = "SELECT * FROM kazanlar WHERE kazan_ad = 'Kazan1'";
            var rdr = database.select(sql);
            if (rdr.Read())
            {
                valueKazan1 = rdr.GetString(1).Trim();
                muslukKazan1 = rdr.GetBoolean(2);
            }
            if (database.connection.State == System.Data.ConnectionState.Open)
            {
                database.connection.Close();
            }
            //database.connection.Close();

            // GET - KUYU1
            if (database.connection.State == System.Data.ConnectionState.Closed)
            {
                database.connection.Open();
            }
            //database.connection.Open();
            sql = "SELECT * FROM kuyular WHERE kuyu_ad = 'Kuyu1'";
            rdr = database.select(sql);
            if (rdr.Read())
            {
                valueKuyu1 = rdr.GetString(1).Trim();
                muslukKuyu1 = rdr.GetBoolean(2);
            }
            if (database.connection.State == System.Data.ConnectionState.Open)
            {
                database.connection.Close();
            }
            //database.connection.Close();

            // SET - KAZAN1
            if (muslukKazan1 == false)
            {
                /*if (crrUser.username == "admin")
                    serialPort_Arduino.Write("0"); // arduino da kazan1 motorunu durdur*/
                picture_rightSu.Visible = false;
                lblMusluk_kazan1.Text = "Musluk : KAPALI";
                lblMuslukDot_kazan1.BackColor = Color.Red;
            }
            else if (muslukKazan1 == true)
            {
                /* if (crrUser.username == "admin")
                     serialPort_Arduino.Write("1"); // arduino da kazan1 motorunu calistir*/
                picture_rightSu.Visible = true;
                lblMusluk_kazan1.Text = "Musluk : AÇIK";
                lblMuslukDot_kazan1.BackColor = Color.Green;
            }

            lblSu_kazan1.Text = "Su Seviyesi : %" + (Int16.Parse(valueKazan1) * 100 / 1024).ToString();
            valueKazan1_forimg = (Int16.Parse(valueKazan1) * 6 / 950).ToString();

            if (valueKazan1_forimg == "0")
            {
                picture_rightKazan.Image = Properties.Resources.rightKazan0;
            }
            else if (valueKazan1_forimg == "1")
            {
                picture_rightKazan.Image = Properties.Resources.rightKazan1;
            }
            else if (valueKazan1_forimg == "2")
            {
                picture_rightKazan.Image = Properties.Resources.rightKazan2;
            }
            else if (valueKazan1_forimg == "3")
            {
                picture_rightKazan.Image = Properties.Resources.rightKazan3;
            }
            else if (valueKazan1_forimg == "4")
            {
                picture_rightKazan.Image = Properties.Resources.rightKazan4;
            }
            else if (valueKazan1_forimg == "5")
            {
                picture_rightKazan.Image = Properties.Resources.rightKazan5;
            }
            else if (valueKazan1_forimg == "6")
            {
                picture_rightKazan.Image = Properties.Resources.rightKazan6;
            }

            // SET - KUYU1
            if (muslukKuyu1 == false)
            {
                /*if(crrUser.username == "admin")
                    serialPort_Arduino.Write("2"); // arduino da kuyu1 motorunu durdur*/
                picture_kuyuMusluk.Image = Properties.Resources.muslukBos;
                picture_boru1.Image = Properties.Resources.boruBos;
                lblMusluk1_kuyu1.Text = "Musluk (Kazan1) : KAPALI";
                lblMusluk1Dot_kuyu1.BackColor = Color.Red;
            }
            else if (muslukKuyu1 == true)
            {
                /*if (crrUser.username == "admin")
                    serialPort_Arduino.Write("3"); // arduino da kuyu1 motorunu calistir*/
                picture_kuyuMusluk.Image = Properties.Resources.muslukDolu;
                picture_boru1.Image = Properties.Resources.boruDolu;
                lblMusluk1_kuyu1.Text = "Musluk (Kazan1) : AÇIK";
                lblMusluk1Dot_kuyu1.BackColor = Color.Green;
            }
            int kuyuHeight = (Int16.Parse(valueKuyu1) * 340 / 1024);
            kuyuHeight = 340 - kuyuHeight;
            picture_kuyu.Height = kuyuHeight;
            lblSu_kuyu1.Text = "Su Seviyesi : %" + (Int16.Parse(valueKuyu1) * 100 / 1024).ToString();


            if (crrUser.permission == true) // kullanicinin yetkisi varsa log tutulur
            {
                // LOG TUTMA ISLEMI
                if (sayac_forGETdata % 4 == 0) // Saniye basi buraya giriyor
                {
                    // LOG - KAZAN1
                    sql = "INSERT INTO logs(log_username,log_turu,log_value,log_musluk,update_date) VALUES ('" + crrUser.username + "','Kazan1','" + valueKazan1 + "'," + muslukKazan1 + ",'" + dateTime + "')";
                    database.insert(sql);

                    // LOG - KUYU1
                    sql = "INSERT INTO logs(log_username,log_turu,log_value,log_musluk,update_date) VALUES ('" + crrUser.username + "','Kuyu1','" + valueKuyu1 + "'," + muslukKuyu1 + ",'" + dateTime + "')";
                    database.insert(sql);
                }
            }
        }
    }
}
