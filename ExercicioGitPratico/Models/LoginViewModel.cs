using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ExercicioGitPratico.Models
{
    public class LoginViewModel
    {
        // Torna o campo 'Email' obrigatório; se estiver vazio, exibe a mensagem personalizada
        [Required(ErrorMessage = "Informe o e-mail.")]
        // Valida se o texto digitado está no formato padrão de um e-mail válido
        [EmailAddress(ErrorMessage = "E-mail inválido.")]

        // Propriedade pública que armazena o e-mail, inicializada por segurança com string vazia
        public string Email { get; set; } = string.Empty;

        // Torna o campo 'Senha' obrigatório; se estiver vazio, exibe a mensagem personalizada
        [Required(ErrorMessage = "Informe a senha.")]
        // Informa ao ASP.NET Core que este campo é do tipo senha (mascara os caracteres na interface)
        [DataType(DataType.Password)]

        // Propriedade pública que armazena a senha, inicializada com string vazia
        public String Senha { get; set; } = String.Empty;
    }
}
