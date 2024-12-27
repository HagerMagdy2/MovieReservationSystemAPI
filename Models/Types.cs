using System.ComponentModel.DataAnnotations;

namespace MovieReservationSystemAPI.Models
{
    public class Types
    {
        [Key]
        public int Type_id { get; set; }
        public string Type_name { get; set; }
      public virtual  List<Movie> Movies { get; set; }=new List<Movie>();
    }
}
