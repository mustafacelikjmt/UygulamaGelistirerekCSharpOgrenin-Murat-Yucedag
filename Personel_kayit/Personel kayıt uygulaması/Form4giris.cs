using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_kayıt_uygulaması
{
    public partial class Form4giris : Form
    {
        SqlConnection bgla = BaglantiSinif.bagla;
        public Form4giris()
        {
            InitializeComponent();
        }

        private void buttongiris_Click(object sender, EventArgs e)
        {
            bgla.Open();
            SqlCommand komut1 = new SqlCommand("select * from table_giris where kullaniciad=@pnick and sifre=@ppassword", bgla);
            komut1.Parameters.AddWithValue("@pnick", textBoxkullaniciad.Text);
            komut1.Parameters.AddWithValue("@ppassword", textBoxsifre.Text);
            SqlDataReader dr = komut1.ExecuteReader();
            if (dr.Read()) {
                Form1main frm1 = new Form1main();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            bgla.Close();
        }

        private void Form4giris_Load(object sender, EventArgs e)
        {

        }
    }
}
