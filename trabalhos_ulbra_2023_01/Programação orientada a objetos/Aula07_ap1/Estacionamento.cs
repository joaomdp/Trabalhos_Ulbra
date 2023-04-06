using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula07_ap1
{
    public class Estacionamento
    {
        private List<Veiculo> vagasDisponiveis = new List<Veiculo>();
        private List<Veiculo> veiuclosEstacionados = new List<Veiculo>();

        public Estacionamento(int vagas)
        {
            for(int i=0;i<vagas;i++)
            {
                vagasDisponiveis.Add(new Carro());
                vagasDisponiveis.Add(new Moto());
            }
        }

        public void Estacionar(Veiculo veiculo)
        {
            if(veiuclosEstacionados.Contains(veiculo))
            {
                System.Console.WriteLine("Veiculo já estacionado");
            }
            if (!vagasDisponiveis.Contains(veiculo))
            {
                System.Console.WriteLine("Tipo de veiculo nao suportado");
            }

            vagasDisponiveis.Remove(veiculo);
            veiuclosEstacionados.Add(veiculo);
        }

        public void Liberar(Veiculo veiculo)
        {
            if (!veiuclosEstacionados.Contains(veiculo))
            {
                System.Console.WriteLine("Veiculo nao esta estacionado");
            }

            veiuclosEstacionados.Remove(veiculo);
            vagasDisponiveis.Add(veiculo);
        }

        public int VagasDisponiveis()
        {
            return vagasDisponiveis.Count;
        }
    }
}