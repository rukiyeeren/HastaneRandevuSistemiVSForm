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
    public partial class Yoneticiekrani : Form
    {
        public Yoneticiekrani()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Randevukontrolet x = new Randevukontrolet();
            x.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
             Hastakontrol x = new Hastakontrol();
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doktorkontrol x = new Doktorkontrol();
            x.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bolumkontrol x = new Bolumkontrol();
            x.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Anaekran x = new Anaekran();
            x.Show();
            this.Hide();
        }
    }
}
