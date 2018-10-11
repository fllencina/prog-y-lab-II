namespace VistaForm
{
    partial class FormDT
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelExperiencia = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDni = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExperiencia = new System.Windows.Forms.NumericUpDown();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonValidar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperiencia)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(58, 35);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(58, 72);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 0;
            this.labelApellido.Text = "Apellido";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(58, 109);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(32, 13);
            this.labelEdad.TabIndex = 0;
            this.labelEdad.Text = "Edad";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(58, 146);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(26, 13);
            this.labelDni.TabIndex = 0;
            this.labelDni.Text = "DNI";
            // 
            // labelExperiencia
            // 
            this.labelExperiencia.AutoSize = true;
            this.labelExperiencia.Location = new System.Drawing.Point(58, 183);
            this.labelExperiencia.Name = "labelExperiencia";
            this.labelExperiencia.Size = new System.Drawing.Size(62, 13);
            this.labelExperiencia.TabIndex = 0;
            this.labelExperiencia.Text = "Experiencia";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(186, 32);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(120, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(186, 68);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(120, 20);
            this.textBoxApellido.TabIndex = 2;
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Location = new System.Drawing.Point(186, 104);
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEdad.TabIndex = 3;
            // 
            // numericUpDownDni
            // 
            this.numericUpDownDni.Location = new System.Drawing.Point(186, 140);
            this.numericUpDownDni.Name = "numericUpDownDni";
            this.numericUpDownDni.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownDni.TabIndex = 4;
            // 
            // numericUpDownExperiencia
            // 
            this.numericUpDownExperiencia.Location = new System.Drawing.Point(186, 176);
            this.numericUpDownExperiencia.Name = "numericUpDownExperiencia";
            this.numericUpDownExperiencia.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownExperiencia.TabIndex = 5;
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(61, 257);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(75, 23);
            this.buttonCrear.TabIndex = 3;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonValidar
            // 
            this.buttonValidar.Location = new System.Drawing.Point(231, 257);
            this.buttonValidar.Name = "buttonValidar";
            this.buttonValidar.Size = new System.Drawing.Size(75, 23);
            this.buttonValidar.TabIndex = 3;
            this.buttonValidar.Text = "Validar";
            this.buttonValidar.UseVisualStyleBackColor = true;
            this.buttonValidar.Click += new System.EventHandler(this.buttonValidar_Click);
            // 
            // FormDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 300);
            this.Controls.Add(this.buttonValidar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.numericUpDownExperiencia);
            this.Controls.Add(this.numericUpDownDni);
            this.Controls.Add(this.numericUpDownEdad);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelExperiencia);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Name = "FormDT";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExperiencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelExperiencia;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.NumericUpDown numericUpDownEdad;
        private System.Windows.Forms.NumericUpDown numericUpDownDni;
        private System.Windows.Forms.NumericUpDown numericUpDownExperiencia;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonValidar;
    }
}

