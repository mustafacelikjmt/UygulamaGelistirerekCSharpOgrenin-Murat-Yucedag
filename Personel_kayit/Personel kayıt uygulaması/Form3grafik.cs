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
using System.Windows.Forms.DataVisualization.Charting;

namespace Personel_kayıt_uygulaması
{
    public partial class Form3grafik : Form
    {
        SqlConnection bgla = BaglantiSinif.bagla;
        public Form3grafik()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form3grafik_Load(object sender, EventArgs e)
        {
            bgla.Open();
            SqlCommand komutdr1 = new SqlCommand("select perşehir,count(*) from per_table group by perşehir", bgla);
            SqlDataReader dr1 = komutdr1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Şehirler"].Points.AddXY(dr1[0], dr1[1]);
            } //while nin ne işe yaradığı şimdi daha iyi anlaşılıyor, istatistik tablosunda kullanımı gereksizdi çünki sql sorgumuz zaten tüm veriyi tarıyordu
              //ancak grafiklerimizde gerekli çünki kodumuzun datareader komutu işlem yaptığı okuma yaptığı sürece çalışıp bütün verileri ayrı ayrı
              //okuyabilmesi için gerekiyor.
            bgla.Close();
            bgla.Open();
            SqlCommand komutdr2 = new SqlCommand("select permeslek,avg(permaas) from per_table group by permeslek", bgla);
            SqlDataReader dr2 = komutdr2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-maaş"].Points.AddXY(dr2[0], dr2[1]);
            }
            bgla.Close();
        }
    }
}
