using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula07_ap1
{
    public class EstacionamentoRepository
    {
        EstacionamentoRepository estacionamento = new EstacionamentoRepository();
        
        public static void Estacionar(Vaga[] estacionamento, string placa, string marca, string modelo, int numOcupantes)
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

        public static void Estacionar(Vaga[] estacionamento, string placa, string marca, string modelo)
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

        public static void ListarVeiculosEstacionados(Vaga[] estacionamento)
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

        public static int ContarVagasDisponiveis(Vaga[] estacionamento)
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

        public static void RemoverVeiculo(Vaga[] estacionamento, int numeroVaga)
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
            estacionamento[numeroVaga-1].veiculo = null;
            System.Console.WriteLine($"Veiculo com placa {placa} e {numOcupantes} ocupante(s) removido da vaga {numeroVaga}");
        }
    }

        
}