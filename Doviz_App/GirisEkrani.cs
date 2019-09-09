using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doviz_App
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnDovizAl_Click(object sender, EventArgs e)
        {
            Form1 dovizAl = new Form1();
            dovizAl.Show();
        }

        private void btnDovizSat_Click(object sender, EventArgs e)
        {
            Form2 dovizSat = new Form2();
            dovizSat.Show();
        }

        private void btnGuncelKurDurumu_Click(object sender, EventArgs e)
        {
            GuncelKur guncelKur = new GuncelKur();
            guncelKur.Show();
        }

        private void btnKasaDurumu_Click(object sender, EventArgs e)
        {
            KasaDurumu kasaDurumu = new KasaDurumu();
            kasaDurumu.Show();
        }
    }
}
