using Healthy_Clinic_Manha_Edu.Domains;

namespace Healthy_Clinic_Manha_Edu.Interfaces
{
    public interface IConsultaRepository
    {
        void Cadastrar(Consulta consulta);

        void Deletar(Guid id);

        List<Consulta> Listar();

        Consulta BuscarPorId(Guid id);
    }
}
