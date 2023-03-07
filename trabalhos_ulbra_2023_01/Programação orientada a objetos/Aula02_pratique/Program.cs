// See https://aka.ms/new-console-template for more information

//Pratique 01
Console.WriteLine("Digite um numero");
var numero = Convert.ToInt32(Console.ReadLine());
if (numero%2==0)
{
    Console.WriteLine("O numero"+ numero+" é par");
}else{
    Console.WriteLine("O numero"+ numero+" é impar");
}