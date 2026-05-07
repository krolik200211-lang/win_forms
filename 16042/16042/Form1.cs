using System;
using System.Windows.Forms;
using System.Drawing;
namespace _16042
{
    public partial class Form1 : Form
    {
        Button[,] btn = new Button[8, 8];
        bool[,] міна = new bool[8, 8];
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Сапер";
            this.Size = new Size(420, 470);

            for (int r = 0; r < 8; r++)
                for (int c = 0; c < 8; c++)
                {
                    btn[r, c] = new Button();
                    btn[r, c].Size = new Size(45, 45);
                    btn[r, c].Location = new Point(c * 47 + 10, r * 47 + 10);
                    btn[r, c].Tag = r * 8 + c;
                    btn[r, c].Click += Клік;
                    this.Controls.Add(btn[r, c]);
                }

            НоваГра();
        }

        void НоваГра()
        {
            for (int r = 0; r < 8; r++)
                for (int c = 0; c < 8; c++)
                {
                    btn[r, c].Text = "";
                    btn[r, c].Enabled = true;
                    btn[r, c].BackColor = SystemColors.Control;
                    міна[r, c] = false;
                }

            int к = 0;
            while (к < 10)
            {
                int r = rnd.Next(8), c = rnd.Next(8);
                if (!міна[r, c]) { міна[r, c] = true; к++; }
            }
        }

        void Клік(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int row = (int)b.Tag / 8;
            int col = (int)b.Tag % 8;

            if (міна[row, col])
            {
                b.BackColor = Color.Red;
                b.Text = "МІНА";
                MessageBox.Show("Програш! Нова гра.");
                НоваГра();
                return;
            }

            int count = 0;
            for (int dr = -1; dr <= 1; dr++)
                for (int dc = -1; dc <= 1; dc++)
                {
                    int r = row + dr, c = col + dc;
                    if (r >= 0 && r < 8 && c >= 0 && c < 8 && міна[r, c]) count++;
                }

            b.Text = count > 0 ? count.ToString() : "";
            b.BackColor = Color.LightGray;
            b.Enabled = false;
        }
    }
}
