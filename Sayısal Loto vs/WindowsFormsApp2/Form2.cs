using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        private void fonksiyon()
        {
            string[] sembol = { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "!", "+", "%", "&", "/", "=", "-", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            Random rnd = new Random();
            string s1, s2, s3, s4, s5, s6;
            s1 = sembol[rnd.Next(0, sembol.Length)];
            s2 = sembol[rnd.Next(0, sembol.Length)];
            s3 = sembol[rnd.Next(0, sembol.Length)];
            s4 = sembol[rnd.Next(0, sembol.Length)];
            s5 = sembol[rnd.Next(0, sembol.Length)];
            s6 = sembol[rnd.Next(0, sembol.Length)];
            label1.Text = s1 + s2 + s3 + s4 + s5 + s6;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fonksiyon();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fonksiyon();
        }

        


        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text != ""  && label1.Text == textBox1.Text)
            {
                MessageBox.Show("Giris Basarili.");
                
                Form1 ad = new Form1();
                ad.mesaj = textBox2.Text;
                ad.Show();
                this.Hide();

                }
            else { MessageBox.Show("Yanlıs Girdiniz."); }
        }
    }
}