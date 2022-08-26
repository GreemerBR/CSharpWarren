using Data.Model;
using Data.Respository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantaController : ControllerBase
    {
        private PlantaRepository _repository;

        public PlantaController()
        {
            this._repository = new PlantaRepository();
        }

        [HttpGet(Name = "Planta")]
        public List<Planta> GetAll()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Planta GetById(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public string Post(Planta model)
        {
            return _repository.Create(model);
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return _repository.Delete(id);
        }

        [HttpPut]
        public string Update(Planta model)
        {
            return _repository.Update(model);
        }
    }
}
