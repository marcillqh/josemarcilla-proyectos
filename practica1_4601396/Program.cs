using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1_4601396
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona Personal = new Persona("verde", "187", "85", "V");
            Console.WriteLine("DESCRIPCIO DE LA PERSONA:");
            Console.WriteLine("Ojos:" + Personal.Ojos);
            Console.WriteLine("Altura:"+Personal.Altura);
            Console.WriteLine("Peso:"+ Personal.Peso);
            Console.WriteLine("sexo"+Personal.Sexo);
            Personal.Hablar("Me llamo borja");
            Console.WriteLine("color de ojos" + Personal.Ojos);
            Personal.correr(1000);
            Console.WriteLine("Mi peso actual es:"+ Personal.Peso);
            Console.ReadKey();
        }
    }
}
