using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSONA_NADADORA_4601396
{
    public class PersonaNadadora:Persona
    {
        public PersonaNadadora(string Ojos, string Altura, string Peso, string Sexo) : base(Ojos,Altura,Peso,Sexo) {
        }
        public void Nadar()
        {
            Console.WriteLine("Nadando para volver al peso ideal");
            this.Peso = "85";
        }
    }
}
