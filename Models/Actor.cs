using System.ComponentModel.DataAnnotations;

namespace MovieReservationSystemAPI.Models
{
    public class Actor
    {
        [Key]
        public int id { get; set; }
        [StringLength(50)]
        [Required]
        public string name { get; set; }
        public string bio { get; set; }
        public int NumberOfMovies { get; set; }
        public virtual List<Movie> Movies { get; set; } = new List<Movie>();
    }
}
