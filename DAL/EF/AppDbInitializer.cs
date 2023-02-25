namespace ChatApp.DAL.EF;

internal static class AppDbInitializer
{
    private static bool _initialized;

    public static void Initialize(AppDbContext ctx, bool rebuildDb = false)
    {
        if (_initialized || !rebuildDb)
        {
            _initialized = true;
            return;
        }

        ctx.Database.EnsureDeleted();
        ctx.Database.EnsureCreated();
        _initialized = true;
        ctx.SaveChanges();
        ctx.ChangeTracker.Clear();
    }
}