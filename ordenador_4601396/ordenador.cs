using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenador_4601396
{
    public class ordenador
    {
        public ordenador(string marca, string procesador, string disco_duro, string memoria, string capacidad)
        {
            this.Marca = marca;
            this.Procesador = procesador;
            this.Disco_duro = disco_duro;
            this.Memoria = memoria;
        }
        public string Marca;
        public string Procesador;
        public string Disco_duro;
        public string Memoria;
        public string Capacidad;
        public void mayor_capacidad(int mayor_capacidad)
        {
            Console.WriteLine("capacidad a aumentado" + mayor_capacidad + "GB mas");
            this.capacidad = Convert.ToInt32(mayor_capacidad + 200);

        }
        public void Menor_capacidad(int menor_capacidad);
        {
        Console.Writeline("capacidad a reducido" + Menor_capacidad + "GB menos");
           
    }
}
