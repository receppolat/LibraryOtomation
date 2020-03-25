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
    public partial class PersonelDuzenlemeVeSilme : Form
    {
        public PersonelDuzenlemeVeSilme()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bin\\Debug\\KutuphaneOtomasyonu.mdb");
        int satir;
        string gonderilen;

        private void verigoster(string cumlecik)
        {
            listView1.Items.Clear();
            OleDbCommand cmd = new OleDbCommand(cumlecik, conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if(lwpasaport.Width>lwtc.Width)
                {
                    if (rd["pasaportkimlik"].ToString().Length != 0)
                    {
                        ListViewItem ekle = new ListViewItem();
                        ekle.Text = rd["personelid"].ToString();
                        ekle.SubItems.Add(rd["tckimlik"].ToString());
                        ekle.SubItems.Add(rd["pasaportkimlik"].ToString());
                        ekle.SubItems.Add(rd["adi"].ToString());
                        ekle.SubItems.Add(rd["soyadi"].ToString());
                        ekle.SubItems.Add(rd["gorevi"].ToString());
                        ekle.SubItems.Add(rd["telefon"].ToString());
                        ekle.SubItems.Add(rd["mail"].ToString());
                        listView1.Items.Add(ekle);
                    }

                }
                else
                {
                    if (rd["tckimlik"].ToString().Length != 0)
                    {
                        ListViewItem ekle = new ListViewItem();
                        ekle.Text = rd["personelid"].ToString();
                        ekle.SubItems.Add(rd["tckimlik"].ToString());
                        ekle.SubItems.Add(rd["pasaportkimlik"].ToString());
                        ekle.SubItems.Add(rd["adi"].ToString());
                        ekle.SubItems.Add(rd["soyadi"].ToString());
                        ekle.SubItems.Add(rd["gorevi"].ToString());
                        ekle.SubItems.Add(rd["telefon"].ToString());
                        ekle.SubItems.Add(rd["mail"].ToString());
                        listView1.Items.Add(ekle);
                    }
                }
                
            }
        }

        private void yabancimi_CheckedChanged(object sender, EventArgs e)
        {
            if (yabancimi.Checked)
            {
                label23.Text = "Pasaport Numarası:";
                tbpasaport.Visible = true;
                tbtc.Visible = false;
                tbtc.Clear();
                tbpasaport.Focus();
                lwpasaport.Width = 80;
                lwtc.Width = 0;
                gonderilen = "select * from personel where pasaportkimlik like'" + tbpasaport.Text + "%'";
                verigoster(gonderilen);         
            }

            else
            {
                label23.Text = "TC Kimklik Numarası:";
                tbtc.Visible = true;
                tbpasaport.Visible = false;
                tbpasaport.Clear();
                tbtc.Focus();
                lwpasaport.Width = 0;
                lwtc.Width = 80;
                gonderilen = "select * from personel where tckimlik like'" + tbtc.Text + "%'";
                verigoster(gonderilen);

            }
        }

        private void btnislevler_Click(object sender, EventArgs e)
        {
            if (Ana_Sayfa.personelduzenlmemi == false)
            {
                DialogResult cevap = MessageBox.Show("Emin misiniz?", "", MessageBoxButtons.YesNo);
                if (cevap == DialogResult.Yes)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from personel where personelid=@personelid";
                    cmd.Parameters.AddWithValue("@personelid", satir);
                    cmd.ExecuteNonQuery();
                    tbpersonelid.Clear();
                    tbtel.Clear();
                    tbsoyisim.Clear();
                    tbtc.Clear();
                    tbpasaport.Clear();
                    tbmail.Clear();
                    tbisim.Clear();
                    tbadres.Clear();
                    sorumlu.Checked = memur.Checked = diger.Checked = false;
                    fotografpersonelekleme.ImageLocation= "";
                    gonderilen = "select * from personel";
                    verigoster(gonderilen);
                    MessageBox.Show("Kaydınız Silindi.");
                    
                }
            }
            else
            {
                string gorevi1;
                if (sorumlu.Checked)
                    gorevi1 = sorumlu.Text;
                else if (memur.Checked)
                    gorevi1 = memur.Text;
                else
                    gorevi1 = diger.Text;

                if (tbisim.Text.Length != 0 && tbsoyisim.Text.Length != 0 && tbadres.Text.Length != 0 && tbtel.Text.Length == 14 && tbpersonelid.Text.Length != 0 && (memur.Checked || diger.Checked || sorumlu.Checked) && fotografpersonelekleme.ImageLocation.ToString().Length != 0)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "update personel set adi=@adi,soyadi=@soyadi,mail=@mail,telefon=@telefon,adres=@adres,gorevi=@gorevi,fotograf=@fotograf where personelid=@personelid";
                    cmd.Parameters.AddWithValue("@adi", tbisim.Text);
                    cmd.Parameters.AddWithValue("@soyadi", tbsoyisim.Text);
                    cmd.Parameters.AddWithValue("@mail", tbmail.Text);
                    cmd.Parameters.AddWithValue("@telefon", tbtel.Text);
                    cmd.Parameters.AddWithValue("@adres", tbadres.Text);
                    cmd.Parameters.AddWithValue("@gorevi", gorevi1);
                    cmd.Parameters.AddWithValue("@fotograf", fotografpersonelekleme.ImageLocation.ToString());
                    cmd.Parameters.AddWithValue("@personelid", int.Parse(tbpersonelid.Text));
                    cmd.ExecuteNonQuery();
                    gonderilen = "select * from personel";
                    verigoster(gonderilen);
                    MessageBox.Show("Kayıt Güncellenmiştir.");
                    tbisim.Clear();
                    tbsoyisim.Clear();
                    tbmail.Clear();
                    tbadres.Clear();
                    tbtel.Clear();
                    sorumlu.Checked = memur.Checked = diger.Checked = false;
                    tbpersonelid.Clear();
                    fotografpersonelekleme.ImageLocation = Application.StartupPath + "\\fotograflar\\personel\\man-user.png";
                }
                else
                {
                    gonderilen = "select * from personel";
                    verigoster(gonderilen);
                    MessageBox.Show("Lütfen yıldızlı alanları doldurunuz.", "Dikkat!" + MessageBoxIcon.Warning);      
                }

            }
        }

        private void btngazetefotograf_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\fotograflar\\personel\\";
            DialogResult konum = openFileDialog1.ShowDialog();
            fotografpersonelekleme.ImageLocation = openFileDialog1.FileName;
        }

        private void PersonelDuzenlemeVeSilme_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            dtarihi.MaxDate = DateTime.Now.AddYears(-18);
            lwpasaport.Width = 0;
            gonderilen = "select * from personel";
            verigoster(gonderilen);
            btnislevler.Enabled = false;
            fotografpersonelekleme.ImageLocation = Application.StartupPath + "\\fotograflar\\personel\\man-user.png";
            if (Ana_Sayfa.personelduzenlmemi==false)
            {                
                this.Text = "Personel Silme";
                btnislevler.Text = "Sil";
            }
            else
            {              
                this.Text = "Personel Düzenleme";
                btnislevler.Text = "Güncelle";
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnislevler.Enabled = true;
            if (Ana_Sayfa.personelduzenlmemi)
            {
                tbisim.ReadOnly = tbsoyisim.ReadOnly=tbpersonelid.ReadOnly = tbmail.ReadOnly = tbadres.ReadOnly = false;
                tbpersonelid.ReadOnly = true;
                dtarihi.Enabled = tbtel.Enabled = sorumlu.Enabled = memur.Enabled = diger.Enabled = btnpersonelfotograf.Enabled = true;
            }         
            try
            {
                satir = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                OleDbCommand cmd = new OleDbCommand("select * from personel where personelid=" + satir, conn);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    tbisim.Text = rd["adi"].ToString();
                    tbsoyisim.Text = rd["soyadi"].ToString();
                    dtarihi.Text = rd["dtarihi"].ToString();
                    tbmail.Text = rd["mail"].ToString();
                    tbtel.Text = rd["telefon"].ToString();
                    tbadres.Text = rd["adres"].ToString();
                    tbpersonelid.Text = rd["personelid"].ToString();
                    if (rd["gorevi"].ToString() == sorumlu.Text)
                        sorumlu.Checked = true;
                    else if (rd["gorevi"].ToString() == memur.Text)
                        memur.Checked = true;
                    else
                        diger.Checked = true;
                    fotografpersonelekleme.ImageLocation = rd["fotograf"].ToString();
                }
            }
            catch { }
        }

        private void tbpasaport_TextChanged(object sender, EventArgs e)
        {
            
            if (yabancimi.Checked)
            {
                if (tbpasaport.Text.Length != 0)
                {
                    gonderilen = "select * from personel where pasaportkimlik like'" + tbpasaport.Text + "%'";
                    verigoster(gonderilen);
                }
                else
                {
                    gonderilen = "select * from personel";
                    verigoster(gonderilen);
                }
            }
            else
            {
                gonderilen = "select * from personel where tckimlik like'" + tbtc.Text + "%'";
                verigoster(gonderilen);
            }
        }

        private void tbtc_TextChanged(object sender, EventArgs e)
        {
           
            if (yabancimi.Checked==false)
            {
                if (tbtc.Text.Length != 0)
                {
                   gonderilen= "select * from personel where tckimlik like'" + tbtc.Text + "%'";
                    verigoster(gonderilen);
                }
                else
                {
                    gonderilen = "select * from personel";
                    verigoster(gonderilen);
                }
            }
            else
            {
                gonderilen = "select * from personel where pasaportkimlik like'" + tbpasaport.Text + "%'";
                verigoster(gonderilen);
            }

        }

        private void tbpersonelid_TextChanged(object sender, EventArgs e)
        {
            //personelidi güncellettir ama aynı personelidlere izin verme
        }
    }
}
