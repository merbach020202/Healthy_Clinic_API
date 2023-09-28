using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Healthy_Clinic_Manha_Edu.Domains
{
    [Table(nameof(Administrador))]
    public class Administrador
    {
        [Key]
        public Guid IdAdministrador { get; set; } = Guid.NewGuid();

        [Column(TypeName ="VARCHAR(50)")]
        public string? Email { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string? Senha { get; set; }


        //Referências
        [Required(ErrorMessage ="Informe o tipo de usuário")]
        public Guid IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario? Usuario { get; set; }
    }
}
