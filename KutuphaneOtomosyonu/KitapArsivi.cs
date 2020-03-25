using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KutuphaneOtomosyonu
{
    public partial class KitapArsivi : Form
    {
        public KitapArsivi()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bin\\Debug\\KutuphaneOtomasyonu.mdb");
        DataSet ds = new DataSet();
        string musait, gonderilen;

        private void verigoster(string cumlecik)
        {
            listView1.Items.Clear();
            OleDbCommand cmd = new OleDbCommand(cumlecik, conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {            
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rd["kitapid"].ToString();
                ekle.SubItems.Add(rd["barkod"].ToString());
                ekle.SubItems.Add(rd["adi"].ToString());
                ekle.SubItems.Add(rd["isbn"].ToString());
                ekle.SubItems.Add(rd["yazaradi"].ToString());
                ekle.SubItems.Add(rd["cevirmen"].ToString());
                ekle.SubItems.Add(rd["yayinevi"].ToString());
                ekle.SubItems.Add(rd["sayfas"].ToString());
                ekle.SubItems.Add(rd["stoks"].ToString());
                ekle.SubItems.Add(rd["baski"].ToString());
                ekle.SubItems.Add(rd["dil"].ToString());
                ekle.SubItems.Add(rd["tur"].ToString());
                ekle.SubItems.Add(rd["kategori"].ToString());
                ekle.SubItems.Add(rd["teminbicim"].ToString());
                ekle.SubItems.Add(rd["durum"].ToString());
                ekle.SubItems.Add(rd["ciltdurum"].ToString());
                ekle.SubItems.Add(rd["ttarihi"].ToString());
                ekle.SubItems.Add(rd["btarihi"].ToString());
                ekle.SubItems.Add(rd["okunmasayisi"].ToString());
                ekle.SubItems.Add(rd["aciklama"].ToString());
                if (rd["musaitmi"].ToString() == "1")
                {
                    ekle.BackColor = Color.Green;
                }           
                else
                {
                    ekle.BackColor = Color.Red;
                }         
                listView1.Items.Add(ekle);
            }
        }

        private void KitapArsivi_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            
            OleDbDataAdapter dakkategoriler = new OleDbDataAdapter("select * from kkategoriler", conn);
            dakkategoriler.Fill(ds, "kkategoriler");
            cbkategori.DataSource = ds.Tables["kkategoriler"];
            cbkategori.ValueMember = "kkategorid";
            cbkategori.DisplayMember = "kkategoriadi";
            cbturu.ValueMember = "kturid";

            OleDbDataAdapter dakkturler = new OleDbDataAdapter("select * from kturler", conn);
            dakkturler.Fill(ds, "kturler1");
            cbturu.DataSource = ds.Tables["kturler1"];
            cbturu.ValueMember = "kturid";
            cbturu.DisplayMember = "kturadi";
            gonderilen = "select * from kitaplar";
            verigoster(gonderilen);
        }

        private void tbkitap_TextChanged(object sender, EventArgs e)
        {
            if(tbkitap.Text.Length!=0)
            {
                tbisbn.Enabled = tbbarkodno.Enabled = tbyazar.Enabled = cbdili.Enabled = cbdurumu.Enabled = cbkategori.Enabled = cbturu.Enabled = false;
                gonderilen = "select * from kitaplar where adi like'" + tbkitap.Text + "%'";
                verigoster(gonderilen);
            }
            else
            {
                tbisbn.Enabled = tbbarkodno.Enabled = tbyazar.Enabled = cbdili.Enabled = cbdurumu.Enabled = cbkategori.Enabled = cbturu.Enabled = true;
                gonderilen = "select * from kitaplar";
                verigoster(gonderilen);
            }
        }

        private void tbyazar_TextChanged(object sender, EventArgs e)
        {

            if (tbyazar.Text.Length != 0)
            {
                tbisbn.Enabled = tbbarkodno.Enabled = tbkitap.Enabled = cbdili.Enabled = cbdurumu.Enabled = cbkategori.Enabled = cbturu.Enabled = false;
                gonderilen = "select * from kitaplar where yazaradi like'" + tbyazar.Text + "%'";
                verigoster(gonderilen);
            }
            else
            {
                tbisbn.Enabled = tbbarkodno.Enabled = tbkitap.Enabled = cbdili.Enabled = cbdurumu.Enabled = cbkategori.Enabled = cbturu.Enabled = true;
                gonderilen = "select * from kitaplar";
                verigoster(gonderilen);
            }
           
        }

        private void tbisbn_TextChanged(object sender, EventArgs e)
        {
            if (tbisbn.Text.Length != 0)
            {
                tbyazar.Enabled = tbbarkodno.Enabled = tbkitap.Enabled = cbdili.Enabled = cbdurumu.Enabled = cbkategori.Enabled = cbturu.Enabled = false;
                gonderilen = "select * from kitaplar where isbn like'" + tbisbn.Text + "%'";
                verigoster(gonderilen);
            }
            else
            {
                tbyazar.Enabled = tbbarkodno.Enabled = tbkitap.Enabled = cbdili.Enabled = cbdurumu.Enabled = cbkategori.Enabled = cbturu.Enabled = true;
                gonderilen = "select * from kitaplar";
                verigoster(gonderilen);
            }
        }

        private void cbturu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbturu.Text.Length != 0)
            {             
                gonderilen = "select * from kitaplar where tur like'" + cbturu.Text + "%'";
                verigoster(gonderilen);
            }
            else
            {
                gonderilen = "select * from kitaplar";
                verigoster(gonderilen);
            }
        }

        private void cbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkategori.Text.Length != 0)
            { 
                gonderilen = "select * from kitaplar where kategori like'" + cbkategori.Text + "%'";
                verigoster(gonderilen);
            }
            else
            {
                gonderilen = "select * from kitaplar";
                verigoster(gonderilen);
            }
        }

        private void cbdurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbdurumu.Text.Length != 0)
            {
                gonderilen = "select * from kitaplar where durum like'" + cbdurumu.Text + "%'";
                verigoster(gonderilen);
            }
            else
            {
                gonderilen = "select * from kitaplar";
                verigoster(gonderilen);
            }
        }

        private void cbdili_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbdili.Text.Length != 0)
            {
                gonderilen = "select * from kitaplar where dil like'" + cbdili.Text + "%'";
                verigoster(gonderilen);
            }
            else
            {
                gonderilen = "select * from kitaplar";
                verigoster(gonderilen);
            }
        }

        private void tbbarkodno_TextChanged(object sender, EventArgs e)
        {
            try {
               
                if (tbbarkodno.Text.Length != 0)
                {
                    tbisbn.Enabled = tbkitap.Enabled = tbyazar.Enabled = cbdili.Enabled = cbdurumu.Enabled = cbkategori.Enabled = cbturu.Enabled = false;

                    if (tbbarkodno.Text.Substring(0, 1).ToLower() == "a".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "b".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "c".ToLower() ||
                        tbbarkodno.Text.Substring(0, 1).ToLower() == "ç".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "d".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "e".ToLower() ||
                        tbbarkodno.Text.Substring(0, 1).ToLower() == "f".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "g".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "h".ToLower() ||
                        tbbarkodno.Text.Substring(0, 1).ToLower() == "ı".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "i".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "k".ToLower() ||
                        tbbarkodno.Text.Substring(0, 1).ToLower() == "l".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "m".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "n".ToLower() ||
                        tbbarkodno.Text.Substring(0, 1).ToLower() == "o".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "ö".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "p".ToLower() ||
                        tbbarkodno.Text.Substring(0, 1).ToLower() == "r".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "s".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "ş".ToLower() ||
                        tbbarkodno.Text.Substring(0, 1).ToLower() == "t".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "u".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "ü".ToLower() ||
                        tbbarkodno.Text.Substring(0, 1).ToLower() == "v".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "y".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "z".ToLower() ||
                        tbbarkodno.Text.Substring(0, 1).ToLower() == "q".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "w".ToLower())
                    {
                        gonderilen = "select * from kitaplar where barkod like'" + tbbarkodno.Text + "%'";
                        verigoster(gonderilen);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen ilk haneyi harf ile doldurunuz.");
                        tbbarkodno.Clear();
                        gonderilen = "select * from kitaplar";
                        verigoster(gonderilen);

                    }
                }
                else
                {
                    tbisbn.Enabled = tbkitap.Enabled = tbyazar.Enabled = cbdili.Enabled = cbdurumu.Enabled = cbkategori.Enabled = cbturu.Enabled = true;
                    gonderilen = "select * from kitaplar";
                    verigoster(gonderilen);
                }
            }
            catch { }
            
           
        }
    }
}
