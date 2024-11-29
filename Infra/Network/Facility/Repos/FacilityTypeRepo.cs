using Nc.Data.Network.Facility;
using Nc.Domain.Network.Facility;
using Nc.Domain.Repos.Network.Facility;
using Nc.Infra.Common;

namespace Nc.Infra.Network.Facility.Repos;

public class FacilityTypeRepo(NetworkDbContext context) : Repo<FacilityType, FacilityTypeData>(context, context.FacilityTypes), IFacilityTypeRepo{
    protected override IQueryable<FacilityTypeData> AddSearch(IQueryable<FacilityTypeData> sql){
        return string.IsNullOrEmpty(SearchString) ? sql
            : sql.Where(s => s.Name != null && s.Name.Contains(SearchString));
    }
    protected override FacilityType ToEntity(FacilityTypeData? data) => new FacilityType(data);    
}
