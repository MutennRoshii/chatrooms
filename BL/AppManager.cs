using ChatApp.DAL;

namespace ChatApp.BL;

public class AppManager
{
    private readonly IRepository _repository;

    public AppManager(IRepository repository)
    {
        _repository = repository;
    }
}