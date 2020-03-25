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
    public partial class arsivrapor : Form
    {
        public arsivrapor()
        {
            InitializeComponent();
        }

        private void anlikkitaplık_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'KutuphaneOtomasyonuDataSet.arsiv' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.arsivTableAdapter.Fill(this.KutuphaneOtomasyonuDataSet.arsiv);

            this.reportViewer1.RefreshReport();
        }
    }
}
