using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    

    public partial class Form1 : Form
    {
        Temporizador temporizador;

        public Form1()
        {
            InitializeComponent();
        }

        public void AsignarHora()
        {
            if (this.lblHora.InvokeRequired)
            {
                this.lblHora.BeginInvoke(
                    (MethodInvoker)delegate ()
                    {
                        lblHora.Text = DateTime.Now.ToString();
                    }
                );
            }
            else
            {
                lblHora.Text = DateTime.Now.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temporizador = new Temporizador(1000);
            temporizador.miEventoTemporizador += temporizador_miEventoTemporizador;
            temporizador.Activo = true;
        }

        void temporizador_miEventoTemporizador()
        {
            AsignarHora();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            temporizador.Activo = false;
        }
    }
}
