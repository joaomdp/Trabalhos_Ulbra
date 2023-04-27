using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula09_interface
{
    public class PagamentoBoleto : IServicoPagamento
    {
        public void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado boleto bancário");
        }

        public void EstornarPagamento()
        {
            Console.WriteLine("Pagamento com boleto bancário estornado");
        }
    }
}