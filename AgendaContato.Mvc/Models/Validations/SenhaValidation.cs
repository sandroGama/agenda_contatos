using System.ComponentModel.DataAnnotations;

namespace AgendaContatos.Mvc.Models.Validations
{
    public class SenhaValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if(value != null && value is string)
            {
                var senha = value as string;

                return senha.Any(s => char.IsLower(s))
                    && senha.Any(s => char.IsUpper(s))
                    && senha.Any(s => char.IsDigit(s))
                    && (
                        senha.Contains("@") ||
                        senha.Contains("$") ||
                        senha.Contains("%") ||
                        senha.Contains("#") ||
                        senha.Contains("&")
                        );
            }

            return false;
        }
    }
}
