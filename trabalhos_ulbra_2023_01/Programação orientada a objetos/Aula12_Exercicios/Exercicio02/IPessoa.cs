using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula12_Exercicios.Exercicio02
{
    public interface IPessoa
    {
        public String Nome { get; set; }
        public int Idade { get; set; }
        void Falar();
    }
}