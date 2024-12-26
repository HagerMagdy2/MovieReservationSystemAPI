using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReservationSystemAPI.Models
{
    public class ShowTime
    {
        public int id { get; set; }
        [ForeignKey("movie")]
        public int movie_id { get; set; }
        public virtual Movie? movie { get; set; }
        [ForeignKey("hall")]
        public int hall_id { get; set; }
        public virtual Hall? hall { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

       
    }
}
