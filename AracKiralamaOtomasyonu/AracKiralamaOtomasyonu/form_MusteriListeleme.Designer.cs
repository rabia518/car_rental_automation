
namespace AracKiralamaOtomasyonu
{
    partial class form_MusteriListeleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_MusteriIptal = new System.Windows.Forms.Button();
            this.button_MusteriListele = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_Adres = new System.Windows.Forms.TextBox();
            this.textBox_Telefon = new System.Windows.Forms.TextBox();
            this.textBox_AdSoyad = new System.Windows.Forms.TextBox();
            this.textBox_TC = new System.Windows.Forms.TextBox();
            this.button_MusteriSil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button_MusteriIptal
            // 
            this.button_MusteriIptal.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_MusteriIptal.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_MusteriIptal.Location = new System.Drawing.Point(963, 325);
            this.button_MusteriIptal.Name = "button_MusteriIptal";
            this.button_MusteriIptal.Size = new System.Drawing.Size(101, 32);
            this.button_MusteriIptal.TabIndex = 24;
            this.button_MusteriIptal.Text = "İPTAL";
            this.button_MusteriIptal.UseVisualStyleBackColor = true;
            this.button_MusteriIptal.Click += new System.EventHandler(this.button_MusteriIptal_Click);
            // 
            // button_MusteriListele
            // 
            this.button_MusteriListele.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_MusteriListele.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_MusteriListele.Location = new System.Drawing.Point(967, 199);
            this.button_MusteriListele.Name = "button_MusteriListele";
            this.button_MusteriListele.Size = new System.Drawing.Size(101, 32);
            this.button_MusteriListele.TabIndex = 23;
            this.button_MusteriListele.Text = "GÜNCELLE";
            this.button_MusteriListele.UseVisualStyleBackColor = true;
            this.button_MusteriListele.Click += new System.EventHandler(this.button_MusteriEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(766, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(766, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(766, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(766, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(766, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "TC Kimlik Numarası";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Email.Location = new System.Drawing.Point(923, 170);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(145, 23);
            this.textBox_Email.TabIndex = 17;
            // 
            // textBox_Adres
            // 
            this.textBox_Adres.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Adres.Location = new System.Drawing.Point(923, 132);
            this.textBox_Adres.Name = "textBox_Adres";
            this.textBox_Adres.Size = new System.Drawing.Size(145, 23);
            this.textBox_Adres.TabIndex = 16;
            // 
            // textBox_Telefon
            // 
            this.textBox_Telefon.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Telefon.Location = new System.Drawing.Point(923, 94);
            this.textBox_Telefon.Name = "textBox_Telefon";
            this.textBox_Telefon.Size = new System.Drawing.Size(145, 23);
            this.textBox_Telefon.TabIndex = 15;
            // 
            // textBox_AdSoyad
            // 
            this.textBox_AdSoyad.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_AdSoyad.Location = new System.Drawing.Point(923, 56);
            this.textBox_AdSoyad.Name = "textBox_AdSoyad";
            this.textBox_AdSoyad.Size = new System.Drawing.Size(145, 23);
            this.textBox_AdSoyad.TabIndex = 14;
            // 
            // textBox_TC
            // 
            this.textBox_TC.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_TC.Location = new System.Drawing.Point(923, 18);
            this.textBox_TC.Name = "textBox_TC";
            this.textBox_TC.Size = new System.Drawing.Size(145, 23);
            this.textBox_TC.TabIndex = 13;
            // 
            // button_MusteriSil
            // 
            this.button_MusteriSil.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_MusteriSil.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_MusteriSil.Location = new System.Drawing.Point(963, 271);
            this.button_MusteriSil.Name = "button_MusteriSil";
            this.button_MusteriSil.Size = new System.Drawing.Size(101, 32);
            this.button_MusteriSil.TabIndex = 25;
            this.button_MusteriSil.Text = "SİL";
            this.button_MusteriSil.UseVisualStyleBackColor = true;
            this.button_MusteriSil.Click += new System.EventHandler(this.button_MusteriSil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(766, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "TC Kimlik Numarasına Göre Arama";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(767, 276);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 23);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // form_MusteriListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1080, 369);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_MusteriSil);
            this.Controls.Add(this.button_MusteriIptal);
            this.Controls.Add(this.button_MusteriListele);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_Adres);
            this.Controls.Add(this.textBox_Telefon);
            this.Controls.Add(this.textBox_AdSoyad);
            this.Controls.Add(this.textBox_TC);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_MusteriListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musteri Listeleme Sayfası";
            this.Load += new System.EventHandler(this.form_MusteriListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_MusteriIptal;
        private System.Windows.Forms.Button button_MusteriListele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_Adres;
        private System.Windows.Forms.TextBox textBox_Telefon;
        private System.Windows.Forms.TextBox textBox_AdSoyad;
        private System.Windows.Forms.TextBox textBox_TC;
        private System.Windows.Forms.Button button_MusteriSil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}