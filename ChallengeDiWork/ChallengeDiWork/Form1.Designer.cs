namespace ChallengeDiWork
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbEnviar = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEnviar
            // 
            this.tbEnviar.Location = new System.Drawing.Point(392, 37);
            this.tbEnviar.Name = "tbEnviar";
            this.tbEnviar.Size = new System.Drawing.Size(82, 22);
            this.tbEnviar.TabIndex = 0;
            this.tbEnviar.Text = "Enviar";
            this.tbEnviar.UseVisualStyleBackColor = true;
            this.tbEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(39, 37);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(223, 22);
            this.tbValor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese aquí el calor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 143);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbEnviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbEnviar;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label1;
    }
}

