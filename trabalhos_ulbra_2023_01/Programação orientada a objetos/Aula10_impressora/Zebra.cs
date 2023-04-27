using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula10_impressora
{
    public class Zebra : IImpressoraDeCodigoDeBarras
    {
        public int resolucao = 600;
        public string tamanhoEtiqueta = "15cm x 7cm";
        public string tipoEtiqueta = "Poliester";

        public void ImprimirEtiqueta(Produto produto)
        {
            Console.WriteLine($"Resolução: {resolucao}dpi");
            Console.WriteLine($"Tamanho da etiqueta: {tamanhoEtiqueta}");
            Console.WriteLine($"Tipo de etiqueta: {tipoEtiqueta}");
            Console.WriteLine($"Código de barras: {produto.CodigoBarras}");
        }
    }
}