using Nc.Data.Network.Components;
using Nc.Data.Network.Location;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos;
using Nc.Domain.Repos.Network.Components;

namespace Nc.Domain.Network.Location;
public sealed class Pathway(PathwayData? data) : LocationEntity<PathwayData>(data) {
    public double TotalDistance => _data.TotalDistance;
    public override async Task LoadLazy() {
        await base.LoadLazy();
        var cableWirings = await GetFromRepo.Items<ICableWiringRepo, CableWiring>(nameof(CableWiringData.PathwayId), Id);
        CableWirings ??= (cableWirings ?? Enumerable.Empty<CableWiring>())
        .Where(cw => cw.PathwayId == Id)
        .ToList(); 

        var fiberWirings = await GetFromRepo.Items<IFiberWiringRepo, FiberWiring>(nameof(FiberWiringData.PathwayId), Id);
        FiberWirings ??= (fiberWirings ?? Enumerable.Empty<FiberWiring>())
        .Where(fw => fw.PathwayId == Id)
        .ToList();

        var microwaveComponents = await GetFromRepo.Items<IMicrowaveComponentRepo, MicrowaveComponent>(nameof(MicrowaveComponentData.PathwayId), Id);
        MicrowaveComponents ??= (microwaveComponents ?? Enumerable.Empty<MicrowaveComponent>())
        .Where(mc => mc.PathwayId == Id)
        .ToList();
    }
    public List<CableWiring>? CableWirings { get; private set; }
    public List<FiberWiring>? FiberWirings { get; private set; }
    public List<MicrowaveComponent>? MicrowaveComponents { get; private set; }

}
