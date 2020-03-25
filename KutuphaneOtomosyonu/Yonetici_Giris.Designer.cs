namespace KutuphaneOtomosyonu
{
    partial class Yonetici_Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetici_Giris));
            this.btnyoneticigiris = new System.Windows.Forms.Button();
            this.tbyoneticisifre = new System.Windows.Forms.TextBox();
            this.tbyoneticiid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnyoneticigiris
            // 
            this.btnyoneticigiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnyoneticigiris.Location = new System.Drawing.Point(413, 197);
            this.btnyoneticigiris.Name = "btnyoneticigiris";
            this.btnyoneticigiris.Size = new System.Drawing.Size(75, 33);
            this.btnyoneticigiris.TabIndex = 24;
            this.btnyoneticigiris.Text = "Giriş";
            this.btnyoneticigiris.UseVisualStyleBackColor = true;
            this.btnyoneticigiris.Click += new System.EventHandler(this.btnyoneticigiris_Click);
            // 
            // tbyoneticisifre
            // 
            this.tbyoneticisifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbyoneticisifre.Location = new System.Drawing.Point(336, 159);
            this.tbyoneticisifre.Multiline = true;
            this.tbyoneticisifre.Name = "tbyoneticisifre";
            this.tbyoneticisifre.PasswordChar = '*';
            this.tbyoneticisifre.ReadOnly = true;
            this.tbyoneticisifre.Size = new System.Drawing.Size(152, 32);
            this.tbyoneticisifre.TabIndex = 23;
            // 
            // tbyoneticiid
            // 
            this.tbyoneticiid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbyoneticiid.Location = new System.Drawing.Point(336, 121);
            this.tbyoneticiid.Multiline = true;
            this.tbyoneticiid.Name = "tbyoneticiid";
            this.tbyoneticiid.Size = new System.Drawing.Size(152, 32);
            this.tbyoneticiid.TabIndex = 22;
            this.tbyoneticiid.TextChanged += new System.EventHandler(this.tbyoneticiid_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(188, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Yönetici Numarası:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(111, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 161);
            this.panel1.TabIndex = 25;
            // 
            // Yonetici_Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 386);
            this.Controls.Add(this.btnyoneticigiris);
            this.Controls.Add(this.tbyoneticisifre);
            this.Controls.Add(this.tbyoneticiid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Yonetici_Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Giriş";
            this.Load += new System.EventHandler(this.Yonetici_Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnyoneticigiris;
        private System.Windows.Forms.TextBox tbyoneticisifre;
        private System.Windows.Forms.TextBox tbyoneticiid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}