using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Pedir el nombre de la semana al usuario y decirle si es fin de semana o no. 
 */

namespace InformarSiEsFinDeSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = 30;
            Console.WriteLine("Ingrese un dia de la semana, todo en minuscula:");

            string DiaDeLaSemana = Convert.ToString(Console.ReadLine());

            switch (DiaDeLaSemana.ToLower())
            {
                case"lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("Es un dia habil.");
                    break;

                case "sabado":
                case "domingo":
                case "feriado":
                    Console.WriteLine("Ese es un dia no-laborable.");
                    break;
                default:
                    Console.WriteLine("Ese dia no es correcto.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
