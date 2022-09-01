using Data.Model;
using Data.Respository;

namespace WebApi.Controllers
{
    public class AnimalController : GenericController<Animal, AnimalRepository>
    {
    }
}
