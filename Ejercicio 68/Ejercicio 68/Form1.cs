using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_68
{
    public partial class Form1 : Form
    {
        private event DelegadoString EventoDelegado;
        private Persona persona;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EventoDelegado += NotificarCambio;
        }
        public void NotificarCambio(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(persona==null)
            {
                if (txtNombre.Text.Length > 0 && txtApellido.Text.Length > 0)
                {
                    persona = new Persona(txtNombre.Text, txtApellido.Text);
                    btnCrear.Text = "Actualizar";
                    EventoDelegado("Se ha creado la persona: " + persona.Mostrar());
                }
                else
                {
                    MessageBox.Show("Los campos nombre y/o apellido no pueden estar vacios");
                }
            }
            else
            {
                if (persona.Nombre != txtNombre.Text)
                {
                    persona.Nombre = txtNombre.Text;
                    EventoDelegado("Se ha actualizado el nombre a " + persona.Nombre);
                }

                if (persona.Apellido != txtApellido.Text)
                {
                    persona.Apellido = txtApellido.Text;
                    EventoDelegado("Se ha actualizado el apellido a " + persona.Apellido);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea salir de la aplicacion?", "Salir.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(respuesta!=DialogResult.OK)
            {
                e.Cancel=true;
            }
        }
    }
}
