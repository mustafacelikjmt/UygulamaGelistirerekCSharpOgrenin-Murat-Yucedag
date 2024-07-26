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
    public partial class Form3ortayakarisik : Form
    {
        public Form3ortayakarisik()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
           
            /*for (int i = 0; i < 6; i++)
            {
                listBox1.Items.Add(i);
            }*/
        }
        int sayac, saat, dakika, saniye = 0;
        
        int t5 = 0;
        private void timer5_Tick(object sender, EventArgs e)
        {
            
            
            if (t5 < 100)
            {
                t5++;
                progressBar5.Value = t5;
            }
            if (t5 == 100)
            {
                
                timer5.Stop();
                timer1.Stop();
            }
        }
        int t4 = 0;
        private void timer4_Tick(object sender, EventArgs e)
        {
            t4++;
            if (t4<=100)
            {
                progressBar4.Value = t4;
            }
            if (t4 == 101)
            {
                
                timer4.Stop();
                timer5.Start();
            }
        }
        int t3 = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            
            if (t3 % 20 == 10)
            {
                yukle.BackColor = Color.Bisque;
            }
            if(t3 % 20 == 0)
            {
                yukle.BackColor = Color.Azure;
            }
            if (t3<100)
            {
                t3++;
                progressBar3.Value = t3;
            }
            if (t3 == 100)
            {
                timer3.Stop();
                timer4.Start();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int t2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (t2 % 30 == 0) 
            {
                indir.Text = "indiriliyor...";
            }
            if (t2 % 30 == 10)
            {
                indir.Text = "indiriliyor.";
            }
            if (t2 % 30 == 20)
            {
                indir.Text = "indiriliyor..";
            }
            if (t2 < 100)
            {
                t2++;
                progressBar2.Value = t2;
            }
            
            if (t2 == 100) 
            {
                timer2.Stop();
                timer3.Start();
                
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 5)
            {
                this.BackColor = Color.Beige;
            }
            if (sayac == 10)
            {
                this.BackColor = Color.Red;
                sayac = 0;
            }*/
            timer2.Start();
            saniye++;
            label4.Text = saniye.ToString();
            progressBar1.Value = saniye;
            if (saniye == 60)
            {
                dakika++;
                label3.Text = dakika.ToString();
                saniye = 0;
                if (dakika == 4)
                {
                    saat++;
                    label2.Text = saat.ToString();
                    dakika = 0;
                }
            }
            

            
        }
    }
}
