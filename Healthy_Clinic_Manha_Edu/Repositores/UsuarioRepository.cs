using Healthy_Clinic_Manha_Edu.Contexts;
using Healthy_Clinic_Manha_Edu.Domains;
using Healthy_Clinic_Manha_Edu.Interfaces;
using Healthy_Clinic_Manha_Edu.Utils;
using Microsoft.Data.SqlClient;

namespace Healthy_Clinic_Manha_Edu.Repositores
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Context _evento;
        public UsuarioRepository()
        {
            _evento = new Context();
        }

        public Usuario BuscarPorEmailSenha(string email, string senha)
        {
            try
            {
                Usuario usuarioBuscado = _evento.Usuario
                    .Select(u => new Usuario
                    {
                        IdUsuario = u.IdUsuario,
                        Nome = u.Nome,
                        Email = u.Email,
                        Senha = u.Senha,
                        TiposUsuario = new TiposUsuario
                        {
                            IdTiposUsuario = u.IdTiposUsuario,
                            Nome = u.TiposUsuario.Nome
                        }
                    }).FirstOrDefault(u => u.Email == email)!;

                //if (usuarioBuscado != null)
                //{
                //    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senha);

                //    if (confere)
                //    {
                //        return usuarioBuscado;
                //    }
                //}
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuario BuscarPorId(Guid id)
        {
            return _evento.Usuario.FirstOrDefault(e => e.IdUsuario == id);
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {
                usuario.Senha = Criptografia.GerarHash(usuario.Senha);

                _evento.TiposUsuario.Find(usuario.IdTiposUsuario);

                _evento.Usuario.Add(usuario);

                _evento.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Deletar(Guid id)
        {
            Usuario usuarioBuscado = _evento.Usuario.Find(id);

            _evento.Usuario.Remove(usuarioBuscado);

            _evento.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return _evento.Usuario.ToList();
        }
    }
}
