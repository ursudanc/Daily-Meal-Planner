namespace Users.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool admin { get; set; }
        public int? height { get; set; }
        public int? weight { get; set; }
        public int? age { get; set; }
        public string? sex { get; set; }
    }
}