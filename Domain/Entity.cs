using Nc.Data;
using Nc.Helpers.Methods;

namespace Nc.Domain;
public abstract class Entity<TData>(TData? data) where TData : EntityData, new() {
    internal readonly TData _data = data ?? new TData();
    public virtual async Task LoadLazy() { await Task.CompletedTask; }
    public TData Data => PropertyCopier.CopyPropertiesFrom<TData, TData>(_data);
    public int Id => _data.Id;
}
