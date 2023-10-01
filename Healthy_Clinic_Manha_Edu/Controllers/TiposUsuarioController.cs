using Healthy_Clinic_Manha_Edu.Domains;
using Healthy_Clinic_Manha_Edu.Interfaces;
using Healthy_Clinic_Manha_Edu.Repositores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Healthy_Clinic_Manha_Edu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TiposUsuarioController : ControllerBase
    {
        private ITiposUsuario _tiposUsuario;

        public TiposUsuarioController()
        {
            _tiposUsuario = new TiposUsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_tiposUsuario.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]

        public IActionResult Post(TiposUsuario tiposUsuario)
        {
            try
            {
                _tiposUsuario.Cadastrar(tiposUsuario);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _tiposUsuario.Deletar(id);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
