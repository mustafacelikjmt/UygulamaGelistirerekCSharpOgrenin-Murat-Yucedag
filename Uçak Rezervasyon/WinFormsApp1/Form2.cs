using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string deger;
            deger = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = deger;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota " + comboBox1.Text + " - " + comboBox2.Text + " Tarih: " + dateTimePicker1.Text + maskedTextBox2.Text + " Yolcu bilgileri. Adı Soyadı: " + textBox3.Text + " TC: " + maskedTextBox3.Text + " Telefon: " + maskedTextBox4.Text);
            MessageBox.Show("Yolcu kaydı yapıldı.");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
