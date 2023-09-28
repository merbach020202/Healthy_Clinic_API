using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Healthy_Clinic_Manha_Edu.Domains
{
    [Table(nameof(Agendamento))]
    public class Agendamento
    {
        [Key]
        public Guid IdAgendamento { get; set; } = Guid.NewGuid();

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "data de nascimento obrigatoria!")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataConsulta { get; set; }


        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "horário da consulta obrigatório!")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"hh\:mm")]
        public TimeSpan? HorarioConsulta { get; set; }



        //Referências
        [Required(ErrorMessage = "O nome do médico é obrigatório")]
        public Guid IdMedico { get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Medico? medico { get; set; }


        [Required(ErrorMessage = "O nome do paciente é obrigatório")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? paciente { get; set; }


        [Required(ErrorMessage = "O nome do administrador é obrigatório")]
        public Guid IdAdministrador { get; set; }

        [ForeignKey(nameof(IdAdministrador))]
        public Administrador? administrador { get; set; }
    }
}
