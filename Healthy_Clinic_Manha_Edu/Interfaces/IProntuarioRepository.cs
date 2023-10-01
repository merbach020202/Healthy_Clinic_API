using Healthy_Clinic_Manha_Edu.Domains;

namespace Healthy_Clinic_Manha_Edu.Interfaces
{
    public interface IProntuarioRepository
    {
        void Cadastrar(Prontuario prontuario);

        void Deletar(Guid id);

        Prontuario BuscarPorId(Guid id);
        
        List<Prontuario> Listar();
    }
}
