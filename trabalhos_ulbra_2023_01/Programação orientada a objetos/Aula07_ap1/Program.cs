namespace Aula07_ap1
{
    public class Program 
    {
       static void Main(string[]args)
       {
            Estacionamento estacionamento = new Estacionamento(20);

            while(true)
            {
                System.Console.WriteLine(" --- Menu estacionamento ---");
                System.Console.WriteLine("Selecione uma das opções abaixo");
                System.Console.WriteLine("1 - Estacionar carro");
                System.Console.WriteLine("2 - Estacionar moto");
                System.Console.WriteLine("3 - Liberar vaga de carro");
                System.Console.WriteLine("4 - Liberar vaga de moto");
                System.Console.WriteLine("5 - Quantas vagas ainda estão livres");
                System.Console.WriteLine("0 - Sair");

                Console.WriteLine("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                    {
                        case 0:
                            return;
                        case 1:
                            Console.WriteLine("Digite a placa do carro:");
                            string placaCarro = Console.ReadLine();
                            Console.WriteLine("Digite a marca do carro:");
                            string marcaCarro = Console.ReadLine();
                            Console.WriteLine("Digite o modelo do carro:");
                            string modeloCarro = Console.ReadLine();  

                            Carro carro = new Carro()
                            {
                                Placa = placaCarro,
                                Marca = marcaCarro,
                                Modelo = modeloCarro
                            };  

                            estacionamento.Estacionar(carro);

                            Console.WriteLine("Carro estacionado com sucesso!");
                        break;
                        case 2:
                            Console.WriteLine("Digite a placa do Moto:");
                            string placaMoto = Console.ReadLine();
                            Console.WriteLine("Digite a marca do Moto:");
                            string marcaMoto = Console.ReadLine();
                            Console.WriteLine("Digite o modelo do Moto:");
                            string modeloMoto = Console.ReadLine();  

                            Moto moto = new Moto()
                            {
                                Placa = placaMoto,
                                Marca = marcaMoto,
                                Modelo = modeloMoto
                            };  

                            estacionamento.Estacionar(moto);

                            Console.WriteLine("Moto estacionada com sucesso!");
                        break;
                        case 5:
                            Console.WriteLine($"Vagas livres: {estacionamento.VagasDisponiveis()}");
                        break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
            }
        
        }
    }
}
