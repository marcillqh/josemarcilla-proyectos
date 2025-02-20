using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1_4601396
{

    public class Persona
    {
        public Persona(string Ojos, string Altura, string Peso, string Sexo)
        {
            this.Ojos = Ojos;
            this.Altura = Altura;
            this.Peso = Peso;
            this.Sexo = Sexo;
        }

        public string Ojos;
        public string Altura;
        public string Peso;
        public string Sexo;

        public void Hablar(string texto)
        {

            Console.WriteLine("Voy a decir:" + texto);
        }

        public void Comer(double calorias)
        {

            Console.WriteLine("Ganando" + calorias + "calorias");
            this.Peso += calorias / 1000;
        }

        public void correr(double calorias)
        {
            Console.WriteLine("Perdiendo" + calorias + "calorias");
            this.Peso = Convert.ToString(calorias / 1000);
        }
    }
}