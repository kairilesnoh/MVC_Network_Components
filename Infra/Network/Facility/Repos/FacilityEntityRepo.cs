using Nc.Data.Network.Facility;
using Nc.Domain.Network.Facility;
using Nc.Domain.Repos.Network.Facility;
using Nc.Infra.Common;

namespace Nc.Infra.Network.Facility.Repos;

public class FacilityEntityRepo(NetworkDbContext context) : Repo<FacilityEntity, FacilityData>(context, context.FacilityEntities), IFacilityEntityRepo{
    protected override IQueryable<FacilityData> AddSearch(IQueryable<FacilityData> sql){
        return string.IsNullOrEmpty(SearchString) ? sql
            : sql.Where(s => s.FacilityTypeId.ToString() != null && s.FacilityTypeId.ToString().Contains(SearchString));
    }
    protected override FacilityEntity ToEntity(FacilityData? data) => new FacilityEntity(data);    
}
