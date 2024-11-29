using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nc.Data;
using Nc.Domain;
using Nc.Domain.Common;

namespace Nc.Infra.Common;
public abstract class Repo<TEntity, TData>(DbContext context, DbSet<TData> set) :
    PagedRepo<TEntity, TData>(context, set), 
    IRepo<TEntity> where TEntity : Entity<TData> where TData : EntityData, new() {
    protected internal virtual string selectTextField => nameof(EntityData.Id);
    public async Task<dynamic?> SelectItem(int id) {
        var list = await SelectList(id);
        return list.FirstOrDefault();
    }
    public async Task<IEnumerable<dynamic>> SelectItems(string researchString, int id) {
        PageNumber = 1;
        SearchString = researchString;
        SortOrder = selectTextField;
        var list = (await GetAsyncData()).ToList();
        return await SelectList(id, list);
    }
    private async Task<SelectList> SelectList(int id, List<TData>? dataList = null) {
        var list = dataList ?? [];
        var data = await GetAsyncData(id);
        if (data != null && !list.Contains(data)) list.Add(data);
        return new SelectList(list, nameof(EntityData.Id), selectTextField, id);
    }

}
