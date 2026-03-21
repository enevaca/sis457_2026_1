namespace TresEnRaya
{
    public partial class FrmJuego : Form
    {
        bool turnoJugadorX;
        int turnos;
        Button[] botones;

        public FrmJuego()
        {
            InitializeComponent();
            turnos = 0;
            turnoJugadorX = new Random().Next(2) == 0;
            lblTurno.Text = "Turno: " + (turnoJugadorX ? "X" : "O");
            botones = [btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9];
        }

        private void marcar_Click(object sender, EventArgs e)
        {
            Button botonClikeado = (Button)sender;
            if (botonClikeado.Text == "")
            {
                botonClikeado.Text = turnoJugadorX ? "X" : "O";
                botonClikeado.ForeColor = turnoJugadorX ? Color.Black : Color.Red;
                lblTurno.Text = "Turno: " + (turnoJugadorX ? "O" : "X");

                turnoJugadorX = !turnoJugadorX;
                turnos++;
                //botonClikeado.Enabled = false;
                lblTurno.Focus();
                comprobarGanador();
            }
        }

        private void comprobarGanador() 
        {
            bool hayGanadar = false;
            int[,] combinaciones = new int[,]
            {
                { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, // Filas
                { 0, 3, 6 }, { 1, 4, 7}, { 2, 5, 8 }, // Columnas
                { 0, 4, 8 }, { 2, 4, 6 } // Diagonales
            };

            for (int i = 0; i < combinaciones.GetLength(0); i++)
            {
                int coincidencia1 = combinaciones[i, 0];
                int coincidencia2 = combinaciones[i, 1];
                int coincidencia3 = combinaciones[i, 2];

                if (botones[coincidencia1].Text != "" &&
                    botones[coincidencia1].Text == botones[coincidencia2].Text &&
                    botones[coincidencia2].Text == botones[coincidencia3].Text)
                {
                    MessageBox.Show($"¡El jugador {botones[coincidencia1].Text} ha ganado!", 
                        "Juego Terminado");
                    hayGanadar = true;
                    desabilitarBotones();
                    actualizarResultados(botones[coincidencia1].Text);
                    break;
                }
            }

            if (!hayGanadar && turnos == 9)
            {
                MessageBox.Show("¡Empate!", "Juego Terminado");
                actualizarResultados("");
            }
        }

        private void desabilitarBotones()
        {
            foreach (Button boton in botones) boton.Enabled = false;
        }

        private void actualizarResultados(string ganador)
        {
            switch (ganador)
            {
                case "X": lblVictoriasX.Text = (int.Parse(lblVictoriasX.Text) + 1).ToString(); break;
                case "O": lblVictoriasO.Text = (int.Parse(lblVictoriasO.Text) + 1).ToString(); break;
                default: lblEmpates.Text = (int.Parse(lblEmpates.Text) + 1).ToString(); break;
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            turnos = 0;
            turnoJugadorX = new Random().Next(2) == 0;
            lblTurno.Text = "Turno: " + (turnoJugadorX ? "X" : "O");

            foreach (Button boton in botones)
            {
                boton.Text = string.Empty; // ""
                boton.Enabled = true;
            }
        }
    }
}
