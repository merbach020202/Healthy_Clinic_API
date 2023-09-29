using Healthy_Clinic_Manha_Edu.Contexts;
using Healthy_Clinic_Manha_Edu.Domains;
using Healthy_Clinic_Manha_Edu.Interfaces;

namespace Healthy_Clinic_Manha_Edu.Repositores
{
    public class EspecialidadeRepository : IEspecialidadeRepository
    {
        private readonly Context _evento;
        public EspecialidadeRepository()
        {
            _evento = new Context();
        }
        public void Cadastrar(Especialidade especialidade)
        {

            _evento.Especialidade.Add(especialidade);

            _evento.SaveChanges();

        }

        public void Deletar(Guid id)
        {
            Especialidade especialidadeBuscada = _evento.Especialidade.Find(id);

            _evento.Especialidade.Remove(especialidadeBuscada);

            _evento.SaveChanges();
        }

        public List<Especialidade> Listar()
        {
            return _evento.Especialidade.ToList();
        }
    }
}
