namespace AdoNetCore
{
    partial class Form02BuscadorEmpleados
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
            btnBuscadorEmpleados = new Button();
            label1 = new Label();
            txtSalario = new TextBox();
            label2 = new Label();
            lstEmpleados = new ListBox();
            txtOficio = new TextBox();
            label3 = new Label();
            btnBuscadorOficio = new Button();
            SuspendLayout();
            // 
            // btnBuscadorEmpleados
            // 
            btnBuscadorEmpleados.Location = new Point(31, 80);
            btnBuscadorEmpleados.Name = "btnBuscadorEmpleados";
            btnBuscadorEmpleados.Size = new Size(137, 47);
            btnBuscadorEmpleados.TabIndex = 0;
            btnBuscadorEmpleados.Text = "Buscador Empleados";
            btnBuscadorEmpleados.UseVisualStyleBackColor = true;
            btnBuscadorEmpleados.Click += btnBuscadorEmpleados_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 33);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 1;
            label1.Text = "Introduzca salario";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(31, 51);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(137, 23);
            txtSalario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 147);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(31, 175);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(199, 199);
            lstEmpleados.TabIndex = 4;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(188, 51);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(137, 23);
            txtOficio.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 33);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 6;
            label3.Text = "Introduzca Oficio";
            // 
            // btnBuscadorOficio
            // 
            btnBuscadorOficio.Location = new Point(188, 80);
            btnBuscadorOficio.Name = "btnBuscadorOficio";
            btnBuscadorOficio.Size = new Size(137, 47);
            btnBuscadorOficio.TabIndex = 5;
            btnBuscadorOficio.Text = "Buscador Oficio";
            btnBuscadorOficio.UseVisualStyleBackColor = true;
            btnBuscadorOficio.Click += btnBuscadorOficio_Click;
            // 
            // Form02BuscadorEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 450);
            Controls.Add(txtOficio);
            Controls.Add(label3);
            Controls.Add(btnBuscadorOficio);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Controls.Add(btnBuscadorEmpleados);
            Name = "Form02BuscadorEmpleados";
            Text = "Form02BuscadorEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscadorEmpleados;
        private Label label1;
        private TextBox txtSalario;
        private Label label2;
        private ListBox lstEmpleados;
        private TextBox txtOficio;
        private Label label3;
        private Button btnBuscadorOficio;
    }
}