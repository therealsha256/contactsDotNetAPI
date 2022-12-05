namespace ContactsAPI.Models
//contacts domain model
{
    public class Contacts
    {
        public Guid Id { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }

    }
}