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
    public partial class personelrapor : Form
    {
        public personelrapor()
        {
            InitializeComponent();
        }

        private void repor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'KutuphaneOtomasyonuDataSet.personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelTableAdapter.Fill(this.KutuphaneOtomasyonuDataSet.personel);



            this.reportViewer1.RefreshReport();
        }
    }
}
