using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula07_ap1
{
    public class Carro : Veiculo
    {
        public int numOcupantes;

        public Carro(string placa, string marca, string modelo, int numOcupantes) : base(placa, marca, modelo)
        {
            this.numOcupantes = numOcupantes;
        }

        public override int Ocupantes()
        {
            return numOcupantes;
        }
    }
}