using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula09_interface
{
    public interface IServicoPagamento
    {
        void EfetuarPagamento();
        void EstornarPagamento();
    }
}