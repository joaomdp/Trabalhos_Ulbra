using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula02_atividades
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public int Idade { get; private set; }

        public Pessoa(string nome, int idade){
            this.Nome = nome;
            this.Idade = idade;
        }

        public String Apresentar() { 
            return $"Nome: {this.Nome} \n Idade {this.Idade}";
        }

        
    }
}