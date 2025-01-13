namespace AdoNetCore
{
    partial class Form04EliminarPlantillas
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
            label2 = new Label();
            lstPlantilla = new ListBox();
            btnEliminarEmpleado = new Button();
            txtIdEmpleado = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 19);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 9;
            label2.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(182, 37);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(411, 319);
            lstPlantilla.TabIndex = 8;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Location = new Point(17, 90);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(141, 42);
            btnEliminarEmpleado.TabIndex = 7;
            btnEliminarEmpleado.Text = "Eliminar Empleado";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(17, 51);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(141, 23);
            txtIdEmpleado.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Empleado";
            // 
            // Form04EliminarPlantillas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lstPlantilla);
            Controls.Add(btnEliminarEmpleado);
            Controls.Add(txtIdEmpleado);
            Controls.Add(label1);
            Name = "Form04EliminarPlantillas";
            Text = "Form04EliminarPlantillas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ListBox lstPlantilla;
        private Button btnEliminarEmpleado;
        private TextBox txtIdEmpleado;
        private Label label1;
    }
}