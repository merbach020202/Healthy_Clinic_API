using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Healthy_Clinic_Manha_Edu.Domains
{
    [Table(nameof(Comentario))]
    public class Comentario
    {
        [Key]
        public Guid IdComentario { get; set; } = Guid.NewGuid();


        //Referências
        [Required(ErrorMessage ="O nome do paciente é obrigatório")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? paciente { get; set; }


        [Required(ErrorMessage ="O nome do médico é obrigatório")]
        public Guid IdMedico { get; set; }
        
        [ForeignKey(nameof(IdMedico))]
        public Medico? Medico { get; set; }


        [Required(ErrorMessage ="O ID da consulta é obrigatório")]
        public Guid IdConsulta { get; set; }
        
        [ForeignKey(nameof(IdConsulta))]
        public Consulta? consulta { get; set; }
    }
}
