namespace ChatApp.DAL.EF;

public class AppRepository
{
    private readonly AppDbContext _ctx;

    public AppRepository(AppDbContext ctx)
    {
        _ctx = ctx;
    }
}