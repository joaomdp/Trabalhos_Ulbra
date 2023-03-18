using System;
using System.Collections.Generic;
using Aula03_listas;
public class Program {
    static void Main(string[] args) {        
        do{
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Cadastrar nova pessoa");
            Console.WriteLine("2. Listar todas as pessoas");
            Console.WriteLine("3. Atualizar dados de uma pessoa");
            Console.WriteLine("4. Excluir uma pessoa");
            Console.WriteLine("5. Sair");

            Console.Write("\nEscolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:
                    CadastrarPessoa();
                    break;
                case 2:
                    ListarPessoas();
                    break;
                case 3:
                    AtualizarPessoa();
                    break;
                case 4:
                    ExcluirPessoa();
                    break;
                case 5:
                    Console.WriteLine("\nFim do programa!");
                    return;
                default:
                    Console.WriteLine("\nOpção inválida.");
                    break;
            }
        }while(true);
    }
public static List<Pessoa> pessoas = new List<Pessoa>();

        public static void CadastrarPessoa() {
        Console.WriteLine("\nCadastre o ID da pessoa");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nDigite o nome da pessoa: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o telefone da pessoa: ");
        string telefone = Console.ReadLine();

        Pessoa pessoa = new Pessoa() {
            ID = id,
            Nome = nome,
            Telefone = telefone
        };

        pessoas.Add(pessoa);

        Console.WriteLine("\nPessoa cadastrada com sucesso!");
    }

    static void ListarPessoas() {
        if (pessoas.Count == 0) {
            Console.WriteLine("\nNenhuma pessoa cadastrada.");
            return;
        }

        Console.WriteLine("\n--- Lista de pessoas ---");

        foreach (Pessoa pessoa in pessoas) {
            Console.WriteLine($"[{pessoa.ID}] {pessoa.Nome} - {pessoa.Telefone}");
        }
    }

    static void AtualizarPessoa() {
        Console.Write("\nDigite o ID da pessoa a ser atualizada: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Pessoa pessoa = pessoas.Find(p => p.ID == id);

        if (pessoa == null) {
            Console.WriteLine("\nPessoa não encontrada.");
            return;
        }

        Console.Write("Digite o novo nome da pessoa: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o novo telefone da pessoa: ");
        string telefone = Console.ReadLine();

        pessoa.Nome = nome;
        pessoa.Telefone = telefone;

        Console.WriteLine("\nPessoa atualizada com sucesso!");
    }

    static void ExcluirPessoa() {
        Console.Write("\nDigite o ID da pessoa a ser excluída: ");
        int id = Convert.ToInt32(Console.ReadLine());
        
        Pessoa pessoa = pessoas.Find(p => p.ID == id);

        if (pessoa == null) {
            Console.WriteLine("\nPessoa não encontrada.");
            return;
        }

        pessoas.Remove(pessoa);

        Console.WriteLine("\nPessoa excluída com sucesso!");
    }    
}
    



