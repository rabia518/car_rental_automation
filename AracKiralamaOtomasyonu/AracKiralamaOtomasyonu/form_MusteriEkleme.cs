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
    public partial class form_MusteriEkleme : Form
    {
        AracKiralamaDBConnettion aracDBConnection = new AracKiralamaDBConnettion();
        public form_MusteriEkleme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string musteriEkleDB = "insert into MusteriTable(tc,adSoyad,telefon,adres,email) values(@tc,@adSoyad,@telefon,@adres,@email)";
            SqlCommand command = new SqlCommand();
            command.Parameters.AddWithValue("@tc", textBox_TC.Text);
            command.Parameters.AddWithValue("@adSoyad", textBox_AdSoyad.Text);
            command.Parameters.AddWithValue("@telefon", textBox_Telefon.Text);
            command.Parameters.AddWithValue("@adres", textBox_Adres.Text);
            command.Parameters.AddWithValue("@email", textBox_Email.Text);
            aracDBConnection.add_update_remove(command, musteriEkleDB);

            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            MessageBox.Show("Kayıt İşlemi Tamamlandı!", "Bilgilendirme Penceresi");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
