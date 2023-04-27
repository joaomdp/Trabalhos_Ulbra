using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula09_interface
{
    public class FormatadorInvertido : IFormatadorTexto
    {
        public string Formatar(string texto)
        {
            char [] array = texto.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}