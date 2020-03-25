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
    public partial class kitaprapor : Form
    {
        public kitaprapor()
        {
            InitializeComponent();
        }

        private void kitaprapor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'KutuphaneOtomasyonuDataSet.kitaplar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitaplarTableAdapter.Fill(this.KutuphaneOtomasyonuDataSet.kitaplar);

            this.reportViewer1.RefreshReport();
        }
    }
}
