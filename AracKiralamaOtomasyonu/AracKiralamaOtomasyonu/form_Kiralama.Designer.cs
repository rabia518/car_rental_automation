
namespace AracKiralamaOtomasyonu
{
    partial class form_Kiralama
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_EhliyetAlısYeri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_EhliyetAlısTarihi = new System.Windows.Forms.TextBox();
            this.textBox_EhliyetNo = new System.Windows.Forms.TextBox();
            this.textBox_Telefon = new System.Windows.Forms.TextBox();
            this.textBox_AdSoyad = new System.Windows.Forms.TextBox();
            this.textBox_TC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.button_Hesapla = new System.Windows.Forms.Button();
            this.button_KiraGüncelle = new System.Windows.Forms.Button();
            this.button_KiraEkle = new System.Windows.Forms.Button();
            this.date_alis = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.date_verilis = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_tutar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_gun = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_kiraSekli = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_kiraUcreti = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_renk = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_seri = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_araclar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_marka = new System.Windows.Forms.TextBox();
            this.button_AracTeslim = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_TCyeGoreAra = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_Ekstra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(412, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1018, 637);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_EhliyetAlısYeri);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_EhliyetAlısTarihi);
            this.groupBox2.Controls.Add(this.textBox_EhliyetNo);
            this.groupBox2.Controls.Add(this.textBox_Telefon);
            this.groupBox2.Controls.Add(this.textBox_AdSoyad);
            this.groupBox2.Controls.Add(this.textBox_TC);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(8, 470);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 214);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgisi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ehliyet Alış Yeri";
            // 
            // textBox_EhliyetAlısYeri
            // 
            this.textBox_EhliyetAlısYeri.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_EhliyetAlısYeri.Location = new System.Drawing.Point(157, 182);
            this.textBox_EhliyetAlısYeri.Name = "textBox_EhliyetAlısYeri";
            this.textBox_EhliyetAlısYeri.Size = new System.Drawing.Size(231, 23);
            this.textBox_EhliyetAlısYeri.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ehliyet Alış Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ehliyet Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "TC Kimlik Numarası";
            // 
            // textBox_EhliyetAlısTarihi
            // 
            this.textBox_EhliyetAlısTarihi.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_EhliyetAlısTarihi.Location = new System.Drawing.Point(157, 150);
            this.textBox_EhliyetAlısTarihi.Name = "textBox_EhliyetAlısTarihi";
            this.textBox_EhliyetAlısTarihi.Size = new System.Drawing.Size(231, 23);
            this.textBox_EhliyetAlısTarihi.TabIndex = 15;
            // 
            // textBox_EhliyetNo
            // 
            this.textBox_EhliyetNo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_EhliyetNo.Location = new System.Drawing.Point(157, 118);
            this.textBox_EhliyetNo.Name = "textBox_EhliyetNo";
            this.textBox_EhliyetNo.Size = new System.Drawing.Size(231, 23);
            this.textBox_EhliyetNo.TabIndex = 14;
            // 
            // textBox_Telefon
            // 
            this.textBox_Telefon.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Telefon.Location = new System.Drawing.Point(157, 86);
            this.textBox_Telefon.Name = "textBox_Telefon";
            this.textBox_Telefon.Size = new System.Drawing.Size(231, 23);
            this.textBox_Telefon.TabIndex = 13;
            // 
            // textBox_AdSoyad
            // 
            this.textBox_AdSoyad.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_AdSoyad.Location = new System.Drawing.Point(157, 54);
            this.textBox_AdSoyad.Name = "textBox_AdSoyad";
            this.textBox_AdSoyad.Size = new System.Drawing.Size(231, 23);
            this.textBox_AdSoyad.TabIndex = 12;
            // 
            // textBox_TC
            // 
            this.textBox_TC.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_TC.Location = new System.Drawing.Point(157, 22);
            this.textBox_TC.Name = "textBox_TC";
            this.textBox_TC.Size = new System.Drawing.Size(231, 23);
            this.textBox_TC.TabIndex = 11;
            this.textBox_TC.TextChanged += new System.EventHandler(this.textBox_TC_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Temizle);
            this.groupBox1.Controls.Add(this.button_Hesapla);
            this.groupBox1.Controls.Add(this.button_KiraGüncelle);
            this.groupBox1.Controls.Add(this.button_KiraEkle);
            this.groupBox1.Controls.Add(this.date_alis);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.date_verilis);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox_tutar);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.textBox_gun);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.comboBox_kiraSekli);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox_kiraUcreti);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_renk);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_model);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_seri);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox_araclar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_marka);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 424);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgisi";
            // 
            // button_Temizle
            // 
            this.button_Temizle.BackColor = System.Drawing.Color.White;
            this.button_Temizle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Temizle.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_Temizle.Location = new System.Drawing.Point(6, 389);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(147, 29);
            this.button_Temizle.TabIndex = 42;
            this.button_Temizle.Text = "Temizle";
            this.button_Temizle.UseVisualStyleBackColor = false;
            this.button_Temizle.Click += new System.EventHandler(this.button_Temizle_Click);
            // 
            // button_Hesapla
            // 
            this.button_Hesapla.BackColor = System.Drawing.Color.White;
            this.button_Hesapla.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Hesapla.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_Hesapla.Location = new System.Drawing.Point(6, 355);
            this.button_Hesapla.Name = "button_Hesapla";
            this.button_Hesapla.Size = new System.Drawing.Size(147, 29);
            this.button_Hesapla.TabIndex = 41;
            this.button_Hesapla.Text = "Hesapla";
            this.button_Hesapla.UseVisualStyleBackColor = false;
            this.button_Hesapla.Click += new System.EventHandler(this.button_Hesapla_Click);
            // 
            // button_KiraGüncelle
            // 
            this.button_KiraGüncelle.BackColor = System.Drawing.Color.White;
            this.button_KiraGüncelle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_KiraGüncelle.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_KiraGüncelle.Location = new System.Drawing.Point(240, 390);
            this.button_KiraGüncelle.Name = "button_KiraGüncelle";
            this.button_KiraGüncelle.Size = new System.Drawing.Size(148, 29);
            this.button_KiraGüncelle.TabIndex = 40;
            this.button_KiraGüncelle.Text = "Sözleşme Güncelle";
            this.button_KiraGüncelle.UseVisualStyleBackColor = false;
            this.button_KiraGüncelle.Click += new System.EventHandler(this.button_KiraGüncelle_Click);
            // 
            // button_KiraEkle
            // 
            this.button_KiraEkle.BackColor = System.Drawing.Color.White;
            this.button_KiraEkle.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_KiraEkle.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_KiraEkle.Location = new System.Drawing.Point(239, 355);
            this.button_KiraEkle.Name = "button_KiraEkle";
            this.button_KiraEkle.Size = new System.Drawing.Size(147, 29);
            this.button_KiraEkle.TabIndex = 39;
            this.button_KiraEkle.Text = "Sözleşme Ekle";
            this.button_KiraEkle.UseVisualStyleBackColor = false;
            this.button_KiraEkle.Click += new System.EventHandler(this.button_KiraEkle_Click);
            // 
            // date_alis
            // 
            this.date_alis.Location = new System.Drawing.Point(156, 320);
            this.date_alis.Name = "date_alis";
            this.date_alis.Size = new System.Drawing.Size(230, 23);
            this.date_alis.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(9, 322);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 18);
            this.label17.TabIndex = 37;
            this.label17.Text = "Alış Tarihi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(9, 294);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 18);
            this.label16.TabIndex = 36;
            this.label16.Text = "Veriliş Tarihi";
            // 
            // date_verilis
            // 
            this.date_verilis.Location = new System.Drawing.Point(156, 292);
            this.date_verilis.Name = "date_verilis";
            this.date_verilis.Size = new System.Drawing.Size(230, 23);
            this.date_verilis.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(9, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 18);
            this.label12.TabIndex = 34;
            this.label12.Text = "Tutar";
            // 
            // textBox_tutar
            // 
            this.textBox_tutar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_tutar.Location = new System.Drawing.Point(156, 264);
            this.textBox_tutar.Name = "textBox_tutar";
            this.textBox_tutar.Size = new System.Drawing.Size(230, 23);
            this.textBox_tutar.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(9, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 18);
            this.label13.TabIndex = 32;
            this.label13.Text = "Gün";
            // 
            // textBox_gun
            // 
            this.textBox_gun.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_gun.Location = new System.Drawing.Point(156, 234);
            this.textBox_gun.Name = "textBox_gun";
            this.textBox_gun.Size = new System.Drawing.Size(230, 23);
            this.textBox_gun.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(9, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 18);
            this.label14.TabIndex = 30;
            this.label14.Text = "Kira Ücreti";
            // 
            // comboBox_kiraSekli
            // 
            this.comboBox_kiraSekli.FormattingEnabled = true;
            this.comboBox_kiraSekli.Items.AddRange(new object[] {
            "Günlük",
            "Haftalık"});
            this.comboBox_kiraSekli.Location = new System.Drawing.Point(157, 174);
            this.comboBox_kiraSekli.Name = "comboBox_kiraSekli";
            this.comboBox_kiraSekli.Size = new System.Drawing.Size(230, 25);
            this.comboBox_kiraSekli.TabIndex = 29;
            this.comboBox_kiraSekli.SelectedIndexChanged += new System.EventHandler(this.comboBox_kiraSekli_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(9, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 18);
            this.label15.TabIndex = 28;
            this.label15.Text = "Kira Şekli";
            // 
            // textBox_kiraUcreti
            // 
            this.textBox_kiraUcreti.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kiraUcreti.Location = new System.Drawing.Point(156, 205);
            this.textBox_kiraUcreti.Name = "textBox_kiraUcreti";
            this.textBox_kiraUcreti.Size = new System.Drawing.Size(230, 23);
            this.textBox_kiraUcreti.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(9, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "Renk";
            // 
            // textBox_renk
            // 
            this.textBox_renk.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_renk.Location = new System.Drawing.Point(156, 144);
            this.textBox_renk.Name = "textBox_renk";
            this.textBox_renk.Size = new System.Drawing.Size(230, 23);
            this.textBox_renk.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(9, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Model";
            // 
            // textBox_model
            // 
            this.textBox_model.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_model.Location = new System.Drawing.Point(156, 113);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.Size = new System.Drawing.Size(230, 23);
            this.textBox_model.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(9, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Seri";
            // 
            // textBox_seri
            // 
            this.textBox_seri.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_seri.Location = new System.Drawing.Point(156, 83);
            this.textBox_seri.Name = "textBox_seri";
            this.textBox_seri.Size = new System.Drawing.Size(230, 23);
            this.textBox_seri.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(9, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Marka";
            // 
            // comboBox_araclar
            // 
            this.comboBox_araclar.FormattingEnabled = true;
            this.comboBox_araclar.Location = new System.Drawing.Point(157, 23);
            this.comboBox_araclar.Name = "comboBox_araclar";
            this.comboBox_araclar.Size = new System.Drawing.Size(230, 25);
            this.comboBox_araclar.TabIndex = 19;
            this.comboBox_araclar.SelectedIndexChanged += new System.EventHandler(this.comboBox_araclar_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Araç";
            // 
            // textBox_marka
            // 
            this.textBox_marka.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_marka.Location = new System.Drawing.Point(156, 54);
            this.textBox_marka.Name = "textBox_marka";
            this.textBox_marka.Size = new System.Drawing.Size(230, 23);
            this.textBox_marka.TabIndex = 17;
            // 
            // button_AracTeslim
            // 
            this.button_AracTeslim.BackColor = System.Drawing.Color.White;
            this.button_AracTeslim.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_AracTeslim.ForeColor = System.Drawing.Color.SteelBlue;
            this.button_AracTeslim.Location = new System.Drawing.Point(1013, 655);
            this.button_AracTeslim.Name = "button_AracTeslim";
            this.button_AracTeslim.Size = new System.Drawing.Size(147, 29);
            this.button_AracTeslim.TabIndex = 41;
            this.button_AracTeslim.Text = "Araç Teslim";
            this.button_AracTeslim.UseVisualStyleBackColor = false;
            this.button_AracTeslim.Click += new System.EventHandler(this.button_AracTeslim_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(1352, 655);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 29);
            this.button1.TabIndex = 42;
            this.button1.Text = "İPTAL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(5, 446);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(238, 18);
            this.label18.TabIndex = 44;
            this.label18.Text = "TC Kimlik Numarasına Göre Ara";
            // 
            // textBox_TCyeGoreAra
            // 
            this.textBox_TCyeGoreAra.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_TCyeGoreAra.Location = new System.Drawing.Point(248, 445);
            this.textBox_TCyeGoreAra.Name = "textBox_TCyeGoreAra";
            this.textBox_TCyeGoreAra.Size = new System.Drawing.Size(148, 23);
            this.textBox_TCyeGoreAra.TabIndex = 43;
            this.textBox_TCyeGoreAra.TextChanged += new System.EventHandler(this.textBox_TCyeGoreAra_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(411, 659);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(359, 18);
            this.label19.TabIndex = 46;
            this.label19.Text = "Araç Teslimine Bağlı Alınacak/Verilecek Durum";
            // 
            // textBox_Ekstra
            // 
            this.textBox_Ekstra.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_Ekstra.Location = new System.Drawing.Point(776, 658);
            this.textBox_Ekstra.Name = "textBox_Ekstra";
            this.textBox_Ekstra.Size = new System.Drawing.Size(231, 23);
            this.textBox_Ekstra.TabIndex = 45;
            // 
            // form_Kiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1442, 696);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox_Ekstra);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox_TCyeGoreAra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_AracTeslim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "form_Kiralama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiralama Sayfası";
            this.Load += new System.EventHandler(this.form_Kiralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_EhliyetAlısYeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_EhliyetAlısTarihi;
        private System.Windows.Forms.TextBox textBox_EhliyetNo;
        private System.Windows.Forms.TextBox textBox_Telefon;
        private System.Windows.Forms.TextBox textBox_AdSoyad;
        private System.Windows.Forms.TextBox textBox_TC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_seri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_araclar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_marka;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker date_verilis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_tutar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_gun;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox_kiraSekli;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_kiraUcreti;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_renk;
        private System.Windows.Forms.DateTimePicker date_alis;
        private System.Windows.Forms.Button button_KiraGüncelle;
        private System.Windows.Forms.Button button_KiraEkle;
        private System.Windows.Forms.Button button_AracTeslim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Hesapla;
        private System.Windows.Forms.Button button_Temizle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_TCyeGoreAra;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_Ekstra;
    }
}