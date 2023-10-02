using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Healthy_Clinic_Manha_Edu.Domains
{
    [Table(nameof(Consulta))]
    public class Consulta
    {
        [Key]
        public Guid IdConsulta { get; set; } = Guid.NewGuid();


        //Referências
        [Required(ErrorMessage ="Informe o nome do médico")]
        public Guid IdMedico { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Medico? medico { get; set; }

        
        [Required(ErrorMessage ="Informe o nome do paciente")]
        public Guid Idpaciente { get; set; }

        [ForeignKey(nameof(Idpaciente))]
        public Paciente? paciente { get; set; }


        public Guid IdProntuario { get; set; }
        
        [ForeignKey(nameof(IdProntuario))]
        public Prontuario? prontuario { get; set; }


        public Guid IdAgendamento { get; set; }

        [ForeignKey(nameof(IdAgendamento))]
        public Agendamento? agendamento { get; set; }
    }
}
