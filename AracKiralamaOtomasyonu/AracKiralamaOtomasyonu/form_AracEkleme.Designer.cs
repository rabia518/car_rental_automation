
namespace AracKiralamaOtomasyonu
{
    partial class form_AracEkleme
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
            this.textBox_Plaka = new System.Windows.Forms.TextBox();
            this.comboBox_Marka = new System.Windows.Forms.ComboBox();
            this.comboBox_SeriNo = new System.Windows.Forms.ComboBox();
            this.textBox_Model = new System.Windows.Forms.TextBox();
            this.textBox_Renk = new System.Windows.Forms.TextBox();
            this.textBox_Km = new System.Windows.Forms.TextBox();
            this.comboBox_Yakit = new System.Windows.Forms.ComboBox();
            this.textBox_KiraUcreti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_ResimEkle = new System.Windows.Forms.Button();
            this.button_AracEkleme = new System.Windows.Forms.Button();
            this.button_AracIptal = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Plaka
            // 
            this.textBox_Plaka.Location = new System.Drawing.Point(120, 17);
            this.textBox_Plaka.Name = "textBox_Plaka";
            this.textBox_Plaka.Size = new System.Drawing.Size(173, 23);
            this.textBox_Plaka.TabIndex = 0;
            // 
            // comboBox_Marka
            // 
            this.comboBox_Marka.FormattingEnabled = true;
            this.comboBox_Marka.Items.AddRange(new object[] {
            "Hyundai",
            "Opel",
            "Renault",
            "Peugeot"});
            this.comboBox_Marka.Location = new System.Drawing.Point(120, 46);
            this.comboBox_Marka.Name = "comboBox_Marka";
            this.comboBox_Marka.Size = new System.Drawing.Size(173, 25);
            this.comboBox_Marka.TabIndex = 1;
            this.comboBox_Marka.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox_SeriNo
            // 
            this.comboBox_SeriNo.FormattingEnabled = true;
            this.comboBox_SeriNo.Location = new System.Drawing.Point(120, 77);
            this.comboBox_SeriNo.Name = "comboBox_SeriNo";
            this.comboBox_SeriNo.Size = new System.Drawing.Size(173, 25);
            this.comboBox_SeriNo.TabIndex = 2;
            // 
            // textBox_Model
            // 
            this.textBox_Model.Location = new System.Drawing.Point(120, 108);
            this.textBox_Model.Name = "textBox_Model";
            this.textBox_Model.Size = new System.Drawing.Size(173, 23);
            this.textBox_Model.TabIndex = 3;
            // 
            // textBox_Renk
            // 
            this.textBox_Renk.Location = new System.Drawing.Point(120, 138);
            this.textBox_Renk.Name = "textBox_Renk";
            this.textBox_Renk.Size = new System.Drawing.Size(173, 23);
            this.textBox_Renk.TabIndex = 4;
            // 
            // textBox_Km
            // 
            this.textBox_Km.Location = new System.Drawing.Point(120, 167);
            this.textBox_Km.Name = "textBox_Km";
            this.textBox_Km.Size = new System.Drawing.Size(173, 23);
            this.textBox_Km.TabIndex = 5;
            // 
            // comboBox_Yakit
            // 
            this.comboBox_Yakit.FormattingEnabled = true;
            this.comboBox_Yakit.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "LPG"});
            this.comboBox_Yakit.Location = new System.Drawing.Point(120, 196);
            this.comboBox_Yakit.Name = "comboBox_Yakit";
            this.comboBox_Yakit.Size = new System.Drawing.Size(173, 25);
            this.comboBox_Yakit.TabIndex = 6;
            // 
            // textBox_KiraUcreti
            // 
            this.textBox_KiraUcreti.Location = new System.Drawing.Point(120, 227);
            this.textBox_KiraUcreti.Name = "textBox_KiraUcreti";
            this.textBox_KiraUcreti.Size = new System.Drawing.Size(173, 23);
            this.textBox_KiraUcreti.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "PLAKA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "MARKA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "SERİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "MODEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "RENK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "KM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(20, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "YAKIT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "KİRA ÜCRETİ";
            // 
            // button_ResimEkle
            // 
            this.button_ResimEkle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ResimEkle.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_ResimEkle.Location = new System.Drawing.Point(347, 176);
            this.button_ResimEkle.Name = "button_ResimEkle";
            this.button_ResimEkle.Size = new System.Drawing.Size(133, 44);
            this.button_ResimEkle.TabIndex = 17;
            this.button_ResimEkle.Text = "Resim Ekle";
            this.button_ResimEkle.UseVisualStyleBackColor = true;
            this.button_ResimEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_AracEkleme
            // 
            this.button_AracEkleme.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_AracEkleme.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_AracEkleme.Location = new System.Drawing.Point(60, 267);
            this.button_AracEkleme.Name = "button_AracEkleme";
            this.button_AracEkleme.Size = new System.Drawing.Size(133, 44);
            this.button_AracEkleme.TabIndex = 18;
            this.button_AracEkleme.Text = "KAYIT";
            this.button_AracEkleme.UseVisualStyleBackColor = true;
            this.button_AracEkleme.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_AracIptal
            // 
            this.button_AracIptal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_AracIptal.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_AracIptal.Location = new System.Drawing.Point(377, 267);
            this.button_AracIptal.Name = "button_AracIptal";
            this.button_AracIptal.Size = new System.Drawing.Size(133, 44);
            this.button_AracIptal.TabIndex = 19;
            this.button_AracIptal.Text = "İPTAL";
            this.button_AracIptal.UseVisualStyleBackColor = true;
            this.button_AracIptal.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(315, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // form_AracEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(522, 323);
            this.Controls.Add(this.button_AracIptal);
            this.Controls.Add(this.button_AracEkleme);
            this.Controls.Add(this.button_ResimEkle);
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
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "form_AracEkleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arac Kayıt Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Plaka;
        private System.Windows.Forms.ComboBox comboBox_Marka;
        private System.Windows.Forms.ComboBox comboBox_SeriNo;
        private System.Windows.Forms.TextBox textBox_Model;
        private System.Windows.Forms.TextBox textBox_Renk;
        private System.Windows.Forms.TextBox textBox_Km;
        private System.Windows.Forms.ComboBox comboBox_Yakit;
        private System.Windows.Forms.TextBox textBox_KiraUcreti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_ResimEkle;
        private System.Windows.Forms.Button button_AracEkleme;
        private System.Windows.Forms.Button button_AracIptal;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}