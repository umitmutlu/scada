using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace scada_bitirme
{
    public partial class FirstCustomControl : UserControl
    {
        String dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        int EklenenButonlar_Width;
        int Soldan, Ustten;

        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlDataAdapter da;
        databaseConfig database = new databaseConfig();

        public FirstCustomControl()
        {
            InitializeComponent();
        }
        private void FirstCustomControl_Load(object sender, EventArgs e)
        {
            dinamikKuyu();
        }

        void dinamikKuyu()
        {
            this.Controls.Clear();
            EklenenButonlar_Width = 200;
            Soldan = 100;
            Ustten = 100;
            database.connection.Open();
            string sql = "SELECT kuyu_ad FROM kuyular";
            var rdr = database.select(sql);
            while (rdr.Read())
            {
                //Console.WriteLine(rdr[0] + " " + rdr[1] + " " + rdr[2] + " " + rdr[3]);
                butonEkle(rdr.GetString(0));
            }
            database.connection.Close();
        }

        void butonEkle(String kuyu_ad)
        {
            Button btn = new Button()
            {
                Height = 200,
                Width = 210,
                Text = kuyu_ad,
                TextAlign = ContentAlignment.TopCenter,
                Name = "btn_" + kuyu_ad,
                FlatStyle = FlatStyle.Flat,
                Image = global::scada_bitirme.Properties.Resources.kuyuDolu2,
                Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
            };

            btn.FlatAppearance.BorderSize = 0;

            btn.Click += new EventHandler(btn_Click);

            this.Controls.Add(btn);
            // Panel içine butonu Ekledik.
            // butonun nerede duracağını ekleme işlemini yaptıktan sonra belirleyebiliriz.
            // mantıken düşündüğümüzde eklenmemiş bir nesnenin konumunu ayarlayamayız.

            Soldan = (int)(btn.Width * ((float)EklenenButonlar_Width / (float)btn.Width));
            // dikeyde eklenen butonların yüksekliklerinden yola çıkarak, üstten bırakılacak boşluğu buluyoruz                

            EklenenButonlar_Width += btn.Width + 50;
            // eklenen butonların dikeyde toplam boyutu kaç piksel?
            // bu değeri, panel yüksekliği  ile dikeyde eklenen butonların toplam yüksekliği değerlerini karşılaştırdıktan sonra
            // dikeyde yer kalmadıysai, sağına geçip devam etmesi için alıyoruz.

            switch (EklenenButonlar_Width > this.Width)
            // butonların boyutu ekrana sığmıyorsa?
            {
                case true:
                    Soldan = 200;
                    // en üstten başla

                    Ustten += btn.Height + 25;
                    // soldan buton genişliği kadar boşluk bırak.
                    // bir stun boyunca ekledikten sonra sağına geçip devam edecek
                    // ama soldan kaç pksel boşluk bırakacak onu burada belirliyoruz.

                    EklenenButonlar_Width = btn.Width + 250;
                    // ikinci stuna geçtiğimizden dolayı sıfırladık
                    break;
            }
            btn.Location = new Point(Soldan, Ustten); // konumunu ayarladık
                                                      // dediğimiz gibi buton eklendikten sonra konumu ayarlanabilir.

        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //MessageBox.Show("Text: " + btn.Text + " - Name: " + btn.Name);
            if (btn.Text == "Kuyu1")
            {
                KuyuForm kuyu1 = new KuyuForm();
                kuyu1.StartPosition = FormStartPosition.CenterScreen;
                kuyu1.FormBorderStyle = FormBorderStyle.FixedSingle;
                kuyu1.MaximizeBox = false;
                kuyu1.Show();
            }
            else
            {
                MessageBox.Show("Bu kuyular daha aktif edilmemiştir.");
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            // calisiyor burasi
            /*baglanti = new MySqlConnection("Server=localhost;Database=ecat_db;Uid=root;Pwd='';AllowUserVariables=True;UseCompression=True;");
            da = new MySqlDataAdapter("Select * from user", baglanti);
            System.Console.WriteLine("burdayızz"+da);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;*/

            //string cs = @"Server=localhost;Database=ecat_db;Uid=root;Pwd='';AllowUserVariables=True;UseCompression=True;";
            //var con = new MySqlConnection(cs);
            //con.Open();


            /*database.connection.Open();
            string sql = "SELECT * FROM user";
            var rdr = database.select(sql);
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " " + rdr[1] + " " + rdr[2] + " " + rdr[3]);
            }
            database.connection.Close();*/
            String sorgu = "insert into kazanlar(kazan_ad,ilce_ref) values ('Kazan1',0)";
            database.insert(sorgu);
        }
    }
}
