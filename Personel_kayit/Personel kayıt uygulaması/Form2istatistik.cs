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
    public partial class Form2 : Form
    {
        SqlConnection bgla = BaglantiSinif.bagla;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bgla.Open(); //toplam personel
            SqlCommand komut1 = new SqlCommand("select count(*) from Per_Table", bgla);
            SqlDataReader dr1 = komut1.ExecuteReader();
            dr1.Read();
            labeltoplampersonel.Text = dr1[0].ToString();  //hacı buda çalışıyo fazladan koyduğumuz while ne işe yarıyo allah bilir
            /*while (dr1.Read())
            {
                labeltoplampersonel.Text = dr1[0].ToString();
            }*/
            bgla.Close();

            bgla.Open(); //evli
            SqlCommand komut2 = new SqlCommand("select count(*) from Per_Table where perdurum=1", bgla);
            SqlDataReader dr2 = komut2.ExecuteReader();
            dr2.Read();
            labelevlipersonel.Text = dr2[0].ToString();
            bgla.Close();

            bgla.Open(); //bekar
            SqlCommand komut3 = new SqlCommand("select count(*) from Per_Table where perdurum=0", bgla);
            SqlDataReader dr3 = komut3.ExecuteReader();
            dr3.Read();
            labelbekarpersonel.Text = dr3[0].ToString();
            bgla.Close();

            bgla.Open(); //sehir
            SqlCommand komut4 = new SqlCommand("select count(distinct(perşehir)) from Per_Table", bgla);
            SqlDataReader dr4 = komut4.ExecuteReader();
            dr4.Read();
            labelsehir.Text = dr4[0].ToString();
            bgla.Close();

            bgla.Open(); //toplam maaş
            SqlCommand komut5 = new SqlCommand("select sum(permaas) from Per_Table", bgla);
            SqlDataReader dr5 = komut5.ExecuteReader();
            dr5.Read();
            labelmaas.Text = dr5[0].ToString();
            bgla.Close();

            bgla.Open(); //ortalama maaş
            SqlCommand komut6 = new SqlCommand("select avg(permaas) from Per_Table", bgla);
            SqlDataReader dr6 = komut6.ExecuteReader();
            dr6.Read();
            labelortmaas.Text = dr6[0].ToString();
            bgla.Close();


        }

        private void labeltoplampersonel_Click(object sender, EventArgs e)
        {

        }
    }
}