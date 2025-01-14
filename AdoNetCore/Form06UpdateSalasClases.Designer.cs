namespace AdoNetCore
{
    partial class Form06UpdateSalasClases
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
            txtNuevaSala = new TextBox();
            label1 = new Label();
            lstSalas = new ListBox();
            btnModificarSala = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 144);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 9;
            label2.Text = "Actualizar Sala";
            // 
            // txtNuevaSala
            // 
            txtNuevaSala.Location = new Point(308, 162);
            txtNuevaSala.Name = "txtNuevaSala";
            txtNuevaSala.Size = new Size(143, 23);
            txtNuevaSala.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 7;
            label1.Text = "Salas";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(12, 31);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(260, 349);
            lstSalas.TabIndex = 6;
            // 
            // btnModificarSala
            // 
            btnModificarSala.Location = new Point(308, 191);
            btnModificarSala.Name = "btnModificarSala";
            btnModificarSala.Size = new Size(143, 64);
            btnModificarSala.TabIndex = 5;
            btnModificarSala.Text = "Modificar Sala";
            btnModificarSala.UseVisualStyleBackColor = true;
            btnModificarSala.Click += btnModificarSala_Click;
            // 
            // Form06UpdateSalasClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtNuevaSala);
            Controls.Add(label1);
            Controls.Add(lstSalas);
            Controls.Add(btnModificarSala);
            Name = "Form06UpdateSalasClases";
            Text = "Form06UpdateSalasClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtNuevaSala;
        private Label label1;
        private ListBox lstSalas;
        private Button btnModificarSala;
    }
}