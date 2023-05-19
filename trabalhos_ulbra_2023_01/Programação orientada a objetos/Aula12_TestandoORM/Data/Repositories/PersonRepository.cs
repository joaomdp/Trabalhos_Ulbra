using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula12_TestandoORM.Data.Context;
using Aula12_TestandoORM.Domain.Entities;
using Aula12_TestandoORM.Domain.interfaces;

namespace Aula12_TestandoORM.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {

        private readonly MeuContexto context;

        public PersonRepository (MeuContexto context)
        {
            this.context = context;
        }

        public void Delete(int entityId)
        {
            var p = GetById(entityId);
            context.Persons.Remove(p);
            context.SaveChanges();
        }

        public IList<Person> GetAll()
        {
            return context.Persons.ToList();
        }

        public Person GetById(int entityId)
        {
            return context.Persons.SingleOrDefault(x=>x.Id == entityId);
        }

        public void Save(Person entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(Person entity)
        {
            context.Persons.Update(entity);
            context.SaveChanges();
        }
    }
}