using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula12_TestandoORM.Data.Context;
using Aula12_TestandoORM.Domain.Entities;
using Aula12_TestandoORM.Domain.interfaces;

namespace Aula12_TestandoORM.Data.Repositories
{
    public class CarroRepository : ICarroRepository
    {

        private readonly MeuContexto context;

        public CarroRepository (MeuContexto context)
        {
            this.context = context;
        }

        public void Delete(int entityId)
        {
            var c = GetById(entityId);
            context.Carros.Remove(c);
            context.SaveChanges();
        }

        public IList<Carro> GetAll()
        {
            return context.Carros.ToList();
        }

        public Carro GetById(int entityId)
        {
            return context.Carros.SingleOrDefault(x=>x.Id == entityId);
        }

        public void Save(Carro entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(Carro entity)
        {
            context.Carros.Update(entity);
            context.SaveChanges();
        }
    }
}