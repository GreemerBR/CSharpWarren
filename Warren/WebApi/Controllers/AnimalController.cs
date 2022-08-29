using Data.Model;
using Data.Respository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : GenericController<Animal, AnimalRepository>
    {
        public AnimalController() : base(new AnimalRepository())
        {
            ;
        }
    }
}
