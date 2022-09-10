using System.ComponentModel.DataAnnotations;

namespace AgendaContatos.Mvc.Models
{
    /// <summary>
    /// Modelo de dados para a página de recuperação de senha
    /// </summary>
    public class AccountPasswordModel
    {
        [EmailAddress(ErrorMessage = "Por favor, informe um endereço de email válido.")]
        [Required(ErrorMessage = "Por favor, informe o email de acesso.")]
        public string Email { get; set; }
    }
}
