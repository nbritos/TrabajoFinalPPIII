namespace TorneoUI
{
    partial class FormularioLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioLogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIngresoLogIn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSalirLogIn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(104, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(92, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // btnIngresoLogIn
            // 
            this.btnIngresoLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnIngresoLogIn.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresoLogIn.Location = new System.Drawing.Point(132, 235);
            this.btnIngresoLogIn.Name = "btnIngresoLogIn";
            this.btnIngresoLogIn.Size = new System.Drawing.Size(144, 41);
            this.btnIngresoLogIn.TabIndex = 2;
            this.btnIngresoLogIn.Text = "INGRESO";
            this.btnIngresoLogIn.UseVisualStyleBackColor = true;
            this.btnIngresoLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(309, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 39);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(309, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 39);
            this.textBox2.TabIndex = 5;
            // 
            // btnSalirLogIn
            // 
            this.btnSalirLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnSalirLogIn.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalirLogIn.Location = new System.Drawing.Point(368, 235);
            this.btnSalirLogIn.Name = "btnSalirLogIn";
            this.btnSalirLogIn.Size = new System.Drawing.Size(144, 41);
            this.btnSalirLogIn.TabIndex = 6;
            this.btnSalirLogIn.Text = "SALIR";
            this.btnSalirLogIn.UseVisualStyleBackColor = true;
            this.btnSalirLogIn.Click += new System.EventHandler(this.btnSalirLogIn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Tomato;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.Location = new System.Drawing.Point(569, 298);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Registro";
            // 
            // FormularioLogIn
            // 
            this.AcceptButton = this.btnIngresoLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnSalirLogIn;
            this.ClientSize = new System.Drawing.Size(649, 327);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSalirLogIn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIngresoLogIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormularioLogIn";
            this.Text = "FormularioLogIn";
            this.Load += new System.EventHandler(this.FormularioLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnIngresoLogIn;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnSalirLogIn;
        private LinkLabel linkLabel1;
    }
}