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
    public partial class Giris : Form
    {      
        public Giris()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bin\\Debug\\KutuphaneOtomasyonu.mdb");
        public static string personelid;
        public static Boolean yöneticimi;
        private void Giris_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand komut = new OleDbCommand("select * from personel where personelid=" + tbpersonelid.Text, conn);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    if (oku["gorevi"].ToString() == "Kütüphane Memuru"||oku["gorevi"].ToString()=="Yönetici")
                    {                    
                            if (oku["sifre"].ToString() == tbsifre.Text&& oku["personelid"].ToString() == tbpersonelid.Text)
                            {
                                personelid = tbpersonelid.Text;
                                yöneticimi = false;

                                Ana_Sayfa gecis = new Ana_Sayfa();
                                gecis.ShowDialog();
                            }
                            else
                                MessageBox.Show("Şifreniz ya da Personel Numaranız hatalıdır.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Sisteme personel olarak girmeye yetkiniz bulunmamaktadır.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }                     
        }   

        private void btnyonetici_Click(object sender, EventArgs e)
        {
            Yonetici_Giris gecis = new Yonetici_Giris();
            gecis.ShowDialog();
          
        }

        private void tbpersonelid_TextChanged(object sender, EventArgs e)
        {
            if (tbpersonelid.Text.Length == 6|| tbpersonelid.Text.Length == 0)
                tbsifre.ReadOnly = false;               
            else
                tbsifre.ReadOnly = true;
        }
    }
}
