namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price;
            if (int.TryParse(textBox1.Text, out price)) ;
            {
                int newPrice;
                if (price > 1000)
                {
                    newPrice = (int)(price * 0.9);
                    textBox2.Text = "новий прайс" + newPrice + "грн";

                }

                else
                {
                    newPrice = (int)(price * 0.95);
                    textBox2.Text = "новий прайс" + newPrice + "грн";

                }


            }


        }
    }
}
