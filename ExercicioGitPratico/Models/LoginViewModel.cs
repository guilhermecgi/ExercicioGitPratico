using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ExercicioGitPratico.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o e-mail.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]

        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe a senha.")]
        [DataType(DataType.Password)]

        public String Senha { get; set; } = String.Empty;
    }
}
