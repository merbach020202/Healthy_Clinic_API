using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Healthy_Clinic_Manha_Edu.Domains
{
    [Table(nameof(Agendamento))]
    public class Agendamento
    {
        [Key]
        public Guid IdAgendamento = Guid.NewGuid();


    }
}
