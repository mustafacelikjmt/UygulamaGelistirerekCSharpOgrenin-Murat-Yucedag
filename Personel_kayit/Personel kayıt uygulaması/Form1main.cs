using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
    public partial class Form1main : Form
    {
        SqlConnection bgla = BaglantiSinif.bagla;
        /*public SqlConnection baglanti()
        {
            
            return new SqlConnection(bgl.Adres);
        }*/

        //SqlConnection baglanti = new SqlConnection("Data Source=VICTUS-16-JMT\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        Boolean medenihal;
        public void list()
        {
            this.per_TableTableAdapter.Fill(this.personelVeriTabaniDataSet.Per_Table);
        }

        public Form1main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelVeriTabaniDataSet.Per_Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            list();
        }

        /*private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("kapatılıyor");
            Form4giris frm4 = new Form4giris();
            frm4.Close();
            Application.Exit();
            
        }*/

        private void buttonlistele_Click(object sender, EventArgs e)
        {
            list();
        }

        private void buttonkaydet_Click(object sender, EventArgs e)
        {
            bgla.Open();
            SqlCommand komutekle = new SqlCommand("insert into Per_table (perad,persoyad,Perşehir,PerMaas,permeslek,perdurum) values (@ad,@soyad,@sehir,@maas,@meslek,@durum)", bgla);
            komutekle.Parameters.AddWithValue("@ad", textBoxad.Text);
            komutekle.Parameters.AddWithValue("@soyad", textBoxsoyad.Text);
            komutekle.Parameters.AddWithValue("@sehir", comboBoxsehir.Text);
            komutekle.Parameters.AddWithValue("@maas", maskedTextBoxmaas.Text);
            komutekle.Parameters.AddWithValue("@meslek", textBoxmeslek.Text);
            komutekle.Parameters.AddWithValue("@durum", medenihal);
            /*if (radioButtonevli.Checked == true)
            {
                komutekle.Parameters.AddWithValue("@durum", 1);
            }
            else { komutekle.Parameters.AddWithValue("@durum", 0); }*/

            komutekle.ExecuteNonQuery(); //tabloda değişim yapılan sorguları çalıştırmaya yarar
            bgla.Close();
            list();
            MessageBox.Show("Ekleme Başarılı");
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            bgla.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Per_table where personelid=@sil", bgla);
            komutsil.Parameters.AddWithValue("@sil", textBoxid.Text);
            komutsil.ExecuteNonQuery();
            bgla.Close();
            MessageBox.Show("Kayıt silindi.");
            list();
        }

        private void radioButtonevli_CheckedChanged(object sender, EventArgs e)
        {
            medenihal = true;
        }

        private void radioButtonbekar_CheckedChanged(object sender, EventArgs e)
        {
            medenihal = false;
        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            bgla.Open();
            SqlCommand komutguncelle = new SqlCommand("update per_table Set perad=@ad,persoyad=@soyad,perşehir=@sehir,permaas=@maas,perdurum=@durum,permeslek=@meslek where personelid=@id", bgla);
            komutguncelle.Parameters.AddWithValue("@ad", textBoxad.Text);
            komutguncelle.Parameters.AddWithValue("@soyad", textBoxsoyad.Text);
            komutguncelle.Parameters.AddWithValue("@sehir", comboBoxsehir.Text);
            komutguncelle.Parameters.AddWithValue("@maas", maskedTextBoxmaas.Text);
            komutguncelle.Parameters.AddWithValue("@meslek", textBoxmeslek.Text);
            komutguncelle.Parameters.AddWithValue("@durum", medenihal);
            komutguncelle.Parameters.AddWithValue("@id", textBoxid.Text);
            komutguncelle.ExecuteNonQuery();
            bgla.Close();
            list();
        }

        private void buttontemizle_Click(object sender, EventArgs e)
        {
            textBoxid.Text = "";
            textBoxad.Text = "";
            textBoxsoyad.Text = "";
            textBoxmeslek.Text = "";
            maskedTextBoxmaas.Text = "";
            comboBoxsehir.Text = "";
            radioButtonevli.Checked = false;
            radioButtonbekar.Checked = false;
            textBoxad.Focus();


            //backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            //backgroundWorker1.RunWorkerAsync();
        }

        private void buttonistatistik_Click(object sender, EventArgs e)
        { //sql de Count sayaç Sum toplama Avg ortalama verir
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void buttongrafikler_Click(object sender, EventArgs e)
        {
            Form3grafik frm3 = new Form3grafik();
            frm3.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; //seçilerek çağrılan hücrenin [0.] sütununun satır indexi

            textBoxid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString(); //datagridde seçilen satırın 0. hücre değerini stringe dönüştürür
            textBoxad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBoxsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBoxmaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            //var hata = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            try
            {
                medenihal = (bool)dataGridView1.Rows[secilen].Cells[5].Value;
                if (medenihal == true)
                { //label in text changed özelliği ilede yazabilirsin ama ben pek sevmedim.
                    radioButtonevli.Checked = true;
                    //MessageBox.Show("if çalıştı" + @hata);
                }
                else
                {
                    radioButtonbekar.Checked = true; //MessageBox.Show("else çalıştı" + @hata); 
                }//yorum satırı yaptığımız kodlarla anladıkki bazı verilerde istediğimiz bool değeri boş değer geliyor hatamızın kaynağı burası
            }
            catch (Exception ex) //bazı verilerde hata veriyordu hata vermesini önledik
            {
                radioButtonevli.Checked = false;
                radioButtonbekar.Checked = false;
                MessageBox.Show("medeni durum bilinmiyor");
            }
            textBoxmeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void textBoxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5rapor frm5 = new Form5rapor();
            frm5.Show();

        }

        private void buttontest_Click(object sender, EventArgs e)
        {
            //BaglantiSinif ads= new BaglantiSinif();
            //MessageBox.Show(baglanti().ToString());
            //MessageBox.Show(ads.Adres);
        }//System.Data.SqlClient.SqlConnection

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Eğer yeni bir satır eklenmişse uyarı gösterme
            if (e.Result != null && (int)e.Result > 0)
            {
                MessageBox.Show("Alert:Yeni veri eklendi!");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {/*
            // SqlCommand nesnesi oluşturma ve SQL sorgusunu ayarlama
            string sqlCommandText = "insert into Per_table (perad,persoyad,Perşehir,PerMaas,permeslek,perdurum) values (@ad,@soyad,@sehir,@maas,@meslek,@durum); SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(sqlCommandText, bgla);

            // SqlCommand nesnesine parametreler eklemek
            command.Parameters.AddWithValue("@ad", textBoxad.Text);
            command.Parameters.AddWithValue("@soyad", textBoxsoyad.Text);
            command.Parameters.AddWithValue("@sehir", comboBoxsehir.Text);
            command.Parameters.AddWithValue("@maas", maskedTextBoxmaas.Text);
            command.Parameters.AddWithValue("@meslek", textBoxmeslek.Text);
            command.Parameters.AddWithValue("@durum", medenihal);

            // Veritabanı bağlantısını açma
            bgla.Open();

            // SqlCommand'ı çalıştırma ve yeni eklenen satırın kimliğini döndürme
            int newId = (int)command.ExecuteScalar();

            // Yeni eklenen satırın kimliğini "e.Result" parametresine ata
            e.Result = newId;
            */
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
