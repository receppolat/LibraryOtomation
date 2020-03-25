using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomosyonu
{
    public partial class okuyucukontenjanrapor : Form
    {
        public okuyucukontenjanrapor()
        {
            InitializeComponent();
        }

        private void raporcs_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'KutuphaneOtomasyonuDataSet.okuyucukitapkontenjan' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.okuyucukitapkontenjanTableAdapter.Fill(this.KutuphaneOtomasyonuDataSet.okuyucukitapkontenjan);

            this.reportViewer1.RefreshReport();
        }
    }
}
