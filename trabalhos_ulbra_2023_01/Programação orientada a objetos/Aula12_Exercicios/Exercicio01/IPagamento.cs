using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula12_Exercicios.Exercicio01
{
    public interface IPagamento
    {
        void Pagar(decimal valor);
    }
}