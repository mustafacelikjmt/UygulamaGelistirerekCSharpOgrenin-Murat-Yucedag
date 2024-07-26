using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ieee_2
{
    public partial class Form2bilgiyarismasi : Form
    {
        private void Form2_Load(object sender, EventArgs e)
        {
        }
        public Form2bilgiyarismasi()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            label1.Visible = false;
            richTextBox1.Text = "Bilgi Yarismasina Hosgeldiniz.    Sorulari cevaplamak icin butonlari kullanabilirsiniz.";
        }
        int soruno = 0, qdogru = 0, qyanlis = 0;
        string cvp = "";
        void secim (string a)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            label1.Text = "Doğru cevap: " + cvp;
            if (a == cvp)
            {
                qdogru++;
                dogru.Text = qdogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                qyanlis++;
                yanlis.Text = qyanlis.ToString();
                pictureBox2.Visible = true;
            }
            label1.Visible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            soruno++;
            label1.Visible = false;
            soru.Text = soruno.ToString();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            if (soruno == 1)
            {
                richTextBox1.Text = "Türkiyenin başkenti neresidir?";
                button1.Text = "Ankara";
                button2.Text = "İstanbul";
                button3.Text = "izmir";
                button4.Text = "Bursa";
                cvp = "Ankara";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Türkiye Cumhuriyeti hangi yılda kurulmuştur";
                button1.Text = "1921";
                button2.Text = "1922";
                button3.Text = "1923";
                button4.Text = "1924";
                cvp = "1923";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Türkiyenin en kalabalık şehri neresidir?";
                button1.Text = "İstanbul";
                button2.Text = "Ankara";
                button3.Text = "İzmir";
                button4.Text = "Bursa";
                cvp = "İstanbul";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Türkiyenin en kalabalık ilçesi neresidir?";
                button1.Text = "Kadıköy";
                button2.Text = "Beşiktaş";
                button3.Text = "Beyoğlu";
                button4.Text = "Fatih";
                cvp = "Beyoğlu";
            }
            if (soruno == 5)
            {
                MessageBox.Show("Sorular Bitti");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secim (button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secim(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            secim(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            secim(button4.Text);
        }
    }
}