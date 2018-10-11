using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FormDT : Form
    {
        DirectorTecnico director;
        public FormDT()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {          
            if(textBoxNombre.Text.Length>0 && textBoxApellido.Text.Length>0)
            {
                director = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text, (short)numericUpDownEdad.Value, (short)numericUpDownDni.Value, (short)numericUpDownExperiencia.Value);
                MessageBox.Show("Se ha creado el DT!");
            }
           
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if (director == null)
            {
                MessageBox.Show("Aun no se ha creado el DT del formulario");
                
            }
            else
            {
                if (director.ValidarAptitud())
                {
                    MessageBox.Show("El DT es Apto!");
                }
                if (!director.ValidarAptitud())
                {
                    MessageBox.Show("El DT no es Apto.");
                }
            }
        }
    }
}
