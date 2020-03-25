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
    public partial class Yeni_Kitap : Form
    {
        public Yeni_Kitap()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bin\\Debug\\KutuphaneOtomasyonu.mdb");
        Random sayi = new Random();
        int barkod;
        DataSet ds = new DataSet();

        private void btnfotografkitap_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\fotograflar\\kitaplar\\";
            DialogResult konum = openFileDialog1.ShowDialog();
            fotografkitap.ImageLocation = openFileDialog1.FileName;
        }

        private void Yeni_Kitap_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            basimt.MaxDate = DateTime.Today;
            temint.MinDate = DateTime.Today;
            try
            {
                string basharf = cbkategori.Text.Substring(0, 1);               
                OleDbCommand cmd = new OleDbCommand("select * from kitaplar", conn);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    barkod = sayi.Next(9999, 99999);
                    if (basharf != rd["barkod"].ToString())
                    {
                        tbbarkodno.Text = basharf + barkod.ToString();
                    }
                    else
                    {
                        barkod = sayi.Next(9999, 99999);
                        tbbarkodno.Text = basharf + barkod.ToString();
                    }
                }
            }
            catch { }

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

            fotografkitap.ImageLocation = Application.StartupPath + "\\fotograflar\\kitaplar\\kitapload.jpg";
            temint.MaxDate = basimt.MaxDate = DateTime.Today;
        }

        private void btnkitapekle_Click(object sender, EventArgs e)
        {
            string cevirmenadi="";
            if ((cevirmenkontrol.Checked && tbcevirmen.Text.Length != 0))
            {
                cevirmenadi = tbcevirmen.Text;
            }
            if (tbaciklama.Text.Length != 0 && tbbarkodno.Text.Length != 0 &&  tbisbn.Text.Length == 13 && tbkitap.Text.Length != 0 && tbyayinevi.Text.Length != 0 && tbyazar.Text.Length != 0 &&
                cbcilt.Text.Length != 0 && cbdili.Text.Length != 0 && cbdurumu.Text.Length != 0 && cbkategori.Text.Length != 0 && cbtemin.Text.Length != 0 && cbturu.Text.Length != 0 &&
                fotografkitap.ImageLocation.Length != 0 && sayfasayisi.Value != 0 && stoksayisi.Value != 0 && baskisi.Value != 0 && basimt.Text.Length != 0 && temint.Text.Length != 0)
            {

                for (int i = 1;i<= stoksayisi.Value;i++)
                {

                    try
                    {
                        string basharf = cbkategori.Text.Substring(0, 1);
                        OleDbCommand cmd1 = new OleDbCommand("select * from kitaplar", conn);
                        OleDbDataReader rd = cmd1.ExecuteReader();
                        while (rd.Read())
                        {
                            barkod = sayi.Next(9999, 99999);
                            if (basharf != rd["barkod"].ToString())
                            {
                                tbbarkodno.Text = basharf + barkod.ToString();
                            }
                            else
                            {
                                barkod = sayi.Next(9999, 99999);
                                tbbarkodno.Text = basharf + barkod.ToString();
                            }
                        }
                    }
                    catch { }

                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into kitaplar (barkod,isbn,adi,yazaradi,cevirmen,yayinevi,sayfas,stoks,baski,dil,tur,kategori,teminbicim,durum,ciltdurum,ttarihi,btarihi,aciklama,kturid,kkategorid,musaitmi,fotograf) Values (@barkod,@isbn,@adi,@yazaradi,@cevirmen,@yayinevi,@sayfas,@stoks,@baski,@dil,@tur,@kategori,@teminbicim,@durum,@ciltdurum,@ttarihi,@btarihi,@aciklama,@kturid,@kkategorid,@musaitmi,@fotograf)";
                    cmd.Parameters.AddWithValue("@barkod", tbbarkodno.Text);
                    cmd.Parameters.AddWithValue("@isbn", tbisbn.Text);
                    cmd.Parameters.AddWithValue("@adi", tbkitap.Text);
                    cmd.Parameters.AddWithValue("@yazaradi", tbyazar.Text);
                    cmd.Parameters.AddWithValue("@cevirmen", cevirmenadi);
                    cmd.Parameters.AddWithValue("@yayinevi", tbyayinevi.Text);
                    cmd.Parameters.AddWithValue("@sayfas", sayfasayisi.Value);
                    cmd.Parameters.AddWithValue("@stoks", "1");
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
                    cmd.Parameters.AddWithValue("@kturid", cbturu.SelectedValue);
                    cmd.Parameters.AddWithValue("@kkategorid", cbkategori.SelectedValue);
                    cmd.Parameters.AddWithValue("@musaitmi", "1");
                    cmd.Parameters.AddWithValue("@fotograf", fotografkitap.ImageLocation.ToString());
                    cmd.ExecuteNonQuery();
                    
                }
                MessageBox.Show("Kayıt Gerçekleştirilmiştir.");

                this.Close();
                   
            }
            else
                MessageBox.Show("Lütfen bütün bilgileri eksiksiz ve hatasız doldurunuz.");
        }

        private void cbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string basharf = cbkategori.Text.Substring(0, 1);
                OleDbCommand cmd = new OleDbCommand("select * from kitaplar", conn);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    barkod = sayi.Next(9999, 99999);
                    if (basharf != rd["barkod"].ToString())
                    {
                        tbbarkodno.Text = basharf + barkod.ToString();
                    }
                    else
                    {
                        barkod = sayi.Next(9999, 99999);
                        tbbarkodno.Text = basharf + barkod.ToString();
                    }
                }
            }
            catch { }
           
        }

        private void basimt_ValueChanged(object sender, EventArgs e)
        {
            temint.MinDate = DateTime.Parse(basimt.Text);
        }
    }
}
