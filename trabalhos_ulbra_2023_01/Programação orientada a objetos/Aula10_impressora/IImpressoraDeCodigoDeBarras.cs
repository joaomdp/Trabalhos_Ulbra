using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula10_impressora
{
    public interface IImpressoraDeCodigoDeBarras
    {
        void ImprimirEtiqueta(Produto produto);
    }
}