using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carro_4601396
{
    public class cochefreno:coche
    {
        public cochefreno(string marca, string modelo, string velocidad_maxima, string velocidad_actual, int velocidad, int freno)
            : base(marca, modelo, velocidad_actual, velocidad_maxima, velocidad)
        {
            this.Freno = freno;
        }

        public int Freno;
        public void Frenar(int frenar)
        {
            Console.WriteLine();
            this.Freno = Convert.ToInt32(frenar = 0);
        }
    }
}
