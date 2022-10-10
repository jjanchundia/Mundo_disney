using System.ComponentModel.DataAnnotations;

namespace Mundo_disney.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; }= DateTime.Now;
        public string UpdateBy { get; set; } = string.Empty;
        public DateTime? UpdateAt { get; set; }
        public string DeleteBy { get; set; } = string.Empty;
        public DateTime? DeleteAt { get; set; }
        public bool IsDeleted { get; set; } = false;

        //[Required].
        //[Key]
        //public int Id { get; set; }
        //public int UserId { get; set; }
        //public Users CreatedBy { get; set; } = new Users();
        //public DateTime CreateAt { get; set; } = DateTime.Now;
        //public Users UpdateBy { get; set; } = new Users();
        //public DateTime? UpdateAt { get; set; }
        //public Users DeleteBy { get; set; } = new Users();
        //public DateTime? DeleteAt { get; set; }
        //public bool IsDeleted { get; set; } = false;
    }
}
