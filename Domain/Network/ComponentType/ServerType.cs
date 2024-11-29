using Nc.Data.Network.Components;
using Nc.Data.Network.ComponentType;
using Nc.Domain.Repos.Network.Components;
using Nc.Domain.Repos;
using Nc.Domain.Network.Components;

namespace Nc.Domain.Network.ComponentType;
public sealed class ServerType(ServerTypeData? data) : ComponentTypeEntity<ServerTypeData>(data) {
    public int Memory => _data.Memory;
    public string? Hostname => _data.Hostname;
    public List<Switch>? Switches { get; private set; }

    public override async Task LoadLazy() {
        await base.LoadLazy();
         var switches = await GetFromRepo.Items<ISwitchRepo, Switch>(nameof(SwitchData.ServerTypeId), Id);
        Switches ??= (switches ?? Enumerable.Empty<Switch>())
        .Where(s => s.ServerTypeId == Id)
        .ToList();
    }
}

