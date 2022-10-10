using System.ComponentModel.DataAnnotations;

namespace Mundo_disney.Models.DataModels
{
    public class Gender : BaseEntity
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Imagen { get; set; }

        //Peliculas asociadas
        [Required]
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}