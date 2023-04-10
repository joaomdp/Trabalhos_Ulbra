namespace Aula07_ap1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Vaga> estacionamento = new List<Vaga>();
            for (int i = 0; i < 10; i++)
            {
            estacionamento.Add(new Vaga());
            }

            while(true)
            {
                Console.WriteLine("\n--- Escolha uma opção: --- ");
                Console.WriteLine("1 - Estacionar carro");
                Console.WriteLine("2 - Estacionar moto");
                Console.WriteLine("3 - Listar veículos estacionados");
                Console.WriteLine("4 - Mostrar vagas disponíveis");
                Console.WriteLine("5 - Remover veículo");
                Console.WriteLine("0 - Encerrar programa");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("\nFim do programa");
                        return;

                    case 1:
                        Console.WriteLine("\nInforme a placa do carro");
                        string placaCarro = Console.ReadLine();

                        Console.WriteLine("\nInforme a marca do carro");
                        string marcaCarro = Console.ReadLine();

                        Console.WriteLine("\nInforme o modelo do carro");
                        string modeloCarro = Console.ReadLine();

                        Console.WriteLine("\nInforme o número de ocupantes do carro");
                        int numOcupantes = Convert.ToInt32(Console.ReadLine());

                        estacionamento.Add(new Vaga(new Carro(placaCarro, marcaCarro, modeloCarro, numOcupantes)));
                        Console.WriteLine("\nCarro estacionado com sucesso!");
                        break;

                    case 2:
                        Console.WriteLine("\nInforme a placa da moto");
                        string placaMoto = Console.ReadLine();

                        Console.WriteLine("\nInforme a marca da moto");
                        string marcaMoto = Console.ReadLine();

                        Console.WriteLine("\nInforme o modelo da moto");
                        string modeloMoto = Console.ReadLine();

                        estacionamento.Add(new Moto(placaMoto, marcaMoto, modeloMoto));
                        Console.WriteLine("\nMoto estacionada com sucesso!");
                        break;

                    case 3:
                        Console.WriteLine("\nLista de veículos estacionados:");
                        foreach (Vaga vaga in estacionamento)
                        {
                            if (vaga.Ocupada)
                            {
                                Console.WriteLine(vaga.Veiculo.ToString());
                            }
                        }
                        break;

                    case 4:
                        int vagasDisponiveis = 0;
                        foreach (Vaga vaga in estacionamento)
                        {
                            if (!vaga.Ocupada)
                            {
                                vagasDisponiveis++;
                            }
                        }
                        Console.WriteLine($"Há {vagasDisponiveis} vagas disponíveis");
                        break;

                    case 5:
                        Console.WriteLine("\nInforme o número da vaga a ser liberada:");
                        int numeroVaga = Convert.ToInt32(Console.ReadLine());
                        if (numeroVaga < 0 || numeroVaga >= estacionamento.Count)
                        {
                            Console.WriteLine("\nVaga inválida!");
                            break;
                        }

                        Vaga vagaRemover = estacionamento[numeroVaga];
                        if (!vagaRemover.Ocupada)
                        {
                            Console.WriteLine("\nEssa vaga já está livre!");
                            break;
                        }

                        estacionamento[numeroVaga].LiberarVaga();
                        Console.WriteLine("\nVeículo removido com sucesso!");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida!");
                        break;
                }
            }
        }
    }
}