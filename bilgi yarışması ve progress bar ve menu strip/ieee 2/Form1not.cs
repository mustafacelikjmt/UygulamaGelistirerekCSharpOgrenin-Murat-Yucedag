namespace ieee_2
{
    public partial class Form1not : Form
    {
        public Form1not()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) { }


        public float hesapla(float s1, float s2)
        {
            float ortalama = 0;
            ortalama = ((s1 * 3) + (s2 * 7)) / 10;
            return ortalama;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            float not1 = Convert.ToSingle(textBox1.Text);
            float not2 = Convert.ToSingle(textBox2.Text);

            //hesapla(not1,not2);
            //label3.Text = "Sonuç: " + ortalama.ToString();
            label3.Text = "Sonuç: " + Convert.ToString(hesapla(not1, not2));
        }
    }
}