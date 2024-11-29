using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Infra.Common;

namespace Nc.Infra.Network.Components.Repos;

public class CommunicationAppearanceRepo(NetworkDbContext context) : 
    Repo<CommunicationAppearance, CommunicationAppearanceData>(context, context.CommunicationAppearances), ICommunicationAppearanceRepo {
    protected override IQueryable<CommunicationAppearanceData> AddSearch(IQueryable<CommunicationAppearanceData> sql) => string.IsNullOrEmpty(SearchString) ? sql :
        sql.Where(s => s.IpAddress != null && (s.IpAddress.Contains(SearchString)
                                               || s.IpAddress != null && s.IpAddress.Contains(SearchString)
                                               || s.Type != null && s.Type.Contains(SearchString)));
    protected override CommunicationAppearance ToEntity(CommunicationAppearanceData? data) => new CommunicationAppearance(data);
}