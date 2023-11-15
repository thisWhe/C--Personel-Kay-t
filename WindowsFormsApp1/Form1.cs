using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-RA4ABQ2;Initial Catalog=Personel Kayıt;Integrated Security=True");    
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personel_KayıtDataSet.kayıt' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kayıtTableAdapter.Fill(this.personel_KayıtDataSet.kayıt);
            
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.kayıtTableAdapter.Fill(this.personel_KayıtDataSet.kayıt);
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand bag = new SqlCommand("insert into kayıt (PerId, PerAd, PerSoyad, PerSehir, PerMaas, PerDurum, PerMeslek,) values  (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", baglan);           
            bag.Parameters.AddWithValue("@p1", txt_id.Text);
            bag.Parameters.AddWithValue("@p2", txt_ad.Text);
            bag.Parameters.AddWithValue("@p3", txt_soyad.Text);
            bag.Parameters.AddWithValue("@p4", txt_sehir.Text);
            bag.Parameters.AddWithValue("@p5", txt_maas.Text);
            if (radioevli.Checked)
            {
                bag.Parameters.AddWithValue("@p6", radioevli.Text);
            }
            else
            {
                bag.Parameters.AddWithValue("@p6", bekar.Text);
            }
            bag.Parameters.AddWithValue("@p7", txt_meslek.Text);
            bag.ExecuteNonQuery();
            baglan.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();          
            txt_maas.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            txt_sehir.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();
            txt_meslek.Text = dataGridView1.Rows[sec].Cells[6].Value.ToString();
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sil = new SqlCommand("Delete From kayıt where PerId=@p1", baglan);
            sil.Parameters.AddWithValue("@p1", txt_id.Text);       
            sil.ExecuteNonQuery(); // veritabanına baglan
            baglan.Close();
        }
        private void btn_Temizle_Click(object sender, EventArgs e)
        {
           txt_id.Clear();
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_maas.Clear();
            txt_sehir.Text = "";
            txt_meslek.Clear();
        }
        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("update kayıt set PerAd = @b1,  PerSoyad = @b2,  PerMaas = @b3, PerSehir = @b4 , PerMeslek = @b5, PerId = @b6  where PerId=@id", baglan);
            cmd.Parameters.AddWithValue("@b1", txt_ad.Text);
            cmd.Parameters.AddWithValue("@b2", txt_soyad.Text);
            cmd.Parameters.AddWithValue("@b3", txt_maas.Text);
            cmd.Parameters.AddWithValue("@b4", txt_sehir.Text);
            cmd.Parameters.AddWithValue("@b5", txt_meslek.Text);
            cmd.Parameters.AddWithValue("@b6", txt_id.Text);
            cmd.Parameters.AddWithValue("@id", txt_id.Text);

            int donenDeger = cmd.ExecuteNonQuery();
            if (donenDeger==1)
            {
                Console.WriteLine("Kayıt Güncellendi");
            }
            else
            {
                Console.WriteLine("kayıt güncellenirken bir hata olustu");
            }

            baglan.Close();
        }

        private void sayfa3_Click(object sender, EventArgs e)
        {
            Form5 git2 = new Form5();
            git2.Show();
            this.Hide();
        }
        private void btn_ogrenciara_Click(object sender, EventArgs e)
        {
            Form2 git = new Form2();
            git.Show();
            this.Hide();

        }
        private void Grafik_Click(object sender, EventArgs e)
        {

        }
        private void txt_id_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void radioevli_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
