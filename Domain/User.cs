using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ChatApp.BL.Domain;

public class User : IdentityUser
{
    [Key] public int Id { get; set; }
    [StringLength(32, MinimumLength = 3)] public string Name { get; set; }
    [EmailAddress] public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime CreatedTime { get; set; }
    public string Password { get; set; }
    public byte[] Avatar { get; set; }
    public ICollection<Membership> Memberships { get; set; }
}