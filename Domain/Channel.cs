using System.ComponentModel.DataAnnotations;

namespace ChatApp.BL.Domain;

public class Channel
{
    [Key] public int Id { get; set; }
    [StringLength(32, MinimumLength = 3)] public string Name { get; set; }
    public ICollection<Message> Messages { get; set; }
    public Server Server { get; set; }
}