using System.Diagnostics;
using ChatApp.BL.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ChatApp.DAL.EF;

public class AppDbContext : IdentityDbContext<User>
{
    public new DbSet<User> Users { get; set; }
    public DbSet<Membership> Memberships { get; set; }
    public DbSet<Server> Servers { get; set; }
    public DbSet<Channel> Channels { get; set; }
    public DbSet<Message> Messages { get; set; }

    public AppDbContext(DbContextOptions options) : base(options)
    {
        AppDbInitializer.Initialize(this, true);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(message => Debug.WriteLine(message), LogLevel.Information);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Membership>()
            .HasOne<User>()
            .WithMany(user => user.Memberships)
            .IsRequired();
        builder.Entity<Membership>()
            .HasOne<Server>()
            .WithMany(server => server.Members)
            .IsRequired();
    }
}