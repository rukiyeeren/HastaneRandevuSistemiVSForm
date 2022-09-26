using BusinessLayer;
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

namespace nkatmanliproje
{
    public partial class Randevukontrolet : Form
    {
        public Randevukontrolet()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<tbl_randevu> bollist = logicrandevu.Randevulistesi();
            dataGridView1.DataSource = bollist;
        }

        private void textbolum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textdoktor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void texzaman_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textcno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            tbl_randevu ent = new tbl_randevu();
            ent.randevuid = Convert.ToInt32(txtid.Text);
            logicrandevu.Randevusil(ent.randevuid);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            tbl_randevu ent = new tbl_randevu();

            ent.randevuadsoyad = txtadsoyad.Text;
            ent.randevutcno = textcno.Text;
            ent.randevutel = textel.Text;
            ent.randevutarihsaat = Convert.ToDateTime(texzaman.Text);
            ent.randevudoktorid = int.Parse(textdoktor.Text);
            ent.randevubolumid = int.Parse(textbolum.Text);

            logicrandevu.Randevuekle(ent);
            MessageBox.Show("Başarıyla ekleme yapılmıştır");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            tbl_randevu ent = new tbl_randevu();
            ent.randevuid = Convert.ToInt32(txtid.Text);
            ent.randevuadsoyad = txtadsoyad.Text;
            ent.randevutcno = textcno.Text;
            ent.randevutel = textel.Text;
            ent.randevutarihsaat = Convert.ToDateTime(texzaman.Text);
            ent.randevudoktorid = Convert.ToInt32(textdoktor.Text);
            ent.randevubolumid = Convert.ToInt32(textbolum.Text);

            logicrandevu.Randevuguncelle(ent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yoneticiekrani x = new Yoneticiekrani();
            x.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtadsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
