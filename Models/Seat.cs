using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReservationSystemAPI.Models
{
    public class Seat
    {
        [Key]
        public int id { get; set; }
        public int Number { get; set; }
        public string Status { get; set; }
        [ForeignKey("hall")]
        public int hall_id { get; set; }
        public virtual Hall? hall { get; set; }
        public virtual List<ResevationDetails> resevals { get; set; } = new List<ResevationDetails>();
    }
}
