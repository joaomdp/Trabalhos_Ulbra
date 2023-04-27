using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula09_interface
{
    public class PagamentoCartao : IServicoPagamento
    {
        public void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado com cartao de crédito");
        }

        public void EstornarPagamento()
        {
            Console.WriteLine("Pagamento com cartao de crédito estornado");
        }
    }
}