using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula07_ap1
{
    public abstract class Veiculo
    {
        public String Placa { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }

        public Veiculo(string Placa, string Marca, string Modelo)
        {
            this.Placa = Placa;
            this.Marca = Marca;
            this.Modelo = Modelo;
        }

        public abstract int Ocupantes();
    }
}