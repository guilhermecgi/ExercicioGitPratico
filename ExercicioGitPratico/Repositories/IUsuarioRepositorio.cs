using ExercicioGitPratico.Models;

namespace ExercicioGitPratico.Repositories
{
    public interface IUsuarioRepositorio
    {
        Task<bool> Cadastrar(UsuarioModel usuario, string senhaPura);
        Task<UsuarioModel?> BuscarEmail(string email);
    }
}