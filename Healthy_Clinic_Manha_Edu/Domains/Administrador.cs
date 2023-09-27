using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Healthy_Clinic_Manha_Edu.Domains
{
    [Table(nameof(Administrador))]
    public class Administrador
    {
        [Key]
        public Guid IdAdministrador = Guid.NewGuid();

        public string? Email { get; set; }

        public string? Senha { get; set; }


        //Referências
        [Required(ErrorMessage ="Informe o tipo de usuário")]
        public Guid IdTiposUsuario { get; set; }

        [ForeignKey(nameof(IdTiposUsuario))]
        public TiposUsuario? TiposUsuario { get; set; }
    }
}
