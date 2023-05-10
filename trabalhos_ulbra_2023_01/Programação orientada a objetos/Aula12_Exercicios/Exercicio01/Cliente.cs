using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula12_Exercicios.Exercicio01
{
    public class Cliente
    {
        private IPagamento metodoPagamento;

        public Cliente(IPagamento metodoPagamento)
        {
            this.metodoPagamento = metodoPagamento;
        }

        public void Comprar(decimal valor)
        {
            metodoPagamento.Pagar(valor);
        }
    }
}