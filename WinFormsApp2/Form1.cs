namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ortalama, vize, final;
            vize = Convert.ToDouble(numericUpDown1.Value);
            final = Convert.ToDouble(numericUpDown2.Value);
            ortalama = vize * 0.4 + final * 0.6;
            label1.Text = ortalama.ToString();

            if (ortalama <50 || final <50 )
            {
                label3.Text = "KALDI";
                this.ForeColor = Color.Red;
            }
            else
            {
                label3.Text = "GEÇTÝ";
                this.ForeColor = Color.Green;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}