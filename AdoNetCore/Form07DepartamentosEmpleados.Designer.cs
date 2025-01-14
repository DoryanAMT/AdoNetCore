namespace AdoNetCore
{
    partial class Form07DepartamentosEmpleados
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
            label1 = new Label();
            label2 = new Label();
            btnEliminarEmpleado = new Button();
            lstDepartamentos = new ListBox();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 39);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 39);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Empleados";
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Location = new Point(511, 57);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(155, 58);
            btnEliminarEmpleado.TabIndex = 2;
            btnEliminarEmpleado.Text = "Eliminar";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(33, 57);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(231, 364);
            lstDepartamentos.TabIndex = 3;
            lstDepartamentos.SelectedIndexChanged += lstDepartamentos_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(279, 57);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(226, 364);
            lstEmpleados.TabIndex = 4;
            // 
            // Form07DepartamentosEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEmpleados);
            Controls.Add(lstDepartamentos);
            Controls.Add(btnEliminarEmpleado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form07DepartamentosEmpleados";
            Text = "Form07DepartamentosEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnEliminarEmpleado;
        private ListBox lstDepartamentos;
        private ListBox lstEmpleados;
    }
}