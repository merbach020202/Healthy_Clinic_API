using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Healthy_Clinic_Manha_Edu.Domains
{
    [Table(nameof(Especialidades))]
    public class Especialidades
    {
        [Key]
        public Guid IdEspecialdiades { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(20)")]
        public string? EspecialidadesMedico { get; set; }
    }
}
