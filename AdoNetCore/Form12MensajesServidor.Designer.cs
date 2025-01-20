namespace AdoNetCore
{
    partial class Form12MensajesServidor
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
            lbl1 = new Label();
            txtNumero = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtLocalidad = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnInsertar = new Button();
            lstDepartamentos = new ListBox();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(24, 27);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(51, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(24, 45);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(24, 102);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(159, 23);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 84);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(24, 165);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(159, 23);
            txtLocalidad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 147);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Localidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 27);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 6;
            label4.Text = "Departamentos";
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(24, 218);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(159, 39);
            btnInsertar.TabIndex = 7;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(211, 45);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(294, 289);
            lstDepartamentos.TabIndex = 8;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(24, 297);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(64, 15);
            lblMensaje.TabIndex = 9;
            lblMensaje.Text = "lblMensaje";
            // 
            // Form12MensajesServidor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 379);
            Controls.Add(lblMensaje);
            Controls.Add(lstDepartamentos);
            Controls.Add(btnInsertar);
            Controls.Add(label4);
            Controls.Add(txtLocalidad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(lbl1);
            Name = "Form12MensajesServidor";
            Text = "Form12MensajesServidor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtNumero;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtLocalidad;
        private Label label3;
        private Label label4;
        private Button btnInsertar;
        private ListBox lstDepartamentos;
        private Label lblMensaje;
    }
}