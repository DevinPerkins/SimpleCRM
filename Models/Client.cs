namespace SimpleCRM.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal AccountBalance { get; set; }
        public bool IsActive { get; set; }

    }
}