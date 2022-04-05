using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneoUI
{
    public partial class FormularioLogIn : Form
    {
        public FormularioLogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                this.Close();
            }
            
        }

        private void FormularioLogIn_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void btnSalirLogIn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
