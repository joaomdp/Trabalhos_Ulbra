using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula10_impressora
{
    public class Elgin : IImpressoraDeCodigoDeBarras
    {
        public int resolucao = 300;
        public string tamanhoEtiqueta = "10cm x 5cm";
        public string tipoEtiqueta = "Papel adesivo";

        public void ImprimirEtiqueta(Produto produto)
        {
            Console.WriteLine($"Resolução: {resolucao}dpi");
            Console.WriteLine($"Tamanho da etiqueta: {tamanhoEtiqueta}");
            Console.WriteLine($"Tipo de etiqueta: {tipoEtiqueta}");
            Console.WriteLine($"Código de barras: {produto.CodigoBarras}");
        }
    }
}