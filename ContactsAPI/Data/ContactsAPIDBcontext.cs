using Microsoft.EntityFrameworkCore;
using ContactsAPI.Models;

namespace ContactsAPI.Data

{
    public class ContactsAPIDBcontext: DbContext
    {
        public ContactsAPIDBcontext(DbContextOptions options) : base(options){

        }
        public DbSet<Contacts> Contacts { get; set; }
        //these are DB tables
    }
}
