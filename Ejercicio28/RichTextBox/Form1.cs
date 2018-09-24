using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio28;

namespace RichTextBox
{
    public partial class Contador_de_Palabras : Form
    {
        public Contador_de_Palabras()
        {
            InitializeComponent();
        }

        private void Texto_TextChanged(object sender, EventArgs e)
        {
            string palabras = Texto.Text;
             string[] array = Lista.generaArray(palabras);
            Lista.addPalabra(array);
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Texto_TextChanged(sender,e);
            MessageBox.Show(Lista.contador +"palabras");
        }
    }
}
