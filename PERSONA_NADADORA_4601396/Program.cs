using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSONA_NADADORA_4601396
{
    public class Program
    {
        static void Main(string[] args)
        {
            PersonaNadadora Personal = new PersonaNadadora("verdes", "187", "85", "V");
            Console.WriteLine("Descripcion de la persona");
            Console.WriteLine("Ojos" + Personal.Ojos);
            Console.WriteLine("Altura:" + Personal.Altura);
            Console.WriteLine("Peso" + Personal.Peso);
            Console.WriteLine("Sexo" + Personal.Sexo);
            Personal.Hablar("me llamo borja");
            Console.WriteLine("color de mis ojos" + Personal.Ojos);
            Personal.correr(1000);
            Console.WriteLine("mi peso actual es", Personal.Peso);
            Personal.Nadar();
            Console.WriteLine("tras nadar peso:",Personal.Peso);
            Console.ReadKey();


        }
    }
}
