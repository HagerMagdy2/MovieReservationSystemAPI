using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReservationSystemAPI.Models
{

    public class Movie
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public decimal Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        [ForeignKey("types")]
        public int type_id { get; set; }
        public virtual Types? types { get; set; }
        [ForeignKey("actor")]
        public int actor_id { get; set; }
        public virtual Actor? actor { get; set; }
        public virtual List<ShowTime> shows { get; set; }= new List<ShowTime>();
    }
}
