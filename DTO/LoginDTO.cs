using System.ComponentModel.DataAnnotations;

namespace api_filmes_senai.DTO
{
    public class LoginDTO
    {

        [Required(ErrorMessage = "A senha é Obrigatória! ")]
        public string? Email { get; set; }


        [Required(ErrorMessage = "A senha é Obrigatória! ")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "A senha deve conter no mínimo 6 caracteres e no máximo 60")]
        public string? Senha { get; set; }
    }
}

