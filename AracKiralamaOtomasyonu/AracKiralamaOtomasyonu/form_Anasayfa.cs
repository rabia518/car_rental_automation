using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu
{
    public partial class form_Anasayfa : Form
    {
        public form_Anasayfa()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            form_AracEkleme aracEkleme = new form_AracEkleme();
            aracEkleme.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            form_AracListeleme aracListele = new form_AracListeleme();
            aracListele.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_MusteriKayit_Click(object sender, EventArgs e)
        {
            form_MusteriEkleme ekle = new form_MusteriEkleme();
            ekle.ShowDialog();
        }

        private void button_Satislar_Click(object sender, EventArgs e)
        {
            form_Satis satis = new form_Satis();
            satis.ShowDialog();
        }

        private void button_MusteriListe_Click(object sender, EventArgs e)
        {
            form_MusteriListeleme listele = new form_MusteriListeleme();
            listele.ShowDialog();
        }

        private void button_Kiralama_Click(object sender, EventArgs e)
        {
            form_Kiralama kiralama = new form_Kiralama();
            kiralama.ShowDialog();
        }

        private void form_Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
