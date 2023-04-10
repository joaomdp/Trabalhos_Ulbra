using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula07_ap1
{
    public class Estacionamento 
    {
        public int Id { get; set; }
        public Veiculo Veiculo { get; set; }

        public Estacionamento(int id, Veiculo veiculo)
        {
            this.Id = id;
            this.Veiculo = veiculo;
        }

        public void Estacionar()
        {
            Console.WriteLine($"\nID: {Id}");
            Console.WriteLine($"Placa: {Veiculo.Placa}");
        }
    }

}