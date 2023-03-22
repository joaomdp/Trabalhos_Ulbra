using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_listas
{
    public class PersonRepository 
    {
        public void screen()
        {
            do
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1. Cadastrar nova pessoa");
                Console.WriteLine("2. Listar todas as pessoas");
                Console.WriteLine("3. Atualizar dados de uma pessoa");
                Console.WriteLine("4. Excluir uma pessoa");
                Console.WriteLine("5. Adicionar uma cidade");
                Console.WriteLine("6. Listar todas as cidades");
                Console.WriteLine("7. Sair");


                Console.Write("\nEscolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao) 
                {
                    case 1:
                        PersonRegister();
                        break;
                    case 2:
                        PersonList();
                        break;
                    case 3:
                        PersonUpdate();
                        break;
                    case 4:
                        PersonRemove();
                        break;
                    case 5:
                        CityRegister();
                        break;
                    case 6:
                        CityList();
                        break;
                    case 7:
                        Console.WriteLine("\nFim do programa!");
                        return;
                    default:
                        Console.WriteLine("\nOpção inválida.");
                        break;
                }
                
            }while(true);   
        }
        
        public static List<Person> persons = new List<Person>();

        void PersonRegister()
        {
            Console.WriteLine("\nCadastre o ID da pessoa");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite o nome da pessoa: ");
            string? name = Console.ReadLine();

            Console.Write("Digite o telefone da pessoa: ");
            string? phone = Console.ReadLine();

            Console.Write("Digite a cidade da pessoa: ");
            string city = Console.ReadLine().ToString();
            City cityObjetc = cities.Find(c => c.Name == city);

            if(cityObjetc == null)
            {
                Console.WriteLine("\nCidade não encontrada");
                return;
            }

            Person person = new Person(id, name, phone, cityObjetc);
            persons.Add(person);

            Console.WriteLine("\nPessoa cadastrada com sucesso!");
        }

        void PersonList()
        {
            if (persons.Count == 0) 
            {
                Console.WriteLine("\nNenhuma pessoa cadastrada.");
                return;
            }

            Console.WriteLine("\n--- Lista de pessoas ---");

            foreach (Person person in persons) 
            {
                Console.WriteLine($"[{person.Id}] {person.Name} - {person.Phone} - {person.City.Name}");
            }
        }

        void PersonUpdate() 
        {
            Console.Write("\nDigite o ID da pessoa a ser atualizada: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Person person = persons.Find(p => p.Id == id);

            if (person == null) 
            {
                Console.WriteLine("\nPessoa não encontrada.");
                return;
            }

            Console.Write("Digite o novo nome da pessoa: ");
            string? name = Console.ReadLine();

            Console.Write("Digite o novo telefone da pessoa: ");
            string? phone = Console.ReadLine();

            person.Name = name;
            person.Phone = phone;

            Console.WriteLine("\nPessoa atualizada com sucesso!");
        }

        void PersonRemove() 
        {
            Console.Write("\nDigite o ID da pessoa a ser excluída: ");
            int id = Convert.ToInt32(Console.ReadLine());
            
            Person person = persons.Find(p => p.Id == id);

            if (person == null) 
            {
                Console.WriteLine("\nPessoa não encontrada.");
                return;
            }

            persons.Remove(person);

            Console.WriteLine("\nPessoa excluída com sucesso!");
        } 

        public static List<City> cities = new List<City>();

        void CityRegister()
        {
            Console.WriteLine("\nCadastre o ID da Cidade");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o nome da cidade: ");
            string name = Console.ReadLine();

            City city = new City(id, name);
            cities.Add(city);

            Console.WriteLine("\nCidade cadastrada com sucesso!");
        }
      
        void CityList()
        {
            if (cities.Count == 0) 
            {
                Console.WriteLine("\nNenhuma cidade cadastrada.");
                return;
             }

            Console.WriteLine("\n--- Lista de cidades ---");

            foreach (City city in cities) 
            {
                Console.WriteLine($"[{city.Id}] {city.Name}");
            }
        }
    }
}
