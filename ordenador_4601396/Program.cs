using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenador_4601396
{
    internal class Program
    {           
        static void Main(string[] args)
        {
            ordenador ordenador = new ordenador("samsung Chromebook", "intel Atom", "2GB de RAM", "16gb   ", 100);
            Console.WriteLine("Descripción del Ordenador: ");
            Console.WriteLine("Marca: " + ordenador.Marca);
            Console.WriteLine("Procesador: " + ordenador.Procesador);
            Console.WriteLine("Memoria: " + ordenador.Memoria);
            Console.WriteLine("Disco duro: " + ordenador.Disco_duro);

            ordenador.mayor_capacidad(100);
            Console.WriteLine("La capacidad incremento: " + ordenador.Capacidad + "Gb mas");
            ordenador.Menor_capacidad(100);
            Console.WriteLine("La capacidad reduce: " + ordenador.Capacidad + "Gb menos");

            Console.ReadKey();
        }
    }
}
