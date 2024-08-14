using CiclismoDesktopPorCodigo.Views;

namespace CiclismoDesktopPorCodigo
{
    public partial class MenuPrincipaViews : Form
    {
        public MenuPrincipaViews()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gesionarClientensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesView clientesView = new ClientesView();
            clientesView.ShowDialog();
        }
    }
}
