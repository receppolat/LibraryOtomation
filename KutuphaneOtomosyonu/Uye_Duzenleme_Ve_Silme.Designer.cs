namespace KutuphaneOtomosyonu
{
    partial class Uye_Duzenleme_Ve_Silme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.tbpasaport = new System.Windows.Forms.MaskedTextBox();
            this.tbtc = new System.Windows.Forms.MaskedTextBox();
            this.dtarihi = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.yabancimi = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbtel = new System.Windows.Forms.MaskedTextBox();
            this.tbadres = new System.Windows.Forms.TextBox();
            this.tbisim = new System.Windows.Forms.TextBox();
            this.tbmail = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbsoyisim = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.gbograka = new System.Windows.Forms.GroupBox();
            this.tbokul = new System.Windows.Forms.TextBox();
            this.rblise = new System.Windows.Forms.RadioButton();
            this.rbüni = new System.Windows.Forms.RadioButton();
            this.tbsinif = new System.Windows.Forms.TextBox();
            this.tbbolum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelnumara = new System.Windows.Forms.Label();
            this.labelsinif = new System.Windows.Forms.Label();
            this.tbnumara = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbadiaranan = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.uyeid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwtckimlik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwpasaportkimlik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.okuyucutipi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnislevler = new System.Windows.Forms.Button();
            this.labellise = new System.Windows.Forms.Label();
            this.rbakademisyen = new System.Windows.Forms.RadioButton();
            this.rbokul = new System.Windows.Forms.RadioButton();
            this.gb2.SuspendLayout();
            this.gbograka.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.tbpasaport);
            this.gb2.Controls.Add(this.tbtc);
            this.gb2.Controls.Add(this.dtarihi);
            this.gb2.Controls.Add(this.label23);
            this.gb2.Controls.Add(this.yabancimi);
            this.gb2.Controls.Add(this.label17);
            this.gb2.Controls.Add(this.label22);
            this.gb2.Controls.Add(this.label3);
            this.gb2.Controls.Add(this.label21);
            this.gb2.Controls.Add(this.tbtel);
            this.gb2.Controls.Add(this.tbadres);
            this.gb2.Controls.Add(this.tbisim);
            this.gb2.Controls.Add(this.tbmail);
            this.gb2.Controls.Add(this.label19);
            this.gb2.Controls.Add(this.tbsoyisim);
            this.gb2.Controls.Add(this.label18);
            this.gb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb2.Location = new System.Drawing.Point(455, 12);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(339, 255);
            this.gb2.TabIndex = 0;
            this.gb2.TabStop = false;
            this.gb2.Text = "İletişim Bilgileri";
            // 
            // tbpasaport
            // 
            this.tbpasaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbpasaport.Location = new System.Drawing.Point(113, 211);
            this.tbpasaport.Mask = "000000000";
            this.tbpasaport.Name = "tbpasaport";
            this.tbpasaport.PromptChar = ' ';
            this.tbpasaport.ReadOnly = true;
            this.tbpasaport.Size = new System.Drawing.Size(100, 20);
            this.tbpasaport.TabIndex = 51;
            this.tbpasaport.Visible = false;
            this.tbpasaport.TextChanged += new System.EventHandler(this.tbpasaport_TextChanged_1);
            // 
            // tbtc
            // 
            this.tbtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbtc.Location = new System.Drawing.Point(113, 211);
            this.tbtc.Mask = "00000000000";
            this.tbtc.Name = "tbtc";
            this.tbtc.PromptChar = ' ';
            this.tbtc.ReadOnly = true;
            this.tbtc.Size = new System.Drawing.Size(100, 20);
            this.tbtc.TabIndex = 50;
            this.tbtc.TextChanged += new System.EventHandler(this.tbtc_TextChanged_1);
            // 
            // dtarihi
            // 
            this.dtarihi.Enabled = false;
            this.dtarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtarihi.Location = new System.Drawing.Point(113, 76);
            this.dtarihi.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dtarihi.Name = "dtarihi";
            this.dtarihi.Size = new System.Drawing.Size(110, 20);
            this.dtarihi.TabIndex = 3;
            this.dtarihi.Value = new System.DateTime(2013, 12, 31, 0, 0, 0, 0);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(8, 218);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "TC Kimlik Numarası:";
            // 
            // yabancimi
            // 
            this.yabancimi.AutoSize = true;
            this.yabancimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yabancimi.Location = new System.Drawing.Point(113, 233);
            this.yabancimi.Name = "yabancimi";
            this.yabancimi.Size = new System.Drawing.Size(98, 16);
            this.yabancimi.TabIndex = 21;
            this.yabancimi.Text = "Yabancı Vatandaş";
            this.yabancimi.UseVisualStyleBackColor = true;
            this.yabancimi.CheckedChanged += new System.EventHandler(this.yabancimi_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(8, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "Doğum Tarihi:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(8, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 13);
            this.label22.TabIndex = 46;
            this.label22.Text = "İsim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Adres:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(6, 57);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "Soyisim:";
            // 
            // tbtel
            // 
            this.tbtel.Enabled = false;
            this.tbtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbtel.Location = new System.Drawing.Point(113, 127);
            this.tbtel.Mask = "(000) 000-0000";
            this.tbtel.Name = "tbtel";
            this.tbtel.Size = new System.Drawing.Size(82, 20);
            this.tbtel.TabIndex = 5;
            // 
            // tbadres
            // 
            this.tbadres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbadres.Location = new System.Drawing.Point(113, 153);
            this.tbadres.Multiline = true;
            this.tbadres.Name = "tbadres";
            this.tbadres.ReadOnly = true;
            this.tbadres.Size = new System.Drawing.Size(201, 52);
            this.tbadres.TabIndex = 6;
            // 
            // tbisim
            // 
            this.tbisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbisim.Location = new System.Drawing.Point(113, 24);
            this.tbisim.Name = "tbisim";
            this.tbisim.ReadOnly = true;
            this.tbisim.Size = new System.Drawing.Size(110, 20);
            this.tbisim.TabIndex = 1;
            // 
            // tbmail
            // 
            this.tbmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbmail.Location = new System.Drawing.Point(113, 101);
            this.tbmail.Name = "tbmail";
            this.tbmail.ReadOnly = true;
            this.tbmail.Size = new System.Drawing.Size(133, 20);
            this.tbmail.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(8, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 13);
            this.label19.TabIndex = 41;
            this.label19.Text = "Telefon Numarası:";
            // 
            // tbsoyisim
            // 
            this.tbsoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbsoyisim.Location = new System.Drawing.Point(113, 50);
            this.tbsoyisim.Name = "tbsoyisim";
            this.tbsoyisim.ReadOnly = true;
            this.tbsoyisim.Size = new System.Drawing.Size(110, 20);
            this.tbsoyisim.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(8, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 42;
            this.label18.Text = "E-Posta Adresi:";
            // 
            // gbograka
            // 
            this.gbograka.Controls.Add(this.tbokul);
            this.gbograka.Controls.Add(this.rblise);
            this.gbograka.Controls.Add(this.rbüni);
            this.gbograka.Controls.Add(this.tbsinif);
            this.gbograka.Controls.Add(this.tbbolum);
            this.gbograka.Controls.Add(this.label1);
            this.gbograka.Controls.Add(this.label13);
            this.gbograka.Controls.Add(this.labelnumara);
            this.gbograka.Controls.Add(this.labelsinif);
            this.gbograka.Controls.Add(this.tbnumara);
            this.gbograka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbograka.Location = new System.Drawing.Point(455, 290);
            this.gbograka.Name = "gbograka";
            this.gbograka.Size = new System.Drawing.Size(339, 156);
            this.gbograka.TabIndex = 1;
            this.gbograka.TabStop = false;
            this.gbograka.Text = "Akademik Bilgileri";
            // 
            // tbokul
            // 
            this.tbokul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbokul.Location = new System.Drawing.Point(134, 77);
            this.tbokul.Name = "tbokul";
            this.tbokul.ReadOnly = true;
            this.tbokul.Size = new System.Drawing.Size(121, 20);
            this.tbokul.TabIndex = 54;
            // 
            // rblise
            // 
            this.rblise.AutoSize = true;
            this.rblise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rblise.Location = new System.Drawing.Point(15, 25);
            this.rblise.Name = "rblise";
            this.rblise.Size = new System.Drawing.Size(44, 17);
            this.rblise.TabIndex = 52;
            this.rblise.TabStop = true;
            this.rblise.Text = "Lise";
            this.rblise.UseVisualStyleBackColor = true;
            // 
            // rbüni
            // 
            this.rbüni.AutoSize = true;
            this.rbüni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbüni.Location = new System.Drawing.Point(109, 25);
            this.rbüni.Name = "rbüni";
            this.rbüni.Size = new System.Drawing.Size(72, 17);
            this.rbüni.TabIndex = 53;
            this.rbüni.TabStop = true;
            this.rbüni.Text = "Üniversite";
            this.rbüni.UseVisualStyleBackColor = true;
            // 
            // tbsinif
            // 
            this.tbsinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbsinif.Location = new System.Drawing.Point(134, 129);
            this.tbsinif.Name = "tbsinif";
            this.tbsinif.ReadOnly = true;
            this.tbsinif.Size = new System.Drawing.Size(121, 20);
            this.tbsinif.TabIndex = 10;
            // 
            // tbbolum
            // 
            this.tbbolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbbolum.Location = new System.Drawing.Point(134, 103);
            this.tbbolum.Name = "tbbolum";
            this.tbbolum.ReadOnly = true;
            this.tbbolum.Size = new System.Drawing.Size(121, 20);
            this.tbbolum.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Okul:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(12, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Bölüm:";
            // 
            // labelnumara
            // 
            this.labelnumara.AutoSize = true;
            this.labelnumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelnumara.Location = new System.Drawing.Point(12, 57);
            this.labelnumara.Name = "labelnumara";
            this.labelnumara.Size = new System.Drawing.Size(87, 13);
            this.labelnumara.TabIndex = 24;
            this.labelnumara.Text = ".......... Numarası:";
            // 
            // labelsinif
            // 
            this.labelsinif.AutoSize = true;
            this.labelsinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsinif.Location = new System.Drawing.Point(11, 136);
            this.labelsinif.Name = "labelsinif";
            this.labelsinif.Size = new System.Drawing.Size(30, 13);
            this.labelsinif.TabIndex = 41;
            this.labelsinif.Text = "Sınıf:";
            // 
            // tbnumara
            // 
            this.tbnumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbnumara.Location = new System.Drawing.Point(134, 50);
            this.tbnumara.Name = "tbnumara";
            this.tbnumara.ReadOnly = true;
            this.tbnumara.Size = new System.Drawing.Size(121, 20);
            this.tbnumara.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbadiaranan);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 482);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Arama ve Filtreleme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "İsim:";
            // 
            // tbadiaranan
            // 
            this.tbadiaranan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbadiaranan.Location = new System.Drawing.Point(63, 22);
            this.tbadiaranan.Name = "tbadiaranan";
            this.tbadiaranan.Size = new System.Drawing.Size(110, 26);
            this.tbadiaranan.TabIndex = 47;
            this.tbadiaranan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uyeid,
            this.lwtckimlik,
            this.lwpasaportkimlik,
            this.adi,
            this.soyadi,
            this.okuyucutipi,
            this.telefon,
            this.mail});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.Location = new System.Drawing.Point(6, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(411, 422);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // uyeid
            // 
            this.uyeid.Text = "Okuyucu ID";
            this.uyeid.Width = 80;
            // 
            // lwtckimlik
            // 
            this.lwtckimlik.Text = "TC Kimlik";
            this.lwtckimlik.Width = 80;
            // 
            // lwpasaportkimlik
            // 
            this.lwpasaportkimlik.Text = "Pasaport Numarası";
            this.lwpasaportkimlik.Width = 80;
            // 
            // adi
            // 
            this.adi.Text = "İsim";
            this.adi.Width = 80;
            // 
            // soyadi
            // 
            this.soyadi.Text = "Soyisim";
            this.soyadi.Width = 80;
            // 
            // okuyucutipi
            // 
            this.okuyucutipi.Text = "Okuyucu Tipi";
            this.okuyucutipi.Width = 80;
            // 
            // telefon
            // 
            this.telefon.Text = "Telefon";
            this.telefon.Width = 80;
            // 
            // mail
            // 
            this.mail.Text = "Mail";
            this.mail.Width = 100;
            // 
            // btnislevler
            // 
            this.btnislevler.Location = new System.Drawing.Point(679, 452);
            this.btnislevler.Name = "btnislevler";
            this.btnislevler.Size = new System.Drawing.Size(115, 36);
            this.btnislevler.TabIndex = 11;
            this.btnislevler.Text = "Çoklu Buton";
            this.btnislevler.UseVisualStyleBackColor = true;
            this.btnislevler.Click += new System.EventHandler(this.btnislevler_Click);
            // 
            // labellise
            // 
            this.labellise.AutoSize = true;
            this.labellise.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labellise.Location = new System.Drawing.Point(453, 449);
            this.labellise.Name = "labellise";
            this.labellise.Size = new System.Drawing.Size(213, 9);
            this.labellise.TabIndex = 51;
            this.labellise.Text = "Öğrenci lise öğrencisiyse \"Akademik Bilgileri\" doldurmayınız.";
            // 
            // rbakademisyen
            // 
            this.rbakademisyen.AutoSize = true;
            this.rbakademisyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbakademisyen.Location = new System.Drawing.Point(470, 273);
            this.rbakademisyen.Name = "rbakademisyen";
            this.rbakademisyen.Size = new System.Drawing.Size(88, 17);
            this.rbakademisyen.TabIndex = 54;
            this.rbakademisyen.TabStop = true;
            this.rbakademisyen.Text = "Akademisyen";
            this.rbakademisyen.UseVisualStyleBackColor = true;
            this.rbakademisyen.CheckedChanged += new System.EventHandler(this.rbakademisyen_CheckedChanged);
            // 
            // rbokul
            // 
            this.rbokul.AutoSize = true;
            this.rbokul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbokul.Location = new System.Drawing.Point(564, 273);
            this.rbokul.Name = "rbokul";
            this.rbokul.Size = new System.Drawing.Size(47, 17);
            this.rbokul.TabIndex = 55;
            this.rbokul.TabStop = true;
            this.rbokul.Text = "Okul";
            this.rbokul.UseVisualStyleBackColor = true;
            this.rbokul.CheckedChanged += new System.EventHandler(this.rbokul_CheckedChanged);
            // 
            // Uye_Duzenleme_Ve_Silme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(806, 506);
            this.Controls.Add(this.rbakademisyen);
            this.Controls.Add(this.rbokul);
            this.Controls.Add(this.labellise);
            this.Controls.Add(this.btnislevler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbograka);
            this.Controls.Add(this.gb2);
            this.Name = "Uye_Duzenleme_Ve_Silme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okuyucu Düzenleme ve Silme";
            this.Load += new System.EventHandler(this.Uye_Duzenleme_Ve_Silme_Load);
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gbograka.ResumeLayout(false);
            this.gbograka.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.GroupBox gbograka;
        private System.Windows.Forms.TextBox tbsinif;
        private System.Windows.Forms.TextBox tbbolum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelnumara;
        private System.Windows.Forms.Label labelsinif;
        private System.Windows.Forms.TextBox tbnumara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tbtel;
        private System.Windows.Forms.TextBox tbadres;
        private System.Windows.Forms.TextBox tbmail;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnislevler;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbisim;
        private System.Windows.Forms.TextBox tbsoyisim;
        private System.Windows.Forms.DateTimePicker dtarihi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox yabancimi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lwtckimlik;
        private System.Windows.Forms.ColumnHeader adi;
        private System.Windows.Forms.ColumnHeader soyadi;
        private System.Windows.Forms.ColumnHeader okuyucutipi;
        private System.Windows.Forms.ColumnHeader telefon;
        private System.Windows.Forms.ColumnHeader uyeid;
        private System.Windows.Forms.ColumnHeader mail;
        private System.Windows.Forms.Label labellise;
        private System.Windows.Forms.RadioButton rbüni;
        private System.Windows.Forms.RadioButton rblise;
        private System.Windows.Forms.RadioButton rbakademisyen;
        private System.Windows.Forms.RadioButton rbokul;
        private System.Windows.Forms.ColumnHeader lwpasaportkimlik;
        private System.Windows.Forms.MaskedTextBox tbpasaport;
        private System.Windows.Forms.MaskedTextBox tbtc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbadiaranan;
        private System.Windows.Forms.TextBox tbokul;
    }
}