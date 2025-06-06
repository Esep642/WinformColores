namespace Colorama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rng = new();
        List<Button> botones = [];

        Button? botonSeleccionado1 = null;
        Button? botonSeleccionado2 = null;
        Button? botonSeleccionado3 = null;
        Color colorObjetivo;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Instanciamos los botones y los agregamos a la lista.
            for (int i = 1; i <= 8; i++)
            {
                Button? boton = this.Controls["button" + i.ToString()] as Button;
                if (boton != null)
                {
                    botones.Add(boton);
                    boton.Click += Boton_Click;
                }
            }

            // Creo un color objetivo aleatorio.
            colorObjetivo = Color.FromArgb(
                rng.Next(64, 256), // Para no irme a colores muy oscuros.
                rng.Next(64, 256),
                rng.Next(64, 256)
            );

            button9.BackColor = colorObjetivo;
            button9.Size = new Size(270, 50);
            button9.Text = "COLOR OBJETIVO";
            button9.ForeColor = Color.White;

            // Dividimos el color objetivo en tres partes que serán guardadas en el array partes.
            Color[] partes = DividirColorEnTres(colorObjetivo);


            // A la lista de los 3 colores generados le agregamos colores aleatorios hasta que tenga el mismo número de elementos que botones.
            List<Color> colores = new List<Color>(partes);
            while (colores.Count < botones.Count)
            {
                colores.Add(Color.FromArgb(
                    rng.Next(0, 256),
                    rng.Next(0, 256),
                    rng.Next(0, 256)
                ));
            }

            // Ordeno los elementos de la lista según un número aleatorio generado para cada color.
            colores = colores.OrderBy(colores => rng.Next()).ToList();

            // Asignamos los colores a los botones
            for (int i = 0; i < botones.Count; i++)
            {
                botones[i].BackColor = colores[i];
                botones[i].Size = new Size(50, 50);
                botones[i].Text = "";
            }
        }

        // Función que me divide un color en tres subcolores aleatorios.
        private Color[] DividirColorEnTres(Color color)
        {
            int r1 = rng.Next(0, color.R + 1);
            int r2 = rng.Next(0, color.R - r1 + 1);
            int r3 = color.R - r1 - r2;

            int g1 = rng.Next(0, color.G + 1);
            int g2 = rng.Next(0, color.G - g1 + 1);
            int g3 = color.G - g1 - g2;

            int b1 = rng.Next(0, color.B + 1);
            int b2 = rng.Next(0, color.B - b1 + 1);
            int b3 = color.B - b1 - b2;

            return
            [
                Color.FromArgb(r1, g1, b1),
                Color.FromArgb(r2, g2, b2),
                Color.FromArgb(r3, g3, b3)
            ];
        }

        // Handlers para button clicks
        private void Boton_Click(object? sender, EventArgs e)
        {
            if (sender is Button boton)
            {
                if (botonSeleccionado1 == null)
                {
                    botonSeleccionado1 = boton;
                    MarcarBoton(boton);
                }
                else if (botonSeleccionado2 == null && boton != botonSeleccionado1)
                {
                    botonSeleccionado2 = boton;
                    MarcarBoton(boton);
                }
                else if (botonSeleccionado3 == null && boton != botonSeleccionado1 && boton != botonSeleccionado2)
                {
                    botonSeleccionado3 = boton;
                    MarcarBoton(boton);
                    ComprobarSuma();
                }
                else
                {
                    Reiniciar();
                    botonSeleccionado1 = boton;
                    MarcarBoton(boton);
                }
            }
        }

        private static void MarcarBoton(Button boton)
        {
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderColor = Color.Yellow;
            boton.FlatAppearance.BorderSize = 3;
        }

        private void ComprobarSuma()
        {
            if (botonSeleccionado1 != null && botonSeleccionado2 != null && botonSeleccionado3 != null)
            {
                int red = botonSeleccionado1.BackColor.R + botonSeleccionado2.BackColor.R + botonSeleccionado3.BackColor.R;
                int green = botonSeleccionado1.BackColor.G + botonSeleccionado2.BackColor.G + botonSeleccionado3.BackColor.G;
                int blue = botonSeleccionado1.BackColor.B + botonSeleccionado2.BackColor.B + botonSeleccionado3.BackColor.B;

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
            Button?[] seleccionados = { botonSeleccionado1, botonSeleccionado2, botonSeleccionado3 };

            foreach (var boton in seleccionados)
            {
                if (boton != null)
                {
                    boton.FlatAppearance.BorderSize = 0;
                    boton.FlatStyle = FlatStyle.Standard;
                }
            }

            botonSeleccionado1 = null;
            botonSeleccionado2 = null;
            botonSeleccionado3 = null;
        }
    }
}
