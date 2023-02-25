using System.ComponentModel.DataAnnotations;

namespace ChatApp.BL.Domain;

public class Message
{
    [Key] public int Id { get; set; }
    public Membership Sender { get; set; }
    [StringLength(255, MinimumLength = 1)] public string Content { get; set; }
    public DateTime Sent { get; set; }
    public DateTime Arrived { get; set; }
    public Channel Channel { get; set; }
}