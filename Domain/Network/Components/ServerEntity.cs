using Nc.Data.Network.Components;
using Nc.Domain.Network.Location;
using Nc.Domain.Repos;
using Nc.Domain.Repos.Network.Location;

namespace Nc.Domain.Network.Components;
public abstract class ServerEntity<TData>(TData? data)
    : ComponentEntity<TData>(data) where TData : ServerData, new() {
    public async override Task LoadLazy() {
        await base.LoadLazy();
        GeographicPoint ??= await GetFromRepo.Item<IGeographicPointRepo, GeographicPoint>(GeographicPointId);
    }
    public int GeographicPointId => _data.GeographicPointId;
    public GeographicPoint? GeographicPoint { get; private set; }
}
