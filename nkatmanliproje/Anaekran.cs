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
    public partial class Anaekran : Form
    {
        public Anaekran()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Randevual x = new Randevual();
            x.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Girisyap x = new Girisyap();
            x.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dRFATMAÇETİNKAYAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\windows10\\Desktop\\Rukiye Eren\\dktr\\d5.jpg");
            listBox1.Items.Clear();
            listBox1.Items.Add("DR.FATMA ÇETİNDAĞ");
            listBox1.Items.Add("ÖĞRENİM: MARMARA ÜNÜVERİSTESİ");
            listBox1.Items.Add("ALAN: KULAK BURUN BOĞAZ");
        }

        private void oPDRŞEKİPÇELİKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\windows10\\Desktop\\Rukiye Eren\\dktr\\d1.jpg");
            listBox1.Items.Clear();
            listBox1.Items.Add("OP.DR.ŞEKİP ÇELİK");
            listBox1.Items.Add("ÖĞRENİM: DOKUZ EYLÜL ÜNÜVERİSTESİ");
            listBox1.Items.Add("ALAN:İÇ HASTALIKLARI");
        }

        private void oPDRDENİZŞEREFLİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\windows10\\Desktop\\Rukiye Eren\\dktr\\d3.jpg");
            listBox1.Items.Clear();
            listBox1.Items.Add("OP.DR.DENİZ ŞEREFLİ");
            listBox1.Items.Add("ÖĞRENİM: İSTANBUL ÜNÜVERİSTESİ");
            listBox1.Items.Add("ALAN:İÇ HASTALIKLARI");
        }

        private void uZMDRARMAĞANVAROLToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void dRELAALTINDAĞToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\windows10\\Desktop\\Rukiye Eren\\dktr\\d2.jpg");
            listBox1.Items.Clear();
            listBox1.Items.Add("DR.ELA ALTINDAĞ");
            listBox1.Items.Add("ÖĞRENİM: DOKUZ EYLÜL ÜNÜVERİSTESİ");
            listBox1.Items.Add("ALAN: KULAK BURUN BOĞAZ");
        }

        private void oPDRHATİCEERMİNToolStripMenuItem_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = Image.FromFile("C:\\Users\\windows10\\Desktop\\Rukiye Eren\\dktr\\d5.jpg");
            listBox1.Items.Clear();
            listBox1.Items.Add("OP.DR. HATİCE ERMİN");
            listBox1.Items.Add("ÖĞRENİM: MARMARA ÜNÜVERİSTESİ");
            listBox1.Items.Add("ALAN: GÖZ HASTALIKLARI");
        }

        private void kULAKBURUNBOĞAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kulak, Burun ve Boğaz Hastalıkları bölümleri Acıbadem Sağlık Grubu hastanelerinde ve tıp merkezlerinde hizmet vermektedir. Multidisiplinler yaklaşım ile kulak, burun, boğaz ve ilgili baş boyun hastalıklarının hem medikal hem de cerrahi tedavisi yapılmaktadır. ");

        }

        private void iÇHASTALIKLARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acıbadem Sağlık Grubu İç Hastalıkları bölümlerinde genel iç hastalıklarının yanında hematoloji, onkoloji, nefroloji, endokrinoloji, kardiyoloji, romatoloji ve gastroenteroloji dallarında hizmet verilmektedir. Hastanelerimizde yatan hastaların tedavilerini, konsültasyonlarını, ameliyat öncesi hazırlıklarını ve gerekli girişimlerini İç Hastalıkları bölümümüz gerçekleştirmektedir.");

        }

        private void gÖZHASTALIKLARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acıbadem Sağlık Grubu göz hastalıkları kliniğinde her hastaya rutin göz muayenesi hizmeti verilmekte, kontak lens ve gözlük uygulamaları yapılmaktadır. Tetkik ünitelerinde verilen hizmetler arasında; ultrasonografi, bilgisayarlı görme alanı testleri, göz anjioları ve elektrofizyolojik testler yer almaktadır. Özel servisler arasında prematüre bebeklerin retina kontrolü de bulunmaktadır.");

        }

        private void aDRESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fahrettin Kerim Gökay Caddesi No:49 34662 Altunizade / Üsküdar / İSTANBUL");

        }

        private void tELEFONNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+90 216 544 3800");

        }

        private void hAKKINDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Acıbadem Holding veya Acıbadem Sağlık Yatırımları Holding A.Ş., İstanbul merkezli holding kuruluşu. Şirketin yönetim kurulu başkanlığını eski TFF başkanı Mehmet Ali Aydınlar yapmaktadır.1991 yılında İstanbul'da kurulmuştur.", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Anaekran_Load(object sender, EventArgs e)
        {

        }
    }
}
