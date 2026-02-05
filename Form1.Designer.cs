namespace Escalas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.TextBox txtEscala;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblResultado;

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
            components = new System.ComponentModel.Container();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.txtEscala = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Location = new System.Drawing.Point(12, 18);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(352, 15);
            this.lblInstrucciones.TabIndex = 0;
            this.lblInstrucciones.Text = "Introduce la nota de la escala (Do, Re, Mi, Fa, Sol, La, Si) y pulsa Mostrar:";
            // 
            // txtEscala
            // 
            this.txtEscala.Location = new System.Drawing.Point(12, 45);
            this.txtEscala.Name = "txtEscala";
            this.txtEscala.Size = new System.Drawing.Size(200, 23);
            this.txtEscala.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(230, 44);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 25);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 85);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(70, 15);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado...";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(500, 150);
            Controls.Add(this.lblInstrucciones);
            Controls.Add(this.txtEscala);
            Controls.Add(this.btnMostrar);
            Controls.Add(this.lblResultado);
            Name = "Form1";
            Text = "Escalas Musicales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
