namespace TorneoUI
{
    partial class FormularioGestor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioGestor));
            this.lblCopyright = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearTorneoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTorneosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeJugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCopyright.CausesValidation = false;
            this.lblCopyright.Enabled = false;
            this.lblCopyright.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCopyright.Location = new System.Drawing.Point(658, 670);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(371, 21);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "2022 PIXI S.R.L. todos los derechos reservados";
            this.lblCopyright.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearTorneoToolStripMenuItem,
            this.verTorneosToolStripMenuItem,
            this.altaDeEquiposToolStripMenuItem,
            this.altaDeJugadoresToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // crearTorneoToolStripMenuItem
            // 
            this.crearTorneoToolStripMenuItem.Name = "crearTorneoToolStripMenuItem";
            this.crearTorneoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.crearTorneoToolStripMenuItem.Text = "Crear Torneo";
            this.crearTorneoToolStripMenuItem.Click += new System.EventHandler(this.crearTorneoToolStripMenuItem_Click);
            // 
            // verTorneosToolStripMenuItem
            // 
            this.verTorneosToolStripMenuItem.Name = "verTorneosToolStripMenuItem";
            this.verTorneosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.verTorneosToolStripMenuItem.Text = "Ver Torneos";
            this.verTorneosToolStripMenuItem.Click += new System.EventHandler(this.verTorneosToolStripMenuItem_Click);
            // 
            // altaDeEquiposToolStripMenuItem
            // 
            this.altaDeEquiposToolStripMenuItem.Name = "altaDeEquiposToolStripMenuItem";
            this.altaDeEquiposToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.altaDeEquiposToolStripMenuItem.Text = "Alta de equipos";
            this.altaDeEquiposToolStripMenuItem.Click += new System.EventHandler(this.altaDeEquiposToolStripMenuItem_Click);
            // 
            // altaDeJugadoresToolStripMenuItem
            // 
            this.altaDeJugadoresToolStripMenuItem.Name = "altaDeJugadoresToolStripMenuItem";
            this.altaDeJugadoresToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.altaDeJugadoresToolStripMenuItem.Text = "Alta de jugadores";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormularioGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1041, 700);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormularioGestor";
            this.Text = "                                                                                 " +
    "               Gestor de torneos";
            this.Load += new System.EventHandler(this.FormularioVistaTorneo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCopyright;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem crearTorneoToolStripMenuItem;
        private ToolStripMenuItem altaDeEquiposToolStripMenuItem;
        private ToolStripMenuItem altaDeJugadoresToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem verTorneosToolStripMenuItem;
    }
}