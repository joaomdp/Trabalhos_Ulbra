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

    Personagem heroi = new Heroi("Batman", 7.5, 10, "Laminas");
    Console.WriteLine(heroi.Nome);
    Console.WriteLine(heroi.Forca);
    Console.WriteLine(heroi.Inteligencia);
    Console.WriteLine(heroi.Poderes);
    heroi.Lutar();

    Console.WriteLine("\n--- Personagens ---");

    Personagem vilao = new Vilao("Coringa", 6.5, 9, "Piadas");
    Console.WriteLine(vilao.Nome);
    Console.WriteLine(vilao.Forca);
    Console.WriteLine(vilao.Inteligencia);
    Console.WriteLine(vilao.Poderes);
    vilao.Lutar();
   }
}