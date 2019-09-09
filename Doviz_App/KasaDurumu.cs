using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doviz_App
{
    public partial class KasaDurumu : Form
    {
        public KasaDurumu()
        {
            InitializeComponent();
        }

        SqlConnection db = new SqlConnection("Data Source=DESKTOP-DQBE5NI;Initial Catalog=DovizUygulamasi;Integrated Security=True");


        private void KasaDurumu_Load(object sender, EventArgs e)
        {

            db.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Money", db);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                btnTL.Text = dr[0].ToString()+" ₺";
                btnEuro.Text = dr[1].ToString() + " €";
                btnDolar.Text = dr[2].ToString() + " $";
            }
            db.Close();


        }
    }
}
