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
    public partial class anlikgazete : Form
    {
        public anlikgazete()
        {
            InitializeComponent();
        }

        private void anlikkitaplik_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'KutuphaneOtomasyonuDataSet.okuyucugazetekontenjan' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.okuyucugazetekontenjanTableAdapter.Fill(this.KutuphaneOtomasyonuDataSet.okuyucugazetekontenjan);

            this.reportViewer1.RefreshReport();
        }
    }
}
