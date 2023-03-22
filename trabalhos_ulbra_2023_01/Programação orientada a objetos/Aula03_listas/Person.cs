using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula03_listas
{
    public class Person
    {
        public int Id { get;  set; }
        public string Name { get;  set; }
        public string Phone { get; set; }
        public City City {get; set;}

        public Person(int id, string name, string phone, City city)
        {
            this.Id = id;
            this.Name = name;
            this.Phone = phone;
            this.City = city;
        }
    }   
}
  