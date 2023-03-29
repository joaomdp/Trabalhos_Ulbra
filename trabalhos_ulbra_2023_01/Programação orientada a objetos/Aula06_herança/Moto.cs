using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula06_herança
{
    public class Moto : Veiculo
    {
        public Moto(string modelo) : base(modelo) {}    

        public override void Acelerar()
        {
            Console.WriteLine("Acelerando moto!");
        }    
    }
}