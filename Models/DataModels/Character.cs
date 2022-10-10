using System.ComponentModel.DataAnnotations;

namespace Mundo_disney.Models.DataModels
{
    public class Character : BaseEntity
    {
        [Required]
        public string Imagen { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        public int Peso { get; set; }
        [Required]
        public string Historia { get; set; }
        //Peliculas
        //[Required]
        //public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}