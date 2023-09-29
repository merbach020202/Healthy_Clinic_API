using Healthy_Clinic_Manha_Edu.Domains;

namespace Healthy_Clinic_Manha_Edu.Interfaces
{
    public interface IProntuarioRepository
    {
        void Cadastrar(Prontuario prontuario);

        void Deletar(Guid id);

        void Atualizar(Guid id, Prontuario prontuario);

        void BuscarPorId(Guid id);
        
        List<Prontuario> Listar();
    }
}
