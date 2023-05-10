using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula12_Exercicios.Exercicio01;

public class Program
{
    public static void Main (String [] args)
    {
        // metodo Pagar
        IPagamento cartaoCredito = new CartaoDeCredito();
        IPagamento boleto = new Boleto();

        Cliente cliente1 = new Cliente(cartaoCredito);
        Cliente cliente2 = new Cliente(boleto);

        cliente1.Comprar(100);
        cliente2.Comprar(200);
    }
}