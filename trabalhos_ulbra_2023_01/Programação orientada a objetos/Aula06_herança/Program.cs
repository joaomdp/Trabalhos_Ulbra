using System;

namespace Aula06_herança;

class Program
{
   static void Main(string []args)
   {
    // Animal cachorro = new Cachorro("Toby");
    // Console.WriteLine(cachorro.Nome);
    // cachorro.Falar();

    // Animal gato = new Gato("Mimi");
    // Console.WriteLine(gato.Nome);
    // gato.Falar();

    // Veiculo carro = new Carro("Fiat");
    // Console.WriteLine(carro.Modelo);
    // carro.Acelerar();

    // Veiculo moto = new Moto("Honda");
    // Console.WriteLine(moto.Modelo);
    // moto.Acelerar();

   
   Heroi homemAranha = new Heroi()
   {
      Nome = "Homem aranha",
      Forca = 8,
      Inteligencia = 6,
      Poderes = new string[] { "Teia", "Agilidade", "Esacalar parede" }
   };
   Vilao duendeVerde = new Vilao()
      {
         Nome = "Duende Verde",
         Forca = 7,
         Inteligencia = 8,
         Poderes = new string[] { "Armas", "Voo", "Explosivos" }
   };

   homemAranha.LutarVilao(duendeVerde);
   }
}