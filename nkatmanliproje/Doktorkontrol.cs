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
    public partial class Doktorkontrol : Form
    {
        public Doktorkontrol()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<tbl_doktor> bollist = logicdoktor.Doktorlistesi();
            dataGridView1.DataSource = bollist;
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            tbl_doktor ent = new tbl_doktor();
            ent.doktorid = Convert.ToInt32(txtid.Text);
            ent.doktoradisoyadi = txtsehir.Text;

            logicdoktor.Doktorguncelle(ent);
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            tbl_doktor ent = new tbl_doktor();
            ent.doktoradisoyadi = txtsehir.Text;
            logicdoktor.doktorekle(ent);
            MessageBox.Show("Başarıyla ekleme yapılmıştır");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            tbl_doktor ent = new tbl_doktor();
            ent.doktorid = Convert.ToInt32(txtid.Text);
            logicdoktor.Doktorsil(ent.doktorid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yoneticiekrani x = new Yoneticiekrani();
            x.Show();
            this.Hide();
        }
    }
}
