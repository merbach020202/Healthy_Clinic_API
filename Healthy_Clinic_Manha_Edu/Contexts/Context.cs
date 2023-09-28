using Healthy_Clinic_Manha_Edu.Domains;
using Microsoft.EntityFrameworkCore;

namespace Healthy_Clinic_Manha_Edu.Contexts
{
    public class Context : DbContext
    {
        public DbSet<Administrador> Administrador { get; set; }
        public DbSet<Agendamento> Agendamento { get; set; }
        public DbSet<Clinica> Clinica { get; set; }
        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Prontuario> Prontuario { get; set; }
        public DbSet<TiposUsuario> TiposUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE05-S15; DataBase=Healthy_Clinic_Manha_Edu; User Id=sa; Password=Senai@134; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
