namespace RichTextBox
{
    partial class Contador_de_Palabras
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
            this.Texto = new System.Windows.Forms.RichTextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Texto
            // 
            this.Texto.Location = new System.Drawing.Point(0, 0);
            this.Texto.Name = "Texto";
            this.Texto.Size = new System.Drawing.Size(800, 393);
            this.Texto.TabIndex = 0;
            this.Texto.Text = "";
            this.Texto.TextChanged += new System.EventHandler(this.Texto_TextChanged);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(669, 409);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(98, 29);
            this.Calcular.TabIndex = 1;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Contador_de_Palabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Texto);
            this.Name = "Contador_de_Palabras";
            this.Text = "Contador de palabras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Texto;
        private System.Windows.Forms.Button Calcular;
    }
}

