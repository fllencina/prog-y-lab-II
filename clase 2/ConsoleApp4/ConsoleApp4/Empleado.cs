using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Empleado
    {
        private string nombre;
        private int antiguedad;
        private int horasTrabajadas;
        private float valorHora;
       

        public Empleado(string nombre, int antiguedad, int horasTrabajadas, float valorHora)
        {
            setNombre(nombre);
            setAntiguedad(antiguedad);
            setHorasTrabajadas(horasTrabajadas);
            setValorHora(valorHora);
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void getNombre(string nombre)
        {
            nombre = this.nombre; 
        }
        public void setAntiguedad(int antiguedad)
        {
            this.antiguedad = antiguedad;
        }
        public void getAntiguedad(int antiguedad)
        {
            antiguedad = this.antiguedad;
        }
        public void setHorasTrabajadas(int horasTrabajadas)
        {
            this.horasTrabajadas = horasTrabajadas;
        }
        public void getHorasTrabajadas(int horasTrabajadas)
        {
            horasTrabajadas = this.horasTrabajadas;
        }
        public void setValorHora(float valorHora)
        {
            this.valorHora = valorHora;
        }
        public void getValorHora(float valorHora)
        {
            valorHora = this.valorHora;
        }

    }

   
}
