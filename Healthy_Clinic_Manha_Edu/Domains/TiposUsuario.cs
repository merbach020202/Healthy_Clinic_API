using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Healthy_Clinic_Manha_Edu.Domains
{
    [Table(nameof(TiposUsuario))]
    public class TiposUsuario
    {
        [Key]
        public Guid IdTiposUsuario { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage ="Nome do tipo do usuario é obrigatório")]
        [Column(TypeName ="VARCHAR(20)")]
        public string? Nome { get; set; }
    }
}
