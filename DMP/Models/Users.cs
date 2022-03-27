using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMP.Models
{
    [Table("Users")]
    public class Users
    {
        public int Id { get; set; }
        [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Only Alphabets and Numbers allowed.")]
        [Required(ErrorMessage = "Please enter a Username no longer than 25 characters"), MaxLength(25)]
        [StringLength(25, MinimumLength = 6)]
        [DisplayName("Username")]
        public string username { get; set; }
        [Required]
        [MaxLength(25)]
        [DataType(DataType.Password)]
        [StringLength(25, MinimumLength = 6)]
        [DisplayName("Password")]
        public string password { get; set; }
        public bool admin { get; set; }
        [DisplayName("Height (CM)")]
        public int? height { get; set; }
        [DisplayName("Weight (KG)")]
        public int? weight { get; set; }
        [DisplayName("Age")]
        public int? age { get; set; }
        [DisplayName("Sex")]
        [MaxLength(1)]
        [RegularExpression("^[fm]*$", ErrorMessage = "Please enter only f or m")]
        public string? sex { get; set; }
        
    }
}