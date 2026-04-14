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
            int number;
            if (int.TryParse(textBox1.Text, out number))
            {
                if (number % 2 == 0)
                {
                    textBox2.Text = "число парне";
                }
                else
                {
                    textBox2.Text = "число непарне";
                }
            }
        }

    }
}
