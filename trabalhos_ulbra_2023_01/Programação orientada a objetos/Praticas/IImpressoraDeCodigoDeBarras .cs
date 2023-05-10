using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Praticas
{
    public interface IImpressoraDeCodigoDeBarras 
    {
        void imprimirEtiqueta(Produto produto);
    }
}