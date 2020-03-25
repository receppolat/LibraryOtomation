namespace KutuphaneOtomosyonu
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.btngiris = new System.Windows.Forms.Button();
            this.tbsifre = new System.Windows.Forms.TextBox();
            this.tbpersonelid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnyonetici = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btngiris
            // 
            this.btngiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.Location = new System.Drawing.Point(406, 196);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(75, 33);
            this.btngiris.TabIndex = 12;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // tbsifre
            // 
            this.tbsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbsifre.Location = new System.Drawing.Point(329, 158);
            this.tbsifre.Multiline = true;
            this.tbsifre.Name = "tbsifre";
            this.tbsifre.PasswordChar = '*';
            this.tbsifre.Size = new System.Drawing.Size(152, 32);
            this.tbsifre.TabIndex = 11;
            // 
            // tbpersonelid
            // 
            this.tbpersonelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbpersonelid.Location = new System.Drawing.Point(329, 120);
            this.tbpersonelid.Multiline = true;
            this.tbpersonelid.Name = "tbpersonelid";
            this.tbpersonelid.Size = new System.Drawing.Size(152, 32);
            this.tbpersonelid.TabIndex = 10;
            this.tbpersonelid.TextChanged += new System.EventHandler(this.tbpersonelid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(173, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Personel Numarası:";
            // 
            // btnyonetici
            // 
            this.btnyonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyonetici.Location = new System.Drawing.Point(586, 334);
            this.btnyonetici.Name = "btnyonetici";
            this.btnyonetici.Size = new System.Drawing.Size(128, 40);
            this.btnyonetici.TabIndex = 14;
            this.btnyonetici.Text = "Yönetici Girişi";
            this.btnyonetici.UseVisualStyleBackColor = true;
            this.btnyonetici.Click += new System.EventHandler(this.btnyonetici_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(124, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 161);
            this.panel1.TabIndex = 26;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 386);
            this.Controls.Add(this.btnyonetici);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.tbsifre);
            this.Controls.Add(this.tbpersonelid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.TextBox tbsifre;
        private System.Windows.Forms.TextBox tbpersonelid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnyonetici;
        private System.Windows.Forms.Panel panel1;
    }
}