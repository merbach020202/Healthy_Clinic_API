using Healthy_Clinic_Manha_Edu.Domains;

namespace Healthy_Clinic_Manha_Edu.Interfaces
{
    public interface IPacienteRepository
    {
        void Cadastrar(Paciente paciente);

        void Deletar(Guid id);
        
        List<Paciente> Listar();

        void BuscarPorId(Guid id, Paciente paciente);
    }
}
