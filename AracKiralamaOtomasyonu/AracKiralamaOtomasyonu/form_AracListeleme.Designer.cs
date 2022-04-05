
namespace AracKiralamaOtomasyonu
{
    partial class form_AracListeleme
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
            this.comboBox_Araclar = new System.Windows.Forms.ComboBox();
            this.button_AracIptal = new System.Windows.Forms.Button();
            this.button_AracGuncelle = new System.Windows.Forms.Button();
            this.button_ResimDegistir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_KiraUcreti = new System.Windows.Forms.TextBox();
            this.comboBox_Yakit = new System.Windows.Forms.ComboBox();
            this.textBox_Km = new System.Windows.Forms.TextBox();
            this.textBox_Renk = new System.Windows.Forms.TextBox();
            this.textBox_Model = new System.Windows.Forms.TextBox();
            this.comboBox_SeriNo = new System.Windows.Forms.ComboBox();
            this.comboBox_Marka = new System.Windows.Forms.ComboBox();
            this.textBox_Plaka = new System.Windows.Forms.TextBox();
            this.button_AracSil = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboBox_Araclar
            // 
            this.comboBox_Araclar.FormattingEnabled = true;
            this.comboBox_Araclar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "Boş Araçlar"});
            this.comboBox_Araclar.Location = new System.Drawing.Point(1010, 7);
            this.comboBox_Araclar.Name = "comboBox_Araclar";
            this.comboBox_Araclar.Size = new System.Drawing.Size(156, 25);
            this.comboBox_Araclar.TabIndex = 1;
            this.comboBox_Araclar.SelectedIndexChanged += new System.EventHandler(this.comboBox_Araclar_SelectedIndexChanged);
            // 
            // button_AracIptal
            // 
            this.button_AracIptal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_AracIptal.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_AracIptal.Location = new System.Drawing.Point(1034, 459);
            this.button_AracIptal.Name = "button_AracIptal";
            this.button_AracIptal.Size = new System.Drawing.Size(133, 38);
            this.button_AracIptal.TabIndex = 39;
            this.button_AracIptal.Text = "İPTAL";
            this.button_AracIptal.UseVisualStyleBackColor = true;
            this.button_AracIptal.Click += new System.EventHandler(this.button_AracIptal_Click);
            // 
            // button_AracGuncelle
            // 
            this.button_AracGuncelle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_AracGuncelle.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_AracGuncelle.Location = new System.Drawing.Point(12, 459);
            this.button_AracGuncelle.Name = "button_AracGuncelle";
            this.button_AracGuncelle.Size = new System.Drawing.Size(133, 38);
            this.button_AracGuncelle.TabIndex = 38;
            this.button_AracGuncelle.Text = "GÜNCELLE";
            this.button_AracGuncelle.UseVisualStyleBackColor = true;
            this.button_AracGuncelle.Click += new System.EventHandler(this.button_AracGuncelle_Click);
            // 
            // button_ResimDegistir
            // 
            this.button_ResimDegistir.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ResimDegistir.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_ResimDegistir.Location = new System.Drawing.Point(678, 454);
            this.button_ResimDegistir.Name = "button_ResimDegistir";
            this.button_ResimDegistir.Size = new System.Drawing.Size(133, 38);
            this.button_ResimDegistir.TabIndex = 37;
            this.button_ResimDegistir.Text = "Resim Değiştir";
            this.button_ResimDegistir.UseVisualStyleBackColor = true;
            this.button_ResimDegistir.Click += new System.EventHandler(this.button_ResimEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(649, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(313, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "KİRA ÜCRETİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(313, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "YAKIT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(313, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "KM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(313, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "RENK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "MODEL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "SERİ NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "MARKA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "PLAKA";
            // 
            // textBox_KiraUcreti
            // 
            this.textBox_KiraUcreti.Location = new System.Drawing.Point(416, 405);
            this.textBox_KiraUcreti.Name = "textBox_KiraUcreti";
            this.textBox_KiraUcreti.Size = new System.Drawing.Size(173, 23);
            this.textBox_KiraUcreti.TabIndex = 27;
            // 
            // comboBox_Yakit
            // 
            this.comboBox_Yakit.FormattingEnabled = true;
            this.comboBox_Yakit.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "LPG"});
            this.comboBox_Yakit.Location = new System.Drawing.Point(416, 363);
            this.comboBox_Yakit.Name = "comboBox_Yakit";
            this.comboBox_Yakit.Size = new System.Drawing.Size(173, 25);
            this.comboBox_Yakit.TabIndex = 26;
            // 
            // textBox_Km
            // 
            this.textBox_Km.Location = new System.Drawing.Point(416, 323);
            this.textBox_Km.Name = "textBox_Km";
            this.textBox_Km.Size = new System.Drawing.Size(173, 23);
            this.textBox_Km.TabIndex = 25;
            // 
            // textBox_Renk
            // 
            this.textBox_Renk.Location = new System.Drawing.Point(416, 283);
            this.textBox_Renk.Name = "textBox_Renk";
            this.textBox_Renk.Size = new System.Drawing.Size(173, 23);
            this.textBox_Renk.TabIndex = 24;
            // 
            // textBox_Model
            // 
            this.textBox_Model.Location = new System.Drawing.Point(84, 410);
            this.textBox_Model.Name = "textBox_Model";
            this.textBox_Model.Size = new System.Drawing.Size(173, 23);
            this.textBox_Model.TabIndex = 23;
            // 
            // comboBox_SeriNo
            // 
            this.comboBox_SeriNo.FormattingEnabled = true;
            this.comboBox_SeriNo.Location = new System.Drawing.Point(84, 367);
            this.comboBox_SeriNo.Name = "comboBox_SeriNo";
            this.comboBox_SeriNo.Size = new System.Drawing.Size(173, 25);
            this.comboBox_SeriNo.TabIndex = 22;
            // 
            // comboBox_Marka
            // 
            this.comboBox_Marka.FormattingEnabled = true;
            this.comboBox_Marka.Items.AddRange(new object[] {
            "Hyundai",
            "Opel",
            "Renault",
            "Peugeot"});
            this.comboBox_Marka.Location = new System.Drawing.Point(84, 324);
            this.comboBox_Marka.Name = "comboBox_Marka";
            this.comboBox_Marka.Size = new System.Drawing.Size(173, 25);
            this.comboBox_Marka.TabIndex = 21;
            this.comboBox_Marka.SelectedIndexChanged += new System.EventHandler(this.comboBox_Marka_SelectedIndexChanged);
            // 
            // textBox_Plaka
            // 
            this.textBox_Plaka.Location = new System.Drawing.Point(84, 283);
            this.textBox_Plaka.Name = "textBox_Plaka";
            this.textBox_Plaka.Size = new System.Drawing.Size(173, 23);
            this.textBox_Plaka.TabIndex = 20;
            // 
            // button_AracSil
            // 
            this.button_AracSil.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_AracSil.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_AracSil.Location = new System.Drawing.Point(1033, 280);
            this.button_AracSil.Name = "button_AracSil";
            this.button_AracSil.Size = new System.Drawing.Size(133, 31);
            this.button_AracSil.TabIndex = 40;
            this.button_AracSil.Text = "SİL";
            this.button_AracSil.UseVisualStyleBackColor = true;
            this.button_AracSil.Click += new System.EventHandler(this.button_AracSil_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(915, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 41;
            this.label9.Text = "Araç Listesi";
            // 
            // form_AracListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1179, 509);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_AracSil);
            this.Controls.Add(this.button_AracIptal);
            this.Controls.Add(this.button_AracGuncelle);
            this.Controls.Add(this.button_ResimDegistir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_KiraUcreti);
            this.Controls.Add(this.comboBox_Yakit);
            this.Controls.Add(this.textBox_Km);
            this.Controls.Add(this.textBox_Renk);
            this.Controls.Add(this.textBox_Model);
            this.Controls.Add(this.comboBox_SeriNo);
            this.Controls.Add(this.comboBox_Marka);
            this.Controls.Add(this.textBox_Plaka);
            this.Controls.Add(this.comboBox_Araclar);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "form_AracListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Listeleme Sayfası";
            this.Load += new System.EventHandler(this.form_AracListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_Araclar;
        private System.Windows.Forms.Button button_AracIptal;
        private System.Windows.Forms.Button button_AracGuncelle;
        private System.Windows.Forms.Button button_ResimDegistir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_KiraUcreti;
        private System.Windows.Forms.ComboBox comboBox_Yakit;
        private System.Windows.Forms.TextBox textBox_Km;
        private System.Windows.Forms.TextBox textBox_Renk;
        private System.Windows.Forms.TextBox textBox_Model;
        private System.Windows.Forms.ComboBox comboBox_SeriNo;
        private System.Windows.Forms.ComboBox comboBox_Marka;
        private System.Windows.Forms.TextBox textBox_Plaka;
        private System.Windows.Forms.Button button_AracSil;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label9;
    }
}