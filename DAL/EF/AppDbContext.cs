using ChatApp.BL.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.DAL.EF;

public class AppDbContext : IdentityDbContext<User>
{
    public DbSet<User> Users { get; set; }
    public DbSet<Membership> Memberships { get; set; }
    public DbSet<Server> Servers { get; set; }
    public DbSet<Channel> Channels { get; set; }
    public DbSet<Message> Messages { get; set; }

    public AppDbContext()
    {
        AppDbInitializer.Initialize(this, true);
    }
}