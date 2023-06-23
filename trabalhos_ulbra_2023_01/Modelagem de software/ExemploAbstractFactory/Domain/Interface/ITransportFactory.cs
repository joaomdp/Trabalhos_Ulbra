using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploAbstractFactory.Domain.Interface
{
    public interface ITransportFactory
    {
        void CriaOnibus();
        void CriaTrem();
        void CriaBarco();
    }
}