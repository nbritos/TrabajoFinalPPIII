﻿using System;
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
    public partial class FormularioCrearTorneo : Form
    {
        public FormularioCrearTorneo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
