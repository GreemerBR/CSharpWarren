using Data.Model;
using Data.Respository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        private R _repository;

        public GenericController()
        {
            this._repository = Activator.CreateInstance<R>();
        }

        [HttpGet()]
        public List<T> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost()]
        public string Post(T model)
        {
            return _repository.Create(model);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _repository.Delete(id);
        }

        [HttpPut()]
        public string Update(T model)
        {
            return _repository.Update(model);
        }
    }
}
