using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula07_ap1
{
    public abstract class Veiculo
    {
        public string Placa { get; set; }

        public Veiculo(string placa)
        {
            this.Placa = placa;
        }

        public virtual void InfoVeiculo()     
        {         
            Console.WriteLine($"O veículo com placa {Placa} foi estacionado.");     
        }
    }
}