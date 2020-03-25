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
    public partial class KitapSilmeVeDuzenleme : Form
    {
        public KitapSilmeVeDuzenleme()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bin\\Debug\\KutuphaneOtomasyonu.mdb");
        int satir;
        DataSet ds = new DataSet();

        private void verigoster()
        {
            listView1.Items.Clear();
            OleDbCommand cmd = new OleDbCommand("select * from kitaplar", conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rd["kitapid"].ToString();
                ekle.SubItems.Add(rd["barkod"].ToString());
                ekle.SubItems.Add(rd["adi"].ToString());
                ekle.SubItems.Add(rd["isbn"].ToString());
                ekle.SubItems.Add(rd["yazaradi"].ToString());
                ekle.SubItems.Add(rd["yayinevi"].ToString());
                ekle.SubItems.Add(rd["sayfas"].ToString());
                ekle.SubItems.Add(rd["stoks"].ToString());
                listView1.Items.Add(ekle);
            }
        }

        private void btnfotografkitapduzenle_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\fotograflar\\kitaplar\\";
            DialogResult konum = openFileDialog1.ShowDialog();
            fotografkitap.ImageLocation = openFileDialog1.FileName;
        }

        private void btnislevler_Click(object sender, EventArgs e)
        {
            if (Ana_Sayfa.kitapsilmemi)
            {
                DialogResult cevap = MessageBox.Show("Kayıt kalıcı olarak silinecektir. İşlemi onaylamak istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo);
                if (cevap == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from kitaplar where kitapid=@kitapid";
                    cmd.Parameters.AddWithValue("@kitapid", satir);
                    cmd.ExecuteNonQuery();
                    tbaciklama.Clear();
                    tbcevirmen.Clear();
                    tbisbn.Clear();
                    tbkitap.Clear();
                    tbyayinevi.Clear();
                    tbyazar.Clear();
                    cbcilt.ResetText();
                    cbdili.ResetText();
                    cbdurumu.ResetText();
                    cbkategori.ResetText();
                    cbtemin.ResetText();
                    
                    cbturu.ResetText();
                    sayfasayisi.Value = 0;
                    stoksayisi.Value = 0;
                    baskisi.Value = 0;
                    basimt.Text = DateTime.Today.ToString();
                    temint.Text = DateTime.Today.ToString();
                    fotografkitap.ImageLocation = Application.StartupPath + "\\fotograflar\\kitaplar\\kitapload.jpg";
                    verigoster();
                    MessageBox.Show("Kayıt Silinmiştir.");
                    btnislevler.Enabled = false;
                }
            }
            else
            {
                string cevirmenadi = "";
                if ((cevirmenkontrol.Checked && tbcevirmen.Text.Length != 0))
                {
                    cevirmenadi = tbcevirmen.Text;
                }
                if (tbaciklama.Text.Length != 0 && tbisbn.Text.Length == 13 && tbkitap.Text.Length != 0 && tbyayinevi.Text.Length != 0 && tbyazar.Text.Length != 0 && cbcilt.Text.Length != 
                    0 && cbdili.Text.Length != 0 && cbdurumu.Text.Length != 0 && cbkategori.Text.Length != 0 && cbtemin.Text.Length != 0 && cbturu.Text.Length != 0 && basimt.Text.Length !=
                    0 && temint.Text.Length != 0 && sayfasayisi.Value != 0 && baskisi.Value != 0 && stoksayisi.Value >= 0)
                {
                     
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "update kitaplar set adi=@adi,isbn=@isbn,yazaradi=@yazaradi,cevirmen=@cevirmen,yayinevi=@yayinevi,sayfas=@sayfas,stoks=@stoks,baski=@baski,dil=@dil,tur=@tur,kategori=@kategori,teminbicim=@teminbicim,durum=@durum,ciltdurum=@ciltdurum,ttarihi=@ttarihi,btarihi=@btarihi,aciklama=@aciklama,fotograf=@fotograf where kitapid="+satir;
                    cmd.Parameters.AddWithValue("@adi", tbkitap.Text);
                    cmd.Parameters.AddWithValue("@isbn", tbisbn.Text);
                    cmd.Parameters.AddWithValue("@yazaradi", tbyazar.Text);
                    cmd.Parameters.AddWithValue("@cevirmen", tbcevirmen.Text);
                    cmd.Parameters.AddWithValue("@yayinevi", tbyayinevi.Text);
                    cmd.Parameters.AddWithValue("@sayfas", sayfasayisi.Value);
                    cmd.Parameters.AddWithValue("@stoks", stoksayisi.Value);
                    cmd.Parameters.AddWithValue("@baski", baskisi.Value);
                    cmd.Parameters.AddWithValue("@dil", cbdili.Text);
                    cmd.Parameters.AddWithValue("@tur", cbturu.Text);
                    cmd.Parameters.AddWithValue("@kategori", cbkategori.Text);
                    cmd.Parameters.AddWithValue("@teminbicim", cbtemin.Text);
                    cmd.Parameters.AddWithValue("@durum", cbdurumu.Text);
                    cmd.Parameters.AddWithValue("@ciltdurum", cbcilt.Text);
                    cmd.Parameters.AddWithValue("@ttarihi", temint.Text);
                    cmd.Parameters.AddWithValue("@btarihi", basimt.Text);
                    cmd.Parameters.AddWithValue("@aciklama", tbaciklama.Text);
                    cmd.Parameters.AddWithValue("@fotograf", fotografkitap.ImageLocation.ToString());
                    cmd.Parameters.AddWithValue("kitapid", satir);
                    cmd.ExecuteNonQuery();
                        verigoster();
                        MessageBox.Show("Kayıt Güncellenmiştir.");
                    }
                else
                {
                    MessageBox.Show("Lütfen boş yer bırakmayınız.");
                }
            }

        }

        private void veriarama()
        {
            listView1.Items.Clear();
            OleDbCommand cmd = new OleDbCommand("select * from kitaplar where barkod like'" + tbbarkodno.Text + "%'", conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rd["kitapid"].ToString();
                ekle.SubItems.Add(rd["barkod"].ToString());
                ekle.SubItems.Add(rd["kitapid"].ToString());
                ekle.SubItems.Add(rd["isbn"].ToString());
                ekle.SubItems.Add(rd["yazaradi"].ToString());
                ekle.SubItems.Add(rd["yayinevi"].ToString());
                ekle.SubItems.Add(rd["sayfas"].ToString());
                ekle.SubItems.Add(rd["stoks"].ToString());
                listView1.Items.Add(ekle);
            }
        }

        private void KitapSilmeVeDuzenleme_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            basimt.MaxDate = DateTime.Today;
            temint.MinDate = DateTime.Today;
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

            OleDbCommand cmd = new OleDbCommand("select * from kitaplar", conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rd["kitapid"].ToString();
                ekle.SubItems.Add(rd["barkod"].ToString());
                ekle.SubItems.Add(rd["adi"].ToString());
                ekle.SubItems.Add(rd["isbn"].ToString());
                ekle.SubItems.Add(rd["yazaradi"].ToString());
                ekle.SubItems.Add(rd["yayinevi"].ToString());
                ekle.SubItems.Add(rd["sayfas"].ToString());
                ekle.SubItems.Add(rd["stoks"].ToString());
                listView1.Items.Add(ekle);
            }
            fotografkitap.ImageLocation = Application.StartupPath + "\\fotograflar\\kitaplar\\kitapload.jpg";
            btnislevler.Enabled = false;
            cevirmenkontrol.Enabled = false;
            basimt.MaxDate =temint.MaxDate= DateTime.Today;

            if (Ana_Sayfa.kitapsilmemi)
            {
                this.Text = "Kitap Silme";
                btnislevler.Text = "Sil";
            }

            else if (Ana_Sayfa.kitapsilmemi == false)
            {
                this.Text = "Kitap Düzenleme";
                btnislevler.Text = "Güncelle";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnislevler.Enabled = true;
            if (Ana_Sayfa.kitapsilmemi == false)
            {
                tbkitap.ReadOnly = tbaciklama.ReadOnly = tbcevirmen.ReadOnly = tbisbn.ReadOnly = tbyayinevi.ReadOnly = tbyazar.ReadOnly =stoksayisi.ReadOnly = baskisi.ReadOnly = sayfasayisi.ReadOnly = false;
                cbcilt.Enabled = cbdili.Enabled = cbdurumu.Enabled = cbkategori.Enabled = cbtemin.Enabled = cbturu.Enabled = basimt.Enabled =temint.Enabled = btnfotografkitapduzenle.Enabled = btnislevler.Enabled = 
                    cevirmenkontrol.Enabled =  true;
            }
            
            try
            {
                satir = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                OleDbCommand cmd = new OleDbCommand("select * from kitaplar where kitapid=" + satir, conn);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (rd["cevirmen"].ToString().Length != 0)
                        cevirmenkontrol.Checked = true;
                    else
                        cevirmenkontrol.Checked = false;
                    tbkitap.Text = rd["adi"].ToString();
                    tbisbn.Text = rd["isbn"].ToString();
                    tbaciklama.Text = rd["aciklama"].ToString();
                    tbcevirmen.Text = rd["cevirmen"].ToString();
                    tbyayinevi.Text = rd["yayinevi"].ToString();
                    tbyazar.Text = rd["yazaradi"].ToString();
                    cbcilt.Text = rd["ciltdurum"].ToString();
                    cbdili.Text = rd["dil"].ToString();
                    cbdurumu.Text = rd["durum"].ToString();
                    cbkategori.Text = rd["kategori"].ToString();
                    cbtemin.Text = rd["teminbicim"].ToString();
                    cbturu.Text = rd["tur"].ToString();
                    sayfasayisi.Value = int.Parse(rd["sayfas"].ToString());
                    stoksayisi.Value = int.Parse(rd["stoks"].ToString());
                    baskisi.Value = int.Parse(rd["baski"].ToString());
                    fotografkitap.ImageLocation = rd["fotograf"].ToString();
                    temint.Text = rd["ttarihi"].ToString();
                    basimt.Text = rd["btarihi"].ToString();

                }
            }
            catch { }
        }

        private void tbbarkodno_TextChanged(object sender, EventArgs e)
        {
            if (tbbarkodno.Text.Length !=0)
            {
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
                    veriarama();
                }
                else
                {
                    MessageBox.Show("Lütfen ilk haneyi harf ile doldurunuz.");
                    tbbarkodno.Clear();
                    verigoster();

                }
            }
            else
                verigoster();
        }

        private void basimt_ValueChanged(object sender, EventArgs e)
        {
            temint.MinDate = DateTime.Parse(basimt.Text);
        }
    }
}
