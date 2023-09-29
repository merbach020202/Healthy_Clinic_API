using Healthy_Clinic_Manha_Edu.Domains;

namespace Healthy_Clinic_Manha_Edu.Interfaces
{
    public interface IClinicaRepository
    {
        void Cadastrar(Clinica clinica);

        void Deletar(Guid id);

        Clinica BuscarPorId(Guid id);
    }
}
