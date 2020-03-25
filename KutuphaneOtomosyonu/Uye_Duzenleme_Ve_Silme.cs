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
    public partial class Uye_Duzenleme_Ve_Silme : Form
    {
        public Uye_Duzenleme_Ve_Silme()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bin\\Debug\\KutuphaneOtomasyonu.mdb");
        int satir;
        string okuyucu;
        DataSet ds = new DataSet();
        string gonderilen;
        private void verigoster(string cumlecik)
        {
            listView1.Items.Clear();
            OleDbCommand cmd = new OleDbCommand(cumlecik, conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rd["okuyucuid"].ToString();
                ekle.SubItems.Add( rd["tckimlik"].ToString());
                ekle.SubItems.Add(rd["pasaportkimlik"].ToString());
                ekle.SubItems.Add(rd["adi"].ToString());
                ekle.SubItems.Add(rd["soyadi"].ToString());
                ekle.SubItems.Add(rd["okuyucutipi"].ToString());
                ekle.SubItems.Add(rd["telefon"].ToString());
                ekle.SubItems.Add(rd["mail"].ToString());
                listView1.Items.Add(ekle);
            }
        }

        private void Uye_Duzenleme_Ve_Silme_Load(object sender, EventArgs e)
        {
            rbakademisyen.Enabled = rblise.Enabled = rbokul.Enabled = rbüni.Enabled = false;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            btnislevler.Enabled = false;
            dtarihi.MaxDate = DateTime.Now.AddYears(-7);
            gonderilen = "select * from okuyucu";
            verigoster(gonderilen);
            if (Ana_Sayfa.uyesilmemi)
            {
                this.Text = "Üye Silme";
                btnislevler.Text = "Sil";
            }

            else
            {
                this.Text = "Üye Düzenleme";
                btnislevler.Text = "Güncelle";
            }
        }
        private void btnislevler_Click(object sender, EventArgs e)
        {
            if (Ana_Sayfa.uyesilmemi)
            {
                try
                {
                    if (okuyucu.Length != 0)
                    {
                        DialogResult cevap = MessageBox.Show("Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo);
                        if (cevap == DialogResult.Yes)
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = "delete from okuyucu where okuyucuid=@okuyucuid";
                            cmd.Parameters.AddWithValue("@okuyucuid", satir);
                            cmd.ExecuteNonQuery();
                            tbtel.Clear();
                            tbnumara.Clear();
                            tbsoyisim.Clear();
                            tbtc.Clear();
                            tbpasaport.Clear();
                            tbbolum.Clear();
                            tbsinif.Clear();
                            tbmail.Clear();
                            tbisim.Clear();
                            tbadres.Clear();
                            tbokul.Clear();
                            rbüni.Checked = rblise.Checked = false;
                            gonderilen = "select * from okuyucu";
                            verigoster(gonderilen);
                            MessageBox.Show("Kaydınız Silindi.","Tebrikler",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            btnislevler.Enabled = false;
                        }
                    }
                }
                catch { }    
            }
            else
            {
                
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "select * from okuyucu";
                    cmd.Connection = conn;
                    

                       
                            if (okuyucu == "Akademisyen")
                            {

                                if (tbisim.Text.Length != 0 && tbsoyisim.Text.Length != 0 && tbadres.Text.Length != 0 && tbtel.Text.Length == 14 && tbnumara.Text.Length != 0 && tbokul.Text.Length != 0 && tbbolum.Text.Length != 0)
                                {
                                    cmd.CommandText = "update okuyucu set adi=@adi,soyadi=@soyadi,mail=@mail,telefon=@telefon,adres=@adres,numara=@numara,okul=@okul,bolum=@bolum,tckimlik=@tckimlik where okuyucuid=@okuyucuid";
                                    cmd.Parameters.AddWithValue("@adi", tbisim.Text);
                                    cmd.Parameters.AddWithValue("@soyadi", tbsoyisim.Text);
                                    cmd.Parameters.AddWithValue("@mail", tbmail.Text);
                                    cmd.Parameters.AddWithValue("@telefon", tbtel.Text);
                                    cmd.Parameters.AddWithValue("@adres", tbadres.Text);
                                    cmd.Parameters.AddWithValue("@numara", tbnumara.Text);
                                    cmd.Parameters.AddWithValue("@okul", tbokul.Text);
                                    cmd.Parameters.AddWithValue("@bolum", tbbolum.Text);
                                    cmd.Parameters.AddWithValue("@tckimlik", tbtc.Text);
                                    cmd.Parameters.AddWithValue("@okuyucuid", satir);
                                    cmd.ExecuteNonQuery();
                                    gonderilen = "select * from okuyucu";
                                    verigoster(gonderilen);
                                    MessageBox.Show("Kayıt Güncellenmiştir.");
                                }
                            }
                            else if (okuyucu == "Sivil")
                            {
                                if (tbisim.Text.Length != 0 && tbsoyisim.Text.Length != 0 && tbadres.Text.Length != 0 && tbtel.Text.Length == 14)
                                {
                                    cmd.CommandText = "update okuyucu set adi=@adi,soyadi=@soyadi,mail=@mail,telefon=@telefon,adres=@adres,numara=@numara,okul=@okul,bolum=@bolum,tckimlik=@tckimlik where okuyucuid=@okuyucuid";
                                    cmd.Parameters.AddWithValue("@adi", tbisim.Text);
                                    cmd.Parameters.AddWithValue("@soyadi", tbsoyisim.Text);
                                    cmd.Parameters.AddWithValue("@mail", tbmail.Text);
                                    cmd.Parameters.AddWithValue("@telefon", tbtel.Text);
                                    cmd.Parameters.AddWithValue("@adres", tbadres.Text);
                                    cmd.Parameters.AddWithValue("@numara", tbnumara.Text);
                                    cmd.Parameters.AddWithValue("@okul", tbokul.Text);
                                    cmd.Parameters.AddWithValue("@bolum", tbbolum.Text);
                                    cmd.Parameters.AddWithValue("@tckimlik", tbtc.Text);
                                    cmd.Parameters.AddWithValue("@okuyucuid", satir);
                                    cmd.ExecuteNonQuery();
                                    gonderilen = "select * from okuyucu";
                                    verigoster(gonderilen);
                                    MessageBox.Show("Kayıt Güncellenmiştir.");
                                }
                            }
                            else if (okuyucu == "Öğrenci:Lise")
                            {
                                if (tbisim.Text.Length != 0 && tbsoyisim.Text.Length != 0 && tbadres.Text.Length != 0 && tbtel.Text.Length == 14)
                                {
                                    cmd.CommandText = "update okuyucu set adi=@adi,soyadi=@soyadi,mail=@mail,telefon=@telefon,adres=@adres,lisemi=@lisemi,tckimlik=@tckimlik where okuyucuid=@okuyucuid";
                                    cmd.Parameters.AddWithValue("@adi", tbisim.Text);
                                    cmd.Parameters.AddWithValue("@soyadi", tbsoyisim.Text);
                                    cmd.Parameters.AddWithValue("@mail", tbmail.Text);
                                    cmd.Parameters.AddWithValue("@telefon", tbtel.Text);
                                    cmd.Parameters.AddWithValue("@adres", tbadres.Text);
                                    cmd.Parameters.AddWithValue("@lisemi", true);
                                    cmd.Parameters.AddWithValue("@tckimlik", tbtc.Text);
                                    cmd.Parameters.AddWithValue("@okuyucuid", satir);
                                    cmd.ExecuteNonQuery();
                                    gonderilen = "select * from okuyucu";
                                    verigoster(gonderilen);
                                    MessageBox.Show("Kayıt Güncellenmiştir.");
                                }
                            }
                            else if (okuyucu == "Öğrenci:Üniversite")
                            {
                                if (tbisim.Text.Length != 0 && tbsoyisim.Text.Length != 0 && tbadres.Text.Length != 0 && tbtel.Text.Length == 14)
                                {
                                    cmd.CommandText = "update okuyucu set adi=@adi,soyadi=@soyadi,mail=@mail,telefon=@telefon,adres=@adres,numara=@numara,okul=@okul,bolum=@bolum,sinif=@sinif,lisemi=@lisemi,tckimlik=@tckimlik where okuyucuid=@okuyucuid";
                                    cmd.Parameters.AddWithValue("@adi", tbisim.Text);
                                    cmd.Parameters.AddWithValue("@soyadi", tbsoyisim.Text);
                                    cmd.Parameters.AddWithValue("@mail", tbmail.Text);
                                    cmd.Parameters.AddWithValue("@telefon", tbtel.Text);
                                    cmd.Parameters.AddWithValue("@adres", tbadres.Text);
                                    cmd.Parameters.AddWithValue("@numara", tbnumara.Text);
                                    cmd.Parameters.AddWithValue("@okul", tbokul.Text);
                                    cmd.Parameters.AddWithValue("@bolum", tbbolum.Text);
                                    cmd.Parameters.AddWithValue("@sinif", tbsinif.Text);
                                    cmd.Parameters.AddWithValue("@lisemi", false);
                                    cmd.Parameters.AddWithValue("@tckimlik", tbtc.Text);
                                    cmd.Parameters.AddWithValue("@okuyucuid", satir);
                                    cmd.ExecuteNonQuery();
                                    gonderilen = "select * from okuyucu";
                                    verigoster(gonderilen);
                                    MessageBox.Show("Kayıt Güncellenmiştir.");
                                }
                            }
                            else
                            {
                                gonderilen = "select * from okuyucu";
                                verigoster(gonderilen);
                                MessageBox.Show("Lütfen yıldızlı alanları doldurunuz.", "Dikkat!" + MessageBoxIcon.Warning);
                            }
       
                
            }

                
               
        }
        string tc;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnislevler.Enabled = true;
            if(Ana_Sayfa.uyesilmemi==false)
            {
               tbokul.ReadOnly= tbmail.ReadOnly = tbadres.ReadOnly = tbnumara.ReadOnly = tbbolum.ReadOnly = tbsinif.ReadOnly = tbisim.ReadOnly = tbsoyisim.ReadOnly =tbtc.ReadOnly=tbpasaport.ReadOnly= false;
                 rbakademisyen.Enabled = rblise.Enabled = rbokul.Enabled = rbüni.Enabled = tbtel.Enabled = true;

            }

            tbbolum.Clear();
            tbsinif.Clear();
            tbnumara.Clear();
            tbokul.Clear();
            rblise.Checked = rbüni.Checked = false;    
                try
                {
                    satir = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                    OleDbCommand cmd = new OleDbCommand("select * from okuyucu where okuyucuid=" + satir, conn);
                    OleDbDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                  

                        if (rd["okuyucutipi"].ToString() == "Akademisyen")
                        {
                        rbakademisyen.Visible = false;
                        rbokul.Visible = false;
                        rblise.Visible = false;
                        rbüni.Visible = false;
                        labellise.Visible = false;
                        tbsinif.Visible = false;
                        gbograka.Enabled = true;
                        okuyucu = "Akademisyen";
                        labelnumara.Text = "Akademisyen Numarası:";
                        tbnumara.Text = rd["numara"].ToString();
                        tbokul.Text = rd["okul"].ToString();
                        tbbolum.Text = rd["bolum"].ToString();
                        }

                        else if (rd["okuyucutipi"].ToString() == "Sivil")
                        {
                        rbakademisyen.Visible = true;
                        rbokul.Visible = true;
                        rblise.Visible = true;
                        rbüni.Visible = true;
                        tbsinif.Visible = true;
                        labellise.Visible = true;
                        labelnumara.Text = "Eğitim Numarası:";
                        gbograka.Visible = true;
                        labelsinif.Visible = true;
                        okuyucu = "Sivil";
                        
                        }

                    else if (rd["okuyucutipi"].ToString() == "Öğrenci" && rd["lisemi"].ToString() == true.ToString())
                    {
                        gbograka.Enabled = true;
                        labellise.Visible = true;
                        rbakademisyen.Visible = rbokul.Visible = false;
                        okuyucu = "Öğrenci:Lise";
                        tbsinif.Visible = labelsinif.Visible = rblise.Visible = rbüni.Visible = true;
                        labelnumara.Text = "Öğrenci Numarası";
                        rblise.Checked = true;
                        rbokul.Checked = true;
                    }

                    else if (rd["okuyucutipi"].ToString() == "Öğrenci" && rd["lisemi"].ToString() == false.ToString())
                    {
                        okuyucu = "Öğrenci:Üniversite";
                        labellise.Visible = false;
                        rblise.Visible = false;
                        rbakademisyen.Visible = rbokul.Visible = true;
                        tbsinif.Visible = rblise.Visible = rbüni.Visible = labelsinif.Visible = true;
                        gbograka.Enabled = true;
                        rbüni.Checked = true;
                        labelnumara.Text = "Öğrenci Numarası";
                        tbnumara.Text = rd["numara"].ToString();
                        tbokul.Text = rd["okul"].ToString();
                        tbbolum.Text = rd["bolum"].ToString();
                        tbsinif.Text = rd["sinif"].ToString();
                    }
                    if (rd["tckimlik"].ToString().Length==11)
                    {
                        tc= rd["tckimlik"].ToString();
                        tbtc.Text = rd["tckimlik"].ToString();
                        tbpasaport.Visible = false;
                        tbtc.Visible = true;
                        label23.Text = "TC Kimlik Numarası:";
                        yabancimi.Checked = false;
                    }
                       
                    if (rd["pasaportkimlik"].ToString().Length ==9)
                    {
                        pasaport = rd["pasaportkimlik"].ToString();
                        tbpasaport.Text = rd["pasaportkimlik"].ToString();
                        tbpasaport.Visible = true;
                        tbtc.Visible = false;
                        label23.Text = "Pasaport Numarası:";
                        yabancimi.Checked = true;
                    }
                        
                    tbisim.Text = rd["adi"].ToString();
                    tbsoyisim.Text = rd["soyadi"].ToString();
                    tbmail.Text = rd["mail"].ToString();
                    tbtel.Text = rd["telefon"].ToString();
                    tbadres.Text = rd["adres"].ToString();
                    dtarihi.Text = rd["dtarihi"].ToString();

                }
            }
            catch { }


        }


        private void yabancimi_CheckedChanged(object sender, EventArgs e)
        {
            if (yabancimi.Checked)
            {
                tbtc.Clear();
                tbpasaport.Focus();
                label23.Text = "Pasaport Numarası:";
                tbtc.Visible = false;
                tbpasaport.Visible = true;
           
            }
                
            else
            {
                tbpasaport.Clear();
                tbtc.Focus();
                label23.Text = "TC Kimklik Numarası:";
                tbtc.Visible = true;tbpasaport.Visible = false;
       
            }
                
        }

        private void rbakademisyen_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rbakademisyen.Checked)
            {
                labellise.Visible = false;
                gbograka.Enabled = true;
                labelnumara.Text = "Akademisyen Numarası";
                tbsinif.Visible = labelsinif.Visible = rblise.Visible = rbüni.Visible = false;
                gbograka.Enabled = true;
            }
            else if (rbokul.Checked)
            {
                labellise.Visible = true;
                tbsinif.Visible = rblise.Visible = labelsinif.Visible = rbüni.Visible = true;
                rblise.Checked = rbüni.Checked = false;
            }
        }

        private void rbokul_CheckedChanged(object sender, EventArgs e)
        {
            if(rbokul.Checked)
            {
                gbograka.Enabled = true;
                labellise.Visible = true;
                labelnumara.Text = "Öğrenci Numarası";
                tbsinif.Visible = labelsinif.Visible = rblise.Visible = rbüni.Visible = true ;

            }
        }

        private void tbpasaport_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbtc_TextChanged(object sender, EventArgs e)
        {
          
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gonderilen = "select * from okuyucu where adi like'"+tbadiaranan.Text+"%'";
            verigoster(gonderilen);
        }
        string pasaport;
        private void tbpasaport_TextChanged_1(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from okuyucu",conn);
            OleDbDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                if(dr["pasaportkimlik"].ToString()==tbpasaport.Text)
                {
                    if(pasaport==tbpasaport.Text)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Bu okuyucu sistemde kayıtlıdır.");
                        tbpasaport.Text = pasaport;

                    }

                }
                
            }

        }

        private void tbtc_TextChanged_1(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from okuyucu", conn);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (dr["tckimlik"].ToString() == tbtc.Text)
                {
                    if (tc == tbtc.Text)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Bu okuyucu sistemde kayıtlıdır.");
                        tbtc.Text = tc;

                    }

                }

            }
        }
    }
}
