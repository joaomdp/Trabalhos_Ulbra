using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploAbstractFactory.Domain.Interface;

namespace ExemploAbstractFactory.Domain.Factorys
{
    public class BarcoFactory : ITransportFactory
    {
        public void CriaOnibus()
        {
            Console.WriteLine("Esta fábrica não cria ônibus.");
        }

        public void CriaTrem()
        {
            Console.WriteLine("Esta fábrica não cria trens.");
        }

        public void CriaBarco()
        {
            Console.WriteLine("Criando um barco.");
        }
    }
}