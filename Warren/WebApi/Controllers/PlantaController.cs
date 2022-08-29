﻿using Data.Model;
using Data.Respository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantaController : GenericController<Planta, PlantaRepository>
    {
        public PlantaController() : base(new PlantaRepository())
        {
        }
    }
}
