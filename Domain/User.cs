using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ChatApp.BL.Domain;

public class User : IdentityUser
{
    [StringLength(32, MinimumLength = 3)] public string Name { get; set; }
    public DateTime CreatedTime { get; set; }
    public byte[] Avatar { get; set; }
    public ICollection<Membership> Memberships { get; set; }
}