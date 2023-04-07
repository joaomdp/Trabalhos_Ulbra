using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula07_ap1
{
    public class Moto : Veiculo
    {
        public Moto(string placa, string marca, string modelo) : base(placa, marca, modelo){}

        public override int Ocupantes()
        {
            return 1;
        }
    }
}