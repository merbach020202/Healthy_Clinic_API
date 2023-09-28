using Healthy_Clinic_Manha_Edu.Domains;

namespace Healthy_Clinic_Manha_Edu.Interfaces
{
    public interface IAdministradorRepository
    {
        void Cadastrar(Administrador administrador);
        void Deletar(Guid id);
        List<Administrador> Listar();
    }
}
