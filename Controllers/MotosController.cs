using Microsoft.AspNetCore.Mvc;
using TPInvestigacion.Clases;
using TPInvestigacion.Interfaces;

namespace TPInvestigacion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MotosController : ControllerBase
    {
        private readonly IApiRepository _repo;

        public MotosController(IApiRepository repo) 
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            var motos = await _repo.GetMotosAsync();
            return Ok(motos);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Moto moto)
        {
            _repo.Add(moto);
            if (await _repo.SaveAll())
                return Ok(moto);

            return BadRequest();
        }

    }
}
