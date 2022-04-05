using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu
{
    public partial class form_Kiralama : Form
    {
        AracKiralamaDBConnettion aracDBConnection = new AracKiralamaDBConnettion();
        public form_Kiralama()
        {
            InitializeComponent();
        }

        private void form_Kiralama_Load(object sender, EventArgs e)
        {
            BosAracKira();
            Yenile();
        }

        private void BosAracKira()
        {
            string bosAracDB = "select *from AracTable where durum='BOŞ'";
            aracDBConnection.BosAraclar(comboBox_araclar, bosAracDB);
        }

        private void Yenile()
        {
            string kiralamaDB = "select *from KiralamaTable";
            SqlDataAdapter adtr = new SqlDataAdapter();
            dataGridView1.DataSource = aracDBConnection.list(adtr, kiralamaDB);

            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "AD SOYAD";
            dataGridView1.Columns[2].HeaderText = "TELEFON";
            dataGridView1.Columns[3].HeaderText = "PLAKA";
            dataGridView1.Columns[4].HeaderText = "EHLİYET NUMARASI";
            dataGridView1.Columns[5].HeaderText = "EHLİYET ALIŞ TARİH";
            dataGridView1.Columns[6].HeaderText = "EHLİYET ALIŞ YER";
            dataGridView1.Columns[7].HeaderText = "MARKA";
            dataGridView1.Columns[8].HeaderText = "SERİ";
            dataGridView1.Columns[9].HeaderText = "MODEL(YIL)";
            dataGridView1.Columns[10].HeaderText = "RENK";
            dataGridView1.Columns[11].HeaderText = "KİRA ŞEKLİ";
            dataGridView1.Columns[12].HeaderText = "KİRA ÜCRETİ";
            dataGridView1.Columns[13].HeaderText = "GÜN";
            dataGridView1.Columns[14].HeaderText = "TUTAR";
            dataGridView1.Columns[15].HeaderText = "ARAÇ ALIŞ TARİHİ";
            dataGridView1.Columns[16].HeaderText = "ARAÇ VERİLİŞ TARİHİ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_araclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string plakayaGoreAracBulDB = "select *from AracTable where plaka like '" + comboBox_araclar.SelectedItem + "'";
            aracDBConnection.PlakayaGoreAracGetir( comboBox_araclar,textBox_marka, textBox_seri, textBox_model, textBox_renk , plakayaGoreAracBulDB);
        }

        private void comboBox_kiraSekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fiyatHesapla = "select *from AracTable where plaka like '" + comboBox_araclar.SelectedItem + "'";
            aracDBConnection.FiyatHesapla(comboBox_kiraSekli, textBox_kiraUcreti, fiyatHesapla);
        }

        private void button_Hesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun = (DateTime.Parse(date_alis.Text) - DateTime.Parse(date_verilis.Text));
            int intGun = gun.Days;
            textBox_gun.Text = intGun.ToString();

            textBox_tutar.Text = (intGun * int.Parse(textBox_kiraUcreti.Text)).ToString();
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            date_verilis.Text = DateTime.Now.ToShortDateString();
            date_alis.Text = DateTime.Now.ToShortDateString();
            comboBox_kiraSekli.Text = "";
            textBox_kiraUcreti.Text = "";
            textBox_gun.Text = "";
            textBox_tutar.Text = "";
        }

        private void button_KiraEkle_Click(object sender, EventArgs e)
        {
            string kiralamaEkleDB = "insert into KiralamaTable(tc,adSoyad,telefon,plaka,ehliyetNo,ehliyetTarih,ehliyetYer,marka,seri,yil,renk,kiraSekli,kiraUcreti,gun,tutar,alisTarihi,verisTarihi) values(@tc,@adSoyad,@telefon,@plaka,@ehliyetNo,@ehliyetTarih,@ehliyetYer,@marka,@seri,@yil,@renk,@kiraSekli,@kiraUcreti,@gun,@tutar,@alisTarihi,@verisTarihi)";
            SqlCommand command = new SqlCommand(kiralamaEkleDB);
            command.Parameters.AddWithValue("@tc", textBox_TC.Text);
            command.Parameters.AddWithValue("@adSoyad", textBox_AdSoyad.Text);
            command.Parameters.AddWithValue("@telefon", textBox_Telefon.Text);
            command.Parameters.AddWithValue("@plaka", comboBox_araclar.Text);
            command.Parameters.AddWithValue("@ehliyetNo", textBox_EhliyetNo.Text);
            command.Parameters.AddWithValue("@ehliyetTarih", textBox_EhliyetAlısTarihi.Text);
            command.Parameters.AddWithValue("@ehliyetYer", textBox_EhliyetAlısYeri.Text);
            command.Parameters.AddWithValue("@marka", textBox_marka.Text);
            command.Parameters.AddWithValue("@seri", textBox_seri.Text);
            command.Parameters.AddWithValue("@yil", textBox_model.Text);
            command.Parameters.AddWithValue("@renk", textBox_renk.Text);
            command.Parameters.AddWithValue("@kiraSekli", comboBox_kiraSekli.Text);
            command.Parameters.AddWithValue("@kiraUcreti", int.Parse(textBox_kiraUcreti.Text));
            command.Parameters.AddWithValue("@gun", int.Parse(textBox_gun.Text));
            command.Parameters.AddWithValue("@tutar", int.Parse(textBox_tutar.Text));
            command.Parameters.AddWithValue("@alisTarihi", date_alis.Text);
            command.Parameters.AddWithValue("@verisTarihi", date_verilis.Text);
            aracDBConnection.add_update_remove(command,kiralamaEkleDB);

            string doluYapDB = "update AracTable set durum='DOLU' where  plaka='"+comboBox_araclar.Text+"'";
            SqlCommand command7 = new SqlCommand();
            aracDBConnection.add_update_remove(command7, doluYapDB);
            comboBox_araclar.Items.Clear();
            textBox_TCyeGoreAra.Text = "";
            BosAracKira();
            Yenile();

            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboBox_araclar.Text = "";
            Temizle();

            MessageBox.Show("Kiralama İşlemi Tamamlandı!", "Bilgilendirme Penceresi");
        }

        private void textBox_TCyeGoreAra_TextChanged(object sender, EventArgs e)
        {
            if (textBox_TCyeGoreAra.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string tcyeGoreBulDB = "select *from MusteriTable where tc like '" + textBox_TCyeGoreAra.Text + "'";
            aracDBConnection.TCyeGoreAra(textBox_TCyeGoreAra, textBox_TC, textBox_AdSoyad, textBox_Telefon, tcyeGoreBulDB);
        }

        private void button_KiraGüncelle_Click(object sender, EventArgs e)
        {
            string kiralamaEkleDB = "update KiralamaTable set tc=@tc,adSoyad=@adSoyad,telefon=@telefon,ehliyetNo=@ehliyetNo,ehliyetTarih=@ehliyetTarih,ehliyetYer=@ehliyetYer,marka=@marka,seri=@seri,yil=@yil,renk=@renk,kiraSekli=@kiraSekli,kiraUcreti=@kiraUcreti,gun=@gun,tutar=@tutar,alisTarihi=@alisTarihi,verisTarihi=@verisTarihi where plaka=@plaka";
            SqlCommand command = new SqlCommand();
            command.Parameters.AddWithValue("@tc", textBox_TC.Text);
            command.Parameters.AddWithValue("@adSoyad", textBox_AdSoyad.Text);
            command.Parameters.AddWithValue("@telefon", textBox_Telefon.Text);
            command.Parameters.AddWithValue("@plaka", comboBox_araclar.Text);
            command.Parameters.AddWithValue("@ehliyetNo", textBox_EhliyetNo.Text);
            command.Parameters.AddWithValue("@ehliyetTarih", textBox_EhliyetAlısTarihi.Text);
            command.Parameters.AddWithValue("@ehliyetYer", textBox_EhliyetAlısYeri.Text);
            command.Parameters.AddWithValue("@marka", textBox_marka.Text);
            command.Parameters.AddWithValue("@seri", textBox_seri.Text);
            command.Parameters.AddWithValue("@yil", textBox_model.Text);
            command.Parameters.AddWithValue("@renk", textBox_renk.Text);
            command.Parameters.AddWithValue("@kiraSekli", comboBox_kiraSekli.Text);
            command.Parameters.AddWithValue("@kiraUcreti", int.Parse(textBox_kiraUcreti.Text));
            command.Parameters.AddWithValue("@gun", int.Parse(textBox_gun.Text));
            command.Parameters.AddWithValue("@tutar", int.Parse(textBox_tutar.Text));
            command.Parameters.AddWithValue("@alisTarihi", date_alis.Text);
            command.Parameters.AddWithValue("@verisTarihi", date_verilis.Text);
            aracDBConnection.add_update_remove(command, kiralamaEkleDB);

            comboBox_araclar.Items.Clear();
            textBox_TCyeGoreAra.Text = "";
            BosAracKira();
            Yenile();

            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboBox_araclar.Text = "";
            Temizle();

            MessageBox.Show("Kiralama İşlemi Güncellendi!", "Bilgilendirme Penceresi");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox_TC.Text = row.Cells[0].Value.ToString();
            textBox_AdSoyad.Text = row.Cells[1].Value.ToString();
            textBox_Telefon.Text = row.Cells[2].Value.ToString();
            comboBox_araclar.Text = row.Cells[3].Value.ToString();
            textBox_EhliyetNo.Text = row.Cells[4].Value.ToString();
            textBox_EhliyetAlısTarihi.Text = row.Cells[5].Value.ToString();
            textBox_EhliyetAlısYeri.Text = row.Cells[6].Value.ToString();
            textBox_marka.Text = row.Cells[7].Value.ToString();
            textBox_seri.Text = row.Cells[8].Value.ToString();
            textBox_model.Text = row.Cells[9].Value.ToString();
            textBox_renk.Text = row.Cells[10].Value.ToString();
            comboBox_kiraSekli.Text = row.Cells[11].Value.ToString();
            textBox_kiraUcreti.Text = row.Cells[12].Value.ToString();
            textBox_gun.Text = row.Cells[13].Value.ToString();
            textBox_tutar.Text = row.Cells[14].Value.ToString();
            date_alis.Text = row.Cells[15].Value.ToString();
            date_verilis.Text = row.Cells[16].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;

            //gün farkı hesabı
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime alisTarihi = DateTime.Parse(row.Cells["alisTarihi"].Value.ToString());
            int ucret = int.Parse(row.Cells["kiraUcreti"].Value.ToString());
            TimeSpan gunFarkı = bugun - alisTarihi;
            int intGunFarki = gunFarkı.Days;


            //ücret farkı hesabı
            int ucretFarkı;
            ucretFarkı = intGunFarki *ucret;
            textBox_Ekstra.Text = ucretFarkı.ToString();
        }

        private void button_AracTeslim_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox_Ekstra.Text)>=0 || int.Parse(textBox_Ekstra.Text)<0 )
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
                DateTime verisTarihi = DateTime.Parse(row.Cells["verisTarihi"].Value.ToString());
                int ucret = int.Parse(row.Cells["kiraUcreti"].Value.ToString());
                int tutar = int.Parse(row.Cells["tutar"].Value.ToString());
                TimeSpan gun = bugun - verisTarihi;
                int intGun = gun.Days;
                int toplamTutar = intGun * ucret;

                string kiralamaSilDB = "delete from KiralamaTable where plaka ='"+row.Cells["plaka"].Value.ToString()+"'";
                SqlCommand command1 = new SqlCommand();
                aracDBConnection.add_update_remove(command1,kiralamaSilDB);

                string aracDurumuGüncellemeDB = "update AracTable set durum='BOŞ' where plaka='" + row.Cells["plaka"].Value.ToString() + "'";
                SqlCommand command2 = new SqlCommand();
                aracDBConnection.add_update_remove(command2, aracDurumuGüncellemeDB);

                string aracTeslimDB = "insert into SatisTable(tc,adSoyad,plaka,marka,seri,yil,renk,gun,fiyat,tutar,aracVerilisTarihi,tarihBugun) values(@tc,@adSoyad,@plaka,@marka,@seri,@yil,@renk,@gun,@fiyat,@tutar,@aracVerilisTarihi,@tarihBugun)";
                SqlCommand command4 = new SqlCommand();
                command4.Parameters.AddWithValue("@tc", row.Cells["tc"].Value.ToString());
                command4.Parameters.AddWithValue("@adSoyad", row.Cells["adSoyad"].Value.ToString());
                command4.Parameters.AddWithValue("@plaka", row.Cells["plaka"].Value.ToString());
                command4.Parameters.AddWithValue("@marka", row.Cells["marka"].Value.ToString());
                command4.Parameters.AddWithValue("@seri", row.Cells["seri"].Value.ToString());
                command4.Parameters.AddWithValue("@yil", row.Cells["yil"].Value.ToString());
                command4.Parameters.AddWithValue("@renk", row.Cells["renk"].Value.ToString());
                command4.Parameters.AddWithValue("@gun", intGun);
                command4.Parameters.AddWithValue("@fiyat", ucret);
                command4.Parameters.AddWithValue("@tutar", toplamTutar);
                command4.Parameters.AddWithValue("@aracVerilisTarihi", row.Cells["alisTarihi"].Value.ToString());
                command4.Parameters.AddWithValue("@tarihBugun",DateTime.Now.ToShortDateString());

                aracDBConnection.add_update_remove(command4, aracTeslimDB);

                MessageBox.Show("Araç Teslim Edildi!", "Bilgilendirme Penceresi");
                comboBox_araclar.Text = "";
                comboBox_araclar.Items.Clear();
                BosAracKira();
                Yenile();

                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                comboBox_araclar.Text = "";
                Temizle();
                textBox_Ekstra.Text = "";
            }
            else 
            {
                MessageBox.Show("Seçim Yapınız!", "Bilgilendirme Penceresi");
            }
        }

        private void textBox_TC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
