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

                        EstacionarCarro(estacionamento, placaCarro, marcaCarro, modeloCarro, numOcupantes);
                    break;

                    case 2:
                        Console.WriteLine("\nInforme a placa da moto");
                        string placaMoto = Console.ReadLine();

                        Console.WriteLine("\nInforme a marca da moto");
                        string marcaMoto = Console.ReadLine();

                        Console.WriteLine("\nInforme o modelo da moto");
                        string modeloMoto = Console.ReadLine();

                        EstacionarMoto(estacionamento, placaMoto, marcaMoto, modeloMoto);
                    break;

                    case 3:
                        ListarVeiculosEstacionados(estacionamento);
                    break;

                    case 4:
                        int vagasDisponiveis = ContarVagasDisponiveis(estacionamento);
                        Console.WriteLine($"Há {vagasDisponiveis} vagas disponiveis");
                    break;

                    case 5:
                        Console.WriteLine("Informe o numero da vaga a ser liberada: ");
                        int numeroVaga = Convert.ToInt32(Console.ReadLine());
                        RemoverVeiculo(estacionamento, numeroVaga);
                    break;

                    default:
                        Console.WriteLine("Opção invalida");
                    break;
                }
            }
       }

        static void EstacionarCarro(Vaga[] estacionamento, string placa, string marca, string modelo, int numOcupantes)
        {
            for(int i=0;i<estacionamento.Length;i++)
            {
                if(estacionamento[i].estaVazia())
                {
                    estacionamento[i].veiculo = new Carro(placa, marca, modelo, numOcupantes);
                    System.Console.WriteLine($"\nCarro estacionado na vaga {i+1}");
                    return;
                }
            }
            System.Console.WriteLine("Não há vagas disponiveis para carros.");
        }

        static void EstacionarMoto(Vaga[] estacionamento, string placa, string marca, string modelo)
        {
            for(int i=0;i<estacionamento.Length;i++)
            {
                if(estacionamento[i].estaVazia())
                {
                    estacionamento[i].veiculo = new Moto(placa, marca, modelo);
                    System.Console.WriteLine($"\nMoto estacionado na vaga {i+1}");
                    return;
                }
            }
            System.Console.WriteLine("\nNão há vagas disponiveis para motos.");
        }

        static void ListarVeiculosEstacionados(Vaga[] estacionamento)
        {
            System.Console.WriteLine("\nVeiculos estacionado: ");

            for(int i=0;i<estacionamento.Length;i++)
            {
                if(!estacionamento[i].estaVazia())
                {
                     Console.WriteLine($"Vaga {i+1}: {estacionamento[i].veiculo.GetType().Name} - Placa: {estacionamento[i].veiculo.Placa}");
                }
            }
        }

        static int ContarVagasDisponiveis(Vaga[] estacionamento)
        {
            int cont = 0;

    
            for (int i = 0; i < estacionamento.Length; i++)
            {
                if(estacionamento[i].estaVazia())
                {
                    cont++;
                }
            }
            return cont;
        }

        static void RemoverVeiculo(Vaga[] estacionamento, int numeroVaga)
        {
            if (numeroVaga < 1 || numeroVaga > estacionamento.Length)
            {
                System.Console.WriteLine("Numero de vagas invalidos");
                return;
            }
            if(estacionamento[numeroVaga-1].estaVazia())
            {
                System.Console.WriteLine($"A vaga {numeroVaga} já esta vazia");
                return;
            }
            string placa = estacionamento[numeroVaga-1].veiculo.Placa;
            int numOcupantes = estacionamento[numeroVaga-1].veiculo.Ocupantes();
            estacionamento[numeroVaga-1].veiculo =null;
            System.Console.WriteLine($"Veiculo com placa {placa} e {numOcupantes} ocupante(s) removido da vaga {numeroVaga}");
        }
    }
}
