using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T4DominguezGomezSergio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables
            int opcion;
            double perimetro, area;
            double baseT, alturaT, ladoT;
            double radio;

            // Menu de Inicio
            Console.WriteLine("MENÚ PRINCIPAL");
            Console.WriteLine("0 - Salir");
            Console.WriteLine("1 - Rectángulo");
            Console.WriteLine("2 - Círculo");
            Console.WriteLine("3 - Triángulo");
            Console.Write("Introduzca su opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Ha seleccionado salir");
                    break;

                case 1:
                    Console.WriteLine("Ha seleccionado rectángulo");
                    Console.Write("Introduzca la base del rectángulo: ");
                    baseT = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Introduzca la altura del rectángulo: ");
                    alturaT = Convert.ToDouble(Console.ReadLine());
                    perimetro = 2 * (baseT + alturaT);
                    area = baseT * alturaT;
                    Console.WriteLine("El perímetro del rectángulo es: {0}", perimetro);
                    Console.WriteLine("El área del rectángulo es: {0}", area);
                    break;

                case 2:
                    Console.WriteLine("Ha seleccionado círculo");
                    Console.Write("Introduzca el radio del círculo: ");
                    radio = Convert.ToDouble(Console.ReadLine());
                    perimetro = 2 * Math.PI * radio;
                    area = Math.PI * Math.Pow(radio, 2);
                    Console.WriteLine("El perímetro del círculo es: {0}", perimetro);
                    Console.WriteLine("El área del círculo es: {0}", area);
                    break;

                case 3:
                    Console.WriteLine("Ha seleccionado triángulo");
                    Console.Write("Introduzca la base del triángulo: ");
                    baseT = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Introduzca la altura del triángulo: ");
                    alturaT = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Introduzca un lado del triángulo: ");
                    ladoT = Convert.ToDouble(Console.ReadLine());
                    perimetro = baseT + alturaT + ladoT;
                    area = baseT * alturaT / 2;
                    Console.WriteLine("El perímetro del triángulo es: {0}", perimetro);
                    Console.WriteLine("El área del triángulo es: {0}", area);
                    break;

                default:
                    Console.WriteLine("La opción seleccionada no es válida");
                    break;



            }
        }
    }
}
