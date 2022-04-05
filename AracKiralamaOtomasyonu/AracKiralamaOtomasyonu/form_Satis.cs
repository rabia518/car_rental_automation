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
    public partial class form_Satis : Form
    {
        AracKiralamaDBConnettion aracDBConnection = new AracKiralamaDBConnettion();
        public form_Satis()
        {
            InitializeComponent();
        }

        private void form_Satis_Load(object sender, EventArgs e)
        {
            string satisTablosuGetirDB = "select *from SatisTable";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = aracDBConnection.list(adtr2,satisTablosuGetirDB);
            aracDBConnection.SatisHesapla(label_SatisTutar);

            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "AD SOYAD";
            dataGridView1.Columns[2].HeaderText = "PLAKA";
            dataGridView1.Columns[3].HeaderText = "MARKA";
            dataGridView1.Columns[4].HeaderText = "SERİ";
            dataGridView1.Columns[5].HeaderText = "MODEL(YIL)";
            dataGridView1.Columns[6].HeaderText = "RENK";
            dataGridView1.Columns[7].HeaderText = "GÜN";
            dataGridView1.Columns[8].HeaderText = "FİYAT";
            dataGridView1.Columns[9].HeaderText = "TUTAR";
            dataGridView1.Columns[10].HeaderText = "ARAÇ ALIŞ TARİHİ";
            dataGridView1.Columns[11].HeaderText = "ARAÇ VERİLİŞ TARİHİ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
