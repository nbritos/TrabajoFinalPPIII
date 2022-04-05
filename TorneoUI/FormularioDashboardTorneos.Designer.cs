namespace TorneoUI
{
    partial class FormularioDashboardTorneos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioDashboardTorneos));
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCerrarFormCrearTorneo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(102, 149);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(361, 28);
            this.comboBox2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(186, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 37);
            this.label4.TabIndex = 13;
            this.label4.Text = "Torneos creados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(196, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "DASHBOARD";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(186, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "CARGAR SELECCION";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.DarkGreen;
            this.button2.Location = new System.Drawing.Point(221, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 75);
            this.button2.TabIndex = 20;
            this.button2.Text = "CREAR TORNEO";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnCerrarFormCrearTorneo
            // 
            this.btnCerrarFormCrearTorneo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCerrarFormCrearTorneo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarFormCrearTorneo.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarFormCrearTorneo.ForeColor = System.Drawing.Color.Tomato;
            this.btnCerrarFormCrearTorneo.Location = new System.Drawing.Point(437, 311);
            this.btnCerrarFormCrearTorneo.Name = "btnCerrarFormCrearTorneo";
            this.btnCerrarFormCrearTorneo.Size = new System.Drawing.Size(102, 40);
            this.btnCerrarFormCrearTorneo.TabIndex = 21;
            this.btnCerrarFormCrearTorneo.Text = "CERRAR";
            this.btnCerrarFormCrearTorneo.UseVisualStyleBackColor = false;
            this.btnCerrarFormCrearTorneo.Click += new System.EventHandler(this.btnCerrarFormCrearTorneo_Click);
            // 
            // FormularioDashboardTorneos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(551, 363);
            this.Controls.Add(this.btnCerrarFormCrearTorneo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioDashboardTorneos";
            this.Text = "FormularioDashboardTorneos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox2;
        private Label label4;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button btnCerrarFormCrearTorneo;
    }
}