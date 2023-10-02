using Healthy_Clinic_Manha_Edu.Contexts;
using Healthy_Clinic_Manha_Edu.Domains;
using Healthy_Clinic_Manha_Edu.Interfaces;
using Healthy_Clinic_Manha_Edu.Utils;

namespace Healthy_Clinic_Manha_Edu.Repositores
{
    public class MedicoRepository : IMedicoRepository
    {
        private readonly Context _evento;
        public MedicoRepository()
        {
            _evento = new Context();
        }
        public Medico BuscarPorId(Guid id)
        {
            return _evento.Medico.FirstOrDefault(e => e.IdMedico == id);
        }

        public void Cadastrar(Medico medico)
        {
            medico.Usuario.Senha = Criptografia.GerarHash(medico.Usuario.Senha);

            _evento.Medico.Add(medico);

            _evento.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Medico medicoBuscado= _evento.Medico.Find(id);

            _evento.Medico.Remove(medicoBuscado);

            _evento.SaveChanges();
        }

        public List<Medico> Listar()
        {
            return _evento.Medico.ToList();
        }
    }
}
