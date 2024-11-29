using Nc.Data.Network.Components;
using Nc.Domain.Network.Location;
using Nc.Domain.Repos.Network.Location;
using Nc.Domain.Repos;

namespace Nc.Domain.Network.Components;
public abstract class ConnectionComponentEntity<TData>(TData? data) 
    : ComponentEntity<TData>(data) where TData : ConnectionComponentData, new() {
    public async override Task LoadLazy() {
        await base.LoadLazy();
        Pathway ??= await GetFromRepo.Item<IPathwayRepo, Pathway>(PathwayId);
    }
    public int PathwayId => _data.PathwayId;
    public Pathway? Pathway { get; private set; }
}
