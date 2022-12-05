namespace ContactsAPI.Models
{
    public class AddContactRequest
    {
         public string FullName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
    }
}


//this file interacts with the "ContactsController.cs file and adds new users to the DB
//via http - Post request.
