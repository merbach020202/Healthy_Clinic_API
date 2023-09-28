using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Healthy_Clinic_Manha_Edu.Domains
{
    [Table(nameof(Medico))]
    [Index(nameof(CRM), IsUnique = true)]
    public class Medico
    {
        [Key]
        public Guid IdMedico { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(50)")]
        [Required(ErrorMessage ="O nome do médico é obrigatório")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O Email é obrigatório")]
        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "a senha é obrigatória")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "A senha deve conter de 5 a 50 caracteres")]
        public string? Senha { get; set; }

        [Column(TypeName = "VARCHAR(6)")]
        [Required(ErrorMessage = "O CRM é obrigatório")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "O CRM deve conter 6 caracteres")]
        public string CRM { get; set; }


        //Referências
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }


        public Guid IdClinica { get; set; }

        [ForeignKey(nameof(IdClinica))]
        public Clinica? Clinica { get; set; }


        public Guid IdEspecialidades { get; set; }

        [ForeignKey(nameof(IdEspecialidades))]
        public Especialidade? Especialidades { get; set; }
    }
}
