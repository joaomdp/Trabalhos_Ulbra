using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula09_interface
{
    public class PagamentoPayPal : IServicoPagamento
    {
        public void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado com paypal");
        }

        public void EstornarPagamento()
        {
            Console.WriteLine("Pagamento com paypal estornado");
        }
    }
}