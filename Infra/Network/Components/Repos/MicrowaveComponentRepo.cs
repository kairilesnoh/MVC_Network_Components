using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Infra.Common;

namespace Nc.Infra.Network.Components.Repos;

public class MicrowaveComponentRepo(NetworkDbContext context) : 
    Repo<MicrowaveComponent, MicrowaveComponentData>(context, context.MicrowaveComponents), IMicrowaveComponentRepo {
    protected override IQueryable<MicrowaveComponentData> AddSearch(IQueryable<MicrowaveComponentData> sql) {
        return string.IsNullOrEmpty(SearchString) ? sql
            : sql.Where(s => s.Frequency.ToString().Contains(SearchString)
                             || s.SerialNum != null && s.SerialNum.Contains(SearchString)
                             || s.PowerOutput.ToString().Contains(SearchString));
    }
    protected override MicrowaveComponent ToEntity(MicrowaveComponentData? data) => new MicrowaveComponent(data);    
}
