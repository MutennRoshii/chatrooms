using System.ComponentModel.DataAnnotations;

namespace ChatApp.BL.Domain;

public class Server
{
    [Key] public int Id { get; set; }
    [StringLength(32, MinimumLength = 3)] public string Name { get; set; }
    public User Creator { get; set; }
    public DateTime CreatedTime { get; set; }
    public bool IsPublic { get; set; }
    public byte[] ServerImage { get; set; }
    public ICollection<Membership> Members { get; set; }
    public ICollection<Channel> Channels { get; set; }
}