using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carro_4601396
{
    public class coche
    {
        public coche(string Marca, string Modelo, string Velocidad_maxima, string Velocidad_actual, int Velocidad)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Velocidad_maxima = Velocidad_maxima;
            this.Velocidad_actual = Velocidad_actual;
            this.Velocidad = Velocidad;
        }

        public string Marca;
        public string Modelo;
        public string Velocidad_maxima;
        public string Velocidad_actual;
        public int Velocidad;

        public void acelera(int aceleracion)
        {
            Console.WriteLine("El carro acelera: " + aceleracion + "Km/h");
            this.Velocidad = Convert.ToInt32(aceleracion + (5));
        }

        public void decelerar(int deceleracion)
        {
            Console.WriteLine("El carro decelera: " + deceleracion + "Km/h");
            this.Velocidad = Convert.ToInt32(deceleracion + (-5));
        }
    }
}
