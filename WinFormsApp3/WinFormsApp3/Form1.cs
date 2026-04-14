namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            if (int.TryParse(textBox1.Text, out a) && int.TryParse(textBox2.Text, out b))
                if (a > b)
                {
                    textBox3.Text = ">";
                }
                else if (a < b)
                {
                    textBox3.Text = "<";
                }
                else if (a == b)
                 {  
                    textBox3.Text = "=";
                 }    


        }
    }
}
