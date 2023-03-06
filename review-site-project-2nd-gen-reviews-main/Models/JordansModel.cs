using System.ComponentModel.DataAnnotations;

namespace Review_Site_Sok_Michael.Models
{
    public class JordansModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(50)]
        public string Color { get; set; } = null!;
        [Required]
        [StringLength(50)]
        public string ShoeType { get; set; } = null!;
        public string ImageURL { get; set; } = null!;
        public virtual List<ReviewModel>? Reviews { get; set; }
    }
}
