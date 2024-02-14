using Microsoft.AspNetCore.Identity;

namespace USAtoBrazil.Services.Identity.DbContexts
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
