using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting;

namespace KutuphaneOtomosyonu
{
    public partial class raporokuyucu : Form
    {
        public raporokuyucu()
        {
            InitializeComponent();
        }

        private void raporokuyucu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'KutuphaneOtomasyonuDataSet.okuyucu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.okuyucuTableAdapter.Fill(this.KutuphaneOtomasyonuDataSet.okuyucu);

            this.reportViewer1.RefreshReport();

        }
    }
}
