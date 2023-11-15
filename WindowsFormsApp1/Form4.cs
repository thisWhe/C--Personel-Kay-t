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


namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-RA4ABQ2;Initial Catalog=Personel Kayıt;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
           baglan.Open();
            SqlCommand bag = new SqlCommand("Select * From tbl_giris where KullaniciAd = @p1 and Sifre = @p2", baglan);
            bag.Parameters.AddWithValue("@p1", TextBox1.Text);
            bag.Parameters.AddWithValue("@p2", TextBox2.Text);
            SqlDataReader dd = bag.ExecuteReader();
            if (dd.Read())
            {
                Form1 git1 = new Form1();
                git1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            baglan.Close(); 
        }
    }
}
