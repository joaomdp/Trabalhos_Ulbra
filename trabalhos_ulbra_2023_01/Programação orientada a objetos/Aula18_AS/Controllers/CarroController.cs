using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula12_TestandoORM.Data.Repositories;
using Aula12_TestandoORM.Domain.Entities;
using Aula12_TestandoORM.Domain.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Aula18_AS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly ICarroRepository repository;

        public CarroController()
        {
            this.repository = new CarroRepository();
        }

        [HttpGet]
        public IEnumerable<Carro>Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Carro Get(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Carro item)
        {
            repository.Save(item);
            return Ok(new{
                StatusCode = 200,
                message = "Cadastrado com sucesso",
                item
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            repository.GetById(id);
            return Ok(new{
                StatusCode = 200,
                message = "Carro deletado com sucesso"
            });
        }

        [HttpPut]
        public IActionResult Put([FromBody] Carro item)
        {
            repository.Update(item);
            return Ok(new{
                StatusCode = 200,
                message = "Atualizado com sucesso",
                item
            });
        }
    }
}