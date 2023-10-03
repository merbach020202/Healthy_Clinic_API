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
    public class AgendamentoController : ControllerBase
    {
        private IAgendamentoRepository _agendamento;

        public AgendamentoController()
        {
            _agendamento = new AgendamentoRepository();
        }

        [HttpPost]
        public IActionResult Cadastrar(Agendamento agendamento)
        {
            try
            {
                _agendamento.Cadastrar(agendamento);

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
                _agendamento.Deletar(id);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult Atualizar (Guid id, Agendamento agendamento)
        {
            try
            {
                _agendamento.Atualizar(id, agendamento);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
