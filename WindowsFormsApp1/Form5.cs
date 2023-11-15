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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-RA4ABQ2;Initial Catalog=kayıt3;Integrated Security=True");

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kayıt3DataSet2.kayıt4' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kayıt4TableAdapter.Fill(this.kayıt3DataSet2.kayıt4);

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand bag = new SqlCommand("insert into kayıt4 (Id, Ad, SoyAd, Telefon) values  (@p1, @p2, @p3, @p4)", baglan);
            bag.Parameters.AddWithValue("@p1", txt_id.Text);
            bag.Parameters.AddWithValue("@p2", txt_ad.Text);
            bag.Parameters.AddWithValue("@p3", txt_soyad.Text);
            bag.Parameters.AddWithValue("@p4", txt_telefon.Text);
            bag.ExecuteNonQuery();
            baglan.Close();

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            this.kayıt4TableAdapter.Fill(this.kayıt3DataSet2.kayıt4);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            txt_id.Text = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            txt_telefon.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sil = new SqlCommand("Delete From kayıt4 where Id=@p1", baglan);
            sil.Parameters.AddWithValue("@p1", txt_id.Text);

            sil.ExecuteNonQuery(); // veritabanına baglan
            baglan.Close();
        }
    }
}
