using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula12_TestandoORM.Data.Context;
using Aula12_TestandoORM.Domain.Entities;
using Aula12_TestandoORM.Domain.interfaces;

namespace Aula12_TestandoORM.Data.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly MeuContexto context;

        public CityRepository(MeuContexto context)
        {
            this.context = context;
        }

        public void Delete(int entityId)
        {
            var c = GetById(entityId);
            context.cities.Remove(c);
            context.SaveChanges();
        }

        public IList<City> GetAll()
        {
            return context.cities.ToList();
        }

        public City GetById(int entityId)
        {
            return context.cities.SingleOrDefault(x=>x.Id == entityId);
        }

        public void Save(City entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(City entity)
        {
            context.cities.Update(entity);
            context.SaveChanges(); 
        }
    }
}