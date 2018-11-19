using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_61
{
    public partial class Form1 : Form
    {
        List<Persona> personas = null;
       PersonaDAO e= new PersonaDAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0 && txtApellido.Text.Length > 0)
            {
                Persona persona = new Persona(txtNombre.Text, txtApellido.Text);
                try
                {
                    if (PersonaDAO.Guardar(persona))
                    {
                        MessageBox.Show("Guardado correctamente!!");
                        btnLeer_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Para agregar las casillas de nombre y apellido no pueden estar vacías.");
            }

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try
            {
                personas = PersonaDAO.Leer();
                ltsPersonas.Items.Clear();
                ltsPersonas.BeginUpdate();
                foreach (Persona p in personas)
                {
                    ltsPersonas.Items.Add(String.Format("{0} {1}", p.Nombre, p.Apellido));
                }
                ltsPersonas.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = ltsPersonas.SelectedIndex;
                if (index >= 0)
                {
                    Persona p = personas[index];
                    if (PersonaDAO.Modificar(p.Identificacion, txtNombre.Text, txtApellido.Text))
                    {
                        MessageBox.Show("Modificado correctamente!!");
                        btnLeer_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar a alguien de la lista.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = ltsPersonas.SelectedIndex;
                if (index >= 0)
                {
                    Persona p = personas[index];
                    if (PersonaDAO.Borrar(p.Identificacion))
                    {
                        MessageBox.Show("Eliminado correctamente!!");
                        btnLeer_Click(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar a alguien de la lista.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }

        private void ltsPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Persona p = personas[ltsPersonas.SelectedIndex];
                txtNombre.Text = p.Nombre;
                txtApellido.Text = p.Apellido;
            }
            catch (Exception)
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           DialogResult result= MessageBox.Show("Esta seguro que desea cerrar la aplicacion?", "La aplicacion se esta cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(result != DialogResult.Yes)
            {
                e.Cancel=true;
            }
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
