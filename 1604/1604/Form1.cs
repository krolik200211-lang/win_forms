namespace _1604
{
    public partial class Form1 : Form
    {
        string[] images = {
    "https://i.imgflip.com/9fw6ow.jpg",
    "https://i.imgflip.com/9g1k2p.jpg",
    "https://i.imgflip.com/9fz3lm.jpg",
    "https://i.imgflip.com/a30bhu.jpg",
    "https://i.imgflip.com/9h2x1n.jpg"
        };
        int current = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            ShowImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (current > 0) current--;
            ShowImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (current < images.Length - 1) current++;
            ShowImage();
        }
        void ShowImage()
        {
            label1.Text = (current + 1) + " / " + images.Length;
            pictureBox1.ImageLocation = images[current];
        }
    }
}
