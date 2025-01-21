namespace AdoNetCore
{
    partial class Form09CrudHospitales
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
            lstHospitales = new ListBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtNumCamas = new TextBox();
            btnInsert = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label6 = new Label();
            txtIdHospital = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 23);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.Location = new Point(33, 41);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(245, 394);
            lstHospitales.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(305, 101);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(238, 23);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 83);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 139);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(305, 157);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(238, 23);
            txtDireccion.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 202);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 7;
            label4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(305, 220);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(238, 23);
            txtTelefono.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 258);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 9;
            label5.Text = "NumCamas";
            // 
            // txtNumCamas
            // 
            txtNumCamas.Location = new Point(305, 276);
            txtNumCamas.Name = "txtNumCamas";
            txtNumCamas.Size = new Size(238, 23);
            txtNumCamas.TabIndex = 8;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(305, 322);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(238, 33);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(305, 361);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(238, 33);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(305, 400);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(238, 33);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(305, 23);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 14;
            label6.Text = "Id";
            // 
            // txtIdHospital
            // 
            txtIdHospital.Location = new Point(305, 41);
            txtIdHospital.Name = "txtIdHospital";
            txtIdHospital.Size = new Size(238, 23);
            txtIdHospital.TabIndex = 13;
            // 
            // Form09CrudHospitales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 450);
            Controls.Add(label6);
            Controls.Add(txtIdHospital);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsert);
            Controls.Add(label5);
            Controls.Add(txtNumCamas);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtDireccion);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(lstHospitales);
            Controls.Add(label1);
            Name = "Form09CrudHospitales";
            Text = "Form09CrudHospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstHospitales;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtNumCamas;
        private Button btnInsert;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label6;
        private TextBox txtIdHospital;
    }
}