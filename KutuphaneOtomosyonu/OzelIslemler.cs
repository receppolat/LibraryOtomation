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

    public partial class kitapkoltuk : Form
    {
        public kitapkoltuk()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bin\\Debug\\KutuphaneOtomasyonu.mdb");
        DataSet ds = new DataSet();
        Boolean kturler,kkategoriler,gdturler;

        private void verigostergdt()
        {
          
            OleDbCommand cmdkontrol = new OleDbCommand("select * from gdturler", conn);
            OleDbDataReader rd = cmdkontrol.ExecuteReader();
            while (rd.Read())
            {
                if (rd["turadi"].ToString().ToLower() != tbdergit.Text.ToLower())
                {
                    if (ds.Tables["gdturler"] != null)
                        ds.Tables["gdturler"].Clear();
                    OleDbDataAdapter dadturler = new OleDbDataAdapter("select * from gdturler", conn);
                    dadturler.Fill(ds, "gdturler");
                    cbdergit.DataSource = ds.Tables["gdturler"];
                    cbdergit.ValueMember = "gdturid";
                    cbdergit.DisplayMember = "turadi";
                    break;
                }
            }

        }

        private void verigosterkt()
        {
            OleDbCommand cmdkontrol = new OleDbCommand("select * from kturler", conn);
            OleDbDataReader rd = cmdkontrol.ExecuteReader();
            while (rd.Read())
            {
                if (rd["kturadi"].ToString().ToLower() != tbkitapt.Text.ToLower())
                {
                    if (ds.Tables["kturler"] != null)
                        ds.Tables["kturler"].Clear();
                    OleDbDataAdapter dakkturler = new OleDbDataAdapter("select * from kturler", conn);
                    dakkturler.Fill(ds, "kturler");
                    cbkitapt.DataSource = ds.Tables["kturler"];
                    cbkitapt.ValueMember = "kturid";
                    cbkitapt.DisplayMember = "kturadi";
                    break;
                }
            }
        }
        private void verigosterkk()
        {
            OleDbCommand cmdkontrol = new OleDbCommand("select * from kkategoriler", conn);
            OleDbDataReader rd = cmdkontrol.ExecuteReader();
            while (rd.Read())
            {
                if (rd["kkategoriadi"].ToString().ToLower() != tbkitapk.Text.ToLower())
                {
                    if (ds.Tables["kkategoriler"] != null)
                        ds.Tables["kkategoriler"].Clear();
                    OleDbDataAdapter dakkategoriler = new OleDbDataAdapter("select * from kkategoriler", conn);
                    dakkategoriler.Fill(ds, "kkategoriler");
                    cbkitapk.DataSource = ds.Tables["kkategoriler"];
                    cbkitapk.ValueMember = "kkategorid";
                    cbkitapk.DisplayMember = "kkategoriadi";
                    break;
                }
            }
        }
        private void verigosterkkt()
        {
            OleDbCommand cmdkontrol = new OleDbCommand("select * from kturler", conn);
            OleDbDataReader rd = cmdkontrol.ExecuteReader();
            while (rd.Read())
            {
                if (rd["kturadi"].ToString().ToLower() != tbkitapt.Text.ToLower())
                {
                    if (ds.Tables["kturler1"] != null)
                        ds.Tables["kturler1"].Clear();
                    OleDbDataAdapter dakkturler = new OleDbDataAdapter("select * from kturler", conn);
                    dakkturler.Fill(ds, "kturler1");
                    cbkturler.DataSource = ds.Tables["kturler1"];
                    cbkturler.ValueMember = "kturid";
                    cbkturler.DisplayMember = "kturadi";
                    break;
                }
            }
        }


        private void OzelIslemler_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            OleDbDataAdapter dadturler = new OleDbDataAdapter("select * from gdturler", conn);
            dadturler.Fill(ds, "gdturler");
            cbdergit.DataSource = ds.Tables["gdturler"];
            cbdergit.ValueMember = "gdturid";
            cbdergit.DisplayMember = "turadi";

            OleDbDataAdapter dakkategoriler = new OleDbDataAdapter("select * from kkategoriler", conn);
            dakkategoriler.Fill(ds, "kkategoriler");
            cbkitapk.DataSource = ds.Tables["kkategoriler"];
            cbkitapk.ValueMember = "kkategorid";
            cbkitapk.DisplayMember = "kkategoriadi";

            OleDbDataAdapter dakkturler = new OleDbDataAdapter("select * from kturler", conn);
            dakkturler.Fill(ds, "kturler1");
            cbkturler.DataSource = ds.Tables["kturler1"];
            cbkturler.ValueMember = "kturid";
            cbkturler.DisplayMember = "kturadi";

            OleDbDataAdapter dakturler = new OleDbDataAdapter("select * from kturler", conn);
            dakturler.Fill(ds, "kturler");
            cbkitapt.DataSource = ds.Tables["kturler"];
            cbkitapt.ValueMember = "kturid";
            cbkitapt.DisplayMember = "kturadi";     
        }

        private void btndtekle_Click(object sender, EventArgs e)
        {
            if (tbdergit.Text.Length != 0)
            {        
              
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into gdturler (turadi) Values (@turadi)";
                    cmd.Parameters.AddWithValue("@turadi", tbdergit.Text);
                    cmd.ExecuteNonQuery();
                    verigostergdt();
                    MessageBox.Show("Kayıt Gerçekleşmiştir.");
            }
            else
                MessageBox.Show("Lütfen ilgili alanı doldurunuz");
        }

        private void tbdergit_TextChanged(object sender, EventArgs e)
        {
            OleDbCommand cmdkontrol = new OleDbCommand("select * from gdturler", conn);
            OleDbDataReader rd = cmdkontrol.ExecuteReader();
            while (rd.Read())
            {
                if (rd["turadi"].ToString().ToLower() == tbdergit.Text.ToLower())
                {
                    gdturler = false;
                    btndtekle.Enabled = false;
                    MessageBox.Show("Bu tür adı sistemde kayıtlıdır.");
                    break;
                }
                else
                    gdturler = true;
                  
            }
            if(gdturler)
            {
                gdturler = false;
                btndtekle.Enabled = true;
            }
        }

        private void tbkitapt_TextChanged(object sender, EventArgs e)
        {
            OleDbCommand cmdkontrol = new OleDbCommand("select * from kturler", conn);
            OleDbDataReader rd = cmdkontrol.ExecuteReader();
            while (rd.Read())
            {
                if (rd["kturadi"].ToString().ToLower() == tbkitapt.Text.ToLower())
                {
                    kturler = false;
                    btnktekle.Enabled = false;
                    MessageBox.Show("Bu tür adı sistemde kayıtlıdır.");
                    break;
                }
                else
                    kturler = true;
            }
            if (kturler)
            {
                kturler = false;
                btnktekle.Enabled = true;
            }
        }

        private void btnktekle_Click(object sender, EventArgs e)
        {
            if (tbkitapt.Text.Length != 0)
            {    
               
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into kturler (kturadi) Values (@kturadi)";
                    cmd.Parameters.AddWithValue("@kturadi", tbkitapt.Text);
                    cmd.ExecuteNonQuery();
                    verigosterkt();
                    verigosterkkt();
                    MessageBox.Show("Kayıt Gerçekleşmiştir.");
                    kturler = false;          
            }
            else
                MessageBox.Show("Lütfen ilgili alanı doldurunuz");
        }

        private void tbkoltuk_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnkontenjan_Click(object sender, EventArgs e)
        {
          
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update kutuphane set kitaplikkoltuk=@kitaplikkoltuk, gazetekoltuk=@gazetekoltuk where kontenjanid="+1;
                cmd.Parameters.AddWithValue("@kitaplikkoltuk", kitaplıkkoltuk);
                cmd.Parameters.AddWithValue("@gazetekoltuk", gazetekoltuk);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Gerçekleşmiştir. \n Kaydın güncellenmesi için uygulamayı yeniden başlatınız.");
           
        }

        private void btnkkekle_Click(object sender, EventArgs e)
        {
            if (tbkitapk.Text.Length != 0 && cbkturler.Text.Length != 0)
            {
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into kkategoriler (kkategoriadi,kturid) Values (@kkategoriadi,@kturid)";
                    cmd.Parameters.AddWithValue("@kkategoriadi", tbkitapk.Text);
                    cmd.Parameters.AddWithValue("@kturid", cbkturler.SelectedValue);
                    cmd.ExecuteNonQuery();
                    verigosterkk();
                    MessageBox.Show("Kayıt Gerçekleşmiştir.");
                
            }
            else
                MessageBox.Show("Lütfen ilgili alanı doldurunuz");
        }
        private void tbkitapk_TextChanged(object sender, EventArgs e)
        {

            OleDbCommand cmdkontrol = new OleDbCommand("select * from kkategoriler", conn);
            OleDbDataReader rd = cmdkontrol.ExecuteReader();
            while (rd.Read())
            {
                if (rd["kkategoriadi"].ToString().ToLower() == tbkitapk.Text.ToLower())
                {
                    kkategoriler = false;
                    btnkkekle.Enabled = false ;
                    MessageBox.Show("Bu kategori adı sistemde kayıtlıdır.");
                    break;
                }
                else
                    kkategoriler = true;
            }
            if (kkategoriler)
            {
                kkategoriler = false;
                btnkkekle.Enabled = true;
            }
        }
    }
}
