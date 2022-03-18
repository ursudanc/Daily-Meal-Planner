namespace Login.Models
{
    public class Login
    {
        public int Id { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public bool admin { get; set; }
    }
}