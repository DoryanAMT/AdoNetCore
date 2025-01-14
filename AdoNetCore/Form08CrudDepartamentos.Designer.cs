namespace AdoNetCore
{
    partial class Form08CrudDepartamentos
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
            lstDepartamentos = new ListBox();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtLocalidad = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(28, 48);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(324, 379);
            lstDepartamentos.TabIndex = 1;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(390, 235);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(149, 60);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(390, 301);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(149, 60);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(390, 367);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 60);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(390, 66);
            txtId.Name = "txtId";
            txtId.Size = new Size(149, 23);
            txtId.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 48);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 6;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 99);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(390, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 23);
            txtNombre.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(390, 152);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 10;
            label4.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(390, 170);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(149, 23);
            txtLocalidad.TabIndex = 9;
            // 
            // Form08CrudDepartamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 450);
            Controls.Add(label4);
            Controls.Add(txtLocalidad);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(lstDepartamentos);
            Controls.Add(label1);
            Name = "Form08CrudDepartamentos";
            Text = "Form08CrudDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDepartamentos;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtLocalidad;
    }
}