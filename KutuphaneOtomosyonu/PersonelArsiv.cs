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
    public partial class PersonelArsiv : Form
    {
        public PersonelArsiv()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bin\\Debug\\KutuphaneOtomasyonu.mdb");
        string gonderilen,gorevi;
        

        private void verigoster(string cumlecik)
        {
            try {
                listView1.Items.Clear();
                OleDbCommand cmd = new OleDbCommand(cumlecik, conn);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (rd["gorevi"].ToString() == "Kat Sorumlusu")
                        gorevi = "Kat Sorumlusu";
                    else if (rd["gorevi"].ToString() == "Kütüphane Memuru")
                        gorevi = "Kütüphane Memuru";
                    else if (rd["gorevi"].ToString() == "Yönetici")
                        gorevi = "Yönetici";
                    else
                        gorevi = "Diğer";

                    if (lwpasaportkimlik.Width > lwtckimlik.Width)
                    {
                        if (rd["pasaportkimlik"].ToString().Length != 0)
                        {
                            ListViewItem ekle = new ListViewItem();
                            ekle.Text = rd["personelid"].ToString();
                            ekle.SubItems.Add(rd["sifre"].ToString());
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
                            ekle.SubItems.Add(gorevi);
                            ekle.SubItems.Add(rd["gsorusu1"].ToString());
                            ekle.SubItems.Add(rd["gsorusu2"].ToString());
                            ekle.SubItems.Add(rd["gsorusu3"].ToString());
                            ekle.SubItems.Add(rd["cevap1"].ToString());
                            ekle.SubItems.Add(rd["cevap2"].ToString());
                            ekle.SubItems.Add(rd["cevap3"].ToString());
                            listView1.Items.Add(ekle);
                        }
                    }
                    else
                    {
                        if (rd["tckimlik"].ToString().Length != 0)
                        {
                            ListViewItem ekle = new ListViewItem();
                            ekle.Text = rd["personelid"].ToString();
                            ekle.SubItems.Add(rd["sifre"].ToString());
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
                            ekle.SubItems.Add(gorevi);
                            ekle.SubItems.Add(rd["gsorusu1"].ToString());
                            ekle.SubItems.Add(rd["gsorusu2"].ToString());
                            ekle.SubItems.Add(rd["gsorusu3"].ToString());
                            ekle.SubItems.Add(rd["cevap1"].ToString());
                            ekle.SubItems.Add(rd["cevap2"].ToString());
                            ekle.SubItems.Add(rd["cevap3"].ToString());
                            listView1.Items.Add(ekle);
                        }
                    }
                }
            }
            catch { }
            
        }

        private void PersonelArsiv_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            lwpasaportkimlik.Width = 0;
            gonderilen = "select * from personel";
            verigoster(gonderilen);
        }

        private void yabancimi_CheckedChanged(object sender, EventArgs e)
        {
            if(yabancimi.Checked)
            {
                tbpasaportkimlik.Visible = true;
                tbtc.Visible = false;
                tbtc.Clear();
                lwpasaportkimlik.Width = 80;
                lwtckimlik.Width = 0;
                gonderilen = "select * from personel where pasaportkimlik like'" + tbpasaportkimlik.Text + "%'";
                verigoster(gonderilen);

            }
            else
            {
                tbpasaportkimlik.Visible = false;
                tbtc.Visible = true;
                tbpasaportkimlik.Clear();
                lwtckimlik.Width = 80;
                lwpasaportkimlik.Width = 0;
                gonderilen = "select * from personel where tckimlik like'" + tbtc.Text + "%'";
                verigoster(gonderilen);

            }
        }

        private void tbtc_TextChanged(object sender, EventArgs e)
        {
            if(tbtc.Text.Length!=0)
            {
                tbadi.Enabled = tbpersonelid.Enabled = tbsoyadi.Enabled = tbpasaportkimlik.Enabled = false;
                lwtckimlik.Width = 80;
                lwpasaportkimlik.Width = 0;
                gonderilen = "select * from personel where tckimlik like'" + tbtc.Text + "%'";
                verigoster(gonderilen);
            }
            else
            {
                gonderilen = "select * from personel where tckimlik like'" + tbtc.Text + "%'";
                verigoster(gonderilen);
                tbadi.Enabled = tbpersonelid.Enabled = tbsoyadi.Enabled = tbpasaportkimlik.Enabled = true;
            }
        }

        private void tbpasaportkimlik_TextChanged(object sender, EventArgs e)
        {
            if (tbpasaportkimlik.Text.Length != 0)
            {
                tbadi.Enabled = tbpersonelid.Enabled = tbtc.Enabled = tbsoyadi.Enabled = false;
                lwtckimlik.Width = 0;
                lwpasaportkimlik.Width = 80;
                gonderilen = "select * from personel where pasaportkimlik like'" + tbpasaportkimlik.Text + "%'";
                verigoster(gonderilen);
            }
            else
            {
                gonderilen = "select * from personel where pasaportkimlik like'" + tbpasaportkimlik.Text + "%'";
                verigoster(gonderilen);
                tbadi.Enabled = tbpersonelid.Enabled = tbtc.Enabled = tbsoyadi.Enabled = true;
            }
        }

        private void tbpersonelid_TextChanged(object sender, EventArgs e)
        {
            if (tbpersonelid.Text.Length != 0)
            {
                tbadi.Enabled = tbsoyadi.Enabled = tbtc.Enabled = tbpasaportkimlik.Enabled = false;
                lwtckimlik.Width = 80;
                lwpasaportkimlik.Width = 0;
                if (yabancimi.Checked)
                {
                    lwtckimlik.Width = 0;
                    lwpasaportkimlik.Width = 80;

                }
                else
                {
                    lwtckimlik.Width = 80;
                    lwpasaportkimlik.Width = 0;
                }
                gonderilen = "select * from personel where personelid like'" + tbpersonelid.Text + "%'";
                verigoster(gonderilen);

            }
            else
            {
                gonderilen = "select * from personel where personelid like'" + tbpersonelid.Text + "%'";
                verigoster(gonderilen);
                tbadi.Enabled = tbsoyadi.Enabled = tbtc.Enabled = tbpasaportkimlik.Enabled = true;
            }
        }

        private void tbadi_TextChanged(object sender, EventArgs e)
        {
            if (tbadi.Text.Length != 0)
            {
                tbsoyadi.Enabled = tbpersonelid.Enabled = tbtc.Enabled = tbpasaportkimlik.Enabled = false;
                lwtckimlik.Width = 80;
                lwpasaportkimlik.Width = 0;
                if (yabancimi.Checked)
                {
                    lwtckimlik.Width = 0;
                    lwpasaportkimlik.Width = 80;

                }
                else
                {
                    lwtckimlik.Width = 80;
                    lwpasaportkimlik.Width = 0;
                }
                gonderilen = "select * from personel where adi like'" + tbadi.Text + "%'";
                verigoster(gonderilen);

            }
            else
            {
                gonderilen = "select * from personel where adi like'" + tbadi.Text + "%'";
                verigoster(gonderilen);
                tbsoyadi.Enabled = tbpersonelid.Enabled = tbtc.Enabled = tbpasaportkimlik.Enabled = true;
            }
        }

        private void tbsoyadi_TextChanged(object sender, EventArgs e)
        {
            if (tbsoyadi.Text.Length != 0)
            {
                tbadi.Enabled = tbpersonelid.Enabled = tbtc.Enabled = tbpasaportkimlik.Enabled = false;
                lwtckimlik.Width = 80;
                lwpasaportkimlik.Width = 0;
                if (yabancimi.Checked)
                {
                    lwtckimlik.Width = 0;
                    lwpasaportkimlik.Width = 80;

                }
                else
                {
                    lwtckimlik.Width = 80;
                    lwpasaportkimlik.Width = 0;
                }
                gonderilen = "select * from personel where soyadi like'" + tbsoyadi.Text + "%'";
                verigoster(gonderilen);

            }
            else
            {
                gonderilen = "select * from personel where soyadi like'" + tbsoyadi.Text + "%'";
                verigoster(gonderilen);
                tbadi.Enabled = tbpersonelid.Enabled = tbtc.Enabled = tbpasaportkimlik.Enabled = true;
            }
        }
    }
}
