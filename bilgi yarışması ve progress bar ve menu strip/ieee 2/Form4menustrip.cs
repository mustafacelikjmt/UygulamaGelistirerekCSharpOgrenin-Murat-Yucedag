using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ieee_2
{
    public partial class Form4menustrip : Form
    {
        public Form4menustrip()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            araba rb1 = new araba();
            rb1.renk = "renk: kirmizi";
            rb1.MARKA = "marka: bmw";
            rb1.model = "model: m3";
            rb1.hiz = 300;
            rb1.fiyat = 100000;
            rb1.durum = 's';
            rb1.motor = 2.5;
            rb1.YIL = -2015;
            rb1.sahip = "sahip: mustafa";
            rb1.plaka = "plaka: 34 jmt 42";
            

            listBox1.Items.Add(rb1.renk);
            listBox1.Items.Add(rb1.MARKA);
            listBox1.Items.Add(rb1.model);
            listBox1.Items.Add("hiz: " + Convert.ToString(rb1.hiz));
            listBox1.Items.Add("fiyat: " + Convert.ToString(rb1.fiyat));
            listBox1.Items.Add("durum: " + Convert.ToString(rb1.durum));
            listBox1.Items.Add("motor: " + Convert.ToString(rb1.motor));
            listBox1.Items.Add("yil: " + Convert.ToString(rb1.YIL));
            listBox1.Items.Add(rb1.sahip);
            listBox1.Items.Add(rb1.plaka);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("mustafa çelik", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
