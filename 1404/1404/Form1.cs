namespace _1404
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

         
            button1.MouseEnter += button1_MouseEnter;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Left = rnd.Next(0, this.Width - button1.Width - 20);
            button1.Top = rnd.Next(0, this.Height - button1.Height - 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Зловив! Молодець!");
        }


    }
}
