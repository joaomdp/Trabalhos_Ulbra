using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula09_interface
{
    public class Programa
    {
        static void Main (string [] args)
        {
            // IAnimal  
            Cachorro cachorro = new Cachorro();
            Gato gato = new Gato();
            Papagaio papagaio = new Papagaio();

            cachorro.EmitirSom();
            gato.EmitirSom();
            papagaio.EmitirSom();

            System.Console.WriteLine();

            // IFormatadorTexto
            string texto1 = "Texto";

            FormatadorMaiusculo maiusculo = new FormatadorMaiusculo();
            FormatadorMinusculo minusculo = new FormatadorMinusculo();
            FormatadorInvertido invertido = new FormatadorInvertido();

            maiusculo.Formatar(texto1);
            minusculo.Formatar(texto1);
            invertido.Formatar(texto1);

            System.Console.WriteLine();

            // IAnimalEstimação
            var dog = new Dog();
            dog.Nome = "Rex";
            dog.Dono = "João";

            var cat = new Cat();
            cat.Nome = "Mimi";
            cat.Dono = "Maria";

            System.Console.WriteLine();

            // ICalculadora

            var calculadora = new Calculadora();
            var resultadoSoma = calculadora.Somar(2,3);
            var resultadoSubtrair = calculadora.Subtrair(2,3);
            var resultadoMulti = calculadora.Multiplicar(2,3);
            var resultadoDividir = calculadora.Dividir(6,3);

            Console.WriteLine("\nResultado soma: "+ resultadoSoma + "\nResultado subtração" + resultadoSubtrair + "\nResultado multiplicação: "+  resultadoMulti + "\nResultado Divisão: " + resultadoDividir);

            System.Console.WriteLine();

            // IServicoPagamento
            IServicoPagamento pagamento1 = new PagamentoCartao();
            pagamento1.EfetuarPagamento();
            pagamento1.EstornarPagamento();

            IServicoPagamento pagamento2 = new PagamentoBoleto();
            pagamento2.EfetuarPagamento();
            pagamento2.EstornarPagamento();

            IServicoPagamento pagamento3 = new PagamentoPayPal();
            pagamento3.EfetuarPagamento();
            pagamento3.EstornarPagamento();
        }
    }
}