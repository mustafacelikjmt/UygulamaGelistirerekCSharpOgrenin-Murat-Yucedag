using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public string mesaj;

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int say1, say2, say3, say4, tutan = 0;
            say1 = rnd.Next(1, 9);
            say2 = rnd.Next(1, 9);
            say3 = rnd.Next(1, 9);
            say4 = rnd.Next(1, 9);
            label1.Text = say1.ToString();
            label2.Text = say2.ToString();
            label3.Text = say3.ToString();
            label4.Text = say4.ToString();
            //bak aga alttaki if şartını say2 == Convert.ToInt16(textBox2.Text) gibi yaparsan boş değer verdiğinde hata verir çünki boş bişeyin dönüşümünü yapamaz.
            if (label1.Text == textBox1.Text && label2.Text == textBox2.Text && label3.Text == textBox3.Text && label4.Text == textBox4.Text)
            {
                BackColor = Color.Green;
                MessageBox.Show("Tebrikler kazandiniz");

            }
            else
            {
                BackColor = Color.Red;
                //System.Threading.Thread.Sleep(1000); //programı 1 saniye bekletir. kırmızı beyaz geçişi için kullanamadık.
                //BackColor = Color.White; //bunun yerine timeride kullanabilirsin
            }

            if (label1.Text == textBox1.Text)
            {
                tutan++;
                textBox1.BackColor = Color.Yellow;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if (label2.Text == textBox2.Text)
            {
                tutan++;
                textBox2.BackColor = Color.Yellow;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            if (label3.Text == textBox3.Text)
            {
                tutan++;
                textBox3.BackColor = Color.Yellow;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            if (label4.Text == textBox4.Text)
            {
                tutan++;
                textBox4.BackColor = Color.Yellow;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
            label5.Text = "Tutan " + tutan.ToString() + " sayı";

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        int tik = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = mesaj;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tik++;
            if (tik > 350)
            {
                timer1.Stop();
                timer2.Start();
            }

            label7.Text = tik.ToString();
            Point konum = new Point();
            konum.X = 55 + tik;
            konum.Y = 350;
            pictureBox1.Location = konum;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tik--;
            if (tik < 0)
            {
                timer2.Stop();
                timer1.Start();
            }

            label7.Text = tik.ToString();
            Point konum = new Point();
            konum.X = 55 + tik;
            konum.Y = 350;
            pictureBox1.Location = konum;
        }
        enum sehirler { x, adana, adıyaman, afyon, ağrı, amasya, ankara, antalya }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = "0";
            int plaka = Convert.ToInt16(textBox5.Text);
            sehirler s = (sehirler)plaka; //enumdan türetilen s = sehirlerin plakanıncı değeri
            label9.Text = s.ToString();
            /*matematik fonksiyonları: math.bilmemne gibi tanımlanır
             Abs=mutlak Ceil üste Floor alta yuvarlama pow üs alma sqrt kare kök.*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                TextBox txt= new TextBox();
                Point txtknm = new Point(730, 170 + i * 30);
                txt.Location= txtknm;
                txt.Name = "Textbox" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt);
            }
            //label için AutoSize gibi değerler var ve yükseklik genişlik değerleri içinde Height width gibi şeyleri kullan.
            //her özelliğini değiştirebilirsin burdan haberin ola
        }
    }
}
