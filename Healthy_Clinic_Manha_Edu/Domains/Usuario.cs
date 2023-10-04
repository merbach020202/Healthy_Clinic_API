using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Healthy_Clinic_Manha_Edu.Domains
{
    [Table(nameof(Usuario))]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O Nome do usuário é obrigatório")]
        public string? Nome { get; set; }

        [Column(TypeName ="VARCHAR(50)")]
        [Required(ErrorMessage ="O Email é obrigatório")]
        public string? Email { get; set; }

        [Column(TypeName ="VARCHAR(60)")]
        [Required(ErrorMessage ="A senha é obrigatória")]
        public string? Senha { get; set; }


        //Referência

        public Guid IdTiposUsuario { get; set; }

        [ForeignKey(nameof(IdTiposUsuario))]
        public TiposUsuario? TiposUsuario { get; set; }
    }
}
