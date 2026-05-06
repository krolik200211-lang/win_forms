using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace _14043
{
    public partial class Form1 : Form
    {
        string filePath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "";

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Текстові файли (*.txt)|*.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                textBox1.Text = File.ReadAllText(filePath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filePath == "")
            {
                MessageBox.Show("Спочатку відкрийте файл!");
                return;
            }
            File.WriteAllText(filePath, textBox1.Text);
            MessageBox.Show("Збережено!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Текстові файли (*.txt)|*.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                File.WriteAllText(filePath, textBox1.Text);
                MessageBox.Show("Збережено!");
            }
        }
    }
}
