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
using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography;

namespace Dosya_işlemleri
{
    public partial class Form3notekle : Form
    {
        public Form3notekle()
        {
            InitializeComponent();
        }
        //public string dosyaadi, dosyayolu;
        //StreamWriter yaz;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            /*string dyol = frm1.dosyayolu;
            string dad = frm1.dosyaadi;*/
            saveFileDialog1.Filter = "Metin Dosyaları|*.txt";
            saveFileDialog1.Title = "Not Kaydet";
            saveFileDialog1.ShowDialog();
            /*FileStream dosya = new FileStream(dyol + "//" + dad + ".txt", FileMode.Create);
            StreamWriter yazıcı = new StreamWriter(dosya);
            yazıcı.WriteLine(richTextBox1.Text);
            yazıcı.Close();
            dosya.Close();
            //olmiy*/
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();
            MessageBox.Show("Notunuz Kaydedildi");
            
            
            



            this.Close();
            frm1.Show();
        }
    }
}
