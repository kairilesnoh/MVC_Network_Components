using Microsoft.EntityFrameworkCore;
using Nc.Data;
using Nc.Domain;
using Nc.Domain.Common;

namespace Nc.Infra.Common;
public abstract class FilteredRepo<TEntity, TData>(DbContext context, DbSet<TData> set) :
    CrudRepo<TEntity, TData>(context, set), IFilteredRepo<TEntity> where TEntity : Entity<TData> where TData : EntityData, new() {
    public string SearchString { get; set; } = string.Empty;
    public string? FixedFilter { get; set; } 
    public string? FixedValue { get; set; } 

    protected internal override IQueryable<TData> CreateSql() {
        var sql = base.CreateSql();
        sql = AddSearch(sql);
        sql = AddFixedFilter(sql);
        return sql;
    }

    protected virtual IQueryable<TData> AddFixedFilter(IQueryable<TData> sql) =>sql;
    protected abstract IQueryable<TData> AddSearch(IQueryable<TData> sql);

}
