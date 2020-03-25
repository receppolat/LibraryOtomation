namespace KutuphaneOtomosyonu
{
    partial class PersonelArsiv
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpersonelid = new System.Windows.Forms.MaskedTextBox();
            this.tbtc = new System.Windows.Forms.MaskedTextBox();
            this.tbpasaportkimlik = new System.Windows.Forms.MaskedTextBox();
            this.tbadi = new System.Windows.Forms.TextBox();
            this.tbsoyadi = new System.Windows.Forms.TextBox();
            this.yabancimi = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lwpersonelid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwtckimlik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lwpasaportkimlik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik Numarası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyadı:";
            // 
            // tbpersonelid
            // 
            this.tbpersonelid.Location = new System.Drawing.Point(347, 19);
            this.tbpersonelid.Mask = "000000";
            this.tbpersonelid.Name = "tbpersonelid";
            this.tbpersonelid.PromptChar = ' ';
            this.tbpersonelid.Size = new System.Drawing.Size(80, 20);
            this.tbpersonelid.TabIndex = 4;
            this.tbpersonelid.TextChanged += new System.EventHandler(this.tbpersonelid_TextChanged);
            // 
            // tbtc
            // 
            this.tbtc.Location = new System.Drawing.Point(132, 19);
            this.tbtc.Mask = "00000000000";
            this.tbtc.Name = "tbtc";
            this.tbtc.PromptChar = ' ';
            this.tbtc.Size = new System.Drawing.Size(112, 20);
            this.tbtc.TabIndex = 5;
            this.tbtc.TextChanged += new System.EventHandler(this.tbtc_TextChanged);
            // 
            // tbpasaportkimlik
            // 
            this.tbpasaportkimlik.Location = new System.Drawing.Point(132, 19);
            this.tbpasaportkimlik.Mask = "00000000000";
            this.tbpasaportkimlik.Name = "tbpasaportkimlik";
            this.tbpasaportkimlik.PromptChar = ' ';
            this.tbpasaportkimlik.Size = new System.Drawing.Size(112, 20);
            this.tbpasaportkimlik.TabIndex = 6;
            this.tbpasaportkimlik.TextChanged += new System.EventHandler(this.tbpasaportkimlik_TextChanged);
            // 
            // tbadi
            // 
            this.tbadi.Location = new System.Drawing.Point(496, 19);
            this.tbadi.Name = "tbadi";
            this.tbadi.Size = new System.Drawing.Size(100, 20);
            this.tbadi.TabIndex = 7;
            this.tbadi.TextChanged += new System.EventHandler(this.tbadi_TextChanged);
            // 
            // tbsoyadi
            // 
            this.tbsoyadi.Location = new System.Drawing.Point(678, 19);
            this.tbsoyadi.Name = "tbsoyadi";
            this.tbsoyadi.Size = new System.Drawing.Size(100, 20);
            this.tbsoyadi.TabIndex = 8;
            this.tbsoyadi.TextChanged += new System.EventHandler(this.tbsoyadi_TextChanged);
            // 
            // yabancimi
            // 
            this.yabancimi.AutoSize = true;
            this.yabancimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yabancimi.Location = new System.Drawing.Point(132, 36);
            this.yabancimi.Name = "yabancimi";
            this.yabancimi.Size = new System.Drawing.Size(112, 17);
            this.yabancimi.TabIndex = 9;
            this.yabancimi.Text = "Yabancı Vatandaş";
            this.yabancimi.UseVisualStyleBackColor = true;
            this.yabancimi.CheckedChanged += new System.EventHandler(this.yabancimi_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lwpersonelid,
            this.columnHeader18,
            this.lwtckimlik,
            this.lwpasaportkimlik,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader19,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.listView1.Location = new System.Drawing.Point(12, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 379);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lwpersonelid
            // 
            this.lwpersonelid.Text = "Personel ID";
            this.lwpersonelid.Width = 70;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Şifre";
            // 
            // lwtckimlik
            // 
            this.lwtckimlik.Text = "TC Kimlik Numarası";
            this.lwtckimlik.Width = 80;
            // 
            // lwpasaportkimlik
            // 
            this.lwpasaportkimlik.Text = "Pasaport Numarası";
            this.lwpasaportkimlik.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adı";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Soyadı";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cinsiyet";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Doğum Tarihi";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Kayıt Tarihi";
            this.columnHeader19.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mail";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Telefon";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Adres";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Görevi";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "1.Güvenlik Sorusu";
            this.columnHeader12.Width = 80;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "2.Güvenlik Sorusu";
            this.columnHeader13.Width = 80;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "3.Güvenlik Sorusu";
            this.columnHeader14.Width = 80;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "1.Cevap";
            this.columnHeader15.Width = 80;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "2.Cevap";
            this.columnHeader16.Width = 80;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "3.Cevap";
            this.columnHeader17.Width = 80;
            // 
            // PersonelArsiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.yabancimi);
            this.Controls.Add(this.tbsoyadi);
            this.Controls.Add(this.tbadi);
            this.Controls.Add(this.tbtc);
            this.Controls.Add(this.tbpersonelid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbpasaportkimlik);
            this.Name = "PersonelArsiv";
            this.Text = "Personel Arşiv";
            this.Load += new System.EventHandler(this.PersonelArsiv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tbpersonelid;
        private System.Windows.Forms.MaskedTextBox tbtc;
        private System.Windows.Forms.MaskedTextBox tbpasaportkimlik;
        private System.Windows.Forms.TextBox tbadi;
        private System.Windows.Forms.TextBox tbsoyadi;
        private System.Windows.Forms.CheckBox yabancimi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lwpersonelid;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader lwtckimlik;
        private System.Windows.Forms.ColumnHeader lwpasaportkimlik;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader19;
    }
}