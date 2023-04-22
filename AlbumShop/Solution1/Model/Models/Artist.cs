using System.ComponentModel.DataAnnotations;

namespace Shop.Model.Models
{
    public class Artist : Base
    {
        [Key]
        public int ArtistId { get; set; } 

        public virtual List<Album> Albums { get; set;} = new List<Album>();
    }
}