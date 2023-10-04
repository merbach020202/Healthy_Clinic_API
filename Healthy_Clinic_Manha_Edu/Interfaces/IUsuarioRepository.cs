using Healthy_Clinic_Manha_Edu.Domains;

namespace Healthy_Clinic_Manha_Edu.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuario);

        void Deletar(Guid id);

        Usuario BuscarPorEmailSenha(string email, string senha);

        Usuario BuscarPorId(Guid id);

        List<Usuario> Listar();
    }
}
