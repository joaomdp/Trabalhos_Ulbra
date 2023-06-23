using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploAbstractFactory.Domain.Interface;

namespace ExemploAbstractFactory.Domain.Entities
{
    public class OnibusFactory : ITransportFactory
    {
        public void CriaOnibus()
        {
            Console.WriteLine("Criando um ônibus.");
        }

        public void CriaTrem()
        {
            Console.WriteLine("Esta fábrica não cria trens.");
        }

        public void CriaBarco()
        {
            Console.WriteLine("Esta fábrica não cria barcos.");
        }
    }
}