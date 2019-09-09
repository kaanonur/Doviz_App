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
    public partial class GuncelKur : Form
    {
        public GuncelKur()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void GuncelKur_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
        }
    }
}
