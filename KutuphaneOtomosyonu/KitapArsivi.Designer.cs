namespace KutuphaneOtomosyonu
{
    partial class KitapArsivi
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbbarkodno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbdurumu = new System.Windows.Forms.ComboBox();
            this.tbisbn = new System.Windows.Forms.TextBox();
            this.tbkitap = new System.Windows.Forms.TextBox();
            this.tbyazar = new System.Windows.Forms.TextBox();
            this.cbdili = new System.Windows.Forms.ComboBox();
            this.cbturu = new System.Windows.Forms.ComboBox();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lwkitapid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwbarkod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwkitapadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwisbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwyazaradi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwcevirmen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwyayinevi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwsayfas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwstoks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwbaski = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwdil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwtur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwkategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwteminbicim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwdurum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwciltdurum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwttarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwbtarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwokunmasayisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwaciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod Numarası:";
            // 
            // tbbarkodno
            // 
            this.tbbarkodno.Location = new System.Drawing.Point(124, 26);
            this.tbbarkodno.Name = "tbbarkodno";
            this.tbbarkodno.Size = new System.Drawing.Size(100, 20);
            this.tbbarkodno.TabIndex = 1;
            this.tbbarkodno.TextChanged += new System.EventHandler(this.tbbarkodno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yazar Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ISBN Numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Türü:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kategorisi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Durum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(659, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Dil:";
            // 
            // cbdurumu
            // 
            this.cbdurumu.FormattingEnabled = true;
            this.cbdurumu.Items.AddRange(new object[] {
            "Hasarlı",
            "Hasarsız"});
            this.cbdurumu.Location = new System.Drawing.Point(518, 56);
            this.cbdurumu.Name = "cbdurumu";
            this.cbdurumu.Size = new System.Drawing.Size(119, 21);
            this.cbdurumu.TabIndex = 14;
            this.cbdurumu.SelectedIndexChanged += new System.EventHandler(this.cbdurumu_SelectedIndexChanged);
            // 
            // tbisbn
            // 
            this.tbisbn.Location = new System.Drawing.Point(124, 61);
            this.tbisbn.Name = "tbisbn";
            this.tbisbn.Size = new System.Drawing.Size(100, 20);
            this.tbisbn.TabIndex = 15;
            this.tbisbn.TextChanged += new System.EventHandler(this.tbisbn_TextChanged);
            // 
            // tbkitap
            // 
            this.tbkitap.Location = new System.Drawing.Point(308, 26);
            this.tbkitap.Name = "tbkitap";
            this.tbkitap.Size = new System.Drawing.Size(119, 20);
            this.tbkitap.TabIndex = 16;
            this.tbkitap.TextChanged += new System.EventHandler(this.tbkitap_TextChanged);
            // 
            // tbyazar
            // 
            this.tbyazar.Location = new System.Drawing.Point(518, 26);
            this.tbyazar.Name = "tbyazar";
            this.tbyazar.Size = new System.Drawing.Size(119, 20);
            this.tbyazar.TabIndex = 17;
            this.tbyazar.TextChanged += new System.EventHandler(this.tbyazar_TextChanged);
            // 
            // cbdili
            // 
            this.cbdili.FormattingEnabled = true;
            this.cbdili.Items.AddRange(new object[] {
            "Türkçe",
            "İngilizce",
            "Fransızca",
            "Almanca",
            "İtalyanca",
            "Rusca",
            "Çince",
            "Korece",
            "Diğer"});
            this.cbdili.Location = new System.Drawing.Point(702, 56);
            this.cbdili.Name = "cbdili";
            this.cbdili.Size = new System.Drawing.Size(100, 21);
            this.cbdili.TabIndex = 18;
            this.cbdili.SelectedIndexChanged += new System.EventHandler(this.cbdili_SelectedIndexChanged);
            // 
            // cbturu
            // 
            this.cbturu.FormattingEnabled = true;
            this.cbturu.Items.AddRange(new object[] {
            "Oyun"});
            this.cbturu.Location = new System.Drawing.Point(702, 25);
            this.cbturu.Name = "cbturu";
            this.cbturu.Size = new System.Drawing.Size(100, 21);
            this.cbturu.TabIndex = 19;
            this.cbturu.SelectedIndexChanged += new System.EventHandler(this.cbturu_SelectedIndexChanged);
            // 
            // cbkategori
            // 
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Items.AddRange(new object[] {
            "Korku",
            "Polisiye"});
            this.cbkategori.Location = new System.Drawing.Point(308, 56);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(119, 21);
            this.cbkategori.TabIndex = 20;
            this.cbkategori.SelectedIndexChanged += new System.EventHandler(this.cbkategori_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lwkitapid,
            this.lwbarkod,
            this.lwkitapadi,
            this.lwisbn,
            this.lwyazaradi,
            this.lwcevirmen,
            this.lwyayinevi,
            this.lwsayfas,
            this.lwstoks,
            this.lwbaski,
            this.lwdil,
            this.lwtur,
            this.lwkategori,
            this.lwteminbicim,
            this.lwdurum,
            this.lwciltdurum,
            this.lwttarihi,
            this.lwbtarihi,
            this.lwokunmasayisi,
            this.lwaciklama});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.Location = new System.Drawing.Point(12, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(790, 368);
            this.listView1.TabIndex = 445;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lwkitapid
            // 
            this.lwkitapid.Text = "Kitap ID";
            // 
            // lwbarkod
            // 
            this.lwbarkod.Text = "Barkod Numarası";
            this.lwbarkod.Width = 80;
            // 
            // lwkitapadi
            // 
            this.lwkitapadi.Text = "Kitap Adı";
            this.lwkitapadi.Width = 80;
            // 
            // lwisbn
            // 
            this.lwisbn.Text = "ISBN Numarası";
            this.lwisbn.Width = 80;
            // 
            // lwyazaradi
            // 
            this.lwyazaradi.Text = "Yazar Adı";
            this.lwyazaradi.Width = 80;
            // 
            // lwcevirmen
            // 
            this.lwcevirmen.Text = "Çevirmen Adı";
            this.lwcevirmen.Width = 80;
            // 
            // lwyayinevi
            // 
            this.lwyayinevi.Text = "Yayınevi";
            this.lwyayinevi.Width = 80;
            // 
            // lwsayfas
            // 
            this.lwsayfas.Text = "Sayfa Sayısı";
            this.lwsayfas.Width = 80;
            // 
            // lwstoks
            // 
            this.lwstoks.Text = "Stok Sayısı";
            this.lwstoks.Width = 80;
            // 
            // lwbaski
            // 
            this.lwbaski.Text = "Baskı";
            this.lwbaski.Width = 76;
            // 
            // lwdil
            // 
            this.lwdil.Text = "Dil";
            this.lwdil.Width = 80;
            // 
            // lwtur
            // 
            this.lwtur.Text = "Tür";
            this.lwtur.Width = 80;
            // 
            // lwkategori
            // 
            this.lwkategori.Text = "Kategori";
            this.lwkategori.Width = 80;
            // 
            // lwteminbicim
            // 
            this.lwteminbicim.Text = "Temin Biçim";
            this.lwteminbicim.Width = 80;
            // 
            // lwdurum
            // 
            this.lwdurum.Text = "Durum";
            this.lwdurum.Width = 80;
            // 
            // lwciltdurum
            // 
            this.lwciltdurum.Text = "Cilt Durumu";
            this.lwciltdurum.Width = 80;
            // 
            // lwttarihi
            // 
            this.lwttarihi.Text = "Temin Tarihi";
            this.lwttarihi.Width = 80;
            // 
            // lwbtarihi
            // 
            this.lwbtarihi.Text = "Basım Tarihi";
            this.lwbtarihi.Width = 80;
            // 
            // lwokunmasayisi
            // 
            this.lwokunmasayisi.Text = "Okunma Sayısı";
            this.lwokunmasayisi.Width = 80;
            // 
            // lwaciklama
            // 
            this.lwaciklama.Text = "Açıklama";
            this.lwaciklama.Width = 80;
            // 
            // KitapArsivi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(808, 481);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbkategori);
            this.Controls.Add(this.cbturu);
            this.Controls.Add(this.cbdili);
            this.Controls.Add(this.tbyazar);
            this.Controls.Add(this.tbkitap);
            this.Controls.Add(this.tbisbn);
            this.Controls.Add(this.cbdurumu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbbarkodno);
            this.Controls.Add(this.label1);
            this.Name = "KitapArsivi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Arşivi";
            this.Load += new System.EventHandler(this.KitapArsivi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbbarkodno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbdurumu;
        private System.Windows.Forms.TextBox tbisbn;
        private System.Windows.Forms.TextBox tbkitap;
        private System.Windows.Forms.TextBox tbyazar;
        private System.Windows.Forms.ComboBox cbdili;
        private System.Windows.Forms.ComboBox cbturu;
        private System.Windows.Forms.ComboBox cbkategori;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lwkitapid;
        private System.Windows.Forms.ColumnHeader lwbarkod;
        private System.Windows.Forms.ColumnHeader lwisbn;
        private System.Windows.Forms.ColumnHeader lwkitapadi;
        private System.Windows.Forms.ColumnHeader lwyazaradi;
        private System.Windows.Forms.ColumnHeader lwcevirmen;
        private System.Windows.Forms.ColumnHeader lwyayinevi;
        private System.Windows.Forms.ColumnHeader lwsayfas;
        private System.Windows.Forms.ColumnHeader lwstoks;
        private System.Windows.Forms.ColumnHeader lwbaski;
        private System.Windows.Forms.ColumnHeader lwdil;
        private System.Windows.Forms.ColumnHeader lwtur;
        private System.Windows.Forms.ColumnHeader lwkategori;
        private System.Windows.Forms.ColumnHeader lwteminbicim;
        private System.Windows.Forms.ColumnHeader lwdurum;
        private System.Windows.Forms.ColumnHeader lwciltdurum;
        private System.Windows.Forms.ColumnHeader lwttarihi;
        private System.Windows.Forms.ColumnHeader lwbtarihi;
        private System.Windows.Forms.ColumnHeader lwokunmasayisi;
        private System.Windows.Forms.ColumnHeader lwaciklama;
    }
}