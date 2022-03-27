using System.ComponentModel.DataAnnotations.Schema;

namespace DMP.Models
{
    [Table("FavouriteRecipes")]
    public class FavouriteRecipes
    {
        public int Id { get; set; }
        public virtual Recipes Recipe { get; set; }
        [ForeignKey("Recipes")]
        public int RecipeId { get; set; }
        public virtual Users User{ get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }

    }
}
