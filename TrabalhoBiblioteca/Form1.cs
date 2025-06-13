
namespace TrabalhoBiblioteca
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btncadastrolivro_Click(object sender, EventArgs e)
        {
            cadstrolivro cadstrolivro = new cadstrolivro();
            cadstrolivro.Show();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrouser_Click(object sender, EventArgs e)
        {
            Cadastrarusuario cadastrarusuario = new Cadastrarusuario();
            cadastrarusuario.Show();
        }
    }
}
