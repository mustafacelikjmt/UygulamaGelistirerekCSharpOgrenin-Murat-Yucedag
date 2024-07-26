using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Dosya_işlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string dosyayolu, dosyaadi = "";
        public StreamWriter yaz;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) //oluştur
        {
            dosyaadi = textBox2.Text;
            yaz = File.CreateText(dosyayolu + "//" + dosyaadi + ".txt");
            yaz.Close();  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2not frm2 = new Form2not();
            frm2.Show();
            textBox1.Text = "C:\\Users\\musta\\Desktop";
            dosyayolu = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3notekle frm3 = new Form3notekle();
            frm3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) //dosya yolu alma
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyayolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = dosyayolu;
            }
        }
    }
}
