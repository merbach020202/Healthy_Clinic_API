using Healthy_Clinic_Manha_Edu.Domains;

namespace Healthy_Clinic_Manha_Edu.Interfaces
{
    public interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidade especialidade);

        void Deletar(Guid id);

        List<Especialidade> Listar();
    }
}
