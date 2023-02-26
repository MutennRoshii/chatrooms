using ChatApp.BL.Domain;

namespace ChatApp.DAL.EF;

public class AppRepository : IRepository
{
    private readonly AppDbContext _ctx;

    public AppRepository(AppDbContext ctx)
    {
        _ctx = ctx;
    }

    public User GetUserById(int userId)
    {
        throw new NotImplementedException();
    }

    public Membership GetMembershipById(int serverId, int userId)
    {
        throw new NotImplementedException();
    }

    public Server GetServerById(int serverId)
    {
        throw new NotImplementedException();
    }

    public Message GetMessageById(int messageId)
    {
        throw new NotImplementedException();
    }

    public Channel GetChannelById(int channelId)
    {
        throw new NotImplementedException();
    }
}