using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Infra.Common;

namespace Nc.Infra.Network.Components.Repos;

public class SupportStructureRepo(NetworkDbContext context) : Repo<SupportStructure, SupportStructureData>(context, context.SupportStructures), ISupportStructureRepo {
    protected override IQueryable<SupportStructureData> AddSearch(IQueryable<SupportStructureData> sql) => string.IsNullOrEmpty(SearchString) ? sql :
        sql.Where(s => s.Location != null && (s.Location.Contains(SearchString)
                                              || s.SerialNum != null && s.SerialNum.Contains(SearchString)
                                              || s.InstallationDate != null && s.InstallationDate.ToString().Contains(SearchString)
                                              || s.IsMaintenanceValid != null && s.IsMaintenanceValid.ToString().Contains(SearchString)));
    protected override SupportStructure ToEntity(SupportStructureData? data) => new(data);
}
