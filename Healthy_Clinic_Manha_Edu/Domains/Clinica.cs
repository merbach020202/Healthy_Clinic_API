using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Healthy_Clinic_Manha_Edu.Domains
{
    [Table(nameof(Clinica))]
    public class Clinica
    {
        [Key]
        public Guid IdClinica { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Endereço é obrigatório")]
        public string? Endereco { get; set; }

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "horário de abertura obrigatório!")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"hh\:mm")]
        public TimeSpan? HorarioAbertura { get; set; }

        [Column(TypeName = "TIME")]
        [Required(ErrorMessage = "horário de abertura obrigatório!")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"hh\:mm")]
        public TimeSpan? HorarioFechamento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "CNPJ é obrigatória")]
        public string? CNPJ { get; set;}

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome fantasia é obrigatório")]
        public string? NomeFantasia { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Razão social é obrigatória")]
        public string? RazaoSocial { get; set; }
    }
}
