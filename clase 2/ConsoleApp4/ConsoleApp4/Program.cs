﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
trabajadas en el mes de N empleados de una fábrica.
Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
descuentos.
Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
Nota: Utilizar estructuras repetitivas y selectivas.*/
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 8";
            string auxNombre;
            int auxAntiguedad;
            int auxhoras;
            float auxValor;

            Console.WriteLine("Ingrese nombre: ");
            auxNombre = Console.ReadLine();
            auxAntiguedad = Convert.ToInt32(Console.ReadLine());
            auxhoras = Convert.ToInt32(Console.ReadLine());
            float.TryParse(Console.ReadLine(),out auxValor);


            Empleado empleadoNew = new Empleado(auxNombre,auxAntiguedad,auxhoras,auxValor);


        }
    }
}
