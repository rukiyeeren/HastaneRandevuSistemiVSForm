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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace nkatmanliproje
{
    public partial class Bolumkontrol : Form
    {
        public Bolumkontrol()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<tbl_bolum> bollist = logicbolum.Bolumlistesi();
            dataGridView1.DataSource = bollist;
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            tbl_bolum guncelle = new tbl_bolum();
            guncelle.bolumid = int.Parse(txtid.Text);
            guncelle.bolumad = txtsehir.Text;

            logicbolum.Bolumguncelle(guncelle);

          

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            
            tbl_bolum ekle = new tbl_bolum();
            ekle.bolumad= txtsehir.Text;
            logicbolum.Bolumekle(ekle);
            MessageBox.Show("Başarıyla ekleme yapılmıştır");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            tbl_bolum sil = new tbl_bolum();
            sil.bolumid = Convert.ToInt32(txtid.Text);
            logicbolum.Bolumsil(sil.bolumid);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yoneticiekrani x = new Yoneticiekrani();
            x.Show();
            this.Hide();
        }
    }
}
