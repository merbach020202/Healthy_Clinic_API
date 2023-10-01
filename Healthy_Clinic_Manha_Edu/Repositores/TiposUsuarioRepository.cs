using Healthy_Clinic_Manha_Edu.Contexts;
using Healthy_Clinic_Manha_Edu.Domains;
using Healthy_Clinic_Manha_Edu.Interfaces;

namespace Healthy_Clinic_Manha_Edu.Repositores
{
    public class TiposUsuarioRepository : ITiposUsuario
    {
        private readonly Context _evento;
        public TiposUsuarioRepository()
        {
            _evento = new Context();
        }
        public void Cadastrar(TiposUsuario tiposUsuario)
        {
            _evento.TiposUsuario.Add(tiposUsuario);

            _evento.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            TiposUsuario tipoUsuarioBuscado = _evento.TiposUsuario.Find(id);

            _evento.TiposUsuario.Remove(tipoUsuarioBuscado);

            _evento.SaveChanges();
        }

        public List<TiposUsuario> Listar()
        {
            return _evento.TiposUsuario.ToList();
        }
    }
}
