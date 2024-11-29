using Nc.Data.Network.Components;
using Nc.Domain.Network.Location;
using Nc.Domain.Repos.Network.Location;
using Nc.Domain.Repos;

namespace Nc.Domain.Network.Components;
public sealed class SupportStructure(SupportStructureData? data) : ComponentEntity<SupportStructureData>(data) {
    public string? Location => _data.Location;
    public DateTime? InstallationDate => _data.InstallationDate;
    public bool? IsMaintenanceValid => _data.IsMaintenanceValid;
    public async override Task LoadLazy() {
        await base.LoadLazy();
        GeographicPoint ??= await GetFromRepo.Item<IGeographicPointRepo, GeographicPoint>(GeographicPointId);
    }
    public int GeographicPointId => _data.GeographicPointId;
    public GeographicPoint? GeographicPoint { get; private set; }
}
