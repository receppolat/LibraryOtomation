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
    public partial class GazeteGuncellemeVeSilme : Form
    {
        public GazeteGuncellemeVeSilme()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bin\\Debug\\KutuphaneOtomasyonu.mdb");
        int satir;
        DataSet ds = new DataSet();

        private void verigoster()
        {
            listView1.Items.Clear();
            OleDbCommand cmd = new OleDbCommand("select * from gazeteler", conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rd["gazeteid"].ToString();
                ekle.SubItems.Add(rd["barkod"].ToString());
                ekle.SubItems.Add(rd["adi"].ToString());
                ekle.SubItems.Add(rd["issn"].ToString());
                ekle.SubItems.Add(rd["hasardurum"].ToString());
                ekle.SubItems.Add(rd["sayfas"].ToString());
                ekle.SubItems.Add(rd["stoks"].ToString());
                ekle.SubItems.Add(rd["fiyat"].ToString());
                listView1.Items.Add(ekle);
            }
        }
        private void veriarama()
        {
            listView1.Items.Clear();
            OleDbCommand cmd = new OleDbCommand("select * from gazeteler where barkod like'"+tbbarkod.Text+"%'",conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rd["gazeteid"].ToString();
                ekle.SubItems.Add(rd["barkod"].ToString());
                ekle.SubItems.Add(rd["adi"].ToString());
                ekle.SubItems.Add(rd["issn"].ToString());
                ekle.SubItems.Add(rd["hasardurum"].ToString());
                ekle.SubItems.Add(rd["sayfas"].ToString());
                ekle.SubItems.Add(rd["stoks"].ToString());
                ekle.SubItems.Add(rd["fiyat"].ToString());
                listView1.Items.Add(ekle);
            }
        }

        private void btnislevler_Click(object sender, EventArgs e)
        {
            if (Ana_Sayfa.gazetesilmemi)
            {
                DialogResult cevap = MessageBox.Show("Kayıt kalıcı olarak silinecektir. İşlemi onaylamak istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo);
                if (cevap == DialogResult.Yes)
                {                
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from gazeteler where gazeteid=@gazeteid";
                    cmd.Parameters.AddWithValue("@gazeteid", satir);
                    cmd.ExecuteNonQuery();
                    tbsayfasayisi.ReadOnly = tbstoksayisi.ReadOnly = tbissn.ReadOnly = tbgazeteadi.ReadOnly = tbfiyat.ReadOnly = true;
                    btnislevler.Enabled=  cbhasardurumu.Enabled = btngazetefotograf.Enabled = yayimtarihi.Enabled = temintarihi.Enabled = false;
                    tbfiyat.Clear();
                    tbgazeteadi.Clear();
                    tbissn.Clear();
                    tbyonetmen.Clear();
                    cbhasardurumu.ResetText();             
                    tbsayfasayisi.Clear();
                    tbstoksayisi.Clear();
                    tbsayisi.Clear();
                    yayimtarihi.Text = DateTime.Today.ToString();
                    temintarihi.Text = DateTime.Today.ToString();
                    fotografgazeteekleme.ImageLocation = Application.StartupPath + "\\fotograflar\\gazeteler\\gazeteload.jpg";
                    verigoster();
                    MessageBox.Show("Kayıt Silinmiştir.");
                }
            }
            else 
            {                
                int tbgazeteid=1;
                Boolean gazetemi=false;
                OleDbCommand cmd2 = new OleDbCommand("select * from gazeteler", conn);
                OleDbDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    if (satir == int.Parse(dr["gazeteid"].ToString()))
                    {
                        tbgazeteid = int.Parse(dr["gazeteid"].ToString());
                        if (dr["dergimi"].ToString() == true.ToString())
                            gazetemi = false;
                        else
                            gazetemi = true;
                    }
                }
                if (gazetemi) 
                {
                    if (tbfiyat.Text.Length != 0 && tbgazeteadi.Text.Length != 0 && tbissn.Text.Length != 0 && cbhasardurumu.Text.Length != 0 && temintarihi.Text.Length != 0 &&
                    yayimtarihi.Text.Length != 0 && tbsayfasayisi.Text.Length != 0 && fotografgazeteekleme.ImageLocation.Length != 0 &&
                  tbstoksayisi.Text.Length != 0)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "update gazeteler set adi=@adi,issn=@issn,hasardurum=@hasardurum,fiyat=@fiyat,sayfas=@sayfas,stoks=@stoks,fotograf=@fotograf where gazeteid=@gazeteid";
                        cmd.Parameters.AddWithValue("@adi", tbgazeteadi.Text);
                        cmd.Parameters.AddWithValue("@issn", tbissn.Text);
                        cmd.Parameters.AddWithValue("@hasardurum", cbhasardurumu.Text);
                        cmd.Parameters.AddWithValue("@fiyat", tbfiyat.Text);
                        cmd.Parameters.AddWithValue("@sayfas", tbsayfasayisi.Text);
                        cmd.Parameters.AddWithValue("@stoks", tbstoksayisi.Text);
                        cmd.Parameters.AddWithValue("@fotograf", fotografgazeteekleme.ImageLocation.ToString());
                        cmd.Parameters.AddWithValue("@gazetelid", tbgazeteid);
                        cmd.ExecuteNonQuery();
                        verigoster();
                        MessageBox.Show("Kayıt Güncellenmiştir.");
                    }                  
                    else
                    {
                        verigoster();
                        MessageBox.Show("Lütfen yıldızlı alanları doldurunuz.", "Dikkat!" + MessageBoxIcon.Warning);
                    }
                }              
                if (gazetemi==false)
                {
                    if (tbfiyat.Text.Length != 0 && tbgazeteadi.Text.Length != 0 && tbissn.Text.Length != 0 && cbhasardurumu.Text.Length != 0 && temintarihi.Text.Length !=
              0 && yayimtarihi.Text.Length != 0 &&  tbsayisi.Text.Length != 0 && tbsayfasayisi.Text.Length != 0 && tbsayfasayisi.Text.Length != 0 && 
              tbstoksayisi.Text.Length !=0 && tbyonetmen.Text.Length != 0 && cbtur.Text.Length != 0&&fotografgazeteekleme.ImageLocation.Length!=0)
                    {
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "update gazeteler set adi=@adi,issn=@issn,hasardurum=@hasardurum,fiyat=@fiyat,sayfas=@sayfas,stoks=@stoks,sayisi=@sayisi,turu=@turu,yonetmeni=@yonetmeni,fotograf=@fotograf where gazeteid=@gazeteid";
                        cmd.Parameters.AddWithValue("@adi", tbgazeteadi.Text);
                        cmd.Parameters.AddWithValue("@issn", tbissn.Text);
                        cmd.Parameters.AddWithValue("@hasardurum", cbhasardurumu.Text);
                        cmd.Parameters.AddWithValue("@fiyat", tbfiyat.Text);
                        cmd.Parameters.AddWithValue("@sayfas", tbsayfasayisi.Text);
                        cmd.Parameters.AddWithValue("@stoks", tbstoksayisi.Text);
                        cmd.Parameters.AddWithValue("@sayisi", tbsayisi.Text);
                        cmd.Parameters.AddWithValue("@turu", cbtur.Text);
                        cmd.Parameters.AddWithValue("@yonetmeni", tbyonetmen.Text);
                        cmd.Parameters.AddWithValue("@fotograf", fotografgazeteekleme.ImageLocation.ToString());
                        cmd.Parameters.AddWithValue("@gazetelid", tbgazeteid);
                        cmd.ExecuteNonQuery();
                        verigoster();
                        MessageBox.Show("Kayıt Güncellenmiştir.");
                    }
                    else
                    {
                        verigoster();
                        MessageBox.Show("Lütfen yıldızlı alanları doldurunuz.", "Dikkat!" + MessageBoxIcon.Warning);
                    }
                }
            }           
        }

        private void GazeteGuncellemeVeSilme_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            yayimtarihi.MaxDate = DateTime.Today;
            temintarihi.MinDate = DateTime.Today;
            btnislevler.Enabled = false;
            OleDbDataAdapter da = new OleDbDataAdapter("select * from gdturler", conn);
            da.Fill(ds, "gdturler");
            cbtur.DataSource = ds.Tables["gdturler"];
            cbtur.ValueMember = "gdturid";
            cbtur.DisplayMember = "turadi";

            OleDbCommand cmd = new OleDbCommand("select * from gazeteler", conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rd["gazeteid"].ToString();
                ekle.SubItems.Add(rd["barkod"].ToString());
                ekle.SubItems.Add(rd["adi"].ToString());
                ekle.SubItems.Add(rd["issn"].ToString());
                ekle.SubItems.Add(rd["hasardurum"].ToString());
                ekle.SubItems.Add(rd["sayfas"].ToString());
                ekle.SubItems.Add(rd["stoks"].ToString());
                ekle.SubItems.Add(rd["fiyat"].ToString());
                listView1.Items.Add(ekle);
            }
            fotografgazeteekleme.ImageLocation = Application.StartupPath + "\\fotograflar\\gazeteler\\gazeteload.jpg";    
            yayimtarihi.MaxDate = DateTime.Today;
            temintarihi.MaxDate = DateTime.Today;
            if (Ana_Sayfa.gazetesilmemi)
            {
                this.Text = "Gazete ve Dergi Silme";
                btnislevler.Text = "Sil";
            }

            else if (Ana_Sayfa.gazetesilmemi == false)
            {
                this.Text = "Gazete ve Dergi Düzenleme";
                btnislevler.Text = "Güncelle";
            }
        }

        private void yayimtarihi_ValueChanged(object sender, EventArgs e)
        {
            temintarihi.MinDate = DateTime.Parse(yayimtarihi.Text);
        }

        private void btngazetefotograf_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\fotograflar\\gazeteler\\";
            DialogResult konum = openFileDialog1.ShowDialog();
            fotografgazeteekleme.ImageLocation = openFileDialog1.FileName;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {           
            try
            {
                if(Ana_Sayfa.gazetesilmemi==false)
                {
                    tbsayfasayisi.ReadOnly = tbstoksayisi.ReadOnly = tbissn.ReadOnly = tbgazeteadi.ReadOnly = tbfiyat.ReadOnly = cbtur.Enabled = false;          
                    cbhasardurumu.Enabled = btngazetefotograf.Enabled = yayimtarihi.Enabled = temintarihi.Enabled = tbsayisi.ReadOnly = tbyonetmen.ReadOnly =  true;
                }
                else
                {
                    tbsayfasayisi.ReadOnly = tbstoksayisi.ReadOnly = tbissn.ReadOnly = tbgazeteadi.ReadOnly = tbfiyat.ReadOnly = tbsayisi.ReadOnly = tbyonetmen.ReadOnly = true;
                    cbhasardurumu.Enabled = btngazetefotograf.Enabled = yayimtarihi.Enabled = temintarihi.Enabled =cbtur.Enabled = false;
                }
                btnislevler.Enabled = true;
                satir = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

                OleDbCommand cmd = new OleDbCommand("select * from gazeteler where gazeteid=" + satir, conn);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {                
                    if (rd["dergimi"].ToString()==false.ToString())
                    {
                        tbgazeteadi.Text = rd["adi"].ToString();
                        tbissn.Text = rd["issn"].ToString();
                        cbhasardurumu.Text = rd["hasardurum"].ToString();
                        tbfiyat.Text = rd["fiyat"].ToString();
                        tbsayfasayisi.Text = rd["sayfas"].ToString();
                        tbstoksayisi.Text = rd["stoks"].ToString();
                        fotografgazeteekleme.ImageLocation = rd["fotograf"].ToString();
                        cbtur.ResetText();
                        cbtur.Enabled = false;
                        tbyonetmen.Clear();
                        tbyonetmen.ReadOnly = true;
                        tbsayisi.Clear();
                        tbsayisi.ReadOnly = true;
                    }
                    else
                    {
                        tbgazeteadi.Text = rd["adi"].ToString();
                        tbissn.Text = rd["issn"].ToString();
                        cbhasardurumu.Text = rd["hasardurum"].ToString();
                        tbfiyat.Text = rd["fiyat"].ToString();
                        tbsayfasayisi.Text = rd["sayfas"].ToString();
                        tbstoksayisi.Text = rd["stoks"].ToString();
                        fotografgazeteekleme.ImageLocation = rd["fotograf"].ToString();
                        tbsayisi.Text = rd["sayisi"].ToString();
                        cbtur.Text = rd["turu"].ToString();
                        tbyonetmen.Text = rd["yonetmeni"].ToString();
                        tbsayisi.ReadOnly = false;                       
                        cbtur.Enabled = true;
                        tbyonetmen.ReadOnly = false;
                    }                   
                }
            }
            catch { }
      
        }

        private void tbbarkod_TextChanged(object sender, EventArgs e)
        {
            if(tbbarkod.Text.Length!=0)
            {
                if (tbbarkod.Text.Substring(0, 1).ToLower() == "g".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "d".ToLower())
                    veriarama();               
                else
                {
                    tbbarkod.Clear();
                    MessageBox.Show("Lütfen ilk haneyi 'G' veya 'D' giriniz.");
                }
                 
            }
            else
            {
                verigoster();
            }
        }
    }
}
