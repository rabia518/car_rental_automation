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
    public partial class form_AracListeleme : Form
    {
        AracKiralamaDBConnettion aracDBConnection = new AracKiralamaDBConnettion();
        public form_AracListeleme()
        {
            InitializeComponent();
        }

        private void form_AracListeleme_Load(object sender, EventArgs e)
        {
            AracListeYenile();
            comboBox_Araclar.SelectedIndex = 0;
        }

        private void AracListeYenile()
        {
            string aracListelemeDB = "select * from AracTable";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = aracDBConnection.list(adtr2, aracListelemeDB);

            dataGridView1.Columns[0].HeaderText = "PLAKA";
            dataGridView1.Columns[1].HeaderText = "MARKA";
            dataGridView1.Columns[2].HeaderText = "SERİ";
            dataGridView1.Columns[3].HeaderText = "MODEL(YIL)";
            dataGridView1.Columns[4].HeaderText = "RENK";
            dataGridView1.Columns[5].HeaderText = "KM";
            dataGridView1.Columns[6].HeaderText = "YAKIT";
            dataGridView1.Columns[7].HeaderText = "KİRA ÜCRETİ";
            dataGridView1.Columns[8].HeaderText = "RESİM ADRESİ";
            dataGridView1.Columns[9].HeaderText = "TARİH";
            dataGridView1.Columns[10].HeaderText = "DOLULUK DURUMU";
        }

        private void button_AracIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button_AracGuncelle_Click(object sender, EventArgs e)
        {
            string aracListeGuncelleDB = "update AracTable set marka=@marka , seri=@seri , yil=@yil , renk=@renk , km=@km , yakit=@yakit , kiraUcreti=@kiraucreti , resim=@resim , tarih=@tarih where plaka=@plaka";
            SqlCommand command = new SqlCommand();
            command.Parameters.AddWithValue("@plaka", textBox_Plaka.Text);
            command.Parameters.AddWithValue("@marka", comboBox_Marka.Text);
            command.Parameters.AddWithValue("@seri", comboBox_SeriNo.Text);
            command.Parameters.AddWithValue("@yil", textBox_Model.Text);
            command.Parameters.AddWithValue("@renk", textBox_Renk.Text);
            command.Parameters.AddWithValue("@km", textBox_Km.Text);
            command.Parameters.AddWithValue("@yakit", comboBox_Yakit.Text);
            command.Parameters.AddWithValue("@kiraUcreti", int.Parse(textBox_KiraUcreti.Text));
            command.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            command.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

            aracDBConnection.add_update_remove(command, aracListeGuncelleDB);
            comboBox_SeriNo.Items.Clear();
            pictureBox1.ImageLocation = "";

            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";

            MessageBox.Show("Güncelleme  İşlemi Tamamlandı!", "Bilgilendirme Penceresi");

            AracListeYenile();  
        }

        private void button_AracSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            string aracSilDB = "delete from AracTable where plaka='"+row.Cells["plaka"].Value.ToString()+"'";
            SqlCommand command6 = new SqlCommand();
            aracDBConnection.add_update_remove(command6,aracSilDB);
            comboBox_SeriNo.Items.Clear();
            pictureBox1.ImageLocation = "";

            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";

            AracListeYenile();
        }

        private void comboBox_Marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox_SeriNo.Items.Clear();
                if (comboBox_Marka.SelectedIndex == 0)
                {
                    comboBox_SeriNo.Items.Add("i20");
                    comboBox_SeriNo.Items.Add("i30");
                    comboBox_SeriNo.Items.Add("Tuscon");
                }
                else if (comboBox_Marka.SelectedIndex == 1)
                {
                    comboBox_SeriNo.Items.Add("Astra");
                    comboBox_SeriNo.Items.Add("Corsa");
                }
                else if (comboBox_Marka.SelectedIndex == 2)
                {
                    comboBox_SeriNo.Items.Add("Clio");
                    comboBox_SeriNo.Items.Add("Megane");
                }
                else if (comboBox_Marka.SelectedIndex == 3)
                {
                    comboBox_SeriNo.Items.Add("2008");
                    comboBox_SeriNo.Items.Add("3008");
                    comboBox_SeriNo.Items.Add("5008");
                }
            }
            catch (Exception)
            {

                
            }
        }

        private void comboBox_Araclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_Araclar.SelectedIndex==0)
                {
                    AracListeYenile();
                }
                else if (comboBox_Araclar.SelectedIndex==1)
                {
                    string aracListelemeDB = "select * from AracTable where durum='BOŞ'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = aracDBConnection.list(adtr2, aracListelemeDB);
                }
                else if (comboBox_Araclar.SelectedIndex==2)
                {
                    string aracListelemeDB = "select * from AracTable durum='DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = aracDBConnection.list(adtr2, aracListelemeDB);
                }
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox_Plaka.Text = row.Cells["plaka"].Value.ToString();
            comboBox_Marka.Text = row.Cells["marka"].Value.ToString();
            comboBox_SeriNo.Text = row.Cells["seri"].Value.ToString();
            textBox_Model.Text = row.Cells["yil"].Value.ToString();
            textBox_Renk.Text = row.Cells["renk"].Value.ToString();
            textBox_Km.Text = row.Cells["km"].Value.ToString();
            comboBox_Yakit.Text = row.Cells["yakit"].Value.ToString();
            textBox_KiraUcreti.Text = row.Cells["kiraUcreti"].Value.ToString();
            pictureBox1.ImageLocation = row.Cells["resim"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
