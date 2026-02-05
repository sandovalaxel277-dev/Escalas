namespace Escalas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.ComboBox cmbBase;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTipo;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInstrucciones = new Label();
            cmbBase = new ComboBox();
            cmbTipo = new ComboBox();
            btnMostrar = new Button();
            lblResultado = new Label();
            lblTipo = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.Location = new Point(12, 18);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(431, 20);
            lblInstrucciones.TabIndex = 0;
            lblInstrucciones.Text = "Selecciona la nota base y el tipo de escala, luego pulsa Mostrar:";
            // 
            // cmbBase
            // 
            cmbBase.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBase.FormattingEnabled = true;
            cmbBase.Location = new Point(67, 45);
            cmbBase.Name = "cmbBase";
            cmbBase.Size = new Size(120, 28);
            cmbBase.TabIndex = 1;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(255, 45);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(80, 28);
            cmbTipo.TabIndex = 2;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(355, 44);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 25);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 85);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(84, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado...";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(207, 48);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(42, 20);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 49);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 5;
            label1.Text = "Nota:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 140);
            Controls.Add(label1);
            Controls.Add(lblInstrucciones);
            Controls.Add(cmbBase);
            Controls.Add(lblTipo);
            Controls.Add(cmbTipo);
            Controls.Add(btnMostrar);
            Controls.Add(lblResultado);
            Name = "Form1";
            Text = "Escalas Musicales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
