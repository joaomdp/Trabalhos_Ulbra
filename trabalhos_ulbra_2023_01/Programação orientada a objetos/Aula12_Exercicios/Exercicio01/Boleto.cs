using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula12_Exercicios.Exercicio01
{
    public class Boleto : IPagamento
    {
        public void Pagar(decimal valor)
        {
            Console.WriteLine($"Pagamento realizado com boleto, no valor de {valor}");
        }
    }
}