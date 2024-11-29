using Microsoft.Extensions.DependencyInjection;
using Nc.Domain.Common;

namespace Nc.Domain.Repos;

public static class GetFromRepo {
    private static IServiceCollection? _services;
    public static void SetServices(IServiceCollection s) => _services = s;
    private static TRepo? Repo<TRepo, TEntity>() where TRepo : IRepo<TEntity> where TEntity : class {
        var provider = _services?.BuildServiceProvider();
        return provider is null ? default : provider.GetRequiredService<TRepo>();
    }
    public static async Task<TEntity?> Item<TRepo, TEntity>(int id) where TRepo : IRepo<TEntity> where TEntity : class {
        var repo = Repo<TRepo, TEntity>();
        return repo is null ? null : await repo.GetAsync(id);
    }
    internal static async Task<List<TEntity>?> Items<TRepo, TEntity>(string property, int value)
        where TRepo : IRepo<TEntity> where TEntity : class {
        var repo = Repo<TRepo, TEntity>();
        if (repo is null) return null;
        repo.FixedValue = value.ToString();
        repo.FixedFilter = property;
        repo.PageSize = repo.TotalItems;
        var list = await repo.GetAsync();
        return list.ToList();
    }
}