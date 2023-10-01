using Healthy_Clinic_Manha_Edu.Contexts;
using Healthy_Clinic_Manha_Edu.Domains;
using Healthy_Clinic_Manha_Edu.Interfaces;

namespace Healthy_Clinic_Manha_Edu.Repositores
{
    public class ProntuarioRepository : IProntuarioRepository
    {
        private readonly Context _evento;
        public ProntuarioRepository()
        {
            _evento = new Context();
        }
        public Prontuario BuscarPorId(Guid id)
        {
            return _evento.Prontuario.FirstOrDefault(e => e.IdProntuario == id);
        }

        public void Cadastrar(Prontuario prontuario)
        {
            _evento.Prontuario.Add(prontuario);

            _evento.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Prontuario prontuarioBuscado = _evento.Prontuario.Find(id);

            _evento.Prontuario.Remove(prontuarioBuscado);

            _evento.SaveChanges();
        }

        public List<Prontuario> Listar()
        {
            return _evento.Prontuario.ToList();
        }
    }
}
