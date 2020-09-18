using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace scada_bitirme
{
    public partial class Form1 : Form
    {
        CurrentUser crr = new CurrentUser();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SidePanel.Height = button_home.Height;
            SidePanel.Top = button_home.Top;
            firstCustomControl1.BringToFront();
            if(crr.username != "admin") // admin değilse ayarlar butonunu gizliyoruz
            {
                button_settings.Visible = false;
            }
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button_home.Height;
            SidePanel.Top = button_home.Top;
            firstCustomControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button_settings.Height;
            SidePanel.Top = button_settings.Top;
            mySecondCustmControl1.BringToFront();
        }

        private void Button_Quit_Click(object sender, EventArgs e)
        {
            /* Determines whether the user wants to exit the application.
             * If not, adds another number to the list box. */
            if(MessageBox.Show(" Uygulamadan çıkmak istediğinize emin misiniz?", "Scada", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            // The user wants to exit the application. Close everything down.
        }

        private void Button_simge_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
