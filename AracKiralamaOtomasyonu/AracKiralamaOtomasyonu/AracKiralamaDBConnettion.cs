using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu
{
    class AracKiralamaDBConnettion
    {
        SqlConnection dbConnettion = new SqlConnection("Data Source=DESKTOP-258GG36;Initial Catalog=AracKiralamaDB;Integrated Security=True");
        DataTable table;
        public void add_update_remove(SqlCommand command , string query)
        {
            dbConnettion.Open();
            command.Connection = dbConnettion;
            command.CommandText = query;
            command.ExecuteNonQuery();
            dbConnettion.Close();
        }

        public DataTable list(SqlDataAdapter adtr , string query)
        {
            table = new DataTable();
            adtr = new SqlDataAdapter(query,dbConnettion);
            adtr.Fill(table);
            dbConnettion.Close();
            return table;
        }

        public void BosAraclar( ComboBox comboBox  , string query)
        {
            dbConnettion.Open();
            SqlCommand command = new SqlCommand(query,dbConnettion);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                comboBox.Items.Add(read["plaka"].ToString());
            }
            dbConnettion.Close();
        }

        public void TCyeGoreAra(TextBox tcyeGoreAra , TextBox tc, TextBox adsoyad, TextBox telefon, string query)
        {
            dbConnettion.Open();
            SqlCommand command = new SqlCommand(query, dbConnettion);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                adsoyad.Text = read["adSoyad"].ToString();
                telefon.Text = read["telefon"].ToString();
            }
            dbConnettion.Close();
        }
        public void FiyatHesapla(ComboBox kiraSekli , TextBox ucret , string query)
        {
            dbConnettion.Open();
            SqlCommand command = new SqlCommand(query, dbConnettion);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                if (kiraSekli.SelectedIndex == 0)
                {
                    ucret.Text = (int.Parse(read["kiraUcreti"].ToString()) * 1).ToString();
                }
                if (kiraSekli.SelectedIndex == 1)
                {
                    ucret.Text = (int.Parse(read["kiraUcreti"].ToString()) * 0.75).ToString() ;
                }

            }
            dbConnettion.Close();
        }

        public void PlakayaGoreAracGetir(ComboBox arac, TextBox marka, TextBox seri , TextBox model, TextBox renk, string query)
        {
            dbConnettion.Open();
            SqlCommand command = new SqlCommand(query, dbConnettion);
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                model.Text = read["yil"].ToString();
                renk.Text = read["renk"].ToString();
            }
            dbConnettion.Close();
        }

        public void SatisHesapla( Label label)
        {
            dbConnettion.Open();
            SqlCommand command = new SqlCommand("select sum(tutar) from SatisTable" , dbConnettion);
            label.Text = "Toplam Tutar = " + command.ExecuteScalar() + " TL";
            dbConnettion.Close();
        }
    }
}
