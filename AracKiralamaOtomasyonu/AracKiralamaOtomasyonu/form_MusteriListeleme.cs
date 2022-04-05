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
    public partial class form_MusteriListeleme : Form
    {
        AracKiralamaDBConnettion aracDBConnection = new AracKiralamaDBConnettion();     
        public form_MusteriListeleme()
        {
            InitializeComponent();
        }

        private void button_MusteriEkle_Click(object sender, EventArgs e)
        {
            string musteriGuncelleDB = "update MusteriTable set adSoyad=@adSoyad , telefon=@telefon , adres=@adres , email=@email where tc=@tc";
            SqlCommand command = new SqlCommand();
            command.Parameters.AddWithValue("@tc", textBox_TC.Text);
            command.Parameters.AddWithValue("@adSoyad", textBox_AdSoyad.Text);
            command.Parameters.AddWithValue("@telefon", textBox_Telefon.Text);
            command.Parameters.AddWithValue("@adres", textBox_Adres.Text);
            command.Parameters.AddWithValue("@email", textBox_Email.Text);
            aracDBConnection.add_update_remove(command, musteriGuncelleDB);

            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            MessageBox.Show("Güncelleme İşlemi Tamamlandı!", "Bilgilendirme Penceresi");
            ListeYenile();
        }

        private void form_MusteriListeleme_Load(object sender, EventArgs e)
        {
            ListeYenile();
        }

        private void ListeYenile()
        {
            string musterListeleDB = "select * from MusteriTable";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            
            dataGridView1.DataSource = aracDBConnection.list(adtr2, musterListeleDB);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "AD SOYAD";
            dataGridView1.Columns[2].HeaderText = "TELEFON";
            dataGridView1.Columns[3].HeaderText = "ADRES";
            dataGridView1.Columns[4].HeaderText = "E-MAİL";
            
        }

        private void button_MusteriSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            string musteriSilDB = "delete from MusteriTable where tc='"+row.Cells["tc"].Value.ToString()+"'";
            SqlCommand command4 = new SqlCommand();
            aracDBConnection.add_update_remove(command4, musteriSilDB);

            //foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            ListeYenile();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string musterliListeleDB = "select * from MusteriTable where tc like '%" + textBox1.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = aracDBConnection.list(adtr2, musterliListeleDB);
        }

        private void button_MusteriIptal_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox_TC.Text = row.Cells[0].Value.ToString();
            textBox_AdSoyad.Text = row.Cells[1].Value.ToString();
            textBox_Telefon.Text = row.Cells[2].Value.ToString();
            textBox_Adres.Text = row.Cells[3].Value.ToString();
            textBox_Email.Text = row.Cells[4].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
