using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula12_TestandoORM.Domain.Entities;
using Aula12_TestandoORM.Data.Repositories;
using Aula12_TestandoORM.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Aula12_TestandoORM.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IPersonRepository repositiory;

        public PeopleController()
        {
            this.repositiory = new PersonRepository();
        }

        [HttpGet]
        public IEnumerable<Aula12_TestandoORM.Domain.Entities.Person> Get()
        {
            return repositiory.GetAll();
        }
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return repositiory.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Person item)
        {
            repositiory.Save(item);
            return Ok( new {
                statusCode=200,
                message = "Cadastrado com sucesso",
                item
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            repositiory.Delete(id);
            return Ok( new {
                statusCode=200,
                message = "Pessoa excluída com sucesso"
            });
        }
        [HttpPut]
        public IActionResult Put([FromBody]Person item)
        {
            repositiory.Update(item);
            return Ok( new {
                statusCode=200,
                message = item.Nome + " atualizado com sucesso",
                item
            });
        }
    }
}