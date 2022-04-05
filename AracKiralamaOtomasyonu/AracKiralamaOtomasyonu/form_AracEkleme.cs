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
    public partial class form_AracEkleme : Form
    {
        AracKiralamaDBConnettion aracDBConnection = new AracKiralamaDBConnettion();
        public form_AracEkleme()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox_SeriNo.Items.Clear();
                if(comboBox_Marka.SelectedIndex == 0)
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

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aracEklemeDB = "insert into AracTable(plaka,marka,seri,yil,renk,km,yakit,kiraUcreti,resim,tarih,durum) values(@plaka,@marka,@seri,@yil,@renk,@km,@yakit,@kiraUcreti,@resim,@tarih,@durum)";
            SqlCommand command = new SqlCommand();
            command.Parameters.AddWithValue("@plaka" , textBox_Plaka.Text);
            command.Parameters.AddWithValue("@marka", comboBox_Marka.Text);
            command.Parameters.AddWithValue("@seri", comboBox_SeriNo.Text);
            command.Parameters.AddWithValue("@yil", textBox_Model.Text);
            command.Parameters.AddWithValue("@renk", textBox_Renk.Text);
            command.Parameters.AddWithValue("@km", textBox_Km.Text);
            command.Parameters.AddWithValue("@yakit", comboBox_Yakit.Text);
            command.Parameters.AddWithValue("@kiraUcreti", int.Parse(textBox_KiraUcreti.Text));
            command.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            command.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            command.Parameters.AddWithValue("@durum", "BOŞ");

            aracDBConnection.add_update_remove(command,aracEklemeDB);
            comboBox_SeriNo.Items.Clear();
            pictureBox1.ImageLocation ="";

            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";

            MessageBox.Show("Kayıt İşlemi Tamamlandı!", "Bilgilendirme Penceresi");
        }
    }
}
