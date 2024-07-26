namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("merabalar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "mustafa";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "mustafa";
            label5.Text = "çelik";
            label6.Text = "mühendis";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Text = textBox1.Text;
        }
    }
}