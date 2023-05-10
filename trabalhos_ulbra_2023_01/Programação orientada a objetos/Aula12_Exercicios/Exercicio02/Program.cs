using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula12_Exercicios.Exercicio02
{
    public class Program
    {
        public static void Main2(string [] args)
        {
            Escola escola = new Escola();

            Professor professor = new Professor
            {
                Nome = "João",
                Idade = 35
            };

            Aluno aluno = new Aluno
            {
                Nome = "Maria",
                Idade = 18
            };

            escola.ApresentarPessoa(professor);
            escola.ApresentarPessoa(aluno);
        }
    }
}