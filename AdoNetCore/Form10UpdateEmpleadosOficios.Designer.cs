namespace AdoNetCore
{
    partial class Form10UpdateEmpleadosOficios
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
            btnIncrementarSalario = new Button();
            lstEmpleados = new ListBox();
            label1 = new Label();
            label2 = new Label();
            lblSumaSalarial = new Label();
            lblMediaSalarial = new Label();
            lblMaximoSalario = new Label();
            txtIncremento = new TextBox();
            nada = new Label();
            lstOficios = new ListBox();
            label3 = new Label();
            txtOficio = new TextBox();
            SuspendLayout();
            // 
            // btnIncrementarSalario
            // 
            btnIncrementarSalario.Location = new Point(428, 161);
            btnIncrementarSalario.Name = "btnIncrementarSalario";
            btnIncrementarSalario.Size = new Size(131, 49);
            btnIncrementarSalario.TabIndex = 0;
            btnIncrementarSalario.Text = "Incrementar Salario";
            btnIncrementarSalario.UseVisualStyleBackColor = true;
            btnIncrementarSalario.Click += btnIncrementarSalario_Click;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(244, 42);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(167, 259);
            lstEmpleados.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "Oficios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 24);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(43, 362);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(87, 15);
            lblSumaSalarial.TabIndex = 5;
            lblSumaSalarial.Text = "lblSumaSalarial";
            // 
            // lblMediaSalarial
            // 
            lblMediaSalarial.AutoSize = true;
            lblMediaSalarial.Location = new Point(43, 388);
            lblMediaSalarial.Name = "lblMediaSalarial";
            lblMediaSalarial.Size = new Size(90, 15);
            lblMediaSalarial.TabIndex = 6;
            lblMediaSalarial.Text = "lblMediaSalarial";
            // 
            // lblMaximoSalario
            // 
            lblMaximoSalario.AutoSize = true;
            lblMaximoSalario.Location = new Point(43, 415);
            lblMaximoSalario.Name = "lblMaximoSalario";
            lblMaximoSalario.Size = new Size(99, 15);
            lblMaximoSalario.TabIndex = 7;
            lblMaximoSalario.Text = "lblMaximoSalario";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(428, 120);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(131, 23);
            txtIncremento.TabIndex = 8;
            // 
            // nada
            // 
            nada.AutoSize = true;
            nada.Location = new Point(428, 102);
            nada.Name = "nada";
            nada.Size = new Size(68, 15);
            nada.TabIndex = 9;
            nada.Text = "Incremento";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(26, 39);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(174, 259);
            lstOficios.TabIndex = 10;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 42);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 12;
            label3.Text = "Oficio";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(428, 60);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(131, 23);
            txtOficio.TabIndex = 11;
            // 
            // Form10UpdateEmpleadosOficios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 450);
            Controls.Add(label3);
            Controls.Add(txtOficio);
            Controls.Add(lstOficios);
            Controls.Add(nada);
            Controls.Add(txtIncremento);
            Controls.Add(lblMaximoSalario);
            Controls.Add(lblMediaSalarial);
            Controls.Add(lblSumaSalarial);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstEmpleados);
            Controls.Add(btnIncrementarSalario);
            Name = "Form10UpdateEmpleadosOficios";
            Text = "Form10UpdateEmpleadosOficios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIncrementarSalario;
        private ListBox lstEmpleados;
        private Label label1;
        private Label label2;
        private Label lblSumaSalarial;
        private Label lblMediaSalarial;
        private Label lblMaximoSalario;
        private TextBox txtIncremento;
        private Label nada;
        private ListBox lstOficios;
        private Label label3;
        private TextBox txtOficio;
    }
}