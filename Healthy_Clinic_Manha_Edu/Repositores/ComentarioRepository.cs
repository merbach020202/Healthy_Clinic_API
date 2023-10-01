using Healthy_Clinic_Manha_Edu.Contexts;
using Healthy_Clinic_Manha_Edu.Domains;
using Healthy_Clinic_Manha_Edu.Interfaces;

namespace Healthy_Clinic_Manha_Edu.Repositores
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly Context _evento;
        public ComentarioRepository()
        {
            _evento = new Context();
        }
        public Comentario BuscarPorId(Guid id)
        {
            return _evento.Comentario.FirstOrDefault(e => e.IdComentario == id);
        }

        public void Cadastrar(Comentario comentario)
        {
            _evento.Comentario.Add(comentario);

            _evento.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Comentario comentarioBuscado = _evento.Comentario.Find(id);

            _evento.Comentario.Remove(comentarioBuscado);

            _evento.SaveChanges();
        }

        public List<Comentario> Listar()
        {
            return _evento.Comentario.ToList();
        }
    }
}
