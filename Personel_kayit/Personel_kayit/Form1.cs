using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_kayit
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti=new SqlConnection("Data Source=VICTUS-16-JMT\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        public void liste()
        {
            this.per_TableTableAdapter.Fill(this.personelVeriTabaniDataSet1.Per_Table);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelVeriTabaniDataSet1.Per_Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            liste();

        }

        private void buttonlistele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void buttonkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Per_Table (Perad,Persoyad,Persehir,permaas,permeslek) values (@ad,@soyad,@sehir)", baglanti);
            komut.Parameters.AddWithValue("@ad",textBoxad.Text);
            komut.Parameters.AddWithValue("@soyad",textBoxsoyad.Text);
            komut.ExecuteNonQuery(); //tabloda etkilenme durumu olduğunda kullanıyon sorguyu çalıştırmak için
            baglanti.Close();
            MessageBox.Show("personel eklendi");
            liste();
        }
    }
}
