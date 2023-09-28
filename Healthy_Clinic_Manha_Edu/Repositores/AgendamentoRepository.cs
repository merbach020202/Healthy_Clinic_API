using Healthy_Clinic_Manha_Edu.Contexts;
using Healthy_Clinic_Manha_Edu.Domains;
using Healthy_Clinic_Manha_Edu.Interfaces;

namespace Healthy_Clinic_Manha_Edu.Repositores
{
    public class AgendamentoRepository : IAgendamentoRepository
    {
        private readonly Context _context;

        public AgendamentoRepository()
        {
            _context = new Context();
        }
        public void Atualizar(Guid id, Agendamento agendamento)
        {
            Agendamento agendamentoBuscado = _context.Agendamento.Find(id);

            if (agendamentoBuscado != null)
            {
                agendamentoBuscado.IdAgendamento = agendamento.IdAgendamento;
            }

            _context.Agendamento.Update(agendamentoBuscado);

            _context.SaveChanges();
        }

        public Agendamento BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Agendamento agendamento)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Agendamento> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
