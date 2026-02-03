namespace JWT.models;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

    public class UserIdentityContext : IdentityDbContext<AppUser>

{
    public UserIdentityContext(DbContextOptions<UserIdentityContext> options) : base(options)
    { }

}

