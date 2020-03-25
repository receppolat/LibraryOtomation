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
    public partial class OkuyucuArsivi : Form
    {
        public OkuyucuArsivi()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bin\\Debug\\KutuphaneOtomasyonu.mdb");
        DataSet ds = new DataSet();
        string lisemi=" ", gonderilen;


        private void verigoster()
        {
            listView1.Items.Clear();
            OleDbCommand cmd = new OleDbCommand("select * from okuyucu", conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rd["okuyucuid"].ToString();
                ekle.SubItems.Add(rd["tckimlik"].ToString());
                ekle.SubItems.Add(rd["pasaportkimlik"].ToString());
                ekle.SubItems.Add(rd["adi"].ToString());
                ekle.SubItems.Add(rd["soyadi"].ToString());
                ekle.SubItems.Add(rd["cinsiyet"].ToString());
                ekle.SubItems.Add(rd["dtarihi"].ToString());
                ekle.SubItems.Add(rd["ktarihi"].ToString());
                ekle.SubItems.Add(rd["mail"].ToString());
                ekle.SubItems.Add(rd["telefon"].ToString());
                ekle.SubItems.Add(rd["adres"].ToString());
                ekle.SubItems.Add(rd["kitapsayisi"].ToString());
                ekle.SubItems.Add(rd["aktifmi"].ToString());
                ekle.SubItems.Add(rd["numara"].ToString());
                ekle.SubItems.Add(rd["okul"].ToString());
                ekle.SubItems.Add(rd["bolum"].ToString());
                ekle.SubItems.Add(rd["sinif"].ToString());
                ekle.SubItems.Add(lisemi);
                listView1.Items.Add(ekle);
            }
        }
        private void veriaratc()
        {
            try
            {
                listView1.Items.Clear();
                lwpasaportkimlik.Width = 0;
                OleDbCommand cmd = new OleDbCommand("select * from okuyucu where tckimlik like'" + tbtc.Text + "%'", conn);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (rd["tckimlik"].ToString().Length != 0)
                    {
                        ListViewItem ekle = new ListViewItem();
                        ekle.Text = rd["okuyucuid"].ToString();
                        ekle.SubItems.Add(rd["tckimlik"].ToString());
                        ekle.SubItems.Add(rd["pasaportkimlik"].ToString());
                        ekle.SubItems.Add(rd["adi"].ToString());
                        ekle.SubItems.Add(rd["soyadi"].ToString());
                        ekle.SubItems.Add(rd["cinsiyet"].ToString());
                        ekle.SubItems.Add(rd["dtarihi"].ToString());
                        ekle.SubItems.Add(rd["ktarihi"].ToString());
                        ekle.SubItems.Add(rd["mail"].ToString());
                        ekle.SubItems.Add(rd["telefon"].ToString());
                        ekle.SubItems.Add(rd["adres"].ToString());
                        ekle.SubItems.Add(rd["kitapsayisi"].ToString());
                        ekle.SubItems.Add(rd["aktifmi"].ToString());
                        ekle.SubItems.Add(rd["numara"].ToString());
                        ekle.SubItems.Add(rd["okul"].ToString());
                        ekle.SubItems.Add(rd["bolum"].ToString());
                        ekle.SubItems.Add(rd["sinif"].ToString());
                        ekle.SubItems.Add(lisemi);
                        listView1.Items.Add(ekle);
                    }
                }
            }
            catch { }
        }

        private void veriarapasaport()
        {
            try
            {
                listView1.Items.Clear();
                lwtckimlik.Width = 0;
                OleDbCommand cmd = new OleDbCommand("select * from okuyucu where pasaportkimlik like'" + tbpasaport.Text + "%'", conn);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (rd["pasaportkimlik"].ToString().Length != 0)
                    {
                        ListViewItem ekle = new ListViewItem();
                        ekle.Text = rd["okuyucuid"].ToString();
                        ekle.SubItems.Add(rd["tckimlik"].ToString());
                        ekle.SubItems.Add(rd["pasaportkimlik"].ToString());
                        ekle.SubItems.Add(rd["adi"].ToString());
                        ekle.SubItems.Add(rd["soyadi"].ToString());
                        ekle.SubItems.Add(rd["cinsiyet"].ToString());
                        ekle.SubItems.Add(rd["dtarihi"].ToString());
                        ekle.SubItems.Add(rd["ktarihi"].ToString());
                        ekle.SubItems.Add(rd["mail"].ToString());
                        ekle.SubItems.Add(rd["telefon"].ToString());
                        ekle.SubItems.Add(rd["adres"].ToString());
                        ekle.SubItems.Add(rd["kitapsayisi"].ToString());
                        ekle.SubItems.Add(rd["aktifmi"].ToString());
                        ekle.SubItems.Add(rd["numara"].ToString());
                        ekle.SubItems.Add(rd["okul"].ToString());
                        ekle.SubItems.Add(rd["bolum"].ToString());
                        ekle.SubItems.Add(rd["sinif"].ToString());
                        ekle.SubItems.Add(lisemi);
                        listView1.Items.Add(ekle);
                    }

                }
            }
            catch { }
        }
        private void veriaramaadi()
        {
            try
            {
                listView1.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("select * from okuyucu where adi like'" + tbadi.Text + "%'", conn);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = rd["okuyucuid"].ToString();
                    ekle.SubItems.Add(rd["tckimlik"].ToString());
                    ekle.SubItems.Add(rd["pasaportkimlik"].ToString());
                    ekle.SubItems.Add(rd["adi"].ToString());
                    ekle.SubItems.Add(rd["soyadi"].ToString());
                    ekle.SubItems.Add(rd["cinsiyet"].ToString());
                    ekle.SubItems.Add(rd["dtarihi"].ToString());
                    ekle.SubItems.Add(rd["ktarihi"].ToString());
                    ekle.SubItems.Add(rd["mail"].ToString());
                    ekle.SubItems.Add(rd["telefon"].ToString());
                    ekle.SubItems.Add(rd["adres"].ToString());
                    ekle.SubItems.Add(rd["kitapsayisi"].ToString());
                    ekle.SubItems.Add(rd["aktifmi"].ToString());
                    ekle.SubItems.Add(rd["numara"].ToString());
                    ekle.SubItems.Add(rd["okul"].ToString());
                    ekle.SubItems.Add(rd["bolum"].ToString());
                    ekle.SubItems.Add(rd["sinif"].ToString());
                    ekle.SubItems.Add(lisemi);
                    listView1.Items.Add(ekle);
                }
            }
            catch { }
        }
        private void veriaramasoyadi()
        {
            try
            {
                listView1.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("select * from okuyucu where soyadi like'" + tbsoyadi.Text + "%'", conn);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = rd["okuyucuid"].ToString();
                    ekle.SubItems.Add(rd["tckimlik"].ToString());
                    ekle.SubItems.Add(rd["pasaportkimlik"].ToString());
                    ekle.SubItems.Add(rd["adi"].ToString());
                    ekle.SubItems.Add(rd["soyadi"].ToString());
                    ekle.SubItems.Add(rd["cinsiyet"].ToString());
                    ekle.SubItems.Add(rd["dtarihi"].ToString());
                    ekle.SubItems.Add(rd["ktarihi"].ToString());
                    ekle.SubItems.Add(rd["mail"].ToString());
                    ekle.SubItems.Add(rd["telefon"].ToString());
                    ekle.SubItems.Add(rd["adres"].ToString());
                    ekle.SubItems.Add(rd["kitapsayisi"].ToString());
                    ekle.SubItems.Add(rd["aktifmi"].ToString());
                    ekle.SubItems.Add(rd["numara"].ToString());
                    ekle.SubItems.Add(rd["okul"].ToString());
                    ekle.SubItems.Add(rd["bolum"].ToString());
                    ekle.SubItems.Add(rd["sinif"].ToString());
                    ekle.SubItems.Add(lisemi);
                    listView1.Items.Add(ekle);
                }
            }
            catch { }
        }
        private void veriaramanumara()
        {
            try
            {
                listView1.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("select * from okuyucu where numara like'" + tbnumara.Text + "%'", conn);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = rd["okuyucuid"].ToString();
                    ekle.SubItems.Add(rd["tckimlik"].ToString());
                    ekle.SubItems.Add(rd["pasaportkimlik"].ToString());
                    ekle.SubItems.Add(rd["adi"].ToString());
                    ekle.SubItems.Add(rd["soyadi"].ToString());
                    ekle.SubItems.Add(rd["cinsiyet"].ToString());
                    ekle.SubItems.Add(rd["dtarihi"].ToString());
                    ekle.SubItems.Add(rd["ktarihi"].ToString());
                    ekle.SubItems.Add(rd["mail"].ToString());
                    ekle.SubItems.Add(rd["telefon"].ToString());
                    ekle.SubItems.Add(rd["adres"].ToString());
                    ekle.SubItems.Add(rd["kitapsayisi"].ToString());
                    ekle.SubItems.Add(rd["aktifmi"].ToString());
                    ekle.SubItems.Add(rd["numara"].ToString());
                    ekle.SubItems.Add(rd["okul"].ToString());
                    ekle.SubItems.Add(rd["bolum"].ToString());
                    ekle.SubItems.Add(rd["sinif"].ToString());
                    ekle.SubItems.Add(lisemi);
                    listView1.Items.Add(ekle);
                }
            }
            catch { }
        }
        private void veriaramaokul()
        {
            try
            {
                listView1.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("select * from okuyucu where okul like'" + cbokul.Text + "%'", conn);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = rd["okuyucuid"].ToString();
                    ekle.SubItems.Add(rd["tckimlik"].ToString());
                    ekle.SubItems.Add(rd["pasaportkimlik"].ToString());
                    ekle.SubItems.Add(rd["adi"].ToString());
                    ekle.SubItems.Add(rd["soyadi"].ToString());
                    ekle.SubItems.Add(rd["cinsiyet"].ToString());
                    ekle.SubItems.Add(rd["dtarihi"].ToString());
                    ekle.SubItems.Add(rd["ktarihi"].ToString());
                    ekle.SubItems.Add(rd["mail"].ToString());
                    ekle.SubItems.Add(rd["telefon"].ToString());
                    ekle.SubItems.Add(rd["adres"].ToString());
                    ekle.SubItems.Add(rd["kitapsayisi"].ToString());
                    ekle.SubItems.Add(rd["aktifmi"].ToString());
                    ekle.SubItems.Add(rd["numara"].ToString());
                    ekle.SubItems.Add(rd["okul"].ToString());
                    ekle.SubItems.Add(rd["bolum"].ToString());
                    ekle.SubItems.Add(rd["sinif"].ToString());
                    ekle.SubItems.Add(lisemi);
                    listView1.Items.Add(ekle);
                }
            }
            catch { }
        }


        private void OkuyucuArsivi_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();


            OleDbCommand cmd = new OleDbCommand("select * from okuyucu", conn);
            OleDbDataReader rd = cmd.ExecuteReader();

            if (Ana_Sayfa.ogrencimi)
            {
                lwpasaportkimlik.Width = 0;
                Ana_Sayfa.ogrencimi = false;
                labelnumara.Text = "Öğrenci Numarası:";
                while (rd.Read())
                {
                    if (rd["lisemi"].ToString() == true.ToString())
                        lisemi = "Lise";
                    else
                        lisemi = "Üniversite";
                    if (rd["tckimlik"].ToString().Length != 0)
                    {
                        if (rd["okuyucutipi"].ToString() == "Öğrenci")
                        {
                            ListViewItem ekle = new ListViewItem();
                            ekle.Text = rd["okuyucuid"].ToString();
                            ekle.SubItems.Add(rd["tckimlik"].ToString());
                            ekle.SubItems.Add(rd["pasaportkimlik"].ToString());
                            ekle.SubItems.Add(rd["adi"].ToString());
                            ekle.SubItems.Add(rd["soyadi"].ToString());
                            ekle.SubItems.Add(rd["cinsiyet"].ToString());
                            ekle.SubItems.Add(rd["dtarihi"].ToString());
                            ekle.SubItems.Add(rd["ktarihi"].ToString());
                            ekle.SubItems.Add(rd["mail"].ToString());
                            ekle.SubItems.Add(rd["telefon"].ToString());
                            ekle.SubItems.Add(rd["adres"].ToString());
                            ekle.SubItems.Add(rd["kitapsayisi"].ToString());
                            ekle.SubItems.Add(rd["numara"].ToString());
                            ekle.SubItems.Add(rd["okul"].ToString());
                            ekle.SubItems.Add(rd["bolum"].ToString());
                            ekle.SubItems.Add(rd["sinif"].ToString());
                            ekle.SubItems.Add(lisemi);
                            listView1.Items.Add(ekle);
                        }

                    }

                }
            }
            else if (Ana_Sayfa.akademisyenmi)
            {
                lwpasaportkimlik.Width = 0;
                lwsinif.Width = 0;
                lwlisemi.Width = 0;
                Ana_Sayfa.akademisyenmi = false;
                labelnumara.Text = "Akademisyen Numarası:";
                while (rd.Read())
                {
                    if (rd["tckimlik"].ToString().Length != 0)
                    {
                        if (rd["okuyucutipi"].ToString() == "Akademisyen")
                        {
                            ListViewItem ekle = new ListViewItem();
                            ekle.Text = rd["okuyucuid"].ToString();
                            ekle.SubItems.Add(rd["tckimlik"].ToString());
                            ekle.SubItems.Add(rd["pasaportkimlik"].ToString());
                            ekle.SubItems.Add(rd["adi"].ToString());
                            ekle.SubItems.Add(rd["soyadi"].ToString());
                            ekle.SubItems.Add(rd["cinsiyet"].ToString());
                            ekle.SubItems.Add(rd["dtarihi"].ToString());
                            ekle.SubItems.Add(rd["ktarihi"].ToString());
                            ekle.SubItems.Add(rd["mail"].ToString());
                            ekle.SubItems.Add(rd["telefon"].ToString());
                            ekle.SubItems.Add(rd["adres"].ToString());
                            ekle.SubItems.Add(rd["kitapsayisi"].ToString());
                            ekle.SubItems.Add(rd["numara"].ToString());
                            ekle.SubItems.Add(rd["okul"].ToString());
                            ekle.SubItems.Add(rd["bolum"].ToString());
                            ekle.SubItems.Add(rd["sinif"].ToString());
                            ekle.SubItems.Add(lisemi);
                            listView1.Items.Add(ekle);
                        }

                    }

                }


            }
            else if (Ana_Sayfa.sivilmi)
            {
                labelnumara.Visible = tbnumara.Visible = label4.Visible = cbokul.Visible = false;
                lwpasaportkimlik.Width = 0;
                lwsinif.Width = 0;
                lwlisemi.Width = 0;
                lwbolum.Width = 0;
                lwokul.Width = 0;
                lwnumara.Width = 0;
                while (rd.Read())
                {
                    if (rd["tckimlik"].ToString().Length != 0)
                    {
                        if (rd["okuyucutipi"].ToString() == "Sivil")
                        {
                            ListViewItem ekle = new ListViewItem();
                            ekle.Text = rd["okuyucuid"].ToString();
                            ekle.SubItems.Add(rd["tckimlik"].ToString());
                            ekle.SubItems.Add(rd["pasaportkimlik"].ToString());
                            ekle.SubItems.Add(rd["adi"].ToString());
                            ekle.SubItems.Add(rd["soyadi"].ToString());
                            ekle.SubItems.Add(rd["cinsiyet"].ToString());
                            ekle.SubItems.Add(rd["dtarihi"].ToString());
                            ekle.SubItems.Add(rd["ktarihi"].ToString());
                            ekle.SubItems.Add(rd["mail"].ToString());
                            ekle.SubItems.Add(rd["telefon"].ToString());
                            ekle.SubItems.Add(rd["adres"].ToString());
                            ekle.SubItems.Add(rd["kitapsayisi"].ToString());
                            ekle.SubItems.Add(rd["numara"].ToString());
                            ekle.SubItems.Add(rd["okul"].ToString());
                            ekle.SubItems.Add(rd["bolum"].ToString());
                            ekle.SubItems.Add(rd["sinif"].ToString());
                            ekle.SubItems.Add(lisemi);
                            listView1.Items.Add(ekle);
                        }

                    }

                }
            }
         
        }

        private void yabancimi_CheckedChanged(object sender, EventArgs e)
        {

            if (yabancimi.Checked)
            {
                label23.Text = "Pasaport Numarası *:";
                tbtc.Clear();
                tbtc.Visible = false;
                tbpasaport.Visible = true;
                try
                {
                    listView1.Items.Clear();
                    lwpasaportkimlik.Width = 80;
                    lwtckimlik.Width = 0;
                    OleDbCommand cmd = new OleDbCommand("select * from okuyucu where pasaportkimlik like'" + tbpasaport.Text + "%'", conn);
                    OleDbDataReader rd = cmd.ExecuteReader();

                    while (rd.Read())
                    {

                        if (rd["pasaportkimlik"].ToString().Length != 0)
                        {
                            ListViewItem ekle = new ListViewItem();
                            ekle.Text = rd["okuyucuid"].ToString();
                            ekle.SubItems.Add(rd["tckimlik"].ToString());
                            ekle.SubItems.Add(rd["pasaportkimlik"].ToString());
                            ekle.SubItems.Add(rd["adi"].ToString());
                            ekle.SubItems.Add(rd["soyadi"].ToString());
                            ekle.SubItems.Add(rd["cinsiyet"].ToString());
                            ekle.SubItems.Add(rd["dtarihi"].ToString());
                            ekle.SubItems.Add(rd["ktarihi"].ToString());
                            ekle.SubItems.Add(rd["mail"].ToString());
                            ekle.SubItems.Add(rd["telefon"].ToString());
                            ekle.SubItems.Add(rd["adres"].ToString());
                            ekle.SubItems.Add(rd["kitapsayisi"].ToString());
                            ekle.SubItems.Add(rd["numara"].ToString());
                            ekle.SubItems.Add(rd["okul"].ToString());
                            ekle.SubItems.Add(rd["bolum"].ToString());
                            ekle.SubItems.Add(rd["sinif"].ToString());
                            ekle.SubItems.Add(lisemi);
                            listView1.Items.Add(ekle);
                        }
                    }
                }
                catch { }
            }
            else
            {
                tbpasaport.Clear();
                label23.Text = "TC Kimlik Numarası *:";
                tbpasaport.Visible = false;
                tbtc.Visible = true;
                try
                {
                    listView1.Items.Clear();
                    lwtckimlik.Width = 80;
                    lwpasaportkimlik.Width = 0;
                    OleDbCommand cmd = new OleDbCommand("select * from okuyucu where tckimlik like'" + tbtc.Text + "%'", conn);
                    OleDbDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        if (rd["tckimlik"].ToString().Length != 0)
                        {
                            ListViewItem ekle = new ListViewItem();
                            ekle.Text = rd["okuyucuid"].ToString();
                            ekle.SubItems.Add(rd["tckimlik"].ToString());
                            ekle.SubItems.Add(rd["pasaportkimlik"].ToString());
                            ekle.SubItems.Add(rd["adi"].ToString());
                            ekle.SubItems.Add(rd["soyadi"].ToString());
                            ekle.SubItems.Add(rd["cinsiyet"].ToString());
                            ekle.SubItems.Add(rd["dtarihi"].ToString());
                            ekle.SubItems.Add(rd["ktarihi"].ToString());
                            ekle.SubItems.Add(rd["mail"].ToString());
                            ekle.SubItems.Add(rd["telefon"].ToString());
                            ekle.SubItems.Add(rd["adres"].ToString());
                            ekle.SubItems.Add(rd["kitapsayisi"].ToString());
                            ekle.SubItems.Add(rd["numara"].ToString());
                            ekle.SubItems.Add(rd["okul"].ToString());
                            ekle.SubItems.Add(rd["bolum"].ToString());
                            ekle.SubItems.Add(rd["sinif"].ToString());
                            ekle.SubItems.Add(lisemi);
                            listView1.Items.Add(ekle);
                        }

                    }
                }
                catch { }

            }
        }

        private void tbpasaport_TextChanged(object sender, EventArgs e)
        {
            if (tbpasaport.Text.Length != 0)
            {
                tbadi.Enabled = tbnumara.Enabled = tbtc.Enabled = tbsoyadi.Enabled = cbokul.Enabled = false;
                veriarapasaport();
            }
            else
            {

                tbadi.Enabled = tbnumara.Enabled = tbtc.Enabled = tbsoyadi.Enabled = cbokul.Enabled = true;

                veriarapasaport();
            }
        }

        private void tbtc_TextChanged(object sender, EventArgs e)
        {
            if (tbtc.Text.Length != 0)
            {
                tbadi.Enabled = tbnumara.Enabled = tbpasaport.Enabled = tbsoyadi.Enabled = cbokul.Enabled = false;
                veriaratc();
            }
            else
            {
                tbadi.Enabled = tbnumara.Enabled = tbpasaport.Enabled = tbsoyadi.Enabled = cbokul.Enabled = true;
                veriaratc();
            }
        }

        private void tbadi_TextChanged(object sender, EventArgs e)
        {
            if (tbadi.Text.Length != 0)
            {
                lwpasaportkimlik.Width = lwtckimlik.Width = 80;
                tbtc.Enabled = tbnumara.Enabled = tbpasaport.Enabled = tbsoyadi.Enabled = cbokul.Enabled = false;
                veriaramaadi();
            }
            else
            {
                lwpasaportkimlik.Width = lwtckimlik.Width = 80;
                tbtc.Enabled = tbnumara.Enabled = tbpasaport.Enabled = tbsoyadi.Enabled = cbokul.Enabled = true;
                veriaratc();
            }
        }

        private void tbsoyadi_TextChanged(object sender, EventArgs e)
        {
            if (tbsoyadi.Text.Length != 0)
            {
                lwpasaportkimlik.Width = lwtckimlik.Width = 80;
                tbtc.Enabled = tbnumara.Enabled = tbpasaport.Enabled = tbadi.Enabled = cbokul.Enabled = false;
                veriaramasoyadi();

            }
            else
            {
                lwpasaportkimlik.Width = lwtckimlik.Width = 80;
                tbtc.Enabled = tbnumara.Enabled = tbpasaport.Enabled = tbadi.Enabled = cbokul.Enabled = true;
                veriaratc();
            }
        }

        private void tbnumara_TextChanged(object sender, EventArgs e)
        {
            if (tbnumara.Text.Length != 0)
            {
                lwpasaportkimlik.Width = lwtckimlik.Width = 80;
                tbtc.Enabled = tbsoyadi.Enabled = tbpasaport.Enabled = tbadi.Enabled = cbokul.Enabled = false;
                veriaramanumara();

            }
            else
            {
                lwpasaportkimlik.Width = lwtckimlik.Width = 80;
                tbtc.Enabled = tbsoyadi.Enabled = tbpasaport.Enabled = tbadi.Enabled = cbokul.Enabled = true;
                veriaratc();
            }
        }

        private void cbokul_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbokul.Text.Length != 0)
            {
                lwpasaportkimlik.Width = lwtckimlik.Width = 80;
                veriaramaokul();
            }
            else
            {
                lwpasaportkimlik.Width = lwtckimlik.Width = 80;
                veriaratc();
            }
        }
    }
}
