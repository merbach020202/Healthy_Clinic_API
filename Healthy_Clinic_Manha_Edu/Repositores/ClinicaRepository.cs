using Healthy_Clinic_Manha_Edu.Contexts;
using Healthy_Clinic_Manha_Edu.Domains;
using Healthy_Clinic_Manha_Edu.Interfaces;

namespace Healthy_Clinic_Manha_Edu.Repositores
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly Context _evento;
        public ClinicaRepository()
        {
            _evento = new Context();
        }

        public void Atualizar(Guid id, Clinica clinica)
        {
            try
            {
                _evento.Atualizar(id, clinica);

                return Ok(_evento);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        public Clinica BuscarPorId(Guid id)
        {
            return _evento.Clinica.FirstOrDefault(e => e.IdClinica == id);
        }

        public void Cadastrar(Clinica clinica)
        {
            _evento.Clinica.Add(clinica);

            _evento.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Clinica clinicaBuscada = _evento.Clinica.Find(id);

            _evento.Clinica.Remove(clinicaBuscada);

            _evento.SaveChanges();
        }

        public List<Clinica> Listar()
        {
            return _evento.Clinica.ToList();
        }
    }
}
