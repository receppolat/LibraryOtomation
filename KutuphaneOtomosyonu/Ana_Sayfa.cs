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
    public partial class Ana_Sayfa : Form
    {
        public Ana_Sayfa()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\bin\\Debug\\KutuphaneOtomasyonu.mdb");

        public static Boolean ogrencimi,sivilmi,akademisyenmi;
        public static Boolean uyesilmemi,kitapsilmemi,gazetesilmemi,personelduzenlmemi;
        string[] okuyucular = new string[99];
        string[] gazetedergi =new string[99];
        bool koltukvarmiokuyucu,koltukvarmigazete;
        bool[] dolumuokuyucu = new bool[99];
        bool[] dolumugazete = new bool[99];
        string koadi, kosoyadi, kotc, kokoltuk,kopasaport,goadi,gosoyadi,gotc,gopasaport,buguntarih,songirisgazete;
        int koid,goid;

        
        private void gazetekoltuk()
        {
            int baslaXgazeteler = 10, baslaYgazeteler = 25;
            for (int i = 1; i <= gkoltuk; i++)
            {
                Button gazeteler = new Button();
                gazeteler.Name = i.ToString();
                gazeteler.Text = i.ToString() + ".Koltuk";
                gazeteler.Size = new Size(60, 30);
                gazeteler.Location = new Point(baslaXgazeteler, baslaYgazeteler);
                gazeteler.BackColor =Color.DarkGreen;
                if (gazetedergi[i] == gazeteler.Name)
                {
                    gazeteler.BackColor = Color.DarkRed;
                    OleDbCommand komut = new OleDbCommand("select * from okuyucu", conn);
                    OleDbDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        if (gokoltuk == gazeteler.Name)
                        {
                            gazeteler.Enabled = true;
                        }
                        else
                            gazeteler.Enabled = false;
                    }
                 
                }
                gbgazete.Controls.Add(gazeteler);
                baslaXgazeteler += gazeteler.Width + 5;
                if (i % 7 == 0)
                {
                    baslaXgazeteler = 10;
                    baslaYgazeteler += gazeteler.Height + 10;
                }
                gazeteler.Click+= new EventHandler(gazetelertiklama);
            }
        }
        
        private void okuyucukoltuk()
        {        
            int baslaXokuyucu = 10, baslaYokuyucu =25;
            for (int i = 1; i <= kkoltuk; i++)
            {
                Button okuyucu = new Button();
                okuyucu.Name = i.ToString();
                okuyucu.Text = i.ToString() + ".Koltuk";
                okuyucu.Size = new Size(60, 30);
                okuyucu.Location = new Point(baslaXokuyucu, baslaYokuyucu);
                okuyucu.BackColor = Color.DarkGreen;
                if (okuyucular[i] == okuyucu.Name)
                {
                    okuyucu.BackColor = Color.DarkRed;

                    OleDbCommand komut = new OleDbCommand("select * from okuyucu", conn);
                    OleDbDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {                      
                        if (kokoltuk==okuyucu.Name)
                        {
                            okuyucu.Enabled = true;
                        }
                        else
                            okuyucu.Enabled = false;
                    }             
                }            
                gbokuyucu.Controls.Add(okuyucu);
                baslaXokuyucu += okuyucu.Width + 5;
                if (i % 7 == 0)
                {
                    baslaXokuyucu = 10;
                    baslaYokuyucu += okuyucu.Height + 10;
                }
               okuyucu.Click += new EventHandler(okuyucutiklama);
            }
        }



        string giriscikis = DateTime.Now.ToString(),giriscikisgazete=DateTime.Now.ToString();

        private void gazetelertiklama(object sender, EventArgs e)
        {
            if (cbgazete.Checked == false)
            {
                OleDbCommand komukontrol = new OleDbCommand("select * from okuyucu", conn);
                OleDbDataReader okuyucu = komukontrol.ExecuteReader();
                while (okuyucu.Read())
                {
                    if (okuyucu["tckimlik"].ToString() == tbtcgazete.Text)
                    {
                        if (okuyucu["okuyucukoltuk"].ToString() == "0")
                        {
                            if(okuyucu["tckimlik"].ToString().Length==11)
                            {
                                try
                                {
                                    OleDbCommand komut = new OleDbCommand("select * from okuyucu where tckimlik=@tckimlik", conn);
                                    komut.Parameters.AddWithValue("@tckimlik", tbtcgazete.Text);
                                    OleDbDataReader oku = komut.ExecuteReader();
                                    oku.Read();
                                    songirisgazete = oku["gazetesongiris"].ToString();
                                }
                                catch { }

                                Button gazeteler = (Button)sender;
                                if (dolumugazete[int.Parse(gazeteler.Name)] == false)
                                {
                                    giriscikisgazete = DateTime.Now.ToString();
                                    if (koltukvarmigazete)
                                    {
                                        dolumugazete[int.Parse(gokoltuk)] = false;
                                        OleDbCommand komut1 = new OleDbCommand("update arsiv set cikis=@cikis where tarih=@tarih", conn);
                                        komut1.Parameters.AddWithValue("@cikis", DateTime.Now.ToString());
                                        komut1.Parameters.AddWithValue("@tarih", songirisgazete);
                                        komut1.ExecuteNonQuery();
                                    }
                                    dolumugazete[int.Parse(gazeteler.Name)] = true;
                                    gokoltuk = gazeteler.Name;
                                    gazeteler.BackColor = Color.DarkRed;

                                    OleDbCommand komut2 = new OleDbCommand("update okuyucu set gazetesongiris=@gazetesongiris, gazetekoltuk=@gazetekoltuk where tckimlik=@tckimlik", conn);
                                    komut2.Parameters.AddWithValue("@gazetesongiris", giriscikisgazete);
                                    komut2.Parameters.AddWithValue("@gazetekoltuk", gazeteler.Name);
                                    komut2.Parameters.AddWithValue("@tckimlik", tbtcgazete.Text);
                                    komut2.ExecuteNonQuery();

                                    OleDbCommand komut3 = new OleDbCommand("update okuyucugazetekontenjan set adi=@adi,soyadi=@soyadi,tckimlik=@tckimlik where koltuklar=@gazetekoltuk", conn);
                                    komut3.Parameters.AddWithValue("@adi", goadi);
                                    komut3.Parameters.AddWithValue("@soyadi", gosoyadi);
                                    komut3.Parameters.AddWithValue("@tckimlik", gotc);
                                    komut3.Parameters.AddWithValue("@gazetekoltuk", gazeteler.Name);
                                    komut3.ExecuteNonQuery();
                                    MessageBox.Show(goadi);

                                    OleDbCommand komut4 = new OleDbCommand("insert into arsiv (adi,soyadi,tckimlik,gazetekoltuk,tarih,kontenjanadi,kontenjanid,okuyucuid) Values (@adi,@soyadi,@tckimlik,@gazetekoltuk,@tarih,@kontenjanadi,@kontenjanid,@okuyucuid)", conn);
                                    komut4.Parameters.AddWithValue("@adi", goadi);
                                    komut4.Parameters.AddWithValue("@soyadi", gosoyadi);
                                    komut4.Parameters.AddWithValue("@tckimlik", gotc);
                                    komut4.Parameters.AddWithValue("@gazetekoltuk", gazeteler.Name);
                                    komut4.Parameters.AddWithValue("@tarih", giriscikisgazete);
                                    komut4.Parameters.AddWithValue("@kontenjanadi", "Gazete-Dergi");
                                    komut4.Parameters.AddWithValue("@kontenjanid", 2);
                                    komut4.Parameters.AddWithValue("@okuyucuid", goid);
                                    komut4.ExecuteNonQuery();

                                    for (int i = 1; i <= 98; i++)
                                    {
                                        if (dolumugazete[i] == false)
                                        {

                                            OleDbCommand komut5 = new OleDbCommand("update okuyucugazetekontenjan set adi=@adi,soyadi=@soyadi,tckimlik=@tckimlik where okuyucular=@okuyucular", conn);
                                            komut5.Parameters.AddWithValue("@adi", "");
                                            komut5.Parameters.AddWithValue("@soyadi", "");
                                            komut5.Parameters.AddWithValue("@tckimlik", "");
                                            komut5.Parameters.AddWithValue("@okuyucular", i);
                                            komut5.ExecuteNonQuery();
                                        }
                                    }
                                    gbgazete.Controls.Clear();
                                    doldur();
                                    gazetekoltuk();
                                }
                                else
                                {
                                    if (koltukvarmigazete)
                                    {
                                        dolumugazete[int.Parse(gokoltuk)] = true;
                                        OleDbCommand komut6 = new OleDbCommand("update arsiv set cikis=@cikis where tarih=@tarih", conn);
                                        komut6.Parameters.AddWithValue("@cikis", DateTime.Now.ToString());
                                        komut6.Parameters.AddWithValue("@tarih", songirisgazete);
                                        komut6.ExecuteNonQuery();
                                    }
                                    gazeteler.BackColor = Color.DarkGreen;
                                    dolumugazete[int.Parse(gazeteler.Name)] = false;

                                    OleDbCommand komut7 = new OleDbCommand("update arsiv set cikis=@cikis where tarih=@tarih", conn);
                                    komut7.Parameters.AddWithValue("@cikis", DateTime.Now.ToString());
                                    komut7.Parameters.AddWithValue("@tarih", songirisgazete);
                                    komut7.ExecuteNonQuery();

                                    OleDbCommand komut8 = new OleDbCommand("update okuyucu set gazetekoltuk=@gazetekoltuk where tckimlik=@tckimlik", conn);
                                    komut8.Parameters.AddWithValue("@gazetekoltuk", 0);
                                    komut8.Parameters.AddWithValue("@tckimlik", gotc);
                                    komut8.ExecuteNonQuery();

                                    OleDbCommand komut9 = new OleDbCommand("update okuyucugazetekontenjan set adi=@adi,soyadi=@soyadi,tckimlik=@tckimlik where okuyucular=@okuyucular", conn);
                                    komut9.Parameters.AddWithValue("@adi", "");
                                    komut9.Parameters.AddWithValue("@soyadi", "");
                                    komut9.Parameters.AddWithValue("@tckimlik", "");
                                    komut9.Parameters.AddWithValue("@okuyucular", gazeteler.Name);
                                    komut9.ExecuteNonQuery();


                                    for (int i = 1; i <= 98; i++)
                                    {
                                        if (dolumugazete[i] == false)
                                        {

                                            OleDbCommand komut5 = new OleDbCommand("update okuyucugazetekontenjan set adi=@adi,soyadi=@soyadi,tckimlik=@tckimlik where okuyucular=@okuyucular", conn);
                                            komut5.Parameters.AddWithValue("@adi", "");
                                            komut5.Parameters.AddWithValue("@soyadi", "");
                                            komut5.Parameters.AddWithValue("@tckimlik", "");
                                            komut5.Parameters.AddWithValue("@okuyucular", i);
                                            komut5.ExecuteNonQuery();
                                        }
                                    }
                                    gbgazete.Controls.Clear();
                                    doldur();
                                    gazetekoltuk();
                                }
                                tbtcgazete.Clear();
                            } 

                        }
                    }

                }
            }
            else
            {

                OleDbCommand komukontrol = new OleDbCommand("select * from okuyucu", conn);
                OleDbDataReader okuyucu = komukontrol.ExecuteReader();
                while (okuyucu.Read())
                {
                    if (okuyucu["pasaportkimlik"].ToString() == tbpasaportgazete.Text)
                    {
                        if (okuyucu["okuyucukoltuk"].ToString() == "0")
                        {
                            if(tbpasaportgazete.Text.Length==9)
                            {
                                try
                                {
                                    OleDbCommand komut = new OleDbCommand("select * from okuyucu where pasaportkimlik=@pasaportkimlik", conn);
                                    komut.Parameters.AddWithValue("@pasaportkimlik", tbpasaportgazete.Text);
                                    OleDbDataReader oku = komut.ExecuteReader();
                                    oku.Read();
                                    songiris = oku["gazetesongiris"].ToString();
                                }
                                catch { }
                                Button gazeteler = (Button)sender;
                                if (dolumugazete[int.Parse(gazeteler.Name)] == false)
                                {
                                    giriscikisgazete = DateTime.Now.ToString();
                                    if (koltukvarmigazete)
                                    {
                                        dolumugazete[int.Parse(gokoltuk)] = false;
                                        OleDbCommand komut1 = new OleDbCommand("update arsiv set cikis=@cikis where tarih=@tarih", conn);
                                        komut1.Parameters.AddWithValue("@cikis", DateTime.Now.ToString());
                                        komut1.Parameters.AddWithValue("@tarih", songirisgazete);
                                        komut1.ExecuteNonQuery();
                                    }
                                    dolumugazete[int.Parse(gazeteler.Name)] = true;
                                    gokoltuk = gazeteler.Name;
                                    gazeteler.BackColor = Color.DarkRed;

                                    OleDbCommand komut2 = new OleDbCommand("update okuyucu set gazetesongiris=@gazetesongiris, gazetekoltuk=@gazetekoltuk where pasaportkimlik=@pasaportkimlik", conn);
                                    komut2.Parameters.AddWithValue("@gazetesongiris", giriscikisgazete);
                                    komut2.Parameters.AddWithValue("@gazetekoltuk", gazeteler.Name);
                                    komut2.Parameters.AddWithValue("@pasaportkimlik", tbpasaportgazete.Text);
                                    komut2.ExecuteNonQuery();

                                    OleDbCommand komut3 = new OleDbCommand("update okuyucugazetekontenjan set adi=@adi,soyadi=@soyadi,tckimlik=@tckimlik where koltuklar=@gazetekoltuk", conn);
                                    komut3.Parameters.AddWithValue("@adi", goadi);
                                    komut3.Parameters.AddWithValue("@soyadi", gosoyadi);
                                    komut3.Parameters.AddWithValue("@tckimlik", gopasaport);
                                    komut3.Parameters.AddWithValue("@gazetekoltuk", gazeteler.Name);
                                    komut3.ExecuteNonQuery();
                                    

                                    OleDbCommand komut4 = new OleDbCommand("insert into arsiv (adi,soyadi,tckimlik,gazetekoltuk,tarih,kontenjanadi,kontenjanid,okuyucuid) Values (@adi,@soyadi,@tckimlik,@gazetekoltuk,@tarih,@kontenjanadi,@kontenjanid,@okuyucuid)", conn);
                                    komut4.Parameters.AddWithValue("@adi", goadi);
                                    komut4.Parameters.AddWithValue("@soyadi", gosoyadi);
                                    komut4.Parameters.AddWithValue("@tckimlik", gopasaport);
                                    komut4.Parameters.AddWithValue("@gazetekoltuk", gazeteler.Name);
                                    komut4.Parameters.AddWithValue("@tarih", giriscikisgazete);
                                    komut4.Parameters.AddWithValue("@kontenjanadi", "Gazete-Dergi");
                                    komut4.Parameters.AddWithValue("@kontenjanid", 2);
                                    komut4.Parameters.AddWithValue("@okuyucuid", goid);
                                    komut4.ExecuteNonQuery();

                                    for (int i = 1; i <= 98; i++)
                                    {
                                        if (dolumugazete[i] == false)
                                        {

                                            OleDbCommand komut5 = new OleDbCommand("update okuyucugazetekontenjan set adi=@adi,soyadi=@soyadi,tckimlik=@tckimlik where okuyucular=@okuyucular", conn);
                                            komut5.Parameters.AddWithValue("@adi", "");
                                            komut5.Parameters.AddWithValue("@soyadi", "");
                                            komut5.Parameters.AddWithValue("@tckimlik", "");
                                            komut5.Parameters.AddWithValue("@okuyucular", i);
                                            komut5.ExecuteNonQuery();
                                        }
                                    }
                                    gbgazete.Controls.Clear();
                                    doldur();
                                    gazetekoltuk();

                                }
                                else
                                {
                                    if (koltukvarmigazete)
                                    {
                                        dolumugazete[int.Parse(gokoltuk)] = true;
                                        OleDbCommand komut6 = new OleDbCommand("update arsiv set cikis=@cikis where tarih=@tarih", conn);
                                        komut6.Parameters.AddWithValue("@cikis", DateTime.Now.ToString());
                                        komut6.Parameters.AddWithValue("@tarih", songirisgazete);
                                        komut6.ExecuteNonQuery();
                                    }
                                    gazeteler.BackColor = Color.DarkGreen;
                                    dolumugazete[int.Parse(gazeteler.Name)] = false;

                                    OleDbCommand komut7 = new OleDbCommand("update arsiv set cikis=@cikis where tarih=@tarih", conn);
                                    komut7.Parameters.AddWithValue("@cikis", DateTime.Now.ToString());
                                    komut7.Parameters.AddWithValue("@tarih", songirisgazete);
                                    komut7.ExecuteNonQuery();

                                    OleDbCommand komut8 = new OleDbCommand("update okuyucu set gazetekoltuk=@gazetekoltuk where pasaportkimlik=@pasaportkimlik", conn);
                                    komut8.Parameters.AddWithValue("@gazetekoltuk", 0);
                                    komut8.Parameters.AddWithValue("@pasaportkimlik", gopasaport);
                                    komut8.ExecuteNonQuery();

                                    OleDbCommand komut9 = new OleDbCommand("update okuyucugazetekontenjan set adi=@adi,soyadi=@soyadi,tckimlik=@tckimlik where okuyucular=@okuyucular", conn);
                                    komut9.Parameters.AddWithValue("@adi", "");
                                    komut9.Parameters.AddWithValue("@soyadi", "");
                                    komut9.Parameters.AddWithValue("@tckimlik", "");
                                    komut9.Parameters.AddWithValue("@okuyucular", gazeteler.Name);
                                    komut9.ExecuteNonQuery();

                                    for (int i = 1; i <= 98; i++)
                                    {
                                        if (dolumugazete[i] == false)
                                        {

                                            OleDbCommand komut5 = new OleDbCommand("update okuyucugazetekontenjan set adi=@adi,soyadi=@soyadi,tckimlik=@tckimlik where okuyucular=@okuyucular", conn);
                                            komut5.Parameters.AddWithValue("@adi", "");
                                            komut5.Parameters.AddWithValue("@soyadi", "");
                                            komut5.Parameters.AddWithValue("@tckimlik", "");
                                            komut5.Parameters.AddWithValue("@okuyucular", i);
                                            komut5.ExecuteNonQuery();
                                        }
                                    }
                                    gbgazete.Controls.Clear();
                                    doldur();
                                    gazetekoltuk();
                                }
                                tbpasaportgazete.Clear();
                            }
                           
                        }
                    }
                      
                }

            }
        }

        

        private void okuyucutiklama(object sender,EventArgs e)
        {
            if(cbyabanciokuyucu.Checked==false)
            {
                OleDbCommand komukontrol = new OleDbCommand("select * from okuyucu", conn);
                OleDbDataReader dr4 = komukontrol.ExecuteReader();
                while (dr4.Read())
                {
                    if(dr4["tckimlik"].ToString()==tbtcokuyucu.Text)
                    {
                        if(dr4["gazetekoltuk"].ToString()=="0")
                        {
                            if(dr4["tckimlik"].ToString().Length==11)
                            {
                                OleDbCommand komut10 = new OleDbCommand("select * from okuyucu where tckimlik=@tckimlik", conn);
                                komut10.Parameters.AddWithValue("@tckimlik", tbtcokuyucu.Text);
                                OleDbDataReader oku = komut10.ExecuteReader();
                                oku.Read();
                                songiris = oku["kitaplıksongiris"].ToString();
                                Button okuyucu = (Button)sender;
                                if (dolumuokuyucu[int.Parse(okuyucu.Name)] == false)
                                {
                                    giriscikis = DateTime.Now.ToString();
                                    if (koltukvarmiokuyucu)
                                    {
                                        dolumuokuyucu[int.Parse(kokoltuk)] = false;
                                        OleDbCommand komut8 = new OleDbCommand("update arsiv set cikis=@cikis where tarih=@tarih", conn);
                                        komut8.Parameters.AddWithValue("@cikis", DateTime.Now.ToString());
                                        komut8.Parameters.AddWithValue("@tarih", songiris);
                                        komut8.ExecuteNonQuery();
                                    }

                                    dolumuokuyucu[int.Parse(okuyucu.Name)] = true;
                                    kokoltuk = okuyucu.Name;
                                    okuyucu.BackColor = Color.DarkRed;
                                    OleDbCommand komut = new OleDbCommand("update okuyucu set kitaplıksongiris=@kitaplıksongiris, okuyucukoltuk=@okuyucukoltuk where tckimlik=@tckimlik", conn);
                                    komut.Parameters.AddWithValue("@kitaplıksongiris", giriscikis);
                                    komut.Parameters.AddWithValue("@okuyucukoltuk", okuyucu.Name);
                                    komut.Parameters.AddWithValue("@tckimlik", tbtcokuyucu.Text);
                                    komut.ExecuteNonQuery();

                                    OleDbCommand komut1 = new OleDbCommand("update okuyucukitapkontenjan set adi=@adi,soyadi=@soyadi,tckimlik=@tckimlik where okuyucukoltuk=@okuyucukoltuk", conn);
                                    komut1.Parameters.AddWithValue("@adi", koadi);
                                    komut1.Parameters.AddWithValue("@soyadi", kosoyadi);
                                    komut1.Parameters.AddWithValue("@tckimlik", kotc);
                                    komut1.Parameters.AddWithValue("@okuyucukoltuk", okuyucu.Name);
                                    komut1.ExecuteNonQuery();

                                    OleDbCommand komu2 = new OleDbCommand("insert into arsiv (adi,soyadi,tckimlik,koltukno,tarih,kontenjanadi,okuyucuid) Values (@adi,@soyadi,@tckimlik,@koltukno,@tarih,@kontenjanadi,@okuyucuid)", conn);
                                    komu2.Parameters.AddWithValue("@adi", koadi);
                                    komu2.Parameters.AddWithValue("@soyadi", kosoyadi);
                                    komu2.Parameters.AddWithValue("@tckimlik", kotc);
                                    komu2.Parameters.AddWithValue("@koltukno", okuyucu.Name);
                                    komu2.Parameters.AddWithValue("@tarih", giriscikis);
                                    komu2.Parameters.AddWithValue("@kontenjanadi", "Kitaplık");
                                    komu2.Parameters.AddWithValue("@okuyucuid", koid);
                                    komu2.ExecuteNonQuery();

                                    for (int i = 1; i <= 98; i++)
                                    {
                                        if (dolumuokuyucu[i] == false)
                                        {

                                            OleDbCommand komut3 = new OleDbCommand("update okuyucukitapkontenjan set adi=@adi,soyadi=@soyadi,tckimlik=@tckimlik where okuyucular=@okuyucular", conn);
                                            komut3.Parameters.AddWithValue("@adi", "");
                                            komut3.Parameters.AddWithValue("@soyadi", "");
                                            komut3.Parameters.AddWithValue("@tckimlik", "");
                                            komut3.Parameters.AddWithValue("@okuyucular", i);
                                            komut3.ExecuteNonQuery();
                                        }
                                    }
                                    gbokuyucu.Controls.Clear();
                                    doldur();
                                    okuyucukoltuk();

                                }
                                else
                                {
                                    if (koltukvarmiokuyucu)
                                    {
                                        dolumuokuyucu[int.Parse(kokoltuk)] = true;
                                        OleDbCommand komut9 = new OleDbCommand("update arsiv set cikis=@cikis where tarih=@tarih", conn);
                                        komut9.Parameters.AddWithValue("@cikis", DateTime.Now.ToString());
                                        komut9.Parameters.AddWithValue("@tarih", songiris);
                                        komut9.ExecuteNonQuery();
                                    }

                                    okuyucu.BackColor = Color.DarkGreen;
                                    dolumuokuyucu[int.Parse(okuyucu.Name)] = false;

                                    OleDbCommand komut5 = new OleDbCommand("update arsiv set cikis=@cikis where tarih=@tarih", conn);
                                    komut5.Parameters.AddWithValue("@cikis", DateTime.Now.ToString());
                                    komut5.Parameters.AddWithValue("@tarih", songiris);
                                    komut5.ExecuteNonQuery();


                                    OleDbCommand komut = new OleDbCommand("update okuyucu set okuyucukoltuk=@okuyucukoltuk where tckimlik=@tckimlik", conn);
                                    komut.Parameters.AddWithValue("@okuyucukoltuk", 0);
                                    komut.Parameters.AddWithValue("@tckimlik", kotc);
                                    komut.ExecuteNonQuery();

                                    OleDbCommand komut3 = new OleDbCommand("update okuyucukitapkontenjan set adi=@adi,soyadi=@soyadi,tckimlik=@tckimlik where okuyucular=@okuyucular", conn);
                                    komut3.Parameters.AddWithValue("@adi", "");
                                    komut3.Parameters.AddWithValue("@soyadi", "");
                                    komut3.Parameters.AddWithValue("@tckimlik", "");
                                    komut3.Parameters.AddWithValue("@okuyucular", okuyucu.Name);
                                    komut3.ExecuteNonQuery();

                                    for (int i = 1; i <= 98; i++)
                                    {
                                        if (dolumuokuyucu[i] == false)
                                        {

                                            OleDbCommand komut4 = new OleDbCommand("update okuyucukitapkontenjan set adi=@adi,soyadi=@soyadi,tckimlik=@tckimlik where okuyucular=@okuyucular", conn);
                                            komut4.Parameters.AddWithValue("@adi", "");
                                            komut4.Parameters.AddWithValue("@soyadi", "");
                                            komut4.Parameters.AddWithValue("@tckimlik", "");
                                            komut4.Parameters.AddWithValue("@okuyucular", i);
                                            komut4.ExecuteNonQuery();
                                        }
                                    }
                                    gbokuyucu.Controls.Clear();
                                    doldur();
                                    okuyucukoltuk();
                                }
                                tbtcokuyucu.Clear();
                            }
                          
                        }
                    }
                    }
                }
                
            else
            {
                OleDbCommand komukontrol = new OleDbCommand("select * from okuyucu", conn);
                OleDbDataReader dr4 = komukontrol.ExecuteReader();
                while (dr4.Read())
                {
                    if (dr4["pasaportkimlik"].ToString() == tbtcokuyucu.Text)
                    {
                        if (dr4["gazetekoltuk"].ToString() == "0")
                        {
                            if (dr4["pasaportkimlik"].ToString().Length == 9)
                            {
                                try
                                {
                                    OleDbCommand komut = new OleDbCommand("select * from okuyucu where pasaportkimlik=@pasaportkimlik", conn);
                                    komut.Parameters.AddWithValue("@pasaportkimlik", tbpasaportokuyucu.Text);
                                    OleDbDataReader oku = komut.ExecuteReader();
                                    oku.Read();
                                    songiris = oku["kitaplıksongiris"].ToString();
                                }
                                catch { }
                                Button okuyucu = (Button)sender;
                                if (dolumuokuyucu[int.Parse(okuyucu.Name)] == false)
                                {
                                    giriscikis = DateTime.Now.ToString();
                                    if (koltukvarmiokuyucu)
                                    {
                                        dolumuokuyucu[int.Parse(kokoltuk)] = false;
                                        OleDbCommand komut1 = new OleDbCommand("update arsiv set cikis=@cikis where tarih=@tarih", conn);
                                        komut1.Parameters.AddWithValue("@cikis", DateTime.Now.ToString());
                                        komut1.Parameters.AddWithValue("@tarih", songiris);
                                        komut1.ExecuteNonQuery();

                                    }


                                    dolumuokuyucu[int.Parse(okuyucu.Name)] = true;
                                    kokoltuk = okuyucu.Name;
                                    okuyucu.BackColor = Color.DarkRed;
                                    OleDbCommand komut2 = new OleDbCommand("update okuyucu set kitaplıksongiris=@kitaplıksongiris, okuyucukoltuk=@okuyucukoltuk where pasaportkimlik=@pasaportkimlik", conn);
                                    komut2.Parameters.AddWithValue("@kitaplıksongiris", giriscikis);
                                    komut2.Parameters.AddWithValue("@okuyucukoltuk", okuyucu.Name);
                                    komut2.Parameters.AddWithValue("@pasaportkimlik", tbpasaportokuyucu.Text);
                                    komut2.ExecuteNonQuery();
                                    OleDbCommand komut3 = new OleDbCommand("update okuyucukitapkontenjan set adi=@adi,soyadi=@soyadi,tckimlik=@pasaportkimlik where okuyucukoltuk=@okuyucukoltuk", conn);
                                    komut3.Parameters.AddWithValue("@adi", koadi);
                                    komut3.Parameters.AddWithValue("@soyadi", kosoyadi);
                                    komut3.Parameters.AddWithValue("@pasaportkimlik", kopasaport);
                                    komut3.Parameters.AddWithValue("@okuyucukoltuk", okuyucu.Name);
                                    komut3.ExecuteNonQuery();
                                    OleDbCommand komut4 = new OleDbCommand("insert into arsiv (adi,soyadi,tckimlik,koltukno,tarih,kontenjanadi,okuyucuid) Values (@adi,@soyadi,@pasaportkimlik,@koltukno,@tarih,@kontenjanadi,@okuyucuid)", conn);
                                    komut4.Parameters.AddWithValue("@adi", koadi);
                                    komut4.Parameters.AddWithValue("@soyadi", kosoyadi);
                                    komut4.Parameters.AddWithValue("@pasaportkimlik", kopasaport);
                                    komut4.Parameters.AddWithValue("@koltukno", okuyucu.Name);
                                    komut4.Parameters.AddWithValue("@tarih", giriscikis);
                                    komut4.Parameters.AddWithValue("@kontenjanadi", "Kitaplık");
                                    komut4.Parameters.AddWithValue("@okuyucuid", koid);
                                    komut4.ExecuteNonQuery();
                                    for (int i = 1; i <= 98; i++)
                                    {
                                        if (dolumuokuyucu[i] == false)
                                        {
                                            OleDbCommand komut5 = new OleDbCommand("update okuyucukitapkontenjan set adi=@adi,soyadi=@soyadi,tckimlik=@pasaportkimlik where okuyucular=@okuyucular", conn);
                                            komut5.Parameters.AddWithValue("@adi", "");
                                            komut5.Parameters.AddWithValue("@soyadi", "");
                                            komut5.Parameters.AddWithValue("@pasaportkimlik", "");
                                            komut5.Parameters.AddWithValue("@okuyucular", i);
                                            komut5.ExecuteNonQuery();
                                        }
                                    }
                                    gbokuyucu.Controls.Clear();
                                    doldur();
                                    okuyucukoltuk();
                                }
                                else
                                {
                                    if (koltukvarmiokuyucu)
                                    {
                                        dolumuokuyucu[int.Parse(kokoltuk)] = true;
                                        OleDbCommand komut6 = new OleDbCommand("update arsiv set cikis=@cikis where tarih=@tarih", conn);
                                        komut6.Parameters.AddWithValue("@cikis", DateTime.Now.ToString());
                                        komut6.Parameters.AddWithValue("@tarih", songiris);
                                        komut6.ExecuteNonQuery();
                                    }
                                    okuyucu.BackColor = Color.DarkGreen;
                                    dolumuokuyucu[int.Parse(okuyucu.Name)] = false;


                                    OleDbCommand komut7 = new OleDbCommand("update arsiv set cikis=@cikis where tarih=@tarih", conn);
                                    komut7.Parameters.AddWithValue("@cikis", DateTime.Now.ToString());
                                    komut7.Parameters.AddWithValue("@tarih", songiris);
                                    komut7.ExecuteNonQuery();

                                    OleDbCommand komut8 = new OleDbCommand("update okuyucu set okuyucukoltuk=@okuyucukoltuk where pasaportkimlik=@pasaportkimlik", conn);
                                    komut8.Parameters.AddWithValue("@okuyucukoltuk", "0");
                                    komut8.Parameters.AddWithValue("@pasaportkimlik", tbpasaportokuyucu.Text);
                                    komut8.ExecuteNonQuery();

                                    OleDbCommand komut9 = new OleDbCommand("update okuyucukitapkontenjan set adi=@adi,soyadi=@soyadi,tckimlik=@pasaportkimlik where okuyucular=@okuyucular", conn);
                                    komut9.Parameters.AddWithValue("@adi", "");
                                    komut9.Parameters.AddWithValue("@soyadi", "");
                                    komut9.Parameters.AddWithValue("@pasaportkimlik", "");
                                    komut9.Parameters.AddWithValue("@okuyucular", okuyucu.Name);
                                    komut9.ExecuteNonQuery();

                                    for (int i = 1; i <= 98; i++)
                                    {
                                        if (dolumuokuyucu[i] == false)
                                        {

                                            OleDbCommand komut10 = new OleDbCommand("update okuyucukitapkontenjan set adi=@adi,soyadi=@soyadi,tckimlik=@pasaportkimlik where okuyucular=@okuyucular", conn);
                                            komut10.Parameters.AddWithValue("@adi", "");
                                            komut10.Parameters.AddWithValue("@soyadi", "");
                                            komut10.Parameters.AddWithValue("@pasaportkimlik", "");
                                            komut10.Parameters.AddWithValue("@okuyucular", i.ToString());
                                            komut10.ExecuteNonQuery();
                                        }
                                    }
                                    gbokuyucu.Controls.Clear();
                                    doldur();
                                    okuyucukoltuk();
                                }
                                tbpasaportokuyucu.Clear();
                            }
                        }
                    }
                
                }
               
           
            }

        }

        private void doldur()
        {
            Array.Clear(dolumuokuyucu, 0, dolumuokuyucu.Length);
            Array.Clear(dolumugazete, 0, dolumugazete.Length);
            Array.Clear(gazetedergi, 0, gazetedergi.Length);
            Array.Clear(okuyucular, 0, okuyucular.Length);
            OleDbCommand komut1 = new OleDbCommand("select * from okuyucu", conn);
            OleDbDataReader rd1 = komut1.ExecuteReader();
            while (rd1.Read())
            {   

                if (rd1["okuyucukoltuk"].ToString()!="0")
                {
                    okuyucular[int.Parse(rd1["okuyucukoltuk"].ToString())] = rd1["okuyucukoltuk"].ToString();
                    dolumuokuyucu[int.Parse(rd1["okuyucukoltuk"].ToString())] = true;
                }
                    
            }
            OleDbCommand komut2 = new OleDbCommand("select* from okuyucu", conn);
            OleDbDataReader rd2 = komut2.ExecuteReader();
            while (rd2.Read())
            {
                if (rd2["gazetekoltuk"].ToString()!= "0")
                {
                    gazetedergi[int.Parse(rd2["gazetekoltuk"].ToString())] = rd2["gazetekoltuk"].ToString();
                    dolumugazete[int.Parse(rd2["gazetekoltuk"].ToString())] = true;
                }
                  
            }
        }
        int kkoltuk, gkoltuk; string okuyucu;
        private void Ana_Sayfa_Load(object sender, EventArgs e)
        {             
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            OleDbCommand komut1 = new OleDbCommand("select * from kutuphane", conn);
            OleDbDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                kkoltuk=int.Parse(dr1["kitaplikkoltuk"].ToString());
                gkoltuk = int.Parse(dr1["gazetekoltuk"].ToString());
            }
                for (int i = 0; i <= 98; i++)
            {
                dolumugazete[i] = false;
                dolumuokuyucu[i] = false;
            }
            Array.Clear(okuyucular, 0, okuyucular.Length);
            Array.Clear(gazetedergi, 0, gazetedergi.Length);

            OleDbCommand komut = new OleDbCommand("select * from okuyucu", conn);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                
                OleDbCommand komut12 = new OleDbCommand("select * from kitaplar", conn);
                OleDbDataReader dr = komut12.ExecuteReader();
                listView1.Items.Clear();
                while (dr.Read())
                {

                    if (dr["stoks"].ToString() != "0")
                    {
                        stoks = int.Parse(dr["stoks"].ToString());
                        ListViewItem ekle = new ListViewItem();
                        ekle.Text = dr["kitapid"].ToString();
                        ekle.SubItems.Add(dr["barkod"].ToString());
                        ekle.SubItems.Add(dr["adi"].ToString());
                        ekle.SubItems.Add(dr["yazaradi"].ToString());
                        ekle.SubItems.Add(okuyucu);
                        ekle.BackColor = Color.Green;
                        listView1.Items.Add(ekle);
                    }
                    else
                    {
                            stoks = int.Parse(dr["stoks"].ToString());
                            ListViewItem ekle1 = new ListViewItem();
                            ekle1.Text = dr["kitapid"].ToString();
                            ekle1.SubItems.Add(dr["barkod"].ToString());
                            ekle1.SubItems.Add(dr["adi"].ToString());
                            ekle1.SubItems.Add(dr["yazaradi"].ToString());
                            ekle1.SubItems.Add(okuyucu);
                            ekle1.BackColor = Color.Red;
                            listView1.Items.Add(ekle1);
                        
                    }

                }

            }
            buguntarih = DateTime.Now.ToString();
           
            doldur();
            okuyucukoltuk();
            gazetekoltuk();
           
            if (Giris.yöneticimi == false)
            {
                yöneticiislemleri.Visible = false;
            }

   
        }

        private void yeniuyesiv_Click(object sender, EventArgs e)
        {
            sivilmi = true;
            Yeni_Okuyucu gecis = new Yeni_Okuyucu();
            gecis.ShowDialog();
        }

        private void kytgnc_Click(object sender, EventArgs e)
        {
            uyesilmemi =false;
            Uye_Duzenleme_Ve_Silme gecis = new Uye_Duzenleme_Ve_Silme();
            gecis.ShowDialog();
        }

        private void kytsil_Click(object sender, EventArgs e)
        {
            uyesilmemi = true;
            Uye_Duzenleme_Ve_Silme gecis = new Uye_Duzenleme_Ve_Silme();
            gecis.ShowDialog();
        }

        private void yenikitap_Click(object sender, EventArgs e)
        {
            Yeni_Kitap gecis = new Yeni_Kitap();
            gecis.ShowDialog();
        }

        private void kayıtsilme_Click(object sender, EventArgs e)
        {
            kitapsilmemi=true;
            KitapSilmeVeDuzenleme gecis = new KitapSilmeVeDuzenleme();
            gecis.ShowDialog();
        }

        private void yenigzt_Click(object sender, EventArgs e)
        {
            YeniGazete gecis = new YeniGazete();
            gecis.ShowDialog();
        }

        private void gztgunc_Click(object sender, EventArgs e)
        {
            gazetesilmemi = false;
            GazeteGuncellemeVeSilme gecis = new GazeteGuncellemeVeSilme();
            gecis.ShowDialog();
        }

        private void gztsilme_Click(object sender, EventArgs e)
        {
            gazetesilmemi = true;
            GazeteGuncellemeVeSilme gecis = new GazeteGuncellemeVeSilme();
            gecis.ShowDialog();
        }

        private void gztarsiv_Click(object sender, EventArgs e)
        {

        }

        private void kitapListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void uyearsivogr_Click(object sender, EventArgs e)
        {
            ogrencimi = true;
            OkuyucuArsivi gecis = new OkuyucuArsivi();
            gecis.ShowDialog();
        }

        private void uyearsivaka_Click(object sender, EventArgs e)
        {
            akademisyenmi = true;
            OkuyucuArsivi gecis = new OkuyucuArsivi();
            gecis.ShowDialog();
        }

        private void personelKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            YeniPersonel gecis = new YeniPersonel();
            gecis.ShowDialog();
        }

        private void personelSİlmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelduzenlmemi = false;
            PersonelDuzenlemeVeSilme gecis = new PersonelDuzenlemeVeSilme();
            gecis.ShowDialog();
        }

        private void cbyabanciokuyucu_CheckedChanged(object sender, EventArgs e)
        {
            if(cbyabanciokuyucu.Checked)
            {
                tbtcokuyucu.Visible = false;
                tbpasaportokuyucu.Visible = true;
                labeltcokuyucu.Text = "Pasaport Numarası:";
            }
            else
            {
                tbtcokuyucu.Visible = true;
                tbpasaportokuyucu.Visible = false;
                labeltcokuyucu.Text = "TC Kimlik Numarası:";
            }
        }

        private void cbyabanciemanet_CheckedChanged(object sender, EventArgs e)
        {
            if(cbyabanciemanet.Checked)
            {
                tbtcemanet.Visible = false;
                tbpasaportemanet.Visible = true;
                labeltcemanet.Text = "Pasaport Numarası:";
            }
            else
            {

                tbtcemanet.Visible = true;
                tbpasaportemanet.Visible = false;
                labeltcemanet.Text = "TC Kimlik Numarası:";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbbarkod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbbarkod.Text.Length <= 6 && tbbarkod.Text.Length != 0)
                {
                    if (tbbarkod.Text.Substring(0, 1).ToLower() == "a".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "b".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "c".ToLower() ||
                        tbbarkod.Text.Substring(0, 1).ToLower() == "ç".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "d".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "e".ToLower() ||
                        tbbarkod.Text.Substring(0, 1).ToLower() == "f".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "g".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "h".ToLower() ||
                        tbbarkod.Text.Substring(0, 1).ToLower() == "ı".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "i".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "k".ToLower() ||
                        tbbarkod.Text.Substring(0, 1).ToLower() == "l".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "m".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "n".ToLower() ||
                        tbbarkod.Text.Substring(0, 1).ToLower() == "o".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "ö".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "p".ToLower() ||
                        tbbarkod.Text.Substring(0, 1).ToLower() == "r".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "s".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "ş".ToLower() ||
                        tbbarkod.Text.Substring(0, 1).ToLower() == "t".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "u".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "ü".ToLower() ||
                        tbbarkod.Text.Substring(0, 1).ToLower() == "v".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "y".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "z".ToLower() ||
                        tbbarkod.Text.Substring(0, 1).ToLower() == "q".ToLower() || tbbarkod.Text.Substring(0, 1).ToLower() == "w".ToLower())
                    {

                        OleDbCommand komut = new OleDbCommand("select * from kitaplar where barkod like'" + tbbarkod.Text + "%'", conn);
                        OleDbDataReader dr = komut.ExecuteReader();
                        listView1.Items.Clear();
                        while (dr.Read())
                        {

                            if (dr["stoks"].ToString() != "0")
                            {
                                stoks = int.Parse(dr["stoks"].ToString());
                                ListViewItem ekle = new ListViewItem();
                                ekle.Text = dr["kitapid"].ToString();
                                ekle.SubItems.Add(dr["barkod"].ToString());
                                ekle.SubItems.Add(dr["adi"].ToString());
                                ekle.SubItems.Add(dr["yazaradi"].ToString());
                                ekle.SubItems.Add(okuyucu);
                                ekle.BackColor = Color.Green;
                                listView1.Items.Add(ekle);
                            }
                            else
                            {
                                stoks = int.Parse(dr["stoks"].ToString());
                                ListViewItem ekle = new ListViewItem();
                                ekle.Text = dr["kitapid"].ToString();
                                ekle.SubItems.Add(dr["barkod"].ToString());
                                ekle.SubItems.Add(dr["adi"].ToString());
                                ekle.SubItems.Add(dr["yazaradi"].ToString());
                                ekle.SubItems.Add(okuyucu);
                                ekle.BackColor = Color.Red;
                                listView1.Items.Add(ekle);
                            }


                        }

                    }

                    else if (tbbarkod.Text.Length == 0)
                    {
                        tbtcemanet.Clear();
                    }

                    else
                    {
                        MessageBox.Show("Barkod Numarası 6 haneli olmalıdır.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbbarkod.Text = tbbarkod.Text.Substring(0, 6);
                    }

                }
            }

            catch { }
           
        }

        private void özelİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitapkoltuk gecis = new kitapkoltuk();
            gecis.ShowDialog();
        }

        private void kitapArşiviToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KitapArsivi gecis =new KitapArsivi();
            gecis.ShowDialog();
        }

        private void gazeteArşivToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GazeteArsiv gecis = new GazeteArsiv();
            gecis.ShowDialog();
        }

        private void personelArşivToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelArsiv gecis = new PersonelArsiv();
            gecis.ShowDialog();
        }
      
        private void cbyabanciokuyucu_CheckedChanged_1(object sender, EventArgs e)
        {
            if(cbyabanciokuyucu.Checked)
            {              
                tbtcokuyucu.Visible = false;
                tbpasaportokuyucu.Visible = true;
                tbtcokuyucu.Clear();
                labeltcokuyucu.Text= "Pasaport Numarası:";
            }
            else
            {
                tbtcokuyucu.Visible = true;
                tbpasaportokuyucu.Visible = false;
                labeltcokuyucu.Text = "TC Kimlik Numarası:";
                tbpasaportokuyucu.Clear();
            }
        }

        private void cbgazete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbgazete.Checked)
            {
                tbtcgazete.Visible = false;
                tbpasaportgazete.Visible = true;
                tbtcgazete.Clear();
                labelgazete.Text = "Pasaport Numarası:";
            }
            else
            {
                tbtcgazete.Visible = true;
                tbpasaportgazete.Visible = false;
                labelgazete.Text = "TC Kimlik Numarası:";
                tbpasaportgazete.Clear();
            }

        }

        private void cbyabanciemanet_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbyabanciemanet.Checked)
            {
                tbtcemanet.Visible = false;
                tbpasaportemanet.Visible = true;
                tbtcemanet.Clear();
                labeltcemanet.Text = "Pasaport Numarası:";
            }
            else
            {
                tbtcemanet.Visible = true;
                tbpasaportemanet.Visible = false;
                labeltcemanet.Text = "TC Kimlik Numarası:";
                tbpasaportemanet.Clear();
            }
        }
        string songiris;

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anlikgazete gcs = new anlikgazete();
            gcs.ShowDialog();
        }

        private void arşivToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arsivrapor gcs = new arsivrapor();
            gcs.ShowDialog();
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelrapor gcs = new personelrapor();
            gcs.ShowDialog();
        }

        private void okuyucuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raporokuyucu gcs = new raporokuyucu();
            gcs.ShowDialog();
        }

        private void kitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kitaprapor gcs = new kitaprapor();
            gcs.ShowDialog();
        }

        private void güncelKitaplıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            okuyucukontenjanrapor gcs = new okuyucukontenjanrapor();
            gcs.ShowDialog();
        }

        private void gazetelerVeDergilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gazetedergirapor gcs = new gazetedergirapor();
            gcs.ShowDialog();
        }

        private void uyearsiv_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        int stoks;
        private void btnemanet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbyabanciemanet.Checked == false)
                {
                    if (tbtcemanet.Text.Length == 11)
                    {
                        OleDbCommand komut3 = new OleDbCommand("select * from okuyucu where tckimlik=@tckimlik", conn);
                        komut3.Parameters.AddWithValue("@tckimlik", tbtcemanet.Text);
                        OleDbDataReader oku = komut3.ExecuteReader();
                        while (oku.Read())
                        {                        
                            OleDbCommand komu2 = new OleDbCommand("update okuyucu set emanetkitap=@emanetkitap, sonkitapid=@sonkitapid where tckimlik=@tckimlik", conn);
                            komu2.Parameters.AddWithValue("@emanetkitap", kitapadi);
                            komu2.Parameters.AddWithValue("@sonkitapid", satir);
                            komu2.Parameters.AddWithValue("@tckimlik", tbtcemanet.Text);
                            komu2.ExecuteNonQuery();
                            OleDbCommand komut0 = new OleDbCommand("update kitaplar set musaitmi=@musaitmi,stoks=@stoks,okuyucutc=@okuyucutc where kitapid=" + satir, conn);
                            komut0.Parameters.AddWithValue("@musaitmi", "0");
                            komut0.Parameters.AddWithValue("@stoks","0");
                            komut0.Parameters.AddWithValue("@okuyucutc", tbtcemanet.Text);
                            komut0.ExecuteNonQuery();

                            OleDbCommand komut1 = new OleDbCommand("select * from kitaplar", conn);
                            OleDbDataReader dr = komut1.ExecuteReader();
                            listView1.Items.Clear();

                            while (dr.Read())
                            {
                                
                                if (dr["okuyucutc"].ToString() == tbtcemanet.Text)
                                {
                                    stoks = int.Parse(dr["stoks"].ToString());
                                    ListViewItem ekle = new ListViewItem();
                                    ekle.Text = dr["kitapid"].ToString();
                                    ekle.SubItems.Add(dr["barkod"].ToString());
                                    ekle.SubItems.Add(dr["adi"].ToString());
                                    ekle.SubItems.Add(dr["yazaradi"].ToString());
                                    ekle.SubItems.Add(okuyucu);
                                    ekle.BackColor = Color.Yellow;
                                    listView1.Items.Add(ekle);
                                }
                                if (dr["stoks"].ToString() != "0")
                                {
                                
                                    stoks = int.Parse(dr["stoks"].ToString());
                                    ListViewItem ekle = new ListViewItem();
                                    ekle.Text = dr["kitapid"].ToString();
                                    ekle.SubItems.Add(dr["barkod"].ToString());
                                    ekle.SubItems.Add(dr["adi"].ToString());
                                    ekle.SubItems.Add(dr["yazaradi"].ToString());
                                    ekle.SubItems.Add(okuyucu);
                                    ekle.BackColor = Color.Green;
                                    listView1.Items.Add(ekle);
                                }
                                else
                                {
                               
                                    stoks = int.Parse(dr["stoks"].ToString());
                                    ListViewItem ekle = new ListViewItem();
                                    ekle.Text = dr["kitapid"].ToString();
                                    ekle.SubItems.Add(dr["barkod"].ToString());
                                    ekle.SubItems.Add(dr["adi"].ToString());
                                    ekle.SubItems.Add(dr["yazaradi"].ToString());
                                    ekle.SubItems.Add(okuyucu);
                                    ekle.BackColor = Color.Red;
                                    listView1.Items.Add(ekle);
                                }

                            }
                            tbtcemanet.Clear();
                           
                        }
                    }

                }
                else
                {
                    if(tbpasaportemanet.Text.Length==9)
                    {
                        OleDbCommand komut3 = new OleDbCommand("select * from okuyucu where pasaportkimlik=@pasaportkimlik", conn);
                        komut3.Parameters.AddWithValue("@pasaportkimlik", tbpasaportemanet.Text);
                        OleDbDataReader oku = komut3.ExecuteReader();
                        while (oku.Read())
                        {
                            OleDbCommand komu2 = new OleDbCommand("update okuyucu set emanetkitap=@emanetkitap, sonkitapid=@sonkitapid where pasaportkimlik=@pasaportkimlik", conn);
                            komu2.Parameters.AddWithValue("@emanetkitap", kitapadi);
                            komu2.Parameters.AddWithValue("@sonkitapid", satir);
                            komu2.Parameters.AddWithValue("@pasaportkimlik", tbpasaportemanet.Text);
                            komu2.ExecuteNonQuery();
                            OleDbCommand komut0 = new OleDbCommand("update kitaplar set musaitmi=@musaitmi,stoks=@stoks okuyucutc=@okuyucutc where kitapid=" + satir, conn);
                            komut0.Parameters.AddWithValue("@musaitmi", "0");
                            komut0.Parameters.AddWithValue("@stoks", "0");
                            komut0.Parameters.AddWithValue("@okuyucutc", tbpasaportemanet.Text);
                            komut0.ExecuteNonQuery();
                            OleDbCommand komut1 = new OleDbCommand("select * from kitaplar", conn);
                            OleDbDataReader dr = komut1.ExecuteReader();
                            listView1.Items.Clear();
                            while (dr.Read())
                            {

                                if (dr["okuyucutc"].ToString() == tbpasaportemanet.Text)
                                {
                                    stoks = int.Parse(dr["stoks"].ToString());
                                    ListViewItem ekle = new ListViewItem();
                                    ekle.Text = dr["kitapid"].ToString();
                                    ekle.SubItems.Add(dr["barkod"].ToString());
                                    ekle.SubItems.Add(dr["adi"].ToString());
                                    ekle.SubItems.Add(dr["yazaradi"].ToString());
                                    ekle.SubItems.Add(okuyucu);
                                    ekle.BackColor = Color.Yellow;
                                    listView1.Items.Add(ekle);
                                }
                                if (dr["stoks"].ToString() != "0")
                                {

                                    stoks = int.Parse(dr["stoks"].ToString());
                                    ListViewItem ekle = new ListViewItem();
                                    ekle.Text = dr["kitapid"].ToString();
                                    ekle.SubItems.Add(dr["barkod"].ToString());
                                    ekle.SubItems.Add(dr["adi"].ToString());
                                    ekle.SubItems.Add(dr["yazaradi"].ToString());
                                    ekle.SubItems.Add(okuyucu);
                                    ekle.BackColor = Color.Green;
                                    listView1.Items.Add(ekle);
                                }
                                else
                                {

                                    stoks = int.Parse(dr["stoks"].ToString());
                                    ListViewItem ekle = new ListViewItem();
                                    ekle.Text = dr["kitapid"].ToString();
                                    ekle.SubItems.Add(dr["barkod"].ToString());
                                    ekle.SubItems.Add(dr["adi"].ToString());
                                    ekle.SubItems.Add(dr["yazaradi"].ToString());
                                    ekle.SubItems.Add(okuyucu);
                                    ekle.BackColor = Color.Red;
                                    listView1.Items.Add(ekle);
                                }


                            }
                            tbpasaportemanet.Clear();

                        }
                        
                    }
                    else
                    {
                        OleDbCommand komut1 = new OleDbCommand("select * from kitaplar", conn);
                        OleDbDataReader dr = komut1.ExecuteReader();
                        listView1.Items.Clear();
                        while (dr.Read())
                        {
                            if (dr["okuyucutc"].ToString() == tbtcemanet.Text)
                            {
                                listView1.Items.Clear();
                                stoks = int.Parse(dr["stoks"].ToString());
                                ListViewItem ekle = new ListViewItem();
                                ekle.Text = dr["kitapid"].ToString();
                                ekle.SubItems.Add(dr["barkod"].ToString());
                                ekle.SubItems.Add(dr["adi"].ToString());
                                ekle.SubItems.Add(dr["yazaradi"].ToString());
                                ekle.SubItems.Add(okuyucu);
                                ekle.BackColor = Color.Yellow;
                                listView1.Items.Add(ekle);
                            }
                            if (dr["stoks"].ToString() != "0")
                            {
                               
                                stoks = int.Parse(dr["stoks"].ToString());
                                ListViewItem ekle = new ListViewItem();
                                ekle.Text = dr["kitapid"].ToString();
                                ekle.SubItems.Add(dr["barkod"].ToString());
                                ekle.SubItems.Add(dr["adi"].ToString());
                                ekle.SubItems.Add(dr["yazaradi"].ToString());
                                ekle.SubItems.Add(okuyucu);
                                ekle.BackColor = Color.Green;
                                listView1.Items.Add(ekle);
                            }
                            else
                            {
                             
                                stoks = int.Parse(dr["stoks"].ToString());
                                ListViewItem ekle = new ListViewItem();
                                ekle.Text = dr["kitapid"].ToString();
                                ekle.SubItems.Add(dr["barkod"].ToString());
                                ekle.SubItems.Add(dr["adi"].ToString());
                                ekle.SubItems.Add(dr["yazaradi"].ToString());
                                ekle.SubItems.Add(okuyucu);
                                ekle.BackColor = Color.Red;
                                listView1.Items.Add(ekle);
                            }

                        }
                    }


                }
            }
            catch { }
        }

        int satir,okunmasayisi;
        string kitapadi;
        int kitapid;
        private void btniade_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbyabanciemanet.Checked==false)
                {
                    if(tbtcemanet.Text.Length==11)
                    {
                        
                        OleDbCommand komut = new OleDbCommand("select * from kitaplar where kitapid="+satir, conn);
                        OleDbDataReader oku = komut.ExecuteReader();
                        oku.Read();
                        {

                            if (tbtcemanet.Text == oku["okuyucutc"].ToString())
                            {

                                DialogResult cevap = MessageBox.Show("İade etmek istediğinizden emin misiniz?", "İade Et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (cevap == DialogResult.Yes)
                                {
                                    OleDbCommand komut0 = new OleDbCommand("update kitaplar set musaitmi=@musaitmi,okunmasayisi=@okunmasayisi,stoks=@stoks,okuyucutc=@okuyucutc where kitapid=" + satir, conn);
                                    komut0.Parameters.AddWithValue("@musaitmi", "1");
                                    komut0.Parameters.AddWithValue("@okunmasayisi", ++okunmasayisi);
                                    komut0.Parameters.AddWithValue("@stoks", "1");
                                    komut0.Parameters.AddWithValue("@okuyucutc", "");
                                    komut0.ExecuteNonQuery();
                                    OleDbCommand komut2 = new OleDbCommand("update okuyucu set emanetkitap=@emanetkitap where tckimlik=@tckimlik", conn);
                                    komut2.Parameters.AddWithValue("@emanetkitap", "");
                                    komut2.Parameters.AddWithValue("@tckimlik", tbtcemanet.Text);
                                    komut2.ExecuteNonQuery();
                                    OleDbCommand komut1 = new OleDbCommand("select * from kitaplar", conn);
                                    OleDbDataReader dr = komut1.ExecuteReader();
                                    listView1.Items.Clear();
                                    while (dr.Read())
                                    {
                                        if (dr["stoks"].ToString() != "0")
                                        {
                                            listView1.Items.Clear();
                                            stoks = int.Parse(dr["stoks"].ToString());
                                            ListViewItem ekle = new ListViewItem();
                                            ekle.Text = dr["kitapid"].ToString();
                                            ekle.SubItems.Add(dr["barkod"].ToString());
                                            ekle.SubItems.Add(dr["adi"].ToString());
                                            ekle.SubItems.Add(dr["yazaradi"].ToString());
                                            ekle.SubItems.Add(okuyucu);
                                            ekle.BackColor = Color.Green;
                                            listView1.Items.Add(ekle);
                                        }
                                        else
                                        {
                                            listView1.Items.Clear();
                                            stoks = int.Parse(dr["stoks"].ToString());
                                            ListViewItem ekle = new ListViewItem();
                                            ekle.Text = dr["kitapid"].ToString();
                                            ekle.SubItems.Add(dr["barkod"].ToString());
                                            ekle.SubItems.Add(dr["adi"].ToString());
                                            ekle.SubItems.Add(dr["yazaradi"].ToString());
                                            ekle.SubItems.Add(okuyucu);
                                            ekle.BackColor = Color.Red;
                                            listView1.Items.Add(ekle);
                                        }
                                    }
                                    tbtcemanet.Clear();

                                }

                            }
                            else
                                MessageBox.Show("Kimlik bilgilerini kontrol ediniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                       
                    }
                    
                }
                else
                {
                    if(tbpasaportemanet.Text.Length==9)
                    {
                        OleDbCommand komut = new OleDbCommand("select * from okuyucu where pasaportkimlik=@pasaportkimlik", conn);
                        komut.Parameters.AddWithValue("@pasaportkimlik", tbpasaportemanet.Text);
                        OleDbDataReader oku = komut.ExecuteReader();
                        while (oku.Read())
                        {
                            DialogResult cevap = MessageBox.Show("Kitabı iade etmek istediğinizden emin misiniz?", "İade Et", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (cevap == DialogResult.Yes)
                            {
                                OleDbCommand komut0 = new OleDbCommand("update kitaplar set musaitmi=@musaitmi,okunmasayisi=@okunmasayisi where kitapid=" + kitapid, conn);
                                komut0.Parameters.AddWithValue("@musaitmi", "1");
                                komut0.Parameters.AddWithValue("@okunmasayisi", ++okunmasayisi);
                                komut0.ExecuteNonQuery();
                                OleDbCommand komut2 = new OleDbCommand("update okuyucu set emanetkitap=@emanetkitap where pasaportkimlik=@pasaportkimlik", conn);
                                komut2.Parameters.AddWithValue("@emanetkitap", "");
                                komut2.Parameters.AddWithValue("@pasaportkimlik", tbpasaportemanet.Text);
                                komut2.ExecuteNonQuery();
                                OleDbCommand komut1 = new OleDbCommand("select * from kitaplar", conn);
                                OleDbDataReader dr = komut1.ExecuteReader();
                                listView1.Items.Clear();
                                while (dr.Read())
                                {
                                    if (dr["musaitmi"].ToString() == "1")
                                    {
                                        listView1.Items.Clear();
                                        ListViewItem ekle = new ListViewItem();
                                        ekle.Text = dr["kitapid"].ToString();
                                        ekle.SubItems.Add(dr["barkod"].ToString());
                                        ekle.SubItems.Add(dr["adi"].ToString());
                                        ekle.SubItems.Add(dr["yazaradi"].ToString());
                                        listView1.Items.Add(ekle);
                                    }
                                }
                                tbpasaportemanet.Clear();
                            }
                        }
                    }
                }
            }
            catch { }
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                
                satir = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                OleDbCommand komut = new OleDbCommand("select * from kitaplar where kitapid=" + satir, conn);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    okunmasayisi = int.Parse(oku["okunmasayisi"].ToString());
                    kitapadi = oku["adi"].ToString();
                   
                }
            }
            catch { }

        }
        private void tbpasaportokuyucu_TextChanged(object sender, EventArgs e)
        {
            try
            {        
                if (tbpasaportokuyucu.Text.Length == 9)
                {
                    tbtcgazete.Enabled = false;
                    tbpasaportgazete.Enabled = false;
                    OleDbCommand komut = new OleDbCommand("select * from okuyucu where pasaportkimlik=@pasaportkimlik", conn);
                    komut.Parameters.AddWithValue("@pasaportkimlik", tbpasaportokuyucu.Text);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    koadi = oku["adi"].ToString();
                    kosoyadi = oku["soyadi"].ToString();
                    kopasaport = oku["pasaportkimlik"].ToString();
                    koid = int.Parse(oku["okuyucuid"].ToString());
                    kokoltuk = oku["okuyucukoltuk"].ToString();
                    songiris = oku["kitaplıksongiris"].ToString();
                    if (oku["okuyucukoltuk"].ToString() != "0")
                        koltukvarmiokuyucu = true;
                    else
                        koltukvarmiokuyucu = false;
                    gbokuyucu.Controls.Clear();
                    doldur();
                    okuyucukoltuk();
                    gbokuyucu.Enabled = true;
                }
                else if (tbpasaportokuyucu.Text.Length == 0)
                {
                    gbokuyucu.Enabled = false;
                    tbtcgazete.Enabled = true;
                    tbpasaportgazete.Enabled = true;
                }
                else
                {
                    gbokuyucu.Enabled = false; 
                }
            }
            catch { }
          
        }

        private void tbtcokuyucu_TextChanged(object sender, EventArgs e)
        {
          try
          {
                if (tbtcokuyucu.Text.Length == 11)
                {
                    tbtcgazete.Enabled = false;
                    tbpasaportgazete.Enabled = false;
                    OleDbCommand komut = new OleDbCommand("select * from okuyucu where tckimlik=@tckimlik", conn);
                    komut.Parameters.AddWithValue("@tckimlik", tbtcokuyucu.Text);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    koadi = oku["adi"].ToString();
                    kosoyadi = oku["soyadi"].ToString();
                    kotc = oku["tckimlik"].ToString();
                    koid = int.Parse(oku["okuyucuid"].ToString());
                    kokoltuk = oku["okuyucukoltuk"].ToString();
                    songiris = oku["kitaplıksongiris"].ToString();
                    if (oku["okuyucukoltuk"].ToString() != "0") koltukvarmiokuyucu = true;
                    else koltukvarmiokuyucu = false;

                    gbokuyucu.Enabled = true;
                    gbokuyucu.Controls.Clear();
                    doldur();
                    okuyucukoltuk();
                }
                else if(tbtcokuyucu.Text.Length==0)
                {
                    gbokuyucu.Enabled = false;
                    tbtcgazete.Enabled = true;
                    tbpasaportgazete.Enabled = true;
                }
                else
                {
                    gbokuyucu.Enabled = false;
                }
            }
            catch { }
          }

        string gokoltuk;
        private void tbtcgazete_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbtcgazete.Text.Length == 11)
                {
                    tbtcokuyucu.Enabled = false;
                    tbpasaportokuyucu.Enabled = false;
                    OleDbCommand komut = new OleDbCommand("select * from okuyucu where tckimlik=@tckimlik", conn);
                    komut.Parameters.AddWithValue("@tckimlik", tbtcgazete.Text);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    goadi = oku["adi"].ToString();
                    gosoyadi = oku["soyadi"].ToString();
                    gotc = oku["tckimlik"].ToString();
                    goid = int.Parse(oku["okuyucuid"].ToString());
                    gokoltuk = oku["gazetekoltuk"].ToString();
                    songirisgazete = oku["gazetesongiris"].ToString();

                    if (oku["gazetekoltuk"].ToString() != "0") koltukvarmigazete = true;
                    else koltukvarmigazete = false;

                    gbgazete.Controls.Clear();
                    gazetekoltuk();
                    doldur();
                    gbgazete.Enabled = true;
                }

                else if (tbtcgazete.Text.Length == 0)
                {
                    tbtcokuyucu.Enabled = true;
                    tbpasaportokuyucu.Enabled = true;
                    gbgazete.Enabled = false;
                }
                else
                    gbgazete.Enabled = false;

            }
            catch { }
          
        }

        private void tbpasaportgazete_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbpasaportgazete.Text.Length == 9)
                {
                    tbtcokuyucu.Enabled = false;
                    tbpasaportokuyucu.Enabled = false;
                    OleDbCommand komut = new OleDbCommand("select * from okuyucu where pasaportkimlik=@pasaportkimlik", conn);
                    komut.Parameters.AddWithValue("@pasaportkimlik", tbpasaportgazete.Text);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    goadi = oku["adi"].ToString();
                    gosoyadi = oku["soyadi"].ToString();
                    gopasaport = oku["pasaportkimlik"].ToString();
                    goid = int.Parse(oku["okuyucuid"].ToString());
                    gokoltuk = oku["gazetekoltuk"].ToString();
                    songirisgazete = oku["gazetesongiris"].ToString();

                    if (oku["gazetekoltuk"].ToString() != "0") koltukvarmigazete = true;
                    else koltukvarmigazete = false;

                    gbgazete.Controls.Clear();
                    gazetekoltuk();
                    doldur();
                    gbgazete.Enabled = true;
                }
                else if(tbpasaportgazete.Text.Length==0)
                {
                    gbgazete.Enabled = false;
                    tbtcokuyucu.Enabled = true;
                    tbpasaportokuyucu.Enabled = true;
                }
                else
                    gbgazete.Enabled = false;
            }
            catch { }
           
         
         
    }

        private void tbpasaportemanet_TextChanged(object sender, EventArgs e)
        {
            try {

                    if (tbpasaportemanet.Text.Length == 9)
                    {
                    gbemanet.Enabled = true;
                    OleDbCommand komut = new OleDbCommand("select * from okuyucu where pasaportkimlik=@pasaportkimlik", conn);
                    komut.Parameters.AddWithValue("@pasaportkimlik", tbpasaportemanet.Text);
                    OleDbDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        OleDbCommand komut1 = new OleDbCommand("select * from kitaplar", conn);
                        OleDbDataReader dr = komut1.ExecuteReader();

                        listView1.Items.Clear();
                        while (dr.Read())
                        {
                            if (dr["stoks"].ToString() != "0")
                            {
                                stoks = int.Parse(dr["stoks"].ToString());
                                ListViewItem ekle = new ListViewItem();
                                ekle.Text = dr["kitapid"].ToString();
                                ekle.SubItems.Add(dr["barkod"].ToString());
                                ekle.SubItems.Add(dr["adi"].ToString());
                                ekle.SubItems.Add(dr["yazaradi"].ToString());
                                ekle.SubItems.Add(okuyucu);
                                ekle.BackColor = Color.Green;
                                listView1.Items.Add(ekle);
                            }
                            else
                            {
                                stoks = int.Parse(dr["stoks"].ToString());
                                ListViewItem ekle = new ListViewItem();
                                ekle.Text = dr["kitapid"].ToString();
                                ekle.SubItems.Add(dr["barkod"].ToString());
                                ekle.SubItems.Add(dr["adi"].ToString());
                                ekle.SubItems.Add(dr["yazaradi"].ToString());
                                ekle.SubItems.Add(okuyucu);
                                ekle.BackColor = Color.Red;
                                listView1.Items.Add(ekle);
                            }

                        }
                    }

                }
                    else
                    {
                        gbemanet.Enabled = false;
                    }                    
            }
            catch { }
            
        }

        private void tbtcemanet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbtcemanet.Text.Length == 11)
                {
                    gbemanet.Enabled = true;
                    OleDbCommand komut = new OleDbCommand("select * from okuyucu where tckimlik=@tckimlik", conn);
                    komut.Parameters.AddWithValue("@tckimlik", tbtcemanet.Text);
                    OleDbDataReader oku = komut.ExecuteReader();
                    oku.Read();
                    {
                        OleDbCommand komut1 = new OleDbCommand("select * from kitaplar", conn);
                        OleDbDataReader dr = komut1.ExecuteReader();

                        listView1.Items.Clear();
                        while(dr.Read())
                        {

                            if (dr["stoks"].ToString() != "0")
                            {
                                stoks = int.Parse(dr["stoks"].ToString());
                                ListViewItem ekle = new ListViewItem();
                                ekle.Text = dr["kitapid"].ToString();
                                ekle.SubItems.Add(dr["barkod"].ToString());
                                ekle.SubItems.Add(dr["adi"].ToString());
                                ekle.SubItems.Add(dr["yazaradi"].ToString());
                                ekle.SubItems.Add(okuyucu);
                                ekle.BackColor = Color.Green;
                                listView1.Items.Add(ekle);
                            }
                            else
                            {
                                if (dr["okuyucutc"].ToString() == tbtcemanet.Text)
                                {

                                    stoks = int.Parse(dr["stoks"].ToString());
                                    ListViewItem ekle = new ListViewItem();
                                    ekle.Text = dr["kitapid"].ToString();
                                    ekle.SubItems.Add(dr["barkod"].ToString());
                                    ekle.SubItems.Add(dr["adi"].ToString());
                                    ekle.SubItems.Add(dr["yazaradi"].ToString());
                                    ekle.SubItems.Add(okuyucu);
                                    ekle.BackColor = Color.Yellow;

                                    listView1.Items.Add(ekle);
                                }
                                else
                                {

                                    stoks = int.Parse(dr["stoks"].ToString());
                                    ListViewItem ekle1 = new ListViewItem();
                                    ekle1.Text = dr["kitapid"].ToString();
                                    ekle1.SubItems.Add(dr["barkod"].ToString());
                                    ekle1.SubItems.Add(dr["adi"].ToString());
                                    ekle1.SubItems.Add(dr["yazaradi"].ToString());
                                    ekle1.SubItems.Add(okuyucu);
                                    ekle1.BackColor = Color.Red;
                                    listView1.Items.Add(ekle1);
                                }



                            }

                        }

                    }

                }
                else 
                {
                    gbemanet.Enabled = false;
                    OleDbCommand komut = new OleDbCommand("select * from okuyucu", conn);
                    OleDbDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        OleDbCommand komut1 = new OleDbCommand("select * from kitaplar", conn);
                        OleDbDataReader dr = komut1.ExecuteReader();

                        listView1.Items.Clear();
                        while (dr.Read())
                        {

                            if (dr["stoks"].ToString() != "0")
                            {
                                stoks = int.Parse(dr["stoks"].ToString());
                                ListViewItem ekle = new ListViewItem();
                                ekle.Text = dr["kitapid"].ToString();
                                ekle.SubItems.Add(dr["barkod"].ToString());
                                ekle.SubItems.Add(dr["adi"].ToString());
                                ekle.SubItems.Add(dr["yazaradi"].ToString());
                                ekle.SubItems.Add(okuyucu);
                                ekle.BackColor = Color.Green;
                                listView1.Items.Add(ekle);
                            }
                            else
                            {
                                if (dr["okuyucutc"].ToString() == tbtcemanet.Text)
                                {

                                    stoks = int.Parse(dr["stoks"].ToString());
                                    ListViewItem ekle = new ListViewItem();
                                    ekle.Text = dr["kitapid"].ToString();
                                    ekle.SubItems.Add(dr["barkod"].ToString());
                                    ekle.SubItems.Add(dr["adi"].ToString());
                                    ekle.SubItems.Add(dr["yazaradi"].ToString());
                                    ekle.SubItems.Add(okuyucu);
                                    ekle.BackColor = Color.Yellow;
                                    listView1.Items.Add(ekle);
                                }
                                else
                                {
                                    stoks = int.Parse(dr["stoks"].ToString());
                                    ListViewItem ekle1 = new ListViewItem();
                                    ekle1.Text = dr["kitapid"].ToString();
                                    ekle1.SubItems.Add(dr["barkod"].ToString());
                                    ekle1.SubItems.Add(dr["adi"].ToString());
                                    ekle1.SubItems.Add(dr["yazaradi"].ToString());
                                    ekle1.SubItems.Add(okuyucu);
                                    ekle1.BackColor = Color.Red;
                                    listView1.Items.Add(ekle1);
                                }
                            }

                        }

                    }
                }

            }
            catch { }
        }

        private void personelDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelduzenlmemi = true;
            PersonelDuzenlemeVeSilme gecis = new PersonelDuzenlemeVeSilme();
            gecis.ShowDialog();
        }

        private void uyearsivsiv_Click(object sender, EventArgs e)
        {
            sivilmi = true;
            OkuyucuArsivi gecis = new OkuyucuArsivi();
            gecis.ShowDialog();
        }      

        private void kitapgnc_Click(object sender, EventArgs e)
        {
            kitapsilmemi = false;
            KitapSilmeVeDuzenleme gecis = new KitapSilmeVeDuzenleme();
            gecis.ShowDialog();
        }

        private void yeniuyeaka_Click(object sender, EventArgs e)
        {
            akademisyenmi = true;
            Yeni_Okuyucu gecis = new Yeni_Okuyucu();
            gecis.ShowDialog();
        }

        private void yeniuyeogr_Click(object sender, EventArgs e)
        {
            ogrencimi = true;
            Yeni_Okuyucu gecis = new Yeni_Okuyucu();
            gecis.ShowDialog();
        }
    }
}

