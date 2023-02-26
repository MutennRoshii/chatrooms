using System.ComponentModel.DataAnnotations;

namespace ChatApp.BL.Domain;

public class Membership
{
    [Key] public int Id { get; set; }
    [Required] public Server Server { get; set; }
    [Required] public User User { get; set; }
    [StringLength(32, MinimumLength = 3)] public string Username { get; set; }
    public ICollection<Message> Messages { get; set; }
    public DateTime JoinedTime { get; set; }
    public bool IsActive { get; set; }
}