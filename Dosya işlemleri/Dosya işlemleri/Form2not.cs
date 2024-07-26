using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosya_işlemleri
{
    public partial class Form2not : Form
    {
        public Form2not()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2not_Load(object sender, EventArgs e)
        {
            //Form3notekle frm3 = new Form3notekle();
            openFileDialog1.Filter = "Metin Dosyaları|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();

                while (satir != null)
                { //Add(oku.ReadToEnd()) yaparakta okutabilirsin ama ozaman satır boşluklarını es geçer.
                    listBox1.Items.Add(satir);
                    satir = oku.ReadLine();
                }

            }
            else
            {
                this.Close();
            }
            
        }
    }
}
