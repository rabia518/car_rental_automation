
namespace AracKiralamaOtomasyonu
{
    partial class form_Anasayfa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_MusteriKayit = new System.Windows.Forms.Button();
            this.button_MusteriListe = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Kiralama = new System.Windows.Forms.Button();
            this.button_Satislar = new System.Windows.Forms.Button();
            this.button_Cikis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_AracListe = new System.Windows.Forms.Button();
            this.button_AracKayit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_MusteriKayit);
            this.panel1.Controls.Add(this.button_MusteriListe);
            this.panel1.Location = new System.Drawing.Point(27, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 259);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_MusteriKayit
            // 
            this.button_MusteriKayit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_MusteriKayit.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_MusteriKayit.Location = new System.Drawing.Point(3, 27);
            this.button_MusteriKayit.Name = "button_MusteriKayit";
            this.button_MusteriKayit.Size = new System.Drawing.Size(142, 92);
            this.button_MusteriKayit.TabIndex = 2;
            this.button_MusteriKayit.Text = "Müşteri Kayıt";
            this.button_MusteriKayit.UseVisualStyleBackColor = true;
            this.button_MusteriKayit.Click += new System.EventHandler(this.button_MusteriKayit_Click);
            // 
            // button_MusteriListe
            // 
            this.button_MusteriListe.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_MusteriListe.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_MusteriListe.Location = new System.Drawing.Point(3, 140);
            this.button_MusteriListe.Name = "button_MusteriListe";
            this.button_MusteriListe.Size = new System.Drawing.Size(142, 88);
            this.button_MusteriListe.TabIndex = 3;
            this.button_MusteriListe.Text = "Müşteri Listesi";
            this.button_MusteriListe.UseVisualStyleBackColor = true;
            this.button_MusteriListe.Click += new System.EventHandler(this.button_MusteriListe_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(225, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(524, 37);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ARAÇ KİRALAMA OTOMASYONU";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_Kiralama
            // 
            this.button_Kiralama.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Kiralama.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_Kiralama.Location = new System.Drawing.Point(311, 594);
            this.button_Kiralama.Name = "button_Kiralama";
            this.button_Kiralama.Size = new System.Drawing.Size(143, 84);
            this.button_Kiralama.TabIndex = 7;
            this.button_Kiralama.Text = "Kiralama";
            this.button_Kiralama.UseVisualStyleBackColor = true;
            this.button_Kiralama.Click += new System.EventHandler(this.button_Kiralama_Click);
            // 
            // button_Satislar
            // 
            this.button_Satislar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Satislar.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_Satislar.Location = new System.Drawing.Point(479, 594);
            this.button_Satislar.Name = "button_Satislar";
            this.button_Satislar.Size = new System.Drawing.Size(137, 84);
            this.button_Satislar.TabIndex = 8;
            this.button_Satislar.Text = "Tüm Kiralama İşlemleri";
            this.button_Satislar.UseVisualStyleBackColor = true;
            this.button_Satislar.Click += new System.EventHandler(this.button_Satislar_Click);
            // 
            // button_Cikis
            // 
            this.button_Cikis.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Cikis.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_Cikis.Location = new System.Drawing.Point(822, 642);
            this.button_Cikis.Name = "button_Cikis";
            this.button_Cikis.Size = new System.Drawing.Size(73, 36);
            this.button_Cikis.TabIndex = 9;
            this.button_Cikis.Text = "ÇIKIŞ";
            this.button_Cikis.UseVisualStyleBackColor = true;
            this.button_Cikis.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_AracListe);
            this.panel2.Controls.Add(this.button_AracKayit);
            this.panel2.Location = new System.Drawing.Point(736, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 258);
            this.panel2.TabIndex = 10;
            // 
            // button_AracListe
            // 
            this.button_AracListe.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_AracListe.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_AracListe.Location = new System.Drawing.Point(20, 139);
            this.button_AracListe.Name = "button_AracListe";
            this.button_AracListe.Size = new System.Drawing.Size(139, 89);
            this.button_AracListe.TabIndex = 4;
            this.button_AracListe.Text = "Araç Listesi";
            this.button_AracListe.UseVisualStyleBackColor = true;
            this.button_AracListe.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button_AracKayit
            // 
            this.button_AracKayit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_AracKayit.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_AracKayit.Location = new System.Drawing.Point(20, 26);
            this.button_AracKayit.Name = "button_AracKayit";
            this.button_AracKayit.Size = new System.Drawing.Size(142, 92);
            this.button_AracKayit.TabIndex = 3;
            this.button_AracKayit.Text = "Araç Kayıt";
            this.button_AracKayit.UseVisualStyleBackColor = true;
            this.button_AracKayit.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // form_Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::AracKiralamaOtomasyonu.Properties.Resources.rent_a_car_otomasyonu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(929, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_Cikis);
            this.Controls.Add(this.button_Satislar);
            this.Controls.Add(this.button_Kiralama);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "form_Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kiralama Otomasyonu";
            this.Load += new System.EventHandler(this.form_Anasayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_MusteriKayit;
        private System.Windows.Forms.Button button_MusteriListe;
        private System.Windows.Forms.Button button_Kiralama;
        private System.Windows.Forms.Button button_Satislar;
        private System.Windows.Forms.Button button_Cikis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_AracListe;
        private System.Windows.Forms.Button button_AracKayit;
    }
}

