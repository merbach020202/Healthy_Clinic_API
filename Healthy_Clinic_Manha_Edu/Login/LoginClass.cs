using System.ComponentModel.DataAnnotations;

namespace Healthy_Clinic_Manha_Edu.Login
{
    public class LoginClass
    {
        [Required(ErrorMessage = "O Email é obrigatório!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatória!")]
        public string? Senha { get; set; }
    }
}
