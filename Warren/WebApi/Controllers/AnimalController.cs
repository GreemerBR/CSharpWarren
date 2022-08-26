﻿using Data.Model;
using Data.Respository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private AnimalRepository _repository;

        public AnimalController()
        {
            this._repository = new AnimalRepository();
        }

        [HttpGet(Name = "Animal")]
        public List<Animal> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Animal GetById(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public string Post(Animal model)
        {
            return _repository.Create(model);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _repository.Delete(id);
        }

        [HttpPut]
        public string Update(Animal model)
        {
            return _repository.Update(model);
        }
    }
}
