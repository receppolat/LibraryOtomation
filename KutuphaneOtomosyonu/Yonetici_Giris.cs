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
    public partial class Yonetici_Giris : Form
    {
        public Yonetici_Giris()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bin\\Debug\\KutuphaneOtomasyonu.mdb");

        private void btnyoneticigiris_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand komut = new OleDbCommand("select * from personel where personelid=" + tbyoneticiid.Text, conn);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    if (oku["gorevi"].ToString() == "Yönetici")
                    {
                        if (oku["sifre"].ToString() == tbyoneticisifre.Text&&oku["personelid"].ToString()==tbyoneticiid.Text)
                        {
                            Giris.yöneticimi = true;
                            Ana_Sayfa gecis = new Ana_Sayfa();
                            gecis.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Şifreniz ya da Personel Numaranız hatalıdır.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbyoneticiid.Clear();
                            tbyoneticisifre.Clear();
                        }                  
                    }
                    else
                    {
                        MessageBox.Show("Yetki derecesi yetersiz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbyoneticiid.Clear();
                        tbyoneticisifre.Clear();
                    }
                }
            }
            catch
            {

            }
           

        }

        private void Yonetici_Giris_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            panel1.BackColor = Color.FromArgb(100, 0, 0,0);
        }

        private void tbyoneticiid_TextChanged(object sender, EventArgs e)
        {
            if (tbyoneticiid.Text.Length != 0)
                tbyoneticisifre.ReadOnly = false;
            else
                tbyoneticisifre.ReadOnly = true;
        }
    }
}
