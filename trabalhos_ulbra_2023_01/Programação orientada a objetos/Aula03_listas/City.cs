using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_listas
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public City(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}