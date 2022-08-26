using Data.Model;
using Data.Respository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        [HttpGet(Name = "Animal")]
        public Animal Get()
        {
            Animal animal1 = new Animal { Id = 1, Especie = "Catchorro", Nome = "Chimba", Peso = 5.5f};
            return animal1;
        }

        [HttpPost]
        public string Post(Animal model)
        {
            AnimalRepository repo = new AnimalRepository();
            return repo.Create(model);
        }
    }
}
