namespace AdoNetCore
{
    partial class Form11UpdatePlantillaProcedures
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
            lstPlantilla = new ListBox();
            label3 = new Label();
            cmbHospital = new ComboBox();
            btnModificarSalario = new Button();
            txtIncremento = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 26);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Incremento";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(28, 172);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(374, 184);
            lstPlantilla.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 154);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Plantilla";
            // 
            // cmbHospital
            // 
            cmbHospital.FormattingEnabled = true;
            cmbHospital.Location = new Point(28, 47);
            cmbHospital.Name = "cmbHospital";
            cmbHospital.Size = new Size(121, 23);
            cmbHospital.TabIndex = 7;
            cmbHospital.SelectedIndexChanged += cmbHospital_SelectedIndexChanged;
            // 
            // btnModificarSalario
            // 
            btnModificarSalario.Location = new Point(133, 102);
            btnModificarSalario.Name = "btnModificarSalario";
            btnModificarSalario.Size = new Size(126, 41);
            btnModificarSalario.TabIndex = 8;
            btnModificarSalario.Text = "Modificar Salario";
            btnModificarSalario.UseVisualStyleBackColor = true;
            btnModificarSalario.Click += btnModificarSalario_Click;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(257, 47);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(145, 23);
            txtIncremento.TabIndex = 9;
            // 
            // Form11UpdatePlantillaProcedures
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 450);
            Controls.Add(txtIncremento);
            Controls.Add(btnModificarSalario);
            Controls.Add(cmbHospital);
            Controls.Add(label3);
            Controls.Add(lstPlantilla);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form11UpdatePlantillaProcedures";
            Text = "Form11UpdatePlantillaProcedures";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private ListBox lstPlantilla;
        private Label label3;
        private ComboBox cmbHospital;
        private Button btnModificarSalario;
        private TextBox txtIncremento;
    }
}