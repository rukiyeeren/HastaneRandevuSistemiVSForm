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
using Entitylayer;

namespace nkatmanliproje
{
    public partial class Girisyap : Form
    {
        public Girisyap()
        {
            InitializeComponent();
        }
        public static SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-FLQRUHO;Initial Catalog=nkatmanlihastane;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand login = new SqlCommand("select * from tbl_giris Where kullaniciadi=@p1 and sifre=@p2", baglanti);

            login.Parameters.AddWithValue("@p1", textBox1.Text);
            login.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader oku = login.ExecuteReader();
            if (oku.Read())
            {
                Yoneticiekrani x = new Yoneticiekrani();
                x.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }
            baglanti.Close();

        }
       
        }
    }

