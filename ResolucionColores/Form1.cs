namespace Colorama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rng = new Random();
        List<Button> botones = new List<Button>();

        Button? botonSeleccionado1 = null;
        Button? botonSeleccionado2 = null;
        Color colorObjetivo;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Instanciamos los botones y los agregamos a la lista.
            for (int i = 1; i <= 8; i++)
            {
                Button? boton = this.Controls["button" + i.ToString()] as Button;
                if (boton != null)
                    botones.Add(boton);
                if (boton != null)
                {
                    boton.Click += Boton_Click;
                }   
            }

            // Creamos un color objetivo.
            button9.BackColor = Color.FromArgb(
                rng.Next(256), 
                rng.Next(256), 
                rng.Next(256)
            );
            button9.Size = new Size(270, 50);
            button9.Text = "COLOR OBJETIVO";
            button9.ForeColor = Color.White;

            colorObjetivo = button9.BackColor;



            // Asignamos un color aleatorio a cada botón.
            foreach (Button boton in botones)
            {
                boton.BackColor = Color.FromArgb(
                    rng.Next(0, colorObjetivo.R), 
                    rng.Next(0, colorObjetivo.G), 
                    rng.Next(0, colorObjetivo.B)
                );
                boton.Size = new Size(50, 50);
                boton.Text = "";
                
            }


            // Seleccionmos un color aleatoriamente entre las variaciones y calculamos su sumplementario.
            var colorASumplementar = botones[rng.Next(botones.Count)].BackColor;
            
            var colorSuplementario = Color.FromArgb(
                colorObjetivo.R-colorASumplementar.R,
                colorObjetivo.G- colorASumplementar.G,
                colorObjetivo.B- colorASumplementar.B
            );

            button8.BackColor = colorSuplementario;
        }


        private void Boton_Click(object? sender, EventArgs e)
        {
            if (sender is Button boton)
            {
                if (botonSeleccionado1 == null)
                {
                    botonSeleccionado1 = boton;
                    boton.FlatStyle = FlatStyle.Flat;
                    boton.FlatAppearance.BorderColor = Color.Yellow;
                    boton.FlatAppearance.BorderSize = 3;
                }
                else if (botonSeleccionado2 == null && boton != botonSeleccionado1)
                {
                    botonSeleccionado2 = boton;
                    boton.FlatStyle = FlatStyle.Flat;
                    boton.FlatAppearance.BorderColor = Color.Yellow;
                    boton.FlatAppearance.BorderSize = 3;

                    // Con los dos seleccionados, comprobamos la suma.
                    ComprobarSuma();
                }
                else
                {
                    // Reiniciar selección si ya hay dos seleccionados
                    Reiniciar();
                    botonSeleccionado1 = boton;
                    boton.FlatStyle = FlatStyle.Flat;
                    boton.FlatAppearance.BorderColor = Color.Yellow;
                    boton.FlatAppearance.BorderSize = 3;
                }
            }
        }

        private void ComprobarSuma()
        {
            if (botonSeleccionado1 != null && botonSeleccionado2 != null)
            {
                int red = botonSeleccionado1.BackColor.R + botonSeleccionado2.BackColor.R;
                int green = botonSeleccionado1.BackColor.G + botonSeleccionado2.BackColor.G;
                int blue = botonSeleccionado1.BackColor.B + botonSeleccionado2.BackColor.B;

                // Comprobamos si la suma de los colores es igual al color objetivo.
                if (red == colorObjetivo.R && green == colorObjetivo.G && blue == colorObjetivo.B)
                {
                    MessageBox.Show("¡Correcto!");
                }
                else
                {
                    MessageBox.Show("Incorrecto");
                }

                Reiniciar();
            }
        }

        private void Reiniciar()
        {
            if (botonSeleccionado1 != null)
            {
                botonSeleccionado1.FlatAppearance.BorderSize = 0;
            }
            if (botonSeleccionado2 != null)
            {
                botonSeleccionado2.FlatAppearance.BorderSize = 0;
            }
            botonSeleccionado1 = null;
            botonSeleccionado2 = null;
        }
    }
}
