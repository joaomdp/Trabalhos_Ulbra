using System.Collections.Generic;

namespace Aula12_TestandoORM.Domain.Entities
{
    public class Estacionamento
    {
        public int Id { get; set; }
        public List<Carro> Carros { get; set; }
    }
}
