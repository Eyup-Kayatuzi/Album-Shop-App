using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Models
{
    public class Album : Base
    {
        [Key]
        public int AlbumId { get; set; }
        public string ReleaseDate { get; set; } 
        public decimal AlbumPrice { get; set; }
        public decimal AlbumDiscount { get; set; }  
        public bool IsContinue { get; set; }

        [ForeignKey("ArtistId")]
        public int ArtistId { get; set; } 
        public virtual Artist Artist { get; set; }  
    }
}
