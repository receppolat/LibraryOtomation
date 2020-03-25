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
    public partial class Yeni_Okuyucu : Form
    {
        public Yeni_Okuyucu()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bin\\Debug\\KutuphaneOtomasyonu.mdb");
        string cinsiyet = "", okuyucutipi = "";
        Boolean akademisyenmi,sivilmi,ogrencimi;
        DataSet ds = new DataSet();


        private void Yeni_Okuyucu_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            dtarihi.MaxDate = DateTime.Now.AddYears(-7);
            ktarihi.MaxDate = DateTime.Today;
            if (Ana_Sayfa.akademisyenmi) okuyucutipi = "Akademisyen";
            else if (Ana_Sayfa.ogrencimi) okuyucutipi = "Öğrenci";
            else if (Ana_Sayfa.sivilmi) okuyucutipi = "Sivil";

            if (Ana_Sayfa.ogrencimi == true)
            {                                
                labelsivilicin.Visible = false;
                ogrencimi = true;
                labelnumara.Text = "Öğrenci Numarası *:";
                Ana_Sayfa.ogrencimi = false;
                gbograka.Enabled = false;
            }
            else if (Ana_Sayfa.akademisyenmi == true)
            {
                Ana_Sayfa.akademisyenmi = false;akademisyenmi = true;
                gbograka.Visible = true;
                labelnumara.Text = "Akademisyen Numarası *:"; labellise.Visible = false;
                labelsinif.Visible=rblise.Visible=rbüni.Visible=labelaka.Visible=tbsinif.Visible= labelsivilicin.Visible = false;
            }
            else if(Ana_Sayfa.sivilmi==true)
            {
                Ana_Sayfa.sivilmi = false;
                sivilmi = true;
                this.Height = 280;
                gbograka.Visible =  rblise.Visible = rbüni.Visible = labelaka.Visible = false;
                rblise.Checked = rbüni.Checked = false;
                labellise.Visible = false;
                labelsivilicin.Visible = true;
            }
        }

        private void rblise_CheckedChanged(object sender, EventArgs e)
        {
            if (rblise.Checked)
                gbograka.Enabled = false;
        }

        private void tbpasaport_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbpasaport.Text.Length == 9)
                {
                    OleDbCommand komut = new OleDbCommand("select * from okuyucu", conn);
                    OleDbDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        if (oku["pasaportkimlik"].ToString() == tbpasaport.Text)
                        {
                            MessageBox.Show("Bu kullanıcı sistemde kayıtlıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tbpasaport.Clear();
                        }
                    }

                }
            }
            catch { }

        }

        private void tbtc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbtc.Text.Length == 11)
                {
                    OleDbCommand komut = new OleDbCommand("select * from okuyucu", conn);
                    OleDbDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        if (oku["tckimlik"].ToString() == tbtc.Text)
                        {
                            MessageBox.Show("Bu kullanıcı sistemde kayıtlıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tbtc.Clear();
                        }
                    }
                }

            }
            catch { }
        }

        private void rbüni_CheckedChanged(object sender, EventArgs e)
        {
            if (rbüni.Checked)
                gbograka.Enabled = true;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            if (rberkek.Checked) cinsiyet = rberkek.Text;
            else if (rbkadin.Checked) cinsiyet = rbkadin.Text;
            if (yabancimi.Checked)
            {
                if (okuyucutipi == "Akademisyen")
                {
                    if (tbisim.Text.Length != 0 && tbsoyisim.Text.Length != 0 && (rberkek.Checked || rbkadin.Checked) && tbpasaport.Text.Length == 9 && tbmail.Text.Length != 0 && tbtel.Text.Length == 14 && tbadres.Text.Length != 0 && tbnumara.Text.Length != 0 && tbokul.Text.Length != 0 && tbbolum.Text.Length != 0)
                    {
                        OleDbCommand komut = new OleDbCommand("insert into okuyucu (tckimlik,adi,soyadi,cinsiyet,pasaportkimlik,dtarihi,ktarihi,mail,telefon,adres,numara,okul,bolum,okuyucutipi) Values(@tckimlik,@adi,@soyadi,@cinsiyet,@pasaportkimlik,@dtarihi,@ktarihi,@mail,@telefon,@adres,@numara,@okul,@bolum,@okuyucutipi)", conn);
                        komut.Parameters.AddWithValue("@tckimlik", "Yabancı");
                        komut.Parameters.AddWithValue("@adi", tbisim.Text);
                        komut.Parameters.AddWithValue("@soyadi", tbsoyisim.Text);
                        komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        komut.Parameters.AddWithValue("@pasaportkimlik", tbpasaport.Text);
                        komut.Parameters.AddWithValue("@dtarihi", dtarihi.Text);
                        komut.Parameters.AddWithValue("@ktarihi", ktarihi.Text);
                        komut.Parameters.AddWithValue("@mail", tbmail.Text);
                        komut.Parameters.AddWithValue("@telefon", tbtel.Text);
                        komut.Parameters.AddWithValue("@adres", tbadres.Text);
                        komut.Parameters.AddWithValue("@numara", tbnumara.Text);
                        komut.Parameters.AddWithValue("@okul", tbokul.Text);
                        komut.Parameters.AddWithValue("bolum", tbbolum.Text);
                        komut.Parameters.AddWithValue("@okuyucutipi", okuyucutipi);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kaydınız gerçekleşmiştir.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Eksik bilgi girdiniz. Bilgilerinizi kontrol edip tekrar deneyiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else if (okuyucutipi == "Sivil")
                {
                    if (tbisim.Text.Length != 0 && tbsoyisim.Text.Length != 0 && (rberkek.Checked || rbkadin.Checked) && tbpasaport.Text.Length == 9 && tbmail.Text.Length != 0 && tbtel.Text.Length == 14 && tbadres.Text.Length != 0)
                    {
                        OleDbCommand komut = new OleDbCommand("insert into okuyucu (tckimlik,adi,soyadi,cinsiyet,pasaportkimlik,dtarihi,ktarihi,mail,telefon,adres,okuyucutipi) Values(@tckimlik,@adi,@soyadi,@cinsiyet,@pasaportkimlik,@dtarihi,@ktarihi,@mail,@telefon,@adres,@okuyucutipi)", conn);
                        komut.Parameters.AddWithValue("@tckimlik", "Yabancı");
                        komut.Parameters.AddWithValue("@adi", tbisim.Text);
                        komut.Parameters.AddWithValue("@soyadi", tbsoyisim.Text);
                        komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        komut.Parameters.AddWithValue("@pasaportkimlik", tbpasaport.Text);
                        komut.Parameters.AddWithValue("@dtarihi", dtarihi.Text);
                        komut.Parameters.AddWithValue("@ktarihi", ktarihi.Text);
                        komut.Parameters.AddWithValue("@mail", tbmail.Text);
                        komut.Parameters.AddWithValue("@telefon", tbtel.Text);
                        komut.Parameters.AddWithValue("@adres", tbadres.Text);
                        komut.Parameters.AddWithValue("@okuyucutipi", okuyucutipi);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kaydınız gerçekleşmiştir.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Eksik bilgi girdiniz. Bilgilerinizi kontrol edip tekrar deneyiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (okuyucutipi == "Öğrenci")
                {
                    if (tbisim.Text.Length != 0 && tbsoyisim.Text.Length != 0 && (rberkek.Checked || rbkadin.Checked) && tbpasaport.Text.Length == 9 && tbmail.Text.Length != 0 && tbtel.Text.Length == 14 && tbadres.Text.Length != 0 && tbnumara.Text.Length != 0 && tbokul.Text.Length != 0 && tbbolum.Text.Length != 0 && tbsinif.Text.Length != 0)
                    {
                        OleDbCommand komut = new OleDbCommand("insert into okuyucu (tckimlik,adi,soyadi,cinsiyet,pasaportkimlik,dtarihi,ktarihi,mail,telefon,adres,numara,okul,bolum,sinif,okuyucutipi) Values(@tckimlik,@adi,@soyadi,@cinsiyet,@pasaportkimlik,@dtarihi,@ktarihi,@mail,@telefon,@adres,@numara,@okul,@bolum,@sinif,@okuyucutipi)", conn);
                        komut.Parameters.AddWithValue("@tckimlik", "Yabancı");
                        komut.Parameters.AddWithValue("@adi", tbisim.Text);
                        komut.Parameters.AddWithValue("@soyadi", tbsoyisim.Text);
                        komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        komut.Parameters.AddWithValue("@pasaportkimlik", tbpasaport.Text);
                        komut.Parameters.AddWithValue("@dtarihi", dtarihi.Text);
                        komut.Parameters.AddWithValue("@ktarihi", ktarihi.Text);
                        komut.Parameters.AddWithValue("@mail", tbmail.Text);
                        komut.Parameters.AddWithValue("@telefon", tbtel.Text);
                        komut.Parameters.AddWithValue("@adres", tbadres.Text);
                        komut.Parameters.AddWithValue("@numara", tbnumara.Text);
                        komut.Parameters.AddWithValue("@okul", tbokul.Text);
                        komut.Parameters.AddWithValue("bolum", tbbolum.Text);
                        komut.Parameters.AddWithValue("@sinif", tbsinif.Text);
                        komut.Parameters.AddWithValue("@okuyucutipi", okuyucutipi);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kaydınız gerçekleşmiştir.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Eksik bilgi girdiniz. Bilgilerinizi kontrol edip tekrar deneyiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (okuyucutipi == "Akademisyen")
                {
                    if (tbisim.Text.Length != 0 && tbsoyisim.Text.Length != 0 && (rberkek.Checked || rbkadin.Checked) && tbtc.Text.Length == 11 && tbmail.Text.Length != 0 && tbtel.Text.Length == 14 && tbadres.Text.Length != 0 && tbnumara.Text.Length != 0 && tbokul.Text.Length != 0 && tbbolum.Text.Length != 0)
                    {
                        OleDbCommand komut = new OleDbCommand("insert into okuyucu (pasaportkimlik,adi,soyadi,cinsiyet,tckimlik,dtarihi,ktarihi,mail,telefon,adres,numara,okul,bolum,okuyucutipi) Values(@pasaportkimlik,@adi,@soyadi,@cinsiyet,@tckimlik,@dtarihi,@ktarihi,@mail,@telefon,@adres,@numara,@okul,@bolum,@okuyucutipi)", conn);
                        komut.Parameters.AddWithValue("@pasaportkimlik", "TC");
                        komut.Parameters.AddWithValue("@adi", tbisim.Text);
                        komut.Parameters.AddWithValue("@soyadi", tbsoyisim.Text);
                        komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        komut.Parameters.AddWithValue("@tckimlik", tbtc.Text);
                        komut.Parameters.AddWithValue("@dtarihi", dtarihi.Text);
                        komut.Parameters.AddWithValue("@ktarihi", ktarihi.Text);
                        komut.Parameters.AddWithValue("@mail", tbmail.Text);
                        komut.Parameters.AddWithValue("@telefon", tbtel.Text);
                        komut.Parameters.AddWithValue("@adres", tbadres.Text);
                        komut.Parameters.AddWithValue("@numara", tbnumara.Text);
                        komut.Parameters.AddWithValue("@okul", tbokul.Text);
                        komut.Parameters.AddWithValue("bolum", tbbolum.Text);
                        komut.Parameters.AddWithValue("@okuyucutipi", okuyucutipi);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kaydınız gerçekleşmiştir.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Eksik bilgi girdiniz. Bilgilerinizi kontrol edip tekrar deneyiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (okuyucutipi == "Sivil")
                {
                    if (tbisim.Text.Length != 0 && tbsoyisim.Text.Length != 0 && (rberkek.Checked || rbkadin.Checked) && tbtc.Text.Length == 11 && tbmail.Text.Length != 0 && tbtel.Text.Length == 14 && tbadres.Text.Length != 0)
                    {
                        OleDbCommand komut = new OleDbCommand("insert into okuyucu (pasaportkimlik,adi,soyadi,cinsiyet,tckimlik,dtarihi,ktarihi,mail,telefon,adres,okuyucutipi) Values(@pasaportkimlik,@adi,@soyadi,@cinsiyet,@tckimlik,@dtarihi,@ktarihi,@mail,@telefon,@adres,@okuyucutipi)", conn);
                        komut.Parameters.AddWithValue("@pasaportkimlik", "TC");
                        komut.Parameters.AddWithValue("@adi", tbisim.Text);
                        komut.Parameters.AddWithValue("@soyadi", tbsoyisim.Text);
                        komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        komut.Parameters.AddWithValue("@tckimlik", tbtc.Text);
                        komut.Parameters.AddWithValue("@dtarihi", dtarihi.Text);
                        komut.Parameters.AddWithValue("@ktarihi", ktarihi.Text);
                        komut.Parameters.AddWithValue("@mail", tbmail.Text);
                        komut.Parameters.AddWithValue("@telefon", tbtel.Text);
                        komut.Parameters.AddWithValue("@adres", tbadres.Text);
                        komut.Parameters.AddWithValue("@okuyucutipi", okuyucutipi);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kaydınız gerçekleşmiştir.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Eksik bilgi girdiniz. Bilgilerinizi kontrol edip tekrar deneyiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (okuyucutipi == "Öğrenci")
                {
                    if (tbisim.Text.Length != 0 && tbsoyisim.Text.Length != 0 && (rberkek.Checked || rbkadin.Checked) && tbtc.Text.Length == 11 && tbmail.Text.Length != 0 && tbtel.Text.Length == 14 && tbadres.Text.Length != 0 && tbnumara.Text.Length != 0 && tbokul.Text.Length != 0 && tbbolum.Text.Length != 0 && tbsinif.Text.Length != 0)
                    {
                        OleDbCommand komut = new OleDbCommand("insert into okuyucu (pasaportkimlik,adi,soyadi,cinsiyet,tckimlik,dtarihi,ktarihi,mail,telefon,adres,numara,okul,bolum,sinif,okuyucutipi) Values(@pasaportkimlik,@adi,@soyadi,@cinsiyet,@tckimlik,@dtarihi,@ktarihi,@mail,@telefon,@adres,@numara,@okul,@bolum,@sinif,@okuyucutipi)", conn);
                        komut.Parameters.AddWithValue("@pasaportkimlik", "TC");
                        komut.Parameters.AddWithValue("@adi", tbisim.Text);
                        komut.Parameters.AddWithValue("@soyadi", tbsoyisim.Text);
                        komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        komut.Parameters.AddWithValue("@tckimlik", tbtc.Text);
                        komut.Parameters.AddWithValue("@dtarihi", dtarihi.Text);
                        komut.Parameters.AddWithValue("@ktarihi", ktarihi.Text);
                        komut.Parameters.AddWithValue("@mail", tbmail.Text);
                        komut.Parameters.AddWithValue("@telefon", tbtel.Text);
                        komut.Parameters.AddWithValue("@adres", tbadres.Text);
                        komut.Parameters.AddWithValue("@numara", tbnumara.Text);
                        komut.Parameters.AddWithValue("@okul", tbokul.Text);
                        komut.Parameters.AddWithValue("bolum", tbbolum.Text);
                        komut.Parameters.AddWithValue("@sinif", tbsinif.Text);
                        komut.Parameters.AddWithValue("@okuyucutipi", okuyucutipi);
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kaydınız gerçekleşmiştir.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Eksik bilgi girdiniz. Bilgilerinizi kontrol edip tekrar deneyiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void yabancimi_CheckedChanged(object sender, EventArgs e)
        {
            if(yabancimi.Checked)
            {
                label23.Text = "Pasaport Numarası *:";
                tbtc.Visible = false;
                tbpasaport.Visible = true;
                tbtc.Clear();
            }
            else
            {
                label23.Text = "TC Kimlik Numarası *:";
                tbpasaport.Visible = false;
                tbtc.Visible = true;
                tbpasaport.Clear();
            }
        }
    }
}
