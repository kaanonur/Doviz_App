using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Doviz_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection db = new SqlConnection("Data Source=DESKTOP-DQBE5NI;Initial Catalog=DovizUygulamasi;Integrated Security=True");


        public void ShowCurrency()
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlFile = new XmlDocument();
            xmlFile.Load(today);

            string dolarBuying = xmlFile.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblDolarAlis.Text = dolarBuying;

            string dolarSelling = xmlFile.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblDolarSatis.Text = dolarSelling;

            string euroBuying = xmlFile.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblEuroAlis.Text = euroBuying;

            string euroSelling = xmlFile.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEuroSatis.Text = euroSelling;
        }

        public void CleanTextboxes()
        {
            txtKur.Text = "";
            txtMiktar.Text = "";
            txtTutar.Text = "";
            txtMusteridenAlinan.Text = "";
            txtParaUstu.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ShowCurrency();
        }

        private void btnDolarAl_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarAlis.Text;
            lblSecilenParaBirimi.Text = "SeçilenPara";
        }

        private void btnDolarSat_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblDolarSatis.Text;
            lblSecilenParaBirimi.Text = "dolar";
        }

        private void btnEuroAl_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroAlis.Text;
            lblSecilenParaBirimi.Text = "SeçilenPara";
        }

        private void btnEuroSat_Click(object sender, EventArgs e)
        {
            txtKur.Text = lblEuroSatis.Text;
            lblSecilenParaBirimi.Text = "euro";
        }

        private void txtKur_TextChanged(object sender, EventArgs e)
        {
            txtKur.Text = txtKur.Text.Replace(".", ",");
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double kur, miktar, tutar,musteridenAlinan,paraUstu;

            if (txtKur.Text == "" || txtMiktar.Text == "" || txtMusteridenAlinan.Text == "" || txtParaUstu.Text == "" || txtTutar.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                kur = Convert.ToDouble(txtKur.Text);
                miktar = Convert.ToDouble(txtMiktar.Text);
                musteridenAlinan = Convert.ToDouble(txtMusteridenAlinan.Text);
                tutar = Convert.ToDouble(miktar * kur);
                paraUstu = Convert.ToDouble(musteridenAlinan - tutar);


                txtParaUstu.Text = paraUstu.ToString();
                txtTutar.Text = tutar.ToString();
            }
            
            

        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            if (txtKur.Text == "" || txtMiktar.Text == "" || txtMusteridenAlinan.Text == "" || txtParaUstu.Text==""||txtTutar.Text=="")
            {
                MessageBox.Show("Boş Alan Bırakmayınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lblSecilenParaBirimi.Text == "dolar")
                {
                    db.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_Money SET DOLAR=DOLAR-@P1", db);
                    SqlCommand cmd2 = new SqlCommand("UPDATE tbl_Money SET TL=TL+@P2", db);
                    cmd.Parameters.AddWithValue("@P1", Convert.ToDecimal(txtMiktar.Text));
                    cmd2.Parameters.AddWithValue("@P2", Convert.ToDecimal(txtTutar.Text));
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    db.Close();
                    MessageBox.Show("İşlem Başarılı");
                    CleanTextboxes();

                }
                else if (lblSecilenParaBirimi.Text == "euro")
                {
                    db.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_Money SET EURO=EURO-@P1", db);
                    SqlCommand cmd2 = new SqlCommand("UPDATE tbl_Money SET TL=TL+@P2", db);
                    cmd.Parameters.AddWithValue("@P1", Convert.ToDecimal(txtMiktar.Text));
                    cmd2.Parameters.AddWithValue("@P2", Convert.ToDecimal(txtTutar.Text));
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    db.Close();
                    MessageBox.Show("İşlem Başarılı");
                    CleanTextboxes();
                }
                else
                {
                    MessageBox.Show("Bu Sayfada Sadece Satış İşlemi Yapabilirsiniz!");
                }
            }

        }

        private void btnDovizHesapla_Click(object sender, EventArgs e)
        {
            Process proc = Process.Start("calc.exe");
        }
    }
}
