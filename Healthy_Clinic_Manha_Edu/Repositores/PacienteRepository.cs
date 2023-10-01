using Healthy_Clinic_Manha_Edu.Contexts;
using Healthy_Clinic_Manha_Edu.Domains;
using Healthy_Clinic_Manha_Edu.Interfaces;

namespace Healthy_Clinic_Manha_Edu.Repositores
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly Context _evento;
        public PacienteRepository()
        {
            _evento = new Context();
        }
        public Paciente BuscarPorId(Guid id)
        {
            return _evento.Paciente.FirstOrDefault(e => e.IdPaciente == id);
        }

        public void Cadastrar(Paciente paciente)
        {
            _evento.Paciente.Add(paciente);

            _evento.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Paciente pacienteBuscado = _evento.Paciente.Find(id);

            _evento.Paciente.Remove(pacienteBuscado);

            _evento.SaveChanges();
        }

        public List<Paciente> Listar()
        {
            return _evento.Paciente.ToList();
        }
    }
}
