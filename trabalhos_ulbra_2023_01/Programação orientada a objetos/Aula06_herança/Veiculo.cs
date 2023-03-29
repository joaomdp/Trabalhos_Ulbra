using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_herança
{
    public class Veiculo
    {
        public string Modelo { get; set; }

        public Veiculo(string modelo)
        {
            this.Modelo =  modelo;
        }
        //Ao utilizar o virtual, indicamos que o método pode ser sobrescrito pelas classes derivadas. Isso significa que as classes Carro e Moto podem substituir a implementação do método Acelerar() da classe Veiculo por sua própria implementação, caso necessário.
        public virtual void Acelerar(){
            Console.WriteLine("Acelerando veiculo");
        }
    }
}