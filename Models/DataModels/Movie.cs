using System.ComponentModel.DataAnnotations;

namespace Mundo_disney.Models.DataModels
{
    public class Movie : BaseEntity
    {
        [Required]
        public string Imagen { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
        [Required]
        public int Calificacion { get; set; }

        //Personajes Asociados
        [Required]
        public ICollection<Character> Characters { get; set; } = new List<Character>();
        [Required]
        public ICollection<Gender> Genders { get; set; } = new List<Gender>();
    }
}