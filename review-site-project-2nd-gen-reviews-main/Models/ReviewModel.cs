using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Review_Site_Sok_Michael.Models
{
    public class ReviewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(100)]
        public string Description { get; set; } = null!;
        [ForeignKey("JordansModel")]
        public int JordansId { get; set; }
        public virtual JordansModel? Jordans { get; set; }
        [NotMapped]
        public List<SelectListItem>? JordansList { get; set; }
    }
}
