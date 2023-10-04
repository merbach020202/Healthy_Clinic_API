using Healthy_Clinic_Manha_Edu.Domains;
using Healthy_Clinic_Manha_Edu.Interfaces;
using Healthy_Clinic_Manha_Edu.Repositores;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Healthy_Clinic_Manha_Edu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    //[Authorize(Roles ="Administrador")]
    public class ClinicaController : ControllerBase
    {
        private IClinicaRepository _clinica;

        public ClinicaController()
        {
            _clinica = new ClinicaRepository();
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_clinica.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]

        public IActionResult Post(Clinica clinica)
        {
            try
            {
                _clinica.Cadastrar(clinica);

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
                _clinica.Deletar(id);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(Guid id)
        {
            try
            {
                return Ok(_clinica.BuscarPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Atualizar(Guid id, Clinica clinica)
        {
            try
            {
                _clinica.Atualizar(id, clinica);

                return Ok(_clinica);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
