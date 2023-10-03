using Healthy_Clinic_Manha_Edu.Domains;

namespace Healthy_Clinic_Manha_Edu.Interfaces
{
    public interface IAgendamentoRepository
    {
        void Cadastrar(Agendamento agendamento);

        void Deletar(Guid id);

        Agendamento BuscarPorId(Guid id);

        void Atualizar(Guid id, Agendamento agendamento);
    }
}
