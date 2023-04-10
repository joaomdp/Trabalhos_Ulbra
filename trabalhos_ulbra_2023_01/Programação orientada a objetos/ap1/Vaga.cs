using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula07_ap1
{
    public class Vaga
    {
        public Veiculo veiculo;

        public bool estaVazia()
        {
            return veiculo == null;
        }
    }
}