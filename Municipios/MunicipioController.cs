using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ibge.Municipios
{
    [ApiController]
    [Route("municipios")]
    public class MunicipioController : ControllerBase
    {
        IMunicipios _municipios;

        public MunicipioController(IMunicipios municipios)
        {
            _municipios = municipios;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _municipios.Get());

        }
    }

}