using System.ComponentModel.DataAnnotations;

namespace Mundo_disney.Models.DataModels
{
    public class Users : BaseEntity
    {
        [Required(ErrorMessage ="Nombre Requerido"), StringLength(50, ErrorMessage = "Nombre supera el máximo de caracteres")]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(100)]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Correo Requerido"), EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Contraseña Requerido")]
        public string Password { get; set; } = string.Empty;
    }
}