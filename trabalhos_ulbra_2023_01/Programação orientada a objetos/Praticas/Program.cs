namespace Praticas;

class Program
{
    static void Main (String [] args)
    {
        List<IImpressoraDeCodigoDeBarras> impressoras = new List<IImpressoraDeCodigoDeBarras>();
        impressoras.Add(new Elgin());
        impressoras.Add(new Zebra());

        Console.WriteLine("Informe o código de barras");
        string codigoBarras = Console.ReadLine();

        Produto produto = new Produto {Id = 01, CodBarras = codigoBarras, Preco = 19};

        foreach (var impressora in impressoras)
        {
            impressora.imprimirEtiqueta(produto);
        }
    }
}