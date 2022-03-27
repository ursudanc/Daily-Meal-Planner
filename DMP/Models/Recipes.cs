using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMP.Models
{
    [Table("Recipes")]
    public class Recipes
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        public byte[] Image { get; set; }
        [MaxLength(10)]
        [Required]
        public string Type { get; set; }
        public int Portions { get; set; }
        public virtual Nutrients Nutrient { get; set; }
        [ForeignKey("Nutrients")]
        public int NutrientId { get; set; }




    }
}
