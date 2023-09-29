using Healthy_Clinic_Manha_Edu.Domains;

namespace Healthy_Clinic_Manha_Edu.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);

        void Deletar(Guid id);

        void BuscarPorId(Guid id);

        void Atualizar(Guid id, Usuario usuario);

        List<Usuario> Listar();
    }
}
