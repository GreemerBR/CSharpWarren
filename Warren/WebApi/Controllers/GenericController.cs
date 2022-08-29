﻿using Data.Model;
using Data.Respository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        private R _repository;

        public GenericController(R repository)
        {
            this._repository = repository;
        }

        [HttpGet("GetAll")]
        public List<T> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("GetById/{id}")]
        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost("Post")]
        public string Post(T model)
        {
            return _repository.Create(model);
        }

        [HttpDelete("Delete/{id}")]
        public string Delete(int id)
        {
            return _repository.Delete(id);
        }

        [HttpPut("Put")]
        public string Update(T model)
        {
            return _repository.Update(model);
        }
    }
}
