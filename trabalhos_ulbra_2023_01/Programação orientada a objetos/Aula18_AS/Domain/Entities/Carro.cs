using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Aula12_TestandoORM.Domain.Entities
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        [JsonIgnore]
        public Estacionamento Estacionamento {get; set;}

        public Carro()
        {
            Estacionamento = new Estacionamento();
        }
    }

    
   
}