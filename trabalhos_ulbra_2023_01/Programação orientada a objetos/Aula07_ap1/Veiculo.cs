using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula07_ap1
{
    public class Veiculo
    {
        public string Placa { get; set; }

        public Veiculo(string placa)
        {
            this.Placa = placa;
        }

        public virtual void Estacionar()     
        {         
            Console.WriteLine($"O veículo com placa {Placa} foi estacionado.");     
        }

        public void Estacionar(string local)
        {
            Console.WriteLine($"O veículo com placa {Placa} foi estacionado em {local}.");
        }
    }
}