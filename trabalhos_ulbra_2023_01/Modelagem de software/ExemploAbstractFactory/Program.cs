using ExemploAbstractFactory.Domain.Entities;
using ExemploAbstractFactory.Domain.Factorys;
using ExemploAbstractFactory.Domain.Interface;

class Program
{
    static void Main(string[] args)
    {
        ITransportFactory factory = new BarcoFactory();

        factory.CriaOnibus();
        factory.CriaTrem();
        factory.CriaBarco();
    }
}