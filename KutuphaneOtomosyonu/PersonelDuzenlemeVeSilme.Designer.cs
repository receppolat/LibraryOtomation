namespace KutuphaneOtomosyonu
{
    partial class PersonelDuzenlemeVeSilme
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
            this.btnislevler = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbpasaport = new System.Windows.Forms.MaskedTextBox();
            this.yabancimi = new System.Windows.Forms.CheckBox();
            this.tbtc = new System.Windows.Forms.MaskedTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lwpersonelid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwtc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwpasaport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwsoyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwgorevi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwtelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label23 = new System.Windows.Forms.Label();
            this.gbiletisim = new System.Windows.Forms.GroupBox();
            this.btnpersonelfotograf = new System.Windows.Forms.Button();
            this.gbuye = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.diger = new System.Windows.Forms.RadioButton();
            this.sorumlu = new System.Windows.Forms.RadioButton();
            this.memur = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpersonelid = new System.Windows.Forms.TextBox();
            this.fotografpersonelekleme = new System.Windows.Forms.PictureBox();
            this.dtarihi = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbisim = new System.Windows.Forms.TextBox();
            this.tbsoyisim = new System.Windows.Forms.TextBox();
            this.tbtel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbadres = new System.Windows.Forms.TextBox();
            this.tbmail = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.gbiletisim.SuspendLayout();
            this.gbuye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotografpersonelekleme)).BeginInit();
            this.SuspendLayout();
            // 
            // btnislevler
            // 
            this.btnislevler.Location = new System.Drawing.Point(710, 399);
            this.btnislevler.Name = "btnislevler";
            this.btnislevler.Size = new System.Drawing.Size(115, 36);
            this.btnislevler.TabIndex = 15;
            this.btnislevler.Text = "Çoklu Buton";
            this.btnislevler.UseVisualStyleBackColor = true;
            this.btnislevler.Click += new System.EventHandler(this.btnislevler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbpasaport);
            this.groupBox1.Controls.Add(this.yabancimi);
            this.groupBox1.Controls.Add(this.tbtc);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 423);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama ve Filtreleme";
            // 
            // tbpasaport
            // 
            this.tbpasaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbpasaport.Location = new System.Drawing.Point(146, 25);
            this.tbpasaport.Mask = "000000000";
            this.tbpasaport.Name = "tbpasaport";
            this.tbpasaport.PromptChar = ' ';
            this.tbpasaport.Size = new System.Drawing.Size(152, 23);
            this.tbpasaport.TabIndex = 22;
            this.tbpasaport.Visible = false;
            this.tbpasaport.TextChanged += new System.EventHandler(this.tbpasaport_TextChanged);
            // 
            // yabancimi
            // 
            this.yabancimi.AutoSize = true;
            this.yabancimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yabancimi.Location = new System.Drawing.Point(304, 33);
            this.yabancimi.Name = "yabancimi";
            this.yabancimi.Size = new System.Drawing.Size(98, 16);
            this.yabancimi.TabIndex = 21;
            this.yabancimi.Text = "Yabancı Vatandaş";
            this.yabancimi.UseVisualStyleBackColor = true;
            this.yabancimi.CheckedChanged += new System.EventHandler(this.yabancimi_CheckedChanged);
            // 
            // tbtc
            // 
            this.tbtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbtc.Location = new System.Drawing.Point(146, 25);
            this.tbtc.Mask = "00000000000";
            this.tbtc.Name = "tbtc";
            this.tbtc.PromptChar = ' ';
            this.tbtc.Size = new System.Drawing.Size(152, 23);
            this.tbtc.TabIndex = 0;
            this.tbtc.TextChanged += new System.EventHandler(this.tbtc_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lwpersonelid,
            this.lwtc,
            this.lwpasaport,
            this.lwadi,
            this.lwsoyadi,
            this.lwgorevi,
            this.lwtelefon});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.Location = new System.Drawing.Point(9, 49);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(442, 367);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lwpersonelid
            // 
            this.lwpersonelid.Text = "Personel ID";
            this.lwpersonelid.Width = 75;
            // 
            // lwtc
            // 
            this.lwtc.Text = "TC Kimlik Numarası";
            this.lwtc.Width = 85;
            // 
            // lwpasaport
            // 
            this.lwpasaport.Text = "Pasaport Numarası";
            this.lwpasaport.Width = 85;
            // 
            // lwadi
            // 
            this.lwadi.Text = "İsim";
            this.lwadi.Width = 80;
            // 
            // lwsoyadi
            // 
            this.lwsoyadi.Text = "Soyisim";
            this.lwsoyadi.Width = 80;
            // 
            // lwgorevi
            // 
            this.lwgorevi.Text = "Görevi";
            this.lwgorevi.Width = 80;
            // 
            // lwtelefon
            // 
            this.lwtelefon.Text = "Telefon";
            this.lwtelefon.Width = 85;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(6, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 17);
            this.label23.TabIndex = 14;
            this.label23.Text = "TC Kimlik Numarası:";
            // 
            // gbiletisim
            // 
            this.gbiletisim.Controls.Add(this.btnpersonelfotograf);
            this.gbiletisim.Controls.Add(this.gbuye);
            this.gbiletisim.Controls.Add(this.fotografpersonelekleme);
            this.gbiletisim.Controls.Add(this.dtarihi);
            this.gbiletisim.Controls.Add(this.label22);
            this.gbiletisim.Controls.Add(this.label21);
            this.gbiletisim.Controls.Add(this.label17);
            this.gbiletisim.Controls.Add(this.tbisim);
            this.gbiletisim.Controls.Add(this.tbsoyisim);
            this.gbiletisim.Controls.Add(this.tbtel);
            this.gbiletisim.Controls.Add(this.label4);
            this.gbiletisim.Controls.Add(this.tbadres);
            this.gbiletisim.Controls.Add(this.tbmail);
            this.gbiletisim.Controls.Add(this.label19);
            this.gbiletisim.Controls.Add(this.label18);
            this.gbiletisim.Location = new System.Drawing.Point(473, 12);
            this.gbiletisim.Name = "gbiletisim";
            this.gbiletisim.Size = new System.Drawing.Size(352, 381);
            this.gbiletisim.TabIndex = 16;
            this.gbiletisim.TabStop = false;
            this.gbiletisim.Text = "İletişim Bilgileri";
            // 
            // btnpersonelfotograf
            // 
            this.btnpersonelfotograf.Enabled = false;
            this.btnpersonelfotograf.Location = new System.Drawing.Point(256, 104);
            this.btnpersonelfotograf.Name = "btnpersonelfotograf";
            this.btnpersonelfotograf.Size = new System.Drawing.Size(88, 27);
            this.btnpersonelfotograf.TabIndex = 22;
            this.btnpersonelfotograf.Text = "Fotoğraf Ekle";
            this.btnpersonelfotograf.UseVisualStyleBackColor = true;
            this.btnpersonelfotograf.Click += new System.EventHandler(this.btngazetefotograf_Click);
            // 
            // gbuye
            // 
            this.gbuye.Controls.Add(this.label2);
            this.gbuye.Controls.Add(this.diger);
            this.gbuye.Controls.Add(this.sorumlu);
            this.gbuye.Controls.Add(this.memur);
            this.gbuye.Controls.Add(this.label1);
            this.gbuye.Controls.Add(this.tbpersonelid);
            this.gbuye.Location = new System.Drawing.Point(14, 240);
            this.gbuye.Name = "gbuye";
            this.gbuye.Size = new System.Drawing.Size(330, 133);
            this.gbuye.TabIndex = 1;
            this.gbuye.TabStop = false;
            this.gbuye.Text = "Personel Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Personel Görevi:";
            // 
            // diger
            // 
            this.diger.AutoSize = true;
            this.diger.Enabled = false;
            this.diger.Location = new System.Drawing.Point(118, 109);
            this.diger.Name = "diger";
            this.diger.Size = new System.Drawing.Size(50, 17);
            this.diger.TabIndex = 13;
            this.diger.TabStop = true;
            this.diger.Text = "Diğer";
            this.diger.UseVisualStyleBackColor = true;
            // 
            // sorumlu
            // 
            this.sorumlu.AutoSize = true;
            this.sorumlu.Enabled = false;
            this.sorumlu.Location = new System.Drawing.Point(118, 86);
            this.sorumlu.Name = "sorumlu";
            this.sorumlu.Size = new System.Drawing.Size(93, 17);
            this.sorumlu.TabIndex = 12;
            this.sorumlu.TabStop = true;
            this.sorumlu.Text = "Kat Sorumlusu";
            this.sorumlu.UseVisualStyleBackColor = true;
            // 
            // memur
            // 
            this.memur.AutoSize = true;
            this.memur.Enabled = false;
            this.memur.Location = new System.Drawing.Point(118, 63);
            this.memur.Name = "memur";
            this.memur.Size = new System.Drawing.Size(118, 17);
            this.memur.TabIndex = 11;
            this.memur.TabStop = true;
            this.memur.Text = "Kütüphane Memuru";
            this.memur.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Personel Numarası:";
            // 
            // tbpersonelid
            // 
            this.tbpersonelid.Location = new System.Drawing.Point(118, 29);
            this.tbpersonelid.Name = "tbpersonelid";
            this.tbpersonelid.ReadOnly = true;
            this.tbpersonelid.Size = new System.Drawing.Size(118, 20);
            this.tbpersonelid.TabIndex = 0;
            this.tbpersonelid.TextChanged += new System.EventHandler(this.tbpersonelid_TextChanged);
            // 
            // fotografpersonelekleme
            // 
            this.fotografpersonelekleme.Location = new System.Drawing.Point(256, 17);
            this.fotografpersonelekleme.Name = "fotografpersonelekleme";
            this.fotografpersonelekleme.Size = new System.Drawing.Size(88, 84);
            this.fotografpersonelekleme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotografpersonelekleme.TabIndex = 23;
            this.fotografpersonelekleme.TabStop = false;
            // 
            // dtarihi
            // 
            this.dtarihi.Enabled = false;
            this.dtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtarihi.Location = new System.Drawing.Point(114, 67);
            this.dtarihi.MaxDate = new System.DateTime(2013, 12, 31, 0, 0, 0, 0);
            this.dtarihi.Name = "dtarihi";
            this.dtarihi.Size = new System.Drawing.Size(112, 20);
            this.dtarihi.TabIndex = 43;
            this.dtarihi.Value = new System.DateTime(2013, 12, 31, 0, 0, 0, 0);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 46;
            this.label22.Text = "İsim *:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "Soyisim *:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "Doğum Tarihi *:";
            // 
            // tbisim
            // 
            this.tbisim.Location = new System.Drawing.Point(114, 18);
            this.tbisim.Name = "tbisim";
            this.tbisim.ReadOnly = true;
            this.tbisim.Size = new System.Drawing.Size(112, 20);
            this.tbisim.TabIndex = 39;
            // 
            // tbsoyisim
            // 
            this.tbsoyisim.Location = new System.Drawing.Point(114, 41);
            this.tbsoyisim.Name = "tbsoyisim";
            this.tbsoyisim.ReadOnly = true;
            this.tbsoyisim.Size = new System.Drawing.Size(112, 20);
            this.tbsoyisim.TabIndex = 40;
            // 
            // tbtel
            // 
            this.tbtel.Enabled = false;
            this.tbtel.Location = new System.Drawing.Point(114, 119);
            this.tbtel.Mask = "(999) 000-0000";
            this.tbtel.Name = "tbtel";
            this.tbtel.Size = new System.Drawing.Size(82, 20);
            this.tbtel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Adres *:";
            // 
            // tbadres
            // 
            this.tbadres.Location = new System.Drawing.Point(113, 145);
            this.tbadres.Multiline = true;
            this.tbadres.Name = "tbadres";
            this.tbadres.ReadOnly = true;
            this.tbadres.Size = new System.Drawing.Size(227, 89);
            this.tbadres.TabIndex = 9;
            // 
            // tbmail
            // 
            this.tbmail.Location = new System.Drawing.Point(113, 93);
            this.tbmail.Name = "tbmail";
            this.tbmail.ReadOnly = true;
            this.tbmail.Size = new System.Drawing.Size(133, 20);
            this.tbmail.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 126);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "Telefon Numarası *:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "E-Posta Adresi:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PersonelDuzenlemeVeSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(837, 446);
            this.Controls.Add(this.gbiletisim);
            this.Controls.Add(this.btnislevler);
            this.Controls.Add(this.groupBox1);
            this.Name = "PersonelDuzenlemeVeSilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Düzenleme Ve Silme";
            this.Load += new System.EventHandler(this.PersonelDuzenlemeVeSilme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbiletisim.ResumeLayout(false);
            this.gbiletisim.PerformLayout();
            this.gbuye.ResumeLayout(false);
            this.gbuye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotografpersonelekleme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnislevler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox tbpasaport;
        private System.Windows.Forms.CheckBox yabancimi;
        private System.Windows.Forms.MaskedTextBox tbtc;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox gbiletisim;
        private System.Windows.Forms.Button btnpersonelfotograf;
        private System.Windows.Forms.GroupBox gbuye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton diger;
        private System.Windows.Forms.RadioButton sorumlu;
        private System.Windows.Forms.RadioButton memur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbpersonelid;
        private System.Windows.Forms.PictureBox fotografpersonelekleme;
        private System.Windows.Forms.DateTimePicker dtarihi;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbisim;
        private System.Windows.Forms.TextBox tbsoyisim;
        private System.Windows.Forms.MaskedTextBox tbtel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbadres;
        private System.Windows.Forms.TextBox tbmail;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColumnHeader lwpersonelid;
        private System.Windows.Forms.ColumnHeader lwadi;
        private System.Windows.Forms.ColumnHeader lwsoyadi;
        private System.Windows.Forms.ColumnHeader lwgorevi;
        private System.Windows.Forms.ColumnHeader lwtelefon;
        private System.Windows.Forms.ColumnHeader lwtc;
        private System.Windows.Forms.ColumnHeader lwpasaport;
    }
}