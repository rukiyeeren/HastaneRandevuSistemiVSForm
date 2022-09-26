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
    public partial class Hastakontrol : Form
    {
        public Hastakontrol()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<tbl_hasta> bollist = logichasta.Hastalistesi();
            dataGridView1.DataSource = bollist;
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            tbl_hasta ent = new tbl_hasta();
            ent.hastaid= Convert.ToInt32(txtid.Text);
            ent.hastaadsoyad = txtsehir.Text;
           
            logichasta.Hastaguncelle(ent);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            tbl_hasta ent = new tbl_hasta();
            ent.hastaadsoyad = txtsehir.Text;
            logichasta.Hastaekle(ent);
            MessageBox.Show("Başarıyla ekleme yapılmıştır");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            tbl_hasta ent = new tbl_hasta();
            ent.hastaid = Convert.ToInt32(txtid.Text);
            logichasta.Hastasil(ent.hastaid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yoneticiekrani x = new Yoneticiekrani();
            x.Show();
            this.Hide();
        }
    }
}
