using Healthy_Clinic_Manha_Edu.Contexts;
using Healthy_Clinic_Manha_Edu.Domains;
using Healthy_Clinic_Manha_Edu.Interfaces;
using Healthy_Clinic_Manha_Edu.Utils;

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
            return _context.Agendamento.FirstOrDefault(e => e.IdAgendamento == id);
        }

        public void Cadastrar(Agendamento agendamento)
        {
            _context.Agendamento.Add(agendamento);

            _context.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Agendamento agendamentoBuscado = _context.Agendamento.Find(id);

            _context.Agendamento.Remove(agendamentoBuscado);

            _context.SaveChanges();
        }
    }
}
