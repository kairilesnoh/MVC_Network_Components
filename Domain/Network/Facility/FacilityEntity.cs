using Nc.Data.Network.Facility;
using Nc.Domain.Repos;
using Nc.Domain.Repos.Network.Facility;

namespace Nc.Domain.Network.Facility;
public sealed class FacilityEntity(FacilityData? data) : Entity<FacilityData>(data) {
    public int FacilityTypeId => _data.FacilityTypeId;
    public async override Task LoadLazy() {
        await base.LoadLazy();
        FacilityType ??= await GetFromRepo.Item<IFacilityTypeRepo, FacilityType>(FacilityTypeId);
    }
    public FacilityType? FacilityType { get; private set; }
}
