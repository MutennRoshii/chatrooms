using ChatApp.BL.Domain;

namespace ChatApp.DAL;

public interface IRepository
{
    public User GetUserById(int userId);
    public Membership GetMembershipById(int serverId, int userId);
    public Server GetServerById(int serverId);
    public Message GetMessageById(int messageId);
    public Channel GetChannelById(int channelId);
}