using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula12_TestandoORM.Domain.Entities
{
    public class Estacionamento
    {
        public int Id { get; set; }
        public List<Carro> Carro {get; set;}

        public static implicit operator Estacionamento(Carro v)
        {
            throw new NotImplementedException();
        }
    }
}