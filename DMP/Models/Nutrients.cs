using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMP.Models
{
    [Table("Nutrients")]
    public class Nutrients
    {
        public int Id { get; set; }
        [DisplayName("Calories (g)")]
        public int Calories { get; set; }
        [DisplayName("Proteins (g)")]
        public int Proteins { get; set; }
        [DisplayName("Fats (g)")]
        public int Fats { get; set; }
        [DisplayName("Sugar (g)")]
        public int Sugar { get; set; }
        [DisplayName("Carbs (g)")]
        public int Carbs { get; set; }
        [DisplayName("Fibers (g)")]
        public int Fibers { get; set; }

        public virtual Recipes Recipe { get; set; }
    }
}
