using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void AsignarHora()
        {  
            DateTime diaHora = new DateTime();
           
            while (true)
            {
                diaHora = DateTime.Now;
                if (lblHora.InvokeRequired)
                {
                    lblHora.BeginInvoke((MethodInvoker)delegate ()
                    { lblHora.Text = diaHora.ToString(); });
                }
                else
                {
                    lblHora.Text = diaHora.ToString();
                }
                Thread.Sleep(1000);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(AsignarHora);
            t.Start();
            
        }

        private void AsignarHora(object sender, EventArgs e)
        {
            DateTime diaHora = new DateTime();
            diaHora = DateTime.Now;
            if (lblHora.InvokeRequired)
            {
                lblHora.BeginInvoke((MethodInvoker)delegate ()
                { lblHora.Text = diaHora.ToString(); });              
            }
            else
            {
                lblHora.Text = diaHora.ToString();
            }
        }
       /* public void ActualizaSegundos()
        {
            int vueltas = 0;
            while (vueltas < 5)
            {
                AsignarHora();
                vueltas++;
                Thread.Sleep(1000);
            }
        }*/
         
    }
}
