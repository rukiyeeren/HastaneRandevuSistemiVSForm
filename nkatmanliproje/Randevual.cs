using DataAccessLayer;
using Entitylayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace nkatmanliproje
{
    public partial class Randevual : Form
    {
        public Randevual()
        {
            InitializeComponent();
        }

        private void Randevual_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        

            tbl_randevu ra = new tbl_randevu();
            ra.randevuadsoyad = textBox1.Text;
            ra.randevutcno = textBox2.Text;
            ra.randevutel=textBox4.Text;
            ra.randevutarihsaat =Convert.ToDateTime(textBox3.Text);
            ra.randevudoktorid = Convert.ToInt32( textBox5.Text);
            ra.randevubolumid = Convert.ToInt32( textBox6.Text);
            dalrandevu.Randevuekle(ra);
            MessageBox.Show("Randevunuz Oluşturulmuştur");

  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anaekran x = new Anaekran();
            x.Show();
            this.Hide();
        }
    }
}
