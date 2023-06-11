using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula12_TestandoORM.Data.Context;
using Aula12_TestandoORM.Domain.Entities;
using Aula12_TestandoORM.Domain.interfaces;

namespace Aula12_TestandoORM.Data.Repositories
{
    public class EstacionamentoRepository : IEstacionamentoRepository
    {
        private readonly MeuContexto context;

        public EstacionamentoRepository()
        {
            this.context = new MeuContexto();
        }

        public void Delete(int entityId)
        {
            var c = GetById(entityId);
            context.Estacionamentos.Remove(c);
            context.SaveChanges();
        }

        public IList<Estacionamento> GetAll()
        {
            return context.Estacionamentos.ToList();
        }

        public Estacionamento GetById(int entityId)
        {
            return context.Estacionamentos.SingleOrDefault(x=>x.Id == entityId);
        }

        public void Save(Estacionamento entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(Estacionamento entity)
        {
            context.Estacionamentos.Update(entity);
            context.SaveChanges(); 
        }
    }
}