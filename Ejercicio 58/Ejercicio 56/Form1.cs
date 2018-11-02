using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Ejercicio_56
{
    public partial class Form1 : Form
    {
        string ruta = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ruta != null)
            {
                StreamWriter file = new StreamWriter(ruta);
                file.WriteLine(richTextBox1.Text);
                file.Close();
            }
            else
            {
                guardarComoCtrlMayusSToolStripMenuItem_Click(sender, e);
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    ruta = openFileDialog1.FileName;                   
                    StreamReader file = new StreamReader(ruta);
                    richTextBox1.Text = file.ReadToEnd();
                    file.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void guardarComoCtrlMayusSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfDialog = new SaveFileDialog();

            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ruta = sfDialog.FileName;
                    //Stream stream = openFileDialog1.OpenFile();
                    StreamWriter file = new StreamWriter(ruta);
                    file.WriteLine(richTextBox1.Text);
                    file.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            double contador = richTextBox1.Text.Length;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} caracteres", contador);
            toolStripStatusLabel2.Text = sb.ToString();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
