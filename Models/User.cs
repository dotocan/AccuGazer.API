namespace AccuGazer.API.Models
{
    public class User
    {
        public long Id { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PassswordSalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public long DateOfBirth { get; set; }
    }
}