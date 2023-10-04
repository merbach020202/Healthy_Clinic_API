using Healthy_Clinic_Manha_Edu.Domains;
using Healthy_Clinic_Manha_Edu.Interfaces;
using Healthy_Clinic_Manha_Edu.Repositores;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Healthy_Clinic_Manha_Edu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    //[Authorize(Roles ="Administrador")]
    public class EspecialidadeController : ControllerBase
    {
        private EspecialidadeRepository _especialidade;

        public EspecialidadeController()
        {
            _especialidade = new EspecialidadeRepository();
        }

        [HttpPost]
        public IActionResult Cadastrar(Especialidade especialidade)
        {
            try
            {
                _especialidade.Cadastrar(especialidade);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(Guid id)
        {
            try
            {
                _especialidade.Deletar(id);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_especialidade.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Atualizar(Guid id, Especialidade especialidade)
        {
            try
            {
                _especialidade.Atualizar(id, especialidade);

                return Ok(_especialidade);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
