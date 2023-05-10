using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Praticas
{
    public class Zebra : IImpressoraDeCodigoDeBarras
    {
        public int Resolucao = 600;
        public string TamanhoEtiqueta = "15cm x 7cm";
        public string TipoEtiqueta = "Poliéster";

        public void imprimirEtiqueta(Produto produto)
        {
            Console.WriteLine($"Resolução: {Resolucao} dpi");
            Console.WriteLine($"Tamanho etiqueta: {TamanhoEtiqueta}");
            Console.WriteLine($"Tipo etiqueta: {TipoEtiqueta}");
            Console.WriteLine($"ID: {produto.Id}");
            Console.WriteLine($"Código de Barras: {produto.CodBarras}");
            Console.WriteLine($"Preço: {produto.Preco}");
        }
    }
}