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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 yeniForm = new Form2(); // Yeni pencereyi olu�tur
            yeniForm.Show(); // Yeni pencereyi a�
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rula frmrula = new rula(); // Yeni pencereyi olu�tur
            frmrula.Show(); // Yeni pencereyi a�
            this.Hide();
        }
    }
}
