using Nc.Data.Network.Facility;
using Nc.Domain.Repos;
using Nc.Domain.Repos.Network.Facility;

namespace Nc.Domain.Network.Facility;

public sealed class FacilityType(FacilityTypeData? data) : Entity<FacilityTypeData>(data) {
    public string? Name => _data.Name;
    public override async Task LoadLazy() {
        await base.LoadLazy();
        var facilityEntity = await GetFromRepo.Items<IFacilityEntityRepo, FacilityEntity>(nameof(FacilityData.FacilityTypeId), Id);
        FacilityEntities ??= (facilityEntity ?? Enumerable.Empty<FacilityEntity>())
        .Where(fe => fe.FacilityTypeId == Id)
        .ToList();
    }
    public List<FacilityEntity>? FacilityEntities { get; private set; }
}
