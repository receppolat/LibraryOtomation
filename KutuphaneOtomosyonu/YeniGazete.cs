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
    public partial class YeniGazete : Form
    {
        public YeniGazete()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bin\\Debug\\KutuphaneOtomasyonu.mdb");
        Random sayi = new Random();
        int barkod;
        string harf;
        public static  Boolean dergimii;
        DataSet ds = new DataSet();
        private void btngazetefotograf_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\fotograflar\\gazeteler\\";
            DialogResult konum = openFileDialog1.ShowDialog();
            fotografgazeteekleme.ImageLocation = openFileDialog1.FileName;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {

            if (gazetemi.Checked)
            {             
                if (tbbarkod.Text.Length != 0 && tbfiyat.Text.Length != 0 && tbgazeteadi.Text.Length != 0 && tbissn.Text.Length != 0 && yayimtarihi.Text.Length != 0 && temintarihi.Text.Length != 0 && stoksayisi.Value > 0 )
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into gazeteler (barkod,adi,issn,ytarihi,ttarihi,hasardurum,fiyat,sayfas,stoks,okunmasayisi,dergimi,fotograf) Values (@barkod,@adi,@issn,@ytarihi,@ttarihi,@hasardurum,@fiyat,@sayfas,@stoks,@okunmasayisi,@dergimi,@fotograf)";
                    cmd.Parameters.AddWithValue("@barkod", tbbarkod.Text);
                    cmd.Parameters.AddWithValue("@adi", tbgazeteadi.Text);
                    cmd.Parameters.AddWithValue("@issn", tbissn.Text);
                    cmd.Parameters.AddWithValue("@ytarihi", yayimtarihi.Text);
                    cmd.Parameters.AddWithValue("@ttarihi", temintarihi.Text);
                    cmd.Parameters.AddWithValue("@hasardurum", cbhasardurumu.Text);
                    cmd.Parameters.AddWithValue("@fiyat", tbfiyat.Text);
                    cmd.Parameters.AddWithValue("@sayfas", sayfasayisi.Value);
                    cmd.Parameters.AddWithValue("@stoks", stoksayisi.Value);
                    cmd.Parameters.AddWithValue("@okunmasayisi", 0);
                    cmd.Parameters.AddWithValue("@dergimi", false);
                    cmd.Parameters.AddWithValue("@fotograf", fotografgazeteekleme.ImageLocation.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Gerçekleştirilmiştir.");
                    this.Close();
                }
                else
                    MessageBox.Show("Lütfen yıldızlı (*) alanları doldurunuz.");
            }
            else if (dergimi.Checked)
            {              
                if (tbbarkod.Text.Length != 0 && tbfiyat.Text.Length != 0 && tbgazeteadi.Text.Length != 0 && tbissn.Text.Length != 0 && yayimtarihi.Text.Length != 0 && temintarihi.Text.Length != 0 && stoksayisi.Value > 0 && sayisi.Value != 0)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into gazeteler (barkod,adi,issn,ytarihi,ttarihi,hasardurum,fiyat,sayfas,stoks,sayisi,okunmasayisi,dergimi,turu,gdturid,yonetmeni,fotograf) Values (@barkod,@adi,@issn,@ytarihi,@ttarihi,@hasardurum,@fiyat,@sayfas,@stoks,@sayisi,@okunmasayisi,@dergimi,@turu,@gdturid,@yonetmeni,@fotograf)";
                    cmd.Parameters.AddWithValue("@barkod", tbbarkod.Text);
                    cmd.Parameters.AddWithValue("@adi", tbgazeteadi.Text);
                    cmd.Parameters.AddWithValue("@issn", tbissn.Text);
                    cmd.Parameters.AddWithValue("@ytarihi", yayimtarihi.Text);
                    cmd.Parameters.AddWithValue("@ttarihi", temintarihi.Text);
                    cmd.Parameters.AddWithValue("@hasardurum", cbhasardurumu.Text);
                    cmd.Parameters.AddWithValue("@fiyat", tbfiyat.Text);
                    cmd.Parameters.AddWithValue("@sayfas", sayfasayisi.Value);
                    cmd.Parameters.AddWithValue("@stoks", stoksayisi.Value);
                    cmd.Parameters.AddWithValue("@sayisi", sayisi.Value);
                    cmd.Parameters.AddWithValue("@okunmasayisi", 0);
                    cmd.Parameters.AddWithValue("@dergimi", true);
                    cmd.Parameters.AddWithValue("@turu", cbtur.Text);
                    cmd.Parameters.AddWithValue("@gdturid", cbtur.SelectedValue);
                    cmd.Parameters.AddWithValue("@yonetmeni", tbyonetmen.Text);
                    cmd.Parameters.AddWithValue("@fotograf", fotografgazeteekleme.ImageLocation.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Gerçekleştirilmiştir.");
                    this.Close();
                }
                else
                    MessageBox.Show("Lütfen yıldızlı (*) alanları doldurunuz.");
            }
            else
            {
               
                MessageBox.Show("Lütfen gazete/dergi seçimini yapınız.");
            }
              
        }

        private void YeniGazete_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            yayimtarihi.MaxDate = DateTime.Today;
            temintarihi.MinDate = DateTime.Today;
            fotografgazeteekleme.ImageLocation = Application.StartupPath + "\\fotograflar\\gazeteler\\gazeteload.jpg";
            OleDbDataAdapter da = new OleDbDataAdapter("select * from gdturler", conn);
            da.Fill(ds, "gdturler");
            cbtur.DataSource = ds.Tables["gdturler"];
            cbtur.ValueMember = "gdturid";
            cbtur.DisplayMember = "turadi";
        }

        private void dergimi_CheckedChanged(object sender, EventArgs e)
        {
            if(dergimi.Checked)
            {
                dergimii = true;
                sayisi.Enabled = true;
                labelgazete.Text = "Dergi Adı *:";
                try
                {

                    harf = dergimi.Text.Substring(0, 1);
                    tbbarkod.Text = harf + sayi.Next(10000, 100000).ToString();
                    OleDbCommand cmd = new OleDbCommand("select * from gazeteler", conn);
                    OleDbDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        barkod = sayi.Next(10000, 100000);
                        if (harf != rd["barkod"].ToString())
                        {
                            tbbarkod.Text =harf + barkod.ToString();
                        }
                        else
                        {
                            barkod = sayi.Next(10000, 100000);
                            tbbarkod.Text =harf + barkod.ToString();
                        }
                    }
                }
                catch { }
               
                dergisilemleri.Enabled = true;
            }
                
            else
            {
                dergimii = false;
                labelgazete.Text = "Gazete Adı *:";
                sayisi.Enabled = false;
                try
                {

                    harf = gazetemi.Text.Substring(0, 1);
                    tbbarkod.Text = harf + sayi.Next(10000, 100000).ToString();
                    OleDbCommand cmd = new OleDbCommand("select * from gazeteler", conn);
                    OleDbDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        barkod = sayi.Next(10000, 100000);
                        if (harf != rd["barkod"].ToString())
                        {
                            tbbarkod.Text =harf + barkod.ToString();
                        }
                        else
                        {
                            barkod = sayi.Next(10000, 100000);
                            tbbarkod.Text = harf + barkod.ToString();
                        }
                    }
                }
                catch { }
               
                dergisilemleri.Enabled = false;
            }
               
        }

        private void gazetemi_CheckedChanged(object sender, EventArgs e)
        {
            if (gazetemi.Checked)
            {
                dergimii = false;
                labelgazete.Text = "Gazete Adı *:";
                sayisi.Enabled = false;
                try
                {

                    harf = gazetemi.Text.Substring(0, 1);
                    tbbarkod.Text = harf + sayi.Next(10000, 100000).ToString();
                    OleDbCommand cmd = new OleDbCommand("select * from gazeteler", conn);
                    OleDbDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        barkod = sayi.Next(10000, 100000);
                        if (harf != rd["barkod"].ToString())
                        {
                            tbbarkod.Text = harf + barkod.ToString();
                        }
                        else
                        {
                            barkod = sayi.Next(10000, 100000);
                            tbbarkod.Text = harf + barkod.ToString();
                        }
                    }
                }
                catch { }    
                dergisilemleri.Enabled = false;
            }
                
            else
            {
                dergimii = true;
                sayisi.Enabled = true;
                labelgazete.Text = "Dergi Adı *:";
                try
                {

                    harf = dergimi.Text.Substring(0, 1);
                    tbbarkod.Text = harf + sayi.Next(10000, 100000).ToString();
                    OleDbCommand cmd = new OleDbCommand("select * from gazeteler", conn);
                    OleDbDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        barkod = sayi.Next(10000, 100000);
                        if (harf != rd["barkod"].ToString())
                        {
                            tbbarkod.Text = harf + barkod.ToString();
                        }
                        else
                        {
                            barkod = sayi.Next(10000, 100000);
                            tbbarkod.Text = harf + barkod.ToString();
                        }
                    }
                }
                catch { } 
                dergisilemleri.Enabled = true;
            }
             
        }

        private void yayimtarihi_ValueChanged(object sender, EventArgs e)
        {
            temintarihi.MinDate = DateTime.Parse(yayimtarihi.Text);
        }
    }
}
