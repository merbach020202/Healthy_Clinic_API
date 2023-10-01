using Healthy_Clinic_Manha_Edu.Contexts;
using Healthy_Clinic_Manha_Edu.Domains;
using Healthy_Clinic_Manha_Edu.Interfaces;

namespace Healthy_Clinic_Manha_Edu.Repositores
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly Context _event;
        public ConsultaRepository()
        {
            _event = new Context();
        }

        public Consulta BuscarPorId(Guid id)
        {
            return _event.Consulta.FirstOrDefault(e => e.IdConsulta == id);
        }

        public void Cadastrar(Consulta consulta)
        {
            _event.Consulta.Add(consulta);

            _event.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Consulta consultaBuscada = _event.Consulta.Find(id);

            _event.Consulta.Remove(consultaBuscada);

            _event.SaveChanges();
        }

        public List<Consulta> Listar()
        {
            return _event.Consulta.ToList();
        }
    }
}
