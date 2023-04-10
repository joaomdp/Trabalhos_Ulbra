using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula07_ap1
{
    public class EstacionamentoRepository
    {
        public static void Estacionar(List<Vaga> estacionamento, string placa, string marca, string modelo, int numOcupantes)
        {
            foreach (Vaga vaga in estacionamento)
            {
                if (vaga.estaVazia())
                {
                    vaga.veiculo = new Carro(placa, marca, modelo, numOcupantes);
                    Console.WriteLine($"\nCarro estacionado na vaga {estacionamento.IndexOf(vaga) + 1}");
                    return;
                }
            }
            Console.WriteLine("Não há vagas disponíveis para carros.");
        }

        public static void Estacionar(List<Vaga> estacionamento, string placa, string marca, string modelo)
        {
            foreach (Vaga vaga in estacionamento)
            {
                if (vaga.estaVazia())
                {
                    vaga.veiculo = new Moto(placa, marca, modelo);
                    Console.WriteLine($"\nMoto estacionada na vaga {estacionamento.IndexOf(vaga) + 1}");
                    return;
                }
            }
            Console.WriteLine("\nNão há vagas disponíveis para motos.");
        }

        public static void ListarVeiculosEstacionados(List<Vaga> estacionamento)
        {
            Console.WriteLine("\nVeículos estacionados: ");

            foreach (Vaga vaga in estacionamento)
            {
                if (!vaga.estaVazia())
                {
                    Console.WriteLine($"Vaga {estacionamento.IndexOf(vaga) + 1}: {vaga.veiculo.GetType().Name} - Placa: {vaga.veiculo.Placa}");
                }
            }
        }

        public static void RemoverVeiculo(List<Vaga> estacionamento, int numeroVaga)
        {
            if (numeroVaga < 1 || numeroVaga > estacionamento.Count)
            {
                Console.WriteLine("Número de vagas inválido.");
                return;
            }
            if (estacionamento[numeroVaga - 1].estaVazia())
            {
                Console.WriteLine($"A vaga {numeroVaga} já está vazia.");
                return;
            }

            string placa = estacionamento[numeroVaga - 1].veiculo.Placa;
            int numOcupantes = estacionamento[numeroVaga - 1].veiculo.Ocupantes();
            estacionamento[numeroVaga - 1].veiculo = null;
            Console.WriteLine($"Veículo com placa {placa} e {numOcupantes} ocupante(s) removido da vaga {numeroVaga}.");
        }
    }    
}