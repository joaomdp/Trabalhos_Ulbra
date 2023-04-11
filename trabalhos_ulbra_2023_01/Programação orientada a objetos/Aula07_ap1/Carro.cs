using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula07_ap1
{
    public class Carro : Veiculo
    {
        public int Ocupantes { get; set; }

        public Carro(string placa, int ocupantes) : base(placa)
        {
            Placa = placa;
            Ocupantes = ocupantes;
        }

        public override void InfoVeiculo()
        {
            InfoVeiculo();
        }
 
    }
}