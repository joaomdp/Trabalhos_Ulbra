using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploAbstractFactory.Domain.Interface;

namespace ExemploAbstractFactory.Domain.Factorys
{
    public class TremFactory : ITransportFactory
    {
        public void CriaOnibus()
        {
            Console.WriteLine("Esta fábrica não cria ônibus.");
        }

        public void CriaTrem()
        {
            Console.WriteLine("Criando um trem.");
        }

        public void CriaBarco()
        {
            Console.WriteLine("Esta fábrica não cria barcos.");
        }
    }
}