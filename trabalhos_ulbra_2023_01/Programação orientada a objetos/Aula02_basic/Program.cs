// See https://aka.ms/new-console-template for more information
using Aula02_basic;

Console.WriteLine("Hello, World!");

//tipos de variaveis
int idade = 25;
string nome = "João";
bool possuiCarteira = true;
double altura = 1.75;
decimal valorUnit = 22;

//instanciar um objeto

Garrafa garrafaDoCassio = new Garrafa(1234,"cinza",2000,"garrafa mais bonita");

Console.WriteLine(garrafaDoCassio.AnoFabricacao + "" + garrafaDoCassio.Cor);
garrafaDoCassio.Cor="Tricolor";

Garrafa garrafaDoFelipe = new Garrafa(2334,"azul",3214,"garrafa nem tao bonita");

Console.WriteLine(garrafaDoFelipe.AnoFabricacao);





