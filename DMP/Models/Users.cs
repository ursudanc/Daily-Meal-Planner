using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Users.Models
{
    public class Users
    {
        public class Nutrients
        {
            [Column("ID")]
            public int Id { get; set; }
            [StringLength(30)]
            [Required(ErrorMessage = "Please enter a valid Username"), MaxLength(30)]
            [Column("USERNAME")]
            public string USERNAME { get; set; }
            [Column("PASSWORD")]
            [Required]
            public string Password { get; set; }
            [Column("ADMIN")]
            public bool Admin { get; set; }
            [Column("HEIGHT")]
            public int? Height { get; set; }
            [Column("WEIGHT")]
            public int? Weight { get; set; }
            [Column("AGE")]
            public int? Age { get; set; }
            [Column("SEX")]
            public string? Sex { get; set; }
        }
    }
}