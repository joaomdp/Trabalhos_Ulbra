using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula12_TestandoORM.Domain.Entities;
using Aula12_TestandoORM.Domain.Intrefaces;

namespace Aula12_TestandoORM.Domain.interfaces
{
    public interface IEstacionamentoRepository : IBaseRepository<Estacionamento>
    {
        
    }
}