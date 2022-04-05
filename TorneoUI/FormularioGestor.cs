namespace TorneoUI
{
    public partial class FormularioGestor : Form
    {
        public FormularioGestor()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
          
        }

        private void FormularioVistaTorneo_Load(object sender, EventArgs e)
        {
            Show();
            this.SendToBack();
            //creo un formulario de log y lo mando al frente
            FormularioLogIn formLogIn = new ();
            formLogIn.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearTorneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioCrearTorneo formtorneo = new ();
            
        }

        private void altaDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioCrearEquipo formAltaEquipo = new ();
        }

        private void etcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verTorneosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioDashboardTorneos formularioDashboardTorneos = new FormularioDashboardTorneos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}