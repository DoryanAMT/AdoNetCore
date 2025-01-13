namespace AdoNetCore
{
    partial class Form05UpdateSalas
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
            btnModificarSala = new Button();
            lstSalas = new ListBox();
            label1 = new Label();
            txtNuevaSala = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnModificarSala
            // 
            btnModificarSala.Location = new Point(308, 228);
            btnModificarSala.Name = "btnModificarSala";
            btnModificarSala.Size = new Size(143, 64);
            btnModificarSala.TabIndex = 0;
            btnModificarSala.Text = "Modificar Sala";
            btnModificarSala.UseVisualStyleBackColor = true;
            btnModificarSala.Click += btnModificarSala_Click;
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(12, 68);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(260, 349);
            lstSalas.TabIndex = 1;
            lstSalas.SelectedIndexChanged += lstSalas_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Salas";
            // 
            // txtNuevaSala
            // 
            txtNuevaSala.Location = new Point(308, 199);
            txtNuevaSala.Name = "txtNuevaSala";
            txtNuevaSala.Size = new Size(143, 23);
            txtNuevaSala.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 181);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Nueva Sala";
            // 
            // Form05UpdateSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtNuevaSala);
            Controls.Add(label1);
            Controls.Add(lstSalas);
            Controls.Add(btnModificarSala);
            Name = "Form05UpdateSalas";
            Text = "Form05UpdateSalas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificarSala;
        private ListBox lstSalas;
        private Label label1;
        private TextBox txtNuevaSala;
        private Label label2;
    }
}