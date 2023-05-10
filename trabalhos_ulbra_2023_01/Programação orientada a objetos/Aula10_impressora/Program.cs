namespace Aula10_impressora
{
    class Program
    {
        static void Main(string []args)
        {
            List<IImpressoraDeCodigoDeBarras> impressoras = new List<IImpressoraDeCodigoDeBarras>();
            impressoras.Add(new Elgin());
            impressoras.Add(new Zebra());

            Console.WriteLine("Informe o codigo de barras: ");
            string codigoBarras = Console.ReadLine();

            Produto produto = new Produto{Id = 1, CodigoBarras = codigoBarras, Preco = 10.0m};

            foreach (var impressora in impressoras)
            {
                impressora.ImprimirEtiqueta(produto);
            }
        }
    }

}
