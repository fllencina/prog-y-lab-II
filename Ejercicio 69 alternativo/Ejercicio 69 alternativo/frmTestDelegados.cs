using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_69_alternativo
{
    public partial class frmTestDelegados : Form
    {

        public delegate void Delegado(string nombre);
        public event Delegado EventoDelegado;
        public frmTestDelegados()
        {
            InitializeComponent();
        }

        public  void btnActualizar_Click(object sender, EventArgs e)
        {
            if(EventoDelegado!=null)
            EventoDelegado.Invoke(textBox1.Text);
        }
    }
}
