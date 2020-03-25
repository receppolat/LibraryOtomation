namespace KutuphaneOtomosyonu
{
    partial class OkuyucuArsivi
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
            this.tbtc = new System.Windows.Forms.MaskedTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.okuyucuid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwtckimlik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwpasaportkimlik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwsoyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwcinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwdtarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwktarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwtelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwadres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwokudugukitap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwaktifmi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwnumara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwokul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwbolum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwsinif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwlisemi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label23 = new System.Windows.Forms.Label();
            this.tbsoyadi = new System.Windows.Forms.TextBox();
            this.tbadi = new System.Windows.Forms.TextBox();
            this.cbokul = new System.Windows.Forms.ComboBox();
            this.tbnumara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelnumara = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yabancimi = new System.Windows.Forms.CheckBox();
            this.tbpasaport = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // tbtc
            // 
            this.tbtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbtc.Location = new System.Drawing.Point(182, 15);
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
            this.okuyucuid,
            this.lwtckimlik,
            this.lwpasaportkimlik,
            this.lwadi,
            this.lwsoyadi,
            this.lwcinsiyet,
            this.lwdtarihi,
            this.lwktarihi,
            this.lwmail,
            this.lwtelefon,
            this.lwadres,
            this.lwokudugukitap,
            this.lwaktifmi,
            this.lwnumara,
            this.lwokul,
            this.lwbolum,
            this.lwsinif,
            this.lwlisemi});
            this.listView1.Location = new System.Drawing.Point(12, 94);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(941, 375);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // okuyucuid
            // 
            this.okuyucuid.Text = "Okuyucu ID";
            this.okuyucuid.Width = 80;
            // 
            // lwtckimlik
            // 
            this.lwtckimlik.Text = "TC Kimlik Numarası";
            // 
            // lwpasaportkimlik
            // 
            this.lwpasaportkimlik.Text = "Pasaport Numarası";
            this.lwpasaportkimlik.Width = 80;
            // 
            // lwadi
            // 
            this.lwadi.Text = "Adı";
            this.lwadi.Width = 80;
            // 
            // lwsoyadi
            // 
            this.lwsoyadi.Text = "Soyadı";
            this.lwsoyadi.Width = 80;
            // 
            // lwcinsiyet
            // 
            this.lwcinsiyet.Text = "Cinsiyet";
            this.lwcinsiyet.Width = 80;
            // 
            // lwdtarihi
            // 
            this.lwdtarihi.Text = "Doğum Tarihi";
            this.lwdtarihi.Width = 80;
            // 
            // lwktarihi
            // 
            this.lwktarihi.Text = "Kayıt Tarihi";
            this.lwktarihi.Width = 80;
            // 
            // lwmail
            // 
            this.lwmail.Text = "Mail";
            this.lwmail.Width = 80;
            // 
            // lwtelefon
            // 
            this.lwtelefon.Text = "Telefon";
            this.lwtelefon.Width = 80;
            // 
            // lwadres
            // 
            this.lwadres.Text = "Adres";
            this.lwadres.Width = 80;
            // 
            // lwokudugukitap
            // 
            this.lwokudugukitap.Text = "Okuduğu Kitap Sayısı";
            this.lwokudugukitap.Width = 80;
            // 
            // lwaktifmi
            // 
            this.lwaktifmi.Text = "Aktif/Pasif";
            this.lwaktifmi.Width = 80;
            // 
            // lwnumara
            // 
            this.lwnumara.Text = "Numara";
            this.lwnumara.Width = 80;
            // 
            // lwokul
            // 
            this.lwokul.Text = "Okul";
            this.lwokul.Width = 80;
            // 
            // lwbolum
            // 
            this.lwbolum.Text = "Bölüm";
            this.lwbolum.Width = 80;
            // 
            // lwsinif
            // 
            this.lwsinif.Text = "Sınıf";
            this.lwsinif.Width = 80;
            // 
            // lwlisemi
            // 
            this.lwlisemi.Text = "Lise/Üniversite";
            this.lwlisemi.Width = 80;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(12, 21);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 17);
            this.label23.TabIndex = 17;
            this.label23.Text = "TC Kimlik Numarası:";
            // 
            // tbsoyadi
            // 
            this.tbsoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbsoyadi.Location = new System.Drawing.Point(801, 15);
            this.tbsoyadi.Name = "tbsoyadi";
            this.tbsoyadi.Size = new System.Drawing.Size(152, 23);
            this.tbsoyadi.TabIndex = 2;
            this.tbsoyadi.TextChanged += new System.EventHandler(this.tbsoyadi_TextChanged);
            // 
            // tbadi
            // 
            this.tbadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbadi.Location = new System.Drawing.Point(493, 15);
            this.tbadi.Name = "tbadi";
            this.tbadi.Size = new System.Drawing.Size(152, 23);
            this.tbadi.TabIndex = 1;
            this.tbadi.TextChanged += new System.EventHandler(this.tbadi_TextChanged);
            // 
            // cbokul
            // 
            this.cbokul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbokul.FormattingEnabled = true;
            this.cbokul.Location = new System.Drawing.Point(493, 58);
            this.cbokul.Name = "cbokul";
            this.cbokul.Size = new System.Drawing.Size(152, 24);
            this.cbokul.TabIndex = 4;
            this.cbokul.SelectedIndexChanged += new System.EventHandler(this.cbokul_SelectedIndexChanged);
            // 
            // tbnumara
            // 
            this.tbnumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbnumara.Location = new System.Drawing.Point(182, 59);
            this.tbnumara.Name = "tbnumara";
            this.tbnumara.Size = new System.Drawing.Size(152, 23);
            this.tbnumara.TabIndex = 3;
            this.tbnumara.TextChanged += new System.EventHandler(this.tbnumara_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(680, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Okuyucu Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(380, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Okuyucu Adı:";
            // 
            // labelnumara
            // 
            this.labelnumara.AutoSize = true;
            this.labelnumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelnumara.Location = new System.Drawing.Point(12, 65);
            this.labelnumara.Name = "labelnumara";
            this.labelnumara.Size = new System.Drawing.Size(148, 17);
            this.labelnumara.TabIndex = 25;
            this.labelnumara.Text = "...................Numarası:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(380, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Okulu:";
            // 
            // yabancimi
            // 
            this.yabancimi.AutoSize = true;
            this.yabancimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yabancimi.Location = new System.Drawing.Point(182, 37);
            this.yabancimi.Name = "yabancimi";
            this.yabancimi.Size = new System.Drawing.Size(98, 16);
            this.yabancimi.TabIndex = 27;
            this.yabancimi.Text = "Yabancı Vatandaş";
            this.yabancimi.UseVisualStyleBackColor = true;
            this.yabancimi.CheckedChanged += new System.EventHandler(this.yabancimi_CheckedChanged);
            // 
            // tbpasaport
            // 
            this.tbpasaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbpasaport.Location = new System.Drawing.Point(182, 15);
            this.tbpasaport.Mask = "000000000";
            this.tbpasaport.Name = "tbpasaport";
            this.tbpasaport.PromptChar = ' ';
            this.tbpasaport.Size = new System.Drawing.Size(152, 23);
            this.tbpasaport.TabIndex = 0;
            this.tbpasaport.Visible = false;
            this.tbpasaport.TextChanged += new System.EventHandler(this.tbpasaport_TextChanged);
            // 
            // OkuyucuArsivi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(961, 481);
            this.Controls.Add(this.tbpasaport);
            this.Controls.Add(this.yabancimi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelnumara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbnumara);
            this.Controls.Add(this.cbokul);
            this.Controls.Add(this.tbadi);
            this.Controls.Add(this.tbsoyadi);
            this.Controls.Add(this.tbtc);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label23);
            this.Name = "OkuyucuArsivi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okuyucu Arşivi";
            this.Load += new System.EventHandler(this.OkuyucuArsivi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbtc;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbsoyadi;
        private System.Windows.Forms.TextBox tbadi;
        private System.Windows.Forms.ComboBox cbokul;
        private System.Windows.Forms.TextBox tbnumara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelnumara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox yabancimi;
        private System.Windows.Forms.MaskedTextBox tbpasaport;
        private System.Windows.Forms.ColumnHeader okuyucuid;
        private System.Windows.Forms.ColumnHeader lwtckimlik;
        private System.Windows.Forms.ColumnHeader lwadi;
        private System.Windows.Forms.ColumnHeader lwsoyadi;
        private System.Windows.Forms.ColumnHeader lwcinsiyet;
        private System.Windows.Forms.ColumnHeader lwdtarihi;
        private System.Windows.Forms.ColumnHeader lwmail;
        private System.Windows.Forms.ColumnHeader lwtelefon;
        private System.Windows.Forms.ColumnHeader lwadres;
        private System.Windows.Forms.ColumnHeader lwnumara;
        private System.Windows.Forms.ColumnHeader lwokul;
        private System.Windows.Forms.ColumnHeader lwbolum;
        private System.Windows.Forms.ColumnHeader lwsinif;
        private System.Windows.Forms.ColumnHeader lwktarihi;
        private System.Windows.Forms.ColumnHeader lwlisemi;
        private System.Windows.Forms.ColumnHeader lwokudugukitap;
        private System.Windows.Forms.ColumnHeader lwaktifmi;
        private System.Windows.Forms.ColumnHeader lwpasaportkimlik;
    }
}