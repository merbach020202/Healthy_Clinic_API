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
    }
}
