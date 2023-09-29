using Healthy_Clinic_Manha_Edu.Domains;

namespace Healthy_Clinic_Manha_Edu.Interfaces
{
    public interface ITiposUsuario
    {
        void Cadastrar(TiposUsuario tiposUsuario);

        void Deletar(TiposUsuario tiposUsuario);

        List<TiposUsuario> tiposUsuarios();
    }
}
