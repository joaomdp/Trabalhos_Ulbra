namespace Aula07_ap1
{
    public class Program 
    {
       static void Main(string[]args)
       {
            Vaga[] estacionamento = new Vaga[10];
            for (int i = 0; i < estacionamento.Length; i++)
            {
                estacionamento[i] = new Vaga();
            }

            while(true)
            {
                Console.WriteLine("\n--- Escolha uma opção: --- ");
                Console.WriteLine("1 - Estacionar carro");
                Console.WriteLine("2 - Estacionar moto");
                Console.WriteLine("3 - Listar veiculos estacionados");
                Console.WriteLine("4 - Mostrar vagas disponiveis");
                Console.WriteLine("5 - Remover veiculo");
                Console.WriteLine("0 - Encerrar programa");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        System.Console.WriteLine("\nFim do programa");
                        return;

                    case 1:
                        Console.WriteLine("\nInforme a placa do carro");
                        string placaCarro = Console.ReadLine();

                        Console.WriteLine("\nInforme a marca do carro");
                        string marcaCarro = Console.ReadLine();

                        Console.WriteLine("\nInforme o modelo do carro");
                        string modeloCarro = Console.ReadLine();

                        Console.WriteLine("\nInforme o numero de ocupantes do carro");
                        int numOcupantes =Convert.ToInt32(Console.ReadLine());

                        EstacionamentoRepository.Estacionar(estacionamento, placaCarro, marcaCarro, modeloCarro, numOcupantes);
                    break;

                    case 2:
                        Console.WriteLine("\nInforme a placa da moto");
                        string placaMoto = Console.ReadLine();

                        Console.WriteLine("\nInforme a marca da moto");
                        string marcaMoto = Console.ReadLine();

                        Console.WriteLine("\nInforme o modelo da moto");
                        string modeloMoto = Console.ReadLine();

                        EstacionamentoRepository.Estacionar(estacionamento, placaMoto, marcaMoto, modeloMoto);
                    break;

                    case 3:
                        EstacionamentoRepository.ListarVeiculosEstacionados(estacionamento);
                    break;

                    case 4:
                        int vagasDisponiveis = EstacionamentoRepository.ContarVagasDisponiveis(estacionamento);
                        Console.WriteLine($"Há {vagasDisponiveis} vagas disponiveis");
                    break;

                    case 5:
                        Console.WriteLine("Informe o numero da vaga a ser liberada: ");
                        int numeroVaga = Convert.ToInt32(Console.ReadLine());
                        EstacionamentoRepository.RemoverVeiculo(estacionamento, numeroVaga);
                    break;

                    default:
                        Console.WriteLine("Opção invalida");
                    break;
                }
            }
       }
    }
}
