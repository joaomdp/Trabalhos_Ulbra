using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula12_TestandoORM.Data.Context;
using Aula12_TestandoORM.Domain.Entities;
using Aula12_TestandoORM.Domain.interfaces;
using Microsoft.EntityFrameworkCore;

namespace Aula12_TestandoORM.Data.Repositories
{
    public class CarroRepository : ICarroRepository
    {

        private readonly MeuContexto context;

        public CarroRepository ()
        {
            this.context = new MeuContexto();
        }

        public void Delete(int entityId)
        {
            var c = GetById(entityId);
            context.Carros.Remove(c);
            context.SaveChanges();
        }

        public IList<Carro> GetAll()
        {
            return context.Carros.Include(x=>x.Estacionamento).ToList();
        }

        public Carro GetById(int entityId)
        {
            return context.Carros.Include(x=>x.Estacionamento).SingleOrDefault(x=>x.Id == entityId);
        }

        public void Save(Carro entity)
        {
            entity.Estacionamento = context.Estacionamentos.SingleOrDefault(x=>x.Id == entity.Estacionamento.Id);
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(Carro entity)
        {
            entity.Estacionamento = context.Estacionamentos.SingleOrDefault(x=>x.Id == entity.Estacionamento.Id);
            context.Carros.Update(entity);
            context.SaveChanges();
        }
    }
}