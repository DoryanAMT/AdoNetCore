namespace AdoNetCore
{
    partial class Form01PrimerAdo
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
            btnLeer = new Button();
            btnDesconectar = new Button();
            lstTipos = new ListBox();
            label3 = new Label();
            lstColumnas = new ListBox();
            label2 = new Label();
            lstApellidos = new ListBox();
            label1 = new Label();
            btnConectar = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(21, 249);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(111, 54);
            btnLeer.TabIndex = 19;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Location = new Point(21, 167);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(111, 54);
            btnDesconectar.TabIndex = 18;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // lstTipos
            // 
            lstTipos.FormattingEnabled = true;
            lstTipos.Location = new Point(594, 90);
            lstTipos.Name = "lstTipos";
            lstTipos.Size = new Size(186, 289);
            lstTipos.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(594, 72);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 16;
            label3.Text = "Tipos";
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(389, 90);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(186, 289);
            lstColumnas.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(389, 72);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 14;
            label2.Text = "Columnas";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(177, 90);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(186, 289);
            lstApellidos.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 72);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 12;
            label1.Text = "Apellidos";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(21, 90);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(111, 54);
            btnConectar.TabIndex = 11;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(21, 409);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(38, 15);
            lblMensaje.TabIndex = 20;
            lblMensaje.Text = "label4";
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMensaje);
            Controls.Add(btnLeer);
            Controls.Add(btnDesconectar);
            Controls.Add(lstTipos);
            Controls.Add(label3);
            Controls.Add(lstColumnas);
            Controls.Add(label2);
            Controls.Add(lstApellidos);
            Controls.Add(label1);
            Controls.Add(btnConectar);
            Name = "Form01PrimerAdo";
            Text = "Form01PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeer;
        private Button btnDesconectar;
        private ListBox lstTipos;
        private Label label3;
        private ListBox lstColumnas;
        private Label label2;
        private ListBox lstApellidos;
        private Label label1;
        private Button btnConectar;
        private Label lblMensaje;
    }
}