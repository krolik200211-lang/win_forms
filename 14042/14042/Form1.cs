namespace _14042
{
    public partial class Form1 : Form
    {
       
        string player = "X";

       
        Button b1, b2, b3, b4, b5, b6, b7, b8, b9;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Хрестики-Ноліки";
            this.Size = new Size(320, 360);

            b1 = new Button(); b1.Text = ""; b1.Width = 90; b1.Height = 90; b1.Left = 10; b1.Top = 10; b1.Font = new Font("Arial", 36); b1.Click += Хід;
            b2 = new Button(); b2.Text = ""; b2.Width = 90; b2.Height = 90; b2.Left = 105; b2.Top = 10; b2.Font = new Font("Arial", 36); b2.Click += Хід;
            b3 = new Button(); b3.Text = ""; b3.Width = 90; b3.Height = 90; b3.Left = 200; b3.Top = 10; b3.Font = new Font("Arial", 36); b3.Click += Хід;

            b4 = new Button(); b4.Text = ""; b4.Width = 90; b4.Height = 90; b4.Left = 10; b4.Top = 105; b4.Font = new Font("Arial", 36); b4.Click += Хід;
            b5 = new Button(); b5.Text = ""; b5.Width = 90; b5.Height = 90; b5.Left = 105; b5.Top = 105; b5.Font = new Font("Arial", 36); b5.Click += Хід;
            b6 = new Button(); b6.Text = ""; b6.Width = 90; b6.Height = 90; b6.Left = 200; b6.Top = 105; b6.Font = new Font("Arial", 36); b6.Click += Хід;

            b7 = new Button(); b7.Text = ""; b7.Width = 90; b7.Height = 90; b7.Left = 10; b7.Top = 200; b7.Font = new Font("Arial", 36); b7.Click += Хід;
            b8 = new Button(); b8.Text = ""; b8.Width = 90; b8.Height = 90; b8.Left = 105; b8.Top = 200; b8.Font = new Font("Arial", 36); b8.Click += Хід;
            b9 = new Button(); b9.Text = ""; b9.Width = 90; b9.Height = 90; b9.Left = 200; b9.Top = 200; b9.Font = new Font("Arial", 36); b9.Click += Хід;

            this.Controls.Add(b1); this.Controls.Add(b2); this.Controls.Add(b3);
            this.Controls.Add(b4); this.Controls.Add(b5); this.Controls.Add(b6);
            this.Controls.Add(b7); this.Controls.Add(b8); this.Controls.Add(b9);

            Button reset = new Button();
            reset.Text = "Нова гра";
            reset.Width = 280;
            reset.Height = 40;
            reset.Left = 10;
            reset.Top = 295;
            reset.Font = new Font("Arial", 12);
            reset.Click += (s, e) => Скинути();
            this.Controls.Add(reset);
            this.Size = new Size(320, 400); // трохи збільшуємо вікно
        }

        void Хід(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Text != "") return; 

            b.Text = player; 

           
            if (
                
                Рівні(b1, b2, b3) || Рівні(b4, b5, b6) || Рівні(b7, b8, b9) ||
             
                Рівні(b1, b4, b7) || Рівні(b2, b5, b8) || Рівні(b3, b6, b9) ||
                
                Рівні(b1, b5, b9) || Рівні(b3, b5, b7)
            )
            {
                MessageBox.Show("Переміг: " + player );
                Скинути();
                return;
            }

           
            if (player == "X") player = "O";
            else player = "X";
        }

        
        bool Рівні(Button a, Button b, Button c)
        {
            return a.Text != "" && a.Text == b.Text && b.Text == c.Text;
        }

        void Скинути()
        {
            b1.Text = ""; b2.Text = ""; b3.Text = "";
            b4.Text = ""; b5.Text = ""; b6.Text = "";
            b7.Text = ""; b8.Text = ""; b9.Text = "";
            player = "X";
        }
    }
}
