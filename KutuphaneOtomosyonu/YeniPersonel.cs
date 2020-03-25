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
    public partial class YeniPersonel : Form
    {
        public YeniPersonel()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bin\\Debug\\KutuphaneOtomasyonu.mdb");
        Random sayi = new Random();
        int personelid;

        private void yabancimi_CheckedChanged(object sender, EventArgs e)
        {
            if (yabancimi.Checked)
            {
                label23.Text = "Pasaport Numarası:";
                tbtc.Visible = false;
                tbpasaport.Visible = true;
                tbtc.Clear();
            }

            else
            {
                label23.Text = "TC Kimklik Numarası:";
                tbtc.Visible = true;
                tbpasaport.Visible = false;
                tbpasaport.Clear();
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string gorevi = "as", cinsiyet = "sad";
            if (sorumlu.Checked)
                gorevi = sorumlu.Text;
            else if (memur.Checked)
                gorevi = memur.Text;
            else if (diger.Checked)
                gorevi = diger.Text;
            if (rberkek.Checked)
                cinsiyet = rberkek.Text;
            else if (rbkadin.Checked)
                cinsiyet = rbkadin.Text;

            if (yabancimi.Checked)
            {
               
                if (tbsifre.Text.Length==6&&tbpasaport.Text.Length == 9 && tbisim.Text.Length != 0 && tbsoyisim.Text.Length != 0 && (rberkek.Checked || rbkadin.Checked) && tbadres.Text.Length != 0 && tbtel.Text.Length == 14 && dtarihi.Text.Length != 0 && ktarihi.Text.Length != 0 && tbpersonelid.Text.Length != 0 && (memur.Checked || diger.Checked || sorumlu.Checked) && fotografpersonelekleme.ImageLocation != null)
                {                   
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into personel (tckimlik,personelid,pasaportkimlik,adi,soyadi,cinsiyet,dtarihi,mail,telefon,adres,gorevi,ktarihi,fotograf,sifre) Values (@tckimlik,@personelid,@pasaportkimlik,@adi,@soyadi,@cinsiyet,@dtarihi,@mail,@telefon,@adres,@gorevi,@ktarihi,@fotograf,@sifre)";
                    cmd.Parameters.AddWithValue("@tckimlik", "Yabancı");
                    cmd.Parameters.AddWithValue("@personelid", tbpersonelid.Text);
                    cmd.Parameters.AddWithValue("@pasaportkimlik", tbpasaport.Text);
                    cmd.Parameters.AddWithValue("@adi", tbisim.Text);
                    cmd.Parameters.AddWithValue("@soyadi", tbsoyisim.Text);
                    cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                    cmd.Parameters.AddWithValue("@dtarihi", dtarihi.Text);
                    cmd.Parameters.AddWithValue("@mail", tbmail.Text);
                    cmd.Parameters.AddWithValue("@telefon", tbtel.Text);
                    cmd.Parameters.AddWithValue("@adres", tbadres.Text);
                    cmd.Parameters.AddWithValue("@gorevi", gorevi);
                    cmd.Parameters.AddWithValue("@ktarihi", ktarihi.Text);
                    cmd.Parameters.AddWithValue("@fotograf", fotografpersonelekleme.ImageLocation.ToString());
                    cmd.Parameters.AddWithValue("@sifre", tbsifre.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Gerçekleştirilmiştir.");
                    this.Close();
                }
                else
                    MessageBox.Show("Lütfen yıldızlı alanları doldurunuz.", "Dikkat!" + MessageBoxIcon.Warning);

            }
            else 
            {
                if (tbsifre.Text.Length == 6 && tbtc.Text.Length == 11 && tbisim.Text.Length != 0 && tbsoyisim.Text.Length != 0 && (rberkek.Checked || rbkadin.Checked) && tbadres.Text.Length != 0 && tbtel.Text.Length == 14 && dtarihi.Text.Length != 0 && ktarihi.Text.Length != 0 && tbpersonelid.Text.Length != 0 && (memur.Checked || diger.Checked || sorumlu.Checked) && fotografpersonelekleme.ImageLocation!= null)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into personel (pasaportkimlik,personelid,tckimlik,adi,soyadi,cinsiyet,dtarihi,mail,telefon,adres,gorevi,ktarihi,fotograf,sifre) Values (@pasaportkimlik,@personelid,@tckimlik,@adi,@soyadi,@cinsiyet,@dtarihi,@mail,@telefon,@adres,@gorevi,@ktarihi,@fotograf,@sifre)";
                    cmd.Parameters.AddWithValue("@pasaportkimlik", "TC");
                    cmd.Parameters.AddWithValue("@personelid", tbpersonelid.Text);
                    cmd.Parameters.AddWithValue("@tckimlik", tbtc.Text);
                    cmd.Parameters.AddWithValue("@adi", tbisim.Text);
                    cmd.Parameters.AddWithValue("@soyadi", tbsoyisim.Text);
                    cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                    cmd.Parameters.AddWithValue("@dtarihi", dtarihi.Text);
                    cmd.Parameters.AddWithValue("@mail", tbmail.Text);
                    cmd.Parameters.AddWithValue("@telefon", tbtel.Text);
                    cmd.Parameters.AddWithValue("@adres", tbadres.Text);
                    cmd.Parameters.AddWithValue("@gorevi", gorevi);
                    cmd.Parameters.AddWithValue("@ktarihi", ktarihi.Text);
                    cmd.Parameters.AddWithValue("@fotograf", fotografpersonelekleme.ImageLocation.ToString());
                    cmd.Parameters.AddWithValue("@sifre", tbsifre.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Gerçekleştirilmiştir.");
                    this.Close();
                }
                else
                    MessageBox.Show("Lütfen yıldızlı alanları doldurunuz.", "Dikkat!" + MessageBoxIcon.Warning);
            }
            
        }

        private void YeniPersonel_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            fotografpersonelekleme.ImageLocation=Application.StartupPath+ "\\fotograflar\\personel\\man-user.png";
            dtarihi.MaxDate = DateTime.Now.AddYears(-18);
            ktarihi.MaxDate = DateTime.Today;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from personel";
            OleDbDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                personelid = sayi.Next(100000, 1000000);
                if (personelid.ToString() !=dr["personelid"].ToString())
                    tbpersonelid.Text = personelid.ToString();
                else
                {
                    personelid = sayi.Next(100000, 1000000);
                    tbpersonelid.Text = personelid.ToString();
                }
            }
            
            
        }

        private void btnpersonelfotograf_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\fotograflar\\personel\\";
            DialogResult konum = openFileDialog1.ShowDialog();
            fotografpersonelekleme.ImageLocation = openFileDialog1.FileName;
        }

        private void tbpasaport_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (tbpasaport.Text.Length ==9)
                {
                    OleDbCommand komut = new OleDbCommand("select * from personel where pasaportkimlik=@pasaportkimlik", conn);
                    komut.Parameters.AddWithValue("@pasaportkimlik", tbpasaport.Text);
                    OleDbDataReader oku = komut.ExecuteReader();
                    while(oku.Read())
                    {
                        if (oku["pasaportkimlik"].ToString() == tbpasaport.Text)
                        {
                            MessageBox.Show("Bu personel sistemde kayıtlıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tbpasaport.Clear();
                        }
                    }
                    if (yabancimi.Checked)
                    {
                        tbsifre.Clear();
                        tbsifre.Text = tbpasaport.Text.Substring(0, 6);
                    }
                    else
                    {
                        tbpasaport.Clear();
                    }
                }
                else
                    tbsifre.Clear();
            }
            catch { }
           
        }

        private void tbtc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbtc.Text.Length ==11)
                {
                    OleDbCommand komut = new OleDbCommand("select * from personel where tckimlik=@tckimlik", conn);
                    komut.Parameters.AddWithValue("@tckimlik", tbtc.Text);
                    OleDbDataReader oku = komut.ExecuteReader();
                    while(oku.Read())
                    
                        if (oku["tckimlik"].ToString() == tbtc.Text)
                        {
                            MessageBox.Show("Bu personel sistemde kayıtlıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tbtc.Clear();
                        }
                    
                    if (yabancimi.Checked)
                    {
                        tbtc.Clear();
                    }
                    else
                    {
                        tbsifre.Clear();
                        tbsifre.Text = tbtc.Text.Substring(0, 6);
                    }

                }
                else
                    tbsifre.Clear();           
            }
            catch { }
           
        }
    }
}
