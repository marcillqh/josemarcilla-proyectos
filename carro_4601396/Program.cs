using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carro_4601396
{
    internal class Program
    {
        static void Main(string[] args)
        {
            coche coche = new coche("Chevrolet", "Aveo", "60km/h", "150km/h", 0);
            Console.WriteLine("Descripcion del Coche:");
            Console.WriteLine("Marca:" + coche.Marca);
            Console.WriteLine("Modelo:" + coche.Modelo);
            Console.WriteLine("Velocidad actual:" + coche.Velocidad_actual);
            Console.WriteLine("Velocidad maxima:" + coche.Velocidad_maxima);

            coche.acelera(10);
            Console.WriteLine("El coche acelera:" + coche.Velocidad + "Km/h");
            coche.decelerar(10);
            Console.WriteLine("El coche decelera:" + coche.Velocidad + "Km/h");


            cochefreno cochefreno = new cochefreno("Chevrolet", "Aveo", "60km/h", "150km/h", 0, 0);

            cochefreno.Frenar(0);
            Console.WriteLine("El coche frena:" + cochefreno.Freno + "Km/h");

            Console.ReadKey();
        }
    }
}
