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
    public partial class GazeteArsiv : Form
    {
        public GazeteArsiv()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bin\\Debug\\KutuphaneOtomasyonu.mdb");
        DataSet ds = new DataSet();
        string  gonderilen;

        private void verigoster(string cumlecik)
        {
            listView1.Items.Clear();
            OleDbCommand cmd = new OleDbCommand(cumlecik, conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rd["gazeteid"].ToString();
                ekle.SubItems.Add(rd["barkod"].ToString());
                ekle.SubItems.Add(rd["adi"].ToString());
                ekle.SubItems.Add(rd["issn"].ToString());
                ekle.SubItems.Add(rd["ytarihi"].ToString());
                ekle.SubItems.Add(rd["ttarihi"].ToString());
                ekle.SubItems.Add(rd["hasardurum"].ToString());
                ekle.SubItems.Add(rd["fiyat"].ToString());
                ekle.SubItems.Add(rd["sayfas"].ToString());
                ekle.SubItems.Add(rd["stoks"].ToString());
                ekle.SubItems.Add(rd["okunmasayisi"].ToString());
                if(rd["dergimi"].ToString()==true.ToString())
                {
                    lwsayisi.Width = lwturu.Width = lwyonetmen.Width = 80;
                    ekle.SubItems.Add(rd["sayisi"].ToString());
                    ekle.SubItems.Add(rd["turu"].ToString());
                    ekle.SubItems.Add(rd["yonetmeni"].ToString());
                }
                else
                {
                    lwsayisi.Width = lwturu.Width = lwyonetmen.Width = 0;
                }
                if (rd["musaitmi"].ToString() == true.ToString())
                    ekle.BackColor = Color.Green;
                else
                    ekle.BackColor = Color.Red;
                listView1.Items.Add(ekle);
            }
        }

        private void verimusait(string cumlecikmusait)
        {
            listView1.Items.Clear();
            OleDbCommand cmd = new OleDbCommand(cumlecikmusait, conn);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd["musaitmi"].ToString() == true.ToString())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = rd["gazeteid"].ToString();
                    ekle.SubItems.Add(rd["barkod"].ToString());
                    ekle.SubItems.Add(rd["adi"].ToString());
                    ekle.SubItems.Add(rd["issn"].ToString());
                    ekle.SubItems.Add(rd["ytarihi"].ToString());
                    ekle.SubItems.Add(rd["ttarihi"].ToString());
                    ekle.SubItems.Add(rd["hasardurum"].ToString());
                    ekle.SubItems.Add(rd["fiyat"].ToString());
                    ekle.SubItems.Add(rd["sayfas"].ToString());
                    ekle.SubItems.Add(rd["stoks"].ToString());
                    ekle.SubItems.Add(rd["okunmasayisi"].ToString());
                    if (rd["dergimi"].ToString() == true.ToString())
                    {
                        ekle.SubItems.Add(rd["sayisi"].ToString());
                        ekle.SubItems.Add(rd["turu"].ToString());
                        ekle.SubItems.Add(rd["yonetmeni"].ToString());
                    }
                    ekle.BackColor = Color.Green;

                    listView1.Items.Add(ekle);

                }
            }
        }

        private void tbbarkodno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbbarkodno.Text.Length != 0)
                {
                    tbissn.Enabled = tbadi.Enabled = tbyonetmen.Enabled = cbtumkayitlar.Enabled = cbmusaitler.Enabled = cbhasardurumu.Enabled = cbtur.Enabled = yayimtarihi.Enabled = false;

                    if (tbbarkodno.Text.Substring(0, 1).ToLower() == "g".ToLower() || tbbarkodno.Text.Substring(0, 1).ToLower() == "d".ToLower())
                    {
                        if (cbmusaitler.Checked)
                        {
                            gonderilen = "select * from gazeteler where barkod like'" + tbbarkodno.Text + "%'";
                            verimusait(gonderilen);
                        }
                        else
                        {
                            gonderilen = "select * from gazeteler where barkod like'" + tbbarkodno.Text + "%'";
                            verigoster(gonderilen);
                        }
                    }
                    else
                    {
                        MessageBox.Show("İlk hane g veya d ile başlamalıdır.");
                        tbbarkodno.Clear();
                        gonderilen = "select * from gazeteler";
                        verigoster(gonderilen);
                    
                    }
                }
                else
                {
                    if (cbmusaitler.Checked)
                    {
                        gonderilen = "select * from gazeteler where barkod like'" + tbbarkodno.Text + "%'";
                        verimusait(gonderilen);
                    }
                    else
                    {
                        gonderilen = "select * from gazeteler";
                        verigoster(gonderilen);
                    }
                        tbissn.Enabled = tbadi.Enabled = tbyonetmen.Enabled= cbtumkayitlar.Enabled = cbmusaitler.Enabled = cbhasardurumu.Enabled = cbtur.Enabled = yayimtarihi.Enabled = true;
                  
                }
            }
            catch { }
        }

        private void tbadi_TextChanged(object sender, EventArgs e)
        {

            if (tbadi.Text.Length != 0)
            {
                if (cbmusaitler.Checked)
                {
                    gonderilen = "select * from gazeteler where adi like'" + tbadi.Text + "%'";
                    verimusait(gonderilen);
                }
                else
                {
                    gonderilen = "select * from gazeteler where adi like'" + tbadi.Text + "%'";
                    verigoster(gonderilen);
                }
                tbbarkodno.Enabled = tbissn.Enabled = tbyonetmen.Enabled =  cbtumkayitlar.Enabled = cbmusaitler.Enabled = cbhasardurumu.Enabled = cbtur.Enabled = yayimtarihi.Enabled = false;
               
            }
            else
            {
                if (cbmusaitler.Checked)
                {
                    gonderilen = "select * from gazeteler";
                    verimusait(gonderilen);
                }
                else
                {
                    gonderilen = "select * from gazeteler";
                    verigoster(gonderilen);
                }
                tbbarkodno.Enabled = tbissn.Enabled = tbyonetmen.Enabled =cbtumkayitlar.Enabled = cbmusaitler.Enabled = cbhasardurumu.Enabled = cbtur.Enabled = yayimtarihi.Enabled = true;

            }
        }

        private void tbyonetmen_TextChanged(object sender, EventArgs e)
        {
            if (tbyonetmen.Text.Length != 0)
            {
                if (cbmusaitler.Checked)
                {
                    gonderilen = "select * from gazeteler where yonetmeni like'" + tbyonetmen.Text + "%'";
                    verimusait(gonderilen);
                }
                else
                {
                    gonderilen = "select * from gazeteler where yonetmeni like'" + tbyonetmen.Text + "%'";
                    verigoster(gonderilen);
                }
                tbbarkodno.Enabled = tbissn.Enabled = tbadi.Enabled = cbtumkayitlar.Enabled = cbmusaitler.Enabled = cbhasardurumu.Enabled = cbtur.Enabled = yayimtarihi.Enabled = false;
                
            }
            else
            {
                if (cbmusaitler.Checked)
                {
                    gonderilen = "select * from gazeteler";
                    verimusait(gonderilen);
                }
                else
                {
                    gonderilen = "select * from gazeteler";
                    verigoster(gonderilen);
                }
                tbbarkodno.Enabled = tbissn.Enabled = tbadi.Enabled  = cbtumkayitlar.Enabled = cbmusaitler.Enabled = cbhasardurumu.Enabled = cbtur.Enabled = yayimtarihi.Enabled = true;

            }
        }

        private void cbtur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtur.Text.Length != 0)
            {
                if (cbmusaitler.Checked)
                {
                    gonderilen = "select * from gazeteler where turu like'" + cbtur.Text + "%'";
                    verimusait(gonderilen);
                }
                else
                {
                    gonderilen = "select * from gazeteler where turu like'" + cbtur.Text + "%'";
                    verigoster(gonderilen);
                }
            }
            else
            {
                if (cbmusaitler.Checked)
                {
                    gonderilen = "select * from gazeteler";
                    verimusait(gonderilen);
                }
                else
                {
                    gonderilen = "select * from gazeteler";
                    verigoster(gonderilen);
                }

            }
        }

        private void cbhasardurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbhasardurumu.Text.Length != 0)
            {
                if (cbmusaitler.Checked)
                {
                    gonderilen = "select * from gazeteler where hasardurum like'" + cbhasardurumu.Text + "%'";
                    verimusait(gonderilen);
                }
                else
                {
                    gonderilen = "select * from gazeteler where hasardurum like'" + cbhasardurumu.Text + "%'";
                    verigoster(gonderilen);
                }

            }
            else
            {
                if (cbmusaitler.Checked)
                {
                    gonderilen = "select * from gazeteler";
                    verimusait(gonderilen);
                }
                else
                {
                    gonderilen = "select * from gazeteler";
                    verigoster(gonderilen);
                }
 
            }
        }

        private void yayimtarihi_ValueChanged(object sender, EventArgs e)
        {
            if (yayimtarihi.Text.Length != 0)
            {
                if (cbmusaitler.Checked)
                {
                    gonderilen = "select * from gazeteler where ytarihi like'" + yayimtarihi.Text + "%'";
                    verimusait(gonderilen);
                }
                else
                {
                    gonderilen = "select * from gazeteler where ytarihi like'" + yayimtarihi.Text + "%'";
                    verigoster(gonderilen);
                }

            }
            else
            {
                if (cbmusaitler.Checked)
                {
                    gonderilen = "select * from gazeteler";
                    verimusait(gonderilen);
                }
                else
                {
                    gonderilen = "select * from gazeteler";
                    verigoster(gonderilen);
                }
 
            }
        }

        private void cbmusaitler_CheckedChanged(object sender, EventArgs e)
        {
            if(cbmusaitler.Checked)
            {
                listView1.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("select * from gazeteler", conn);
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (rd["musaitmi"].ToString() == true.ToString())
                    {
                        ListViewItem ekle = new ListViewItem();
                        ekle.Text = rd["gazeteid"].ToString();
                        ekle.SubItems.Add(rd["barkod"].ToString());
                        ekle.SubItems.Add(rd["adi"].ToString());
                        ekle.SubItems.Add(rd["issn"].ToString());
                        ekle.SubItems.Add(rd["ytarihi"].ToString());
                        ekle.SubItems.Add(rd["ttarihi"].ToString());
                        ekle.SubItems.Add(rd["hasardurum"].ToString());
                        ekle.SubItems.Add(rd["fiyat"].ToString());
                        ekle.SubItems.Add(rd["sayfas"].ToString());
                        ekle.SubItems.Add(rd["stoks"].ToString());
                        ekle.SubItems.Add(rd["okunmasayisi"].ToString());
                        if (rd["dergimi"].ToString() == true.ToString())
                        {
                            ekle.SubItems.Add(rd["sayisi"].ToString());
                            ekle.SubItems.Add(rd["turu"].ToString());
                            ekle.SubItems.Add(rd["yonetmeni"].ToString());
                        }
                        ekle.BackColor = Color.Green;

                        listView1.Items.Add(ekle);
                    }
                }
            } 
            else
            {
                if (cbmusaitler.Checked)
                {
                    gonderilen = "select * from gazeteler";
                    verimusait(gonderilen);
                }
                else
                {
                    gonderilen = "select * from gazeteler";
                    verigoster(gonderilen);
                }
 
            }
        }

        private void cbtumkayitlar_CheckedChanged(object sender, EventArgs e)
        {
            if(cbtumkayitlar.Checked)
            {
                if (cbmusaitler.Checked)
                {
                    gonderilen = "select * from gazeteler";
                    verimusait(gonderilen);
                }
                else
                {
                    gonderilen = "select * from gazeteler";
                    verigoster(gonderilen);
                }
            }
            else
            {
                if (cbmusaitler.Checked)
                {
                    gonderilen = "select * from gazeteler";
                    verimusait(gonderilen);
                }
                else
                {
                    gonderilen = "select * from gazeteler";
                    verigoster(gonderilen);
                }
            }

        }

        private void tbissn_TextChanged(object sender, EventArgs e)
        {
            if (tbissn.Text.Length != 0)
            {
                if (cbmusaitler.Checked)
                {
                    gonderilen = "select * from gazeteler where issn like'" + tbissn.Text + "%'";
                    verimusait(gonderilen);
                }
                else
                {
                    gonderilen = "select * from gazeteler where issn like'" + tbissn.Text + "%'";
                    verigoster(gonderilen);
                }
                tbbarkodno.Enabled = tbadi.Enabled = tbyonetmen.Enabled = cbtumkayitlar.Enabled = cbmusaitler.Enabled =cbhasardurumu.Enabled=cbtur.Enabled=yayimtarihi.Enabled= false;

            }
            else
            {
                if (cbmusaitler.Checked)
                {
                    gonderilen = "select * from gazeteler";
                    verimusait(gonderilen);
                }
                else
                {
                    gonderilen = "select * from gazeteler";
                    verigoster(gonderilen);
                }
                tbbarkodno.Enabled = tbadi.Enabled = tbyonetmen.Enabled = cbtumkayitlar.Enabled = cbmusaitler.Enabled = cbhasardurumu.Enabled = cbtur.Enabled = yayimtarihi.Enabled = true;
 
            }
        }

        private void GazeteArsiv_Load(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            yayimtarihi.MaxDate = DateTime.Today;
            OleDbDataAdapter da = new OleDbDataAdapter("select * from gdturler", conn);
            da.Fill(ds, "gdturler");
            cbtur.DataSource = ds.Tables["gdturler"];
            cbtur.ValueMember = "gdturid";
            cbtur.DisplayMember = "turadi";
            gonderilen = "select * from gazeteler";
            verigoster(gonderilen);
        }
    }
}
