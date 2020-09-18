using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace scada_bitirme
{
    public partial class LogsForm : Form
    {
        databaseConfig database = new databaseConfig();

        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlDataAdapter da;
        string sql,tur;
        string tarih;
        double su_degeri;        

        public LogsForm(string text)
        {
            InitializeComponent();
            tur = text;
        }

        private void LogsForm_Load(object sender, EventArgs e)
        {
            if (tur == "Kazan1")
            {
                baglanti = new MySqlConnection("Server=localhost;Database=scada;Uid=root;Pwd='';AllowUserVariables=True;UseCompression=True;");
                da = new MySqlDataAdapter("SELECT * FROM logs WHERE log_turu='" + tur + "' ORDER BY update_date desc", baglanti);
                System.Console.WriteLine("burdayızz" + da);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGrid_logs.AutoGenerateColumns = false;
                dataGrid_logs.DataSource = tablo;
                database.connection.Close();

                grafik_ciz(tur);                               
            }
            else if (tur == "Kuyu1")
            {
                baglanti = new MySqlConnection("Server=localhost;Database=scada;Uid=root;Pwd='';AllowUserVariables=True;UseCompression=True;");
                da = new MySqlDataAdapter("SELECT * FROM logs WHERE log_turu='" + tur + "' ORDER BY update_date DESC", baglanti);
                System.Console.WriteLine("burdayızz" + da);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGrid_logs.AutoGenerateColumns = false;
                dataGrid_logs.DataSource = tablo;

                grafik_ciz(tur);
            }
            else if (tur == "all")
            {
                this.Width = chart_logs.Width + 32;
                grafik_ciz_all();
            }
        }

        private void grafik_ciz(string isim)
        {
            // grafik cizimi
            chart_logs.Titles.Clear();//Chart da varsayılan olarak gelen başlıkları temizliyoruz.
            chart_logs.Series.Clear();//Chart da varsayılan olarak gelen series (Liste) temizliyoruz.
            chart_logs.Series.Add(isim);
            chart_logs.Series[isim].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            chart_logs.ChartAreas[0].AxisY.Maximum = 100;
            chart_logs.ChartAreas[0].AxisY.Interval = 10;
            chart_logs.ChartAreas[0].AxisY.Title = "Yüzde (%)";
            chart_logs.ChartAreas[0].AxisX.Title = "Tarih";

            database.connection.Open();
            sql = "SELECT * FROM logs WHERE log_turu = '" + isim + "'";
            var rdr = database.select(sql);
            while (rdr.Read())
            {
                su_degeri = Convert.ToDouble(rdr.GetString(3));
                su_degeri = su_degeri * 100.0 / 1024.0;
                tarih = rdr.GetDateTime(5).ToString("HH:mm:ss");
                chart_logs.Series[isim].Points.AddXY(tarih, su_degeri);//x parametresi altta yazacak yazıyı belirliyor y ise o yazının değerini belirliyor.
                                                                           //valueKazan1 = rdr.GetString(1);
                                                                           //muslukKazan1 = rdr.GetBoolean(2);
            }
            database.connection.Close();
        }
        private void grafik_ciz_all()
        {
            // grafik cizimi
            chart_logs.Titles.Clear();//Chart da varsayılan olarak gelen başlıkları temizliyoruz.
            chart_logs.Series.Clear();//Chart da varsayılan olarak gelen series (Liste) temizliyoruz.
            chart_logs.Series.Add("Kuyu1");
            chart_logs.Series["Kuyu1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart_logs.Series.Add("Kazan1");
            chart_logs.Series["Kazan1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart_logs.ChartAreas[0].AxisY.Maximum = 100;
            chart_logs.ChartAreas[0].AxisY.Interval = 10;
            chart_logs.ChartAreas[0].AxisY.Title = "Yüzde (%)";
            chart_logs.ChartAreas[0].AxisX.Title = "Tarih";

            database.connection.Open();
            sql = "SELECT * FROM logs WHERE log_turu = 'Kuyu1'";
            var rdr = database.select(sql);
            while (rdr.Read())
            {
                su_degeri = Convert.ToDouble(rdr.GetString(3));
                su_degeri = su_degeri * 100.0 / 1024.0;
                tarih = rdr.GetDateTime(5).ToString("HH:mm:ss");
                chart_logs.Series["Kuyu1"].Points.AddXY(tarih, su_degeri);//x parametresi altta yazacak yazıyı belirliyor y ise o yazının değerini belirliyor.
            }
            database.connection.Close();

            database.connection.Open();
            sql = "SELECT * FROM logs WHERE log_turu = 'Kazan1'";
            rdr = database.select(sql);
            while (rdr.Read())
            {
                su_degeri = Convert.ToDouble(rdr.GetString(3));
                su_degeri = su_degeri * 100.0 / 1024.0;
                tarih = rdr.GetDateTime(5).ToString("HH:mm:ss");
                chart_logs.Series["Kazan1"].Points.AddXY(tarih, su_degeri);//x parametresi altta yazacak yazıyı belirliyor y ise o yazının değerini belirliyor.
            }
            database.connection.Close();
        }
    }
}
