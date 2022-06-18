using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_de_fundamento_de_programacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            valorAbsoluto();
            ferrocarril();
            areaCirculo();
        }
        static int valorAbsoluto()
        {
            int valor = 0;

            Console.WriteLine("ingrese un numero negativo");

            valor=int.Parse(Console.ReadLine()); 
            
            Console.WriteLine(Math.Abs(valor));

            Console.ReadKey();

            return valor;
        }
        static double ferrocarril()
        {
            int distancia = 50;

            int tiempo = 5;

            double velocidad = 0;

            velocidad = (50 / 5) / 1.60934;

            Console.WriteLine("para un tren que se desplaza a 50 kilometros por hora....");

            Console.WriteLine($"su velocidad en milla sera de:{velocidad} \n");

            Console.ReadKey();

            return velocidad; 
                   
        }
        static double areaCirculo()
        {
            double area = 0;
            double radio = 2.50;

            area = Math.PI*(Math.Pow(2.50 ,2));

            Console.WriteLine($"teniendo un circulo cuyo radio es de {radio}");

            Console.WriteLine("¿cual sera su area?");

            Console.WriteLine($"el area del circulo es: {area}");

            Console.ReadKey();

            return area;
        }
    }
}
