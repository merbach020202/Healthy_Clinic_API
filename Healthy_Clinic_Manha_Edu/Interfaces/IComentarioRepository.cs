using Healthy_Clinic_Manha_Edu.Domains;

namespace Healthy_Clinic_Manha_Edu.Interfaces
{
    public interface IComentarioRepository
    {
        void Cadastrar(Comentario comentario);

        void Deletar(Guid id);

        List<Comentario> Listar();

        Comentario BuscarPorId(Guid id);
    }
}
