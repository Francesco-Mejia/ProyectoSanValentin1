namespace ProyectoSanValentin1
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            // Formulario
            this.Text = "¡San Valentin!";
            this.Size = new Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.HotPink;

            // Tag Pregunta
            Label lblPregunta = new Label();
            lblPregunta.Text = "¿QUIERES SER MI SAN VALENTIN?";
            lblPregunta.Font = new Font("Arial", 18, FontStyle.Bold);
            lblPregunta.ForeColor = Color.White;
            lblPregunta.AutoSize = true;
            lblPregunta.Location = new Point((this.ClientSize.Width - lblPregunta.Width) / 2, 50);
            this.Controls.Add(lblPregunta);

            // Botón SI
            Button btnSi = new Button();
            btnSi.Text = "SI";
            btnSi.Size = new Size(120, 60);
            btnSi.Font = new Font("Arial", 14, FontStyle.Bold);
            btnSi.BackColor = Color.LightGreen;
            btnSi.Location = new Point(
                (this.ClientSize.Width / 2) - 130,
                this.ClientSize.Height / 2
            );
            btnSi.Click += BtnSi_Click;
            this.Controls.Add(btnSi);

            // Botón NO
            Button btnNo = new Button();
            btnNo.Text = "NO";
            btnNo.Size = new Size(120, 60);
            btnNo.Font = new Font("Arial", 14, FontStyle.Bold);
            btnNo.BackColor = Color.Salmon;
            btnNo.MouseEnter += BtnNo_MouseMove;
            this.Controls.Add(btnNo);
            MoverBoton(btnNo);
        }

        private void BtnSi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Gracias por escogerme un año más, te amo mucho.\nNos esperamos el viernes 14 de febrero para pasar un día inolvidable.",
                "¡Feliz San Valentin!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            Application.Exit();
        }

        private void BtnNo_MouseMove(object sender, EventArgs e)
        {
            MoverBoton((Button)sender);
        }

        private void MoverBoton(Button boton)
        {
            int maxX = this.ClientSize.Width - boton.Width;
            int maxY = this.ClientSize.Height - boton.Height;

            boton.Location = new Point(
                random.Next(0, maxX),
                random.Next(0, maxY)
            );
        }
    }
}
