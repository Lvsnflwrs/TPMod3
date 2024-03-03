// Helmy Farikh Alfarizhi_1302220077
namespace TPMod3
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;

            // Menampilkan teks yang dimasukkan ke dalam Label
            label1.Text = "HALO " + inputText;
        }
    }
}
