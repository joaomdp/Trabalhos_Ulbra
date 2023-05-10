using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula12_Exercicios.Exercicio01
{
    public class CartaoDeCredito : IPagamento
    {
        public void Pagar(decimal valor)
        {
            Console.WriteLine($"Pagamento realizado com cartão de crédito, no valor de {valor}");
        }
    }
}