namespace Arboles
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btnClick_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Trim().Equals("unad", StringComparison.OrdinalIgnoreCase))
            {
                // El texto es "unad", permitir el acceso
                MessageBox.Show("Acceso permitido");
                Form menu = new Menu();
                menu.Show(this);

            }
            else
            {
                // El texto no es "unad", mostrar un mensaje de error
                MessageBox.Show("Texto incorrecto. Acceso denegado.");
                // Coloca aquí la lógica adicional para denegar el acceso
            }
        }
    }
}