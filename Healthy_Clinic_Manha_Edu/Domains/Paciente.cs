using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Healthy_Clinic_Manha_Edu.Domains
{
    [Table(nameof(Paciente))]
    public class Paciente
    {
        [Key]
        public Guid IdPaciente { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(50)")]
        [Required(ErrorMessage ="O nome do paciente é obrigatório")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "a senha é obrigatória")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "A senha deve conter de 5 a 50 caracteres")]
        public string? Senha { get; set; }

        [Column(TypeName ="VARCHAR(50)")]
        [Required(ErrorMessage ="O Email é obrigatório")]
        public string? Email { get; set; }

        //Referências
        public Guid IdUsuario { get; set; }
        
        [ForeignKey(nameof(IdUsuario))]
        public Usuario? usuario { get; set; }
    }
}
