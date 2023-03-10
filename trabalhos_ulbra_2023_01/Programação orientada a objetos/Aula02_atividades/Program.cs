// See https://aka.ms/new-console-template for more information
using Aula02_atividades;

// Atividade 01
var obj = new Calculadora();
var soma = obj.Calcular(12,10,"soma");
var subtrair = obj.Calcular(12,10,"subtrair");

Console.WriteLine("A soma é: "+soma);
Console.WriteLine("A subtração é: "+subtrair);


// Atividade 02
Pessoa pessoa1 = new Pessoa();
var nome = pessoa1.Nome = "João";
var idade = pessoa1.Idade = 20;

Console.WriteLine("O seu nome é "+nome+", e você tem "+idade+" anos");


// Atividade 03
ContaBancaria contaBancaria= new ContaBancaria();

contaBancaria.Depositar(100);
contaBancaria.Sacar(50);
contaBancaria.DetalhesConta();