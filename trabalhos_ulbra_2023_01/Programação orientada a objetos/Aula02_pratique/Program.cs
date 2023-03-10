// See https://aka.ms/new-console-template for more information

//Pratique 01
Console.WriteLine("Digite um numero");
var numero = Convert.ToInt32(Console.ReadLine());
if (numero%2==0)
{
    Console.WriteLine("O numero"+ numero +" é par");
}else{
    Console.WriteLine("O numero"+ numero +" é impar");
}


//Pratique 02
Console.WriteLine("Informe a primeira nota: ");
var nota1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a segunda nota: ");
var nota2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe a terceira nota: ");
var nota3 = Convert.ToDouble(Console.ReadLine());

double soma = nota1+nota2+nota3;
double media = soma / 3;

Console.WriteLine("A media das notas é: " + media);

//Pratique 03

Console.WriteLine("Digite um numero inteiro positivo: ");
var numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    if(i%2==0){
        Console.WriteLine(""+i);    
    }
}
