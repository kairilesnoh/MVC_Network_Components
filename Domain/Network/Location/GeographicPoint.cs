using Nc.Data.Network.Components;
using Nc.Data.Network.Location;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Domain.Repos;

namespace Nc.Domain.Network.Location;
public sealed class GeographicPoint(GeographicPointData? data) : LocationEntity<GeographicPointData>(data) {
    public string Latitude => _data.Latitude;
    public string Longitude => _data.Longitude;
    public override async Task LoadLazy() {
        await base.LoadLazy();
        var supportStructures = await GetFromRepo.Items<ISupportStructureRepo, SupportStructure>(nameof(SupportStructureData.GeographicPointId), Id);
        SupportStructures ??= (supportStructures ?? Enumerable.Empty<SupportStructure>())
        .Where(ss => ss.GeographicPointId == Id)
        .ToList();

        var switches = await GetFromRepo.Items<ISwitchRepo, Switch>(nameof(SwitchData.GeographicPointId), Id);
        Switches ??= (switches ?? Enumerable.Empty<Switch>())
        .Where(s => s.GeographicPointId == Id)
        .ToList();

        var routers = await GetFromRepo.Items<IRouterRepo, Router>(nameof(RouterData.GeographicPointId), Id);
        Routers ??= (routers ?? Enumerable.Empty<Router>())
        .Where(r => r.GeographicPointId == Id)
        .ToList();

        var communicationAppearances = await GetFromRepo.Items<ICommunicationAppearanceRepo, CommunicationAppearance>(nameof(CommunicationAppearanceData.GeographicPointId), Id);
        CommunicationAppearances ??= (communicationAppearances ?? Enumerable.Empty<CommunicationAppearance>())
        .Where(ca => ca.GeographicPointId == Id)
        .ToList();

        var amplifiers = await GetFromRepo.Items<IAmplifierRepo, Amplifier>(nameof(AmplifierData.GeographicPointId), Id);
        Amplifiers ??= (amplifiers ?? Enumerable.Empty<Amplifier>())
        .Where(a => a.GeographicPointId == Id)
        .ToList();

        var filters = await GetFromRepo.Items<IFilterRepo, Filter>(nameof(FilterData.GeographicPointId), Id);
        Filters ??= (filters ?? Enumerable.Empty<Filter>())
        .Where(a => a.GeographicPointId == Id)
        .ToList();
    }
    public List<SupportStructure>? SupportStructures { get; private set; }
    public List<Switch>? Switches { get; private set; }
    public List<Router>? Routers { get; private set; }
    public List<CommunicationAppearance>? CommunicationAppearances { get; private set; }
    public List<Amplifier>? Amplifiers { get; private set; }
    public List<Filter>? Filters { get; private set;}
}
