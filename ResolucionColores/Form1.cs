namespace ResolucionColores
{
    public partial class Form1 : Form
    {
        int playerChoice=0;
        CheckBox[] randomizados;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColorObjetivo.BackColor = Color.FromArgb(199, 233, 122);
            ColorObjetivo.Text = ColorObjetivo.BackColor.ToString();
            checkBox1.BackColor = RandomColor(ColorObjetivo.BackColor.R, ColorObjetivo.BackColor.G, ColorObjetivo.BackColor.B);

            checkBox2.BackColor = RandomColor(ColorObjetivo.BackColor.R, ColorObjetivo.BackColor.G, ColorObjetivo.BackColor.B);
            checkBox3.BackColor = RandomColor(ColorObjetivo.BackColor.R, ColorObjetivo.BackColor.G, ColorObjetivo.BackColor.B);
            checkBox4.BackColor = RandomColor(ColorObjetivo.BackColor.R, ColorObjetivo.BackColor.G, ColorObjetivo.BackColor.B);
            checkBox5.BackColor = RandomColor(ColorObjetivo.BackColor.R, ColorObjetivo.BackColor.G, ColorObjetivo.BackColor.B);
            randomizados = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5 };
            foreach (CheckBox checkBox in randomizados)
            {
                checkBox.Text = checkBox.BackColor.ToString();
            }

            Random rand2 = new Random();
            int indice = rand2.Next(0, randomizados.Length);

            this.Text = randomizados[indice].Text;
            int SR = ColorObjetivo.BackColor.R - randomizados[indice].BackColor.R;
            int SG = ColorObjetivo.BackColor.G - randomizados[indice].BackColor.G;
            int SB = ColorObjetivo.BackColor.B - randomizados[indice].BackColor.B;
            Color Solucion = Color.FromArgb(SR, SG, SB);
            checkBox6.BackColor = Solucion;
            checkBox6.Text = Solucion.ToString();
        }
        public Color RandomColor(int r, int g, int b)
        {
            Random rand = new Random();

            int newR = rand.Next(0, r);
            int newG = rand.Next(0, g);
            int newB = rand.Next(0, b);
            Color col = Color.FromArgb(newR, newG, newB);
            return col;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (playerChoice != 0 & checkBox1.Checked)
            {
                int r;
                int g;
                int b;
                if (playerChoice == 6)
                {
                    r = checkBox1.BackColor.R + checkBox6.BackColor.R;
                    g = checkBox1.BackColor.G + checkBox6.BackColor.G;
                    b = checkBox1.BackColor.B + checkBox6.BackColor.B;
                }
                else
                {
                    r = checkBox1.BackColor.R + randomizados[playerChoice - 1].BackColor.R;
                    g = checkBox1.BackColor.G + randomizados[playerChoice - 1].BackColor.G;
                    b = checkBox1.BackColor.B + randomizados[playerChoice - 1].BackColor.B;
                }
                if (r == ColorObjetivo.BackColor.R & g == ColorObjetivo.BackColor.G & b == ColorObjetivo.BackColor.B)
                {
                    MessageBox.Show("congratz!!");
                }
                else
                {
                    foreach (CheckBox box in randomizados)
                    {
                        box.Checked = false;
                    }
                    checkBox6.Checked = false;
                }
            }

            if (checkBox1.Checked) {
                playerChoice = 1;
            }
            else
            {
                playerChoice = 0;
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (playerChoice != 0 & checkBox2.Checked)
            {
                int r;
                int g;
                int b;
                if (playerChoice == 6)
                {
                    r = checkBox2.BackColor.R + checkBox6.BackColor.R;
                    g = checkBox2.BackColor.G + checkBox6.BackColor.G;
                    b = checkBox2.BackColor.B + checkBox6.BackColor.B;
                }
                else
                {
                    r = checkBox2.BackColor.R + randomizados[playerChoice - 1].BackColor.R;
                    g = checkBox2.BackColor.G + randomizados[playerChoice - 1].BackColor.G;
                    b = checkBox2.BackColor.B + randomizados[playerChoice - 1].BackColor.B;
                }
                if (r == ColorObjetivo.BackColor.R & g == ColorObjetivo.BackColor.G & b == ColorObjetivo.BackColor.B)
                {
                    MessageBox.Show("congratz!!");
                }
                else
                {
                    foreach (CheckBox box in randomizados)
                    {
                        box.Checked = false;
                    }
                    checkBox6.Checked = false;
                }
            }

            if (checkBox2.Checked)
            {
                playerChoice = 2;
            }
            else playerChoice = 0;
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (playerChoice != 0 & checkBox3.Checked)
            {
                int r;
                int g;
                int b;
                if (playerChoice == 6)
                {
                    r = checkBox3.BackColor.R + checkBox6.BackColor.R;
                    g = checkBox3.BackColor.G + checkBox6.BackColor.G;
                    b = checkBox3.BackColor.B + checkBox6.BackColor.B;
                }
                else
                {
                    r = checkBox3.BackColor.R + randomizados[playerChoice - 1].BackColor.R;
                    g = checkBox3.BackColor.G + randomizados[playerChoice - 1].BackColor.G;
                    b = checkBox3.BackColor.B + randomizados[playerChoice - 1].BackColor.B;
                }
                if (r == ColorObjetivo.BackColor.R & g == ColorObjetivo.BackColor.G & b == ColorObjetivo.BackColor.B)
                {
                    MessageBox.Show("congratz!!");
                }
                else
                {
                    foreach (CheckBox box in randomizados)
                    {
                        box.Checked = false;
                    }
                    checkBox6.Checked = false;
                }
            }

            if (checkBox3.Checked)
            {
                playerChoice = 3;
            }
            else
            {
                playerChoice = 0;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (playerChoice != 0 & checkBox4.Checked)
            {
                int r;
                int g;
                int b;
                if (playerChoice == 6)
                {
                    r = checkBox4.BackColor.R + checkBox6.BackColor.R;
                    g = checkBox4.BackColor.G + checkBox6.BackColor.G;
                    b = checkBox4.BackColor.B + checkBox6.BackColor.B;
                }
                else
                {
                    r = checkBox4.BackColor.R + randomizados[playerChoice - 1].BackColor.R;
                    g = checkBox4.BackColor.G + randomizados[playerChoice - 1].BackColor.G;
                    b = checkBox4.BackColor.B + randomizados[playerChoice - 1].BackColor.B;
                }
                if (r == ColorObjetivo.BackColor.R & g == ColorObjetivo.BackColor.G & b == ColorObjetivo.BackColor.B)
                {
                    MessageBox.Show("congratz!!");
                }
                else
                {
                    foreach (CheckBox box in randomizados)
                    {
                        box.Checked = false;
                    }
                    checkBox6.Checked = false;
                }
            }

            if (checkBox4.Checked)
            {
                playerChoice = 4;
            }
            else
            {
                playerChoice = 0;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (playerChoice!=0&checkBox5.Checked)
            {
                int r;
                int g;
                int b;
                if (playerChoice==6)
                {
                    r = checkBox5.BackColor.R +checkBox6.BackColor.R;
                    g = checkBox5.BackColor.G + checkBox6.BackColor.G;
                    b = checkBox5.BackColor.B + checkBox6.BackColor.B;
                }
                else
                {
                    r = checkBox5.BackColor.R + randomizados[playerChoice - 1].BackColor.R;
                    g = checkBox5.BackColor.G + randomizados[playerChoice - 1].BackColor.G;
                    b = checkBox5.BackColor.B + randomizados[playerChoice - 1].BackColor.B;
                }
                    
                if (r==ColorObjetivo.BackColor.R&g==ColorObjetivo.BackColor.G&b==ColorObjetivo.BackColor.B)
                {
                    MessageBox.Show("congratz!!");
                }
                else
                {
                    foreach (CheckBox box in randomizados)
                    {
                        box.Checked = false;
                    }
                    checkBox6.Checked = false;
                }
            }

            if (checkBox5.Checked)
            {
                playerChoice = 5;
            }
            else
            {
                playerChoice = 0;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (playerChoice != 0 & checkBox6.Checked)
            {
                int r = checkBox6.BackColor.R + randomizados[playerChoice-1].BackColor.R;
                int g = checkBox6.BackColor.G + randomizados[playerChoice-1].BackColor.G;
                int b = checkBox6.BackColor.B + randomizados[playerChoice-1].BackColor.B;
                if (r == ColorObjetivo.BackColor.R & g == ColorObjetivo.BackColor.G & b == ColorObjetivo.BackColor.B)
                {
                    MessageBox.Show("congratz!!");
                }
                else
                {
                    
                    foreach (CheckBox box in randomizados)
                    {
                        box.Checked = false;
                    }
                    checkBox6.Checked = false;
                }
            }

            if (checkBox6.Checked)
            {
                playerChoice = 6;
            }
            else
            {
                playerChoice = 0;
            }
        }
    }

}
