using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Domain.Repos.Network.Components;
using Nc.Infra.Common;

namespace Nc.Infra.Network.Components.Repos;
public class AmplifierRepo(NetworkDbContext context) :
    Repo<Amplifier, AmplifierData>(context, context.Amplifiers), IAmplifierRepo {
    protected override IQueryable<AmplifierData> AddSearch(IQueryable<AmplifierData> sql) {
        return string.IsNullOrEmpty(SearchString) ? sql
            : sql.Where(s => s.SerialNum != null && s.SerialNum.Contains(SearchString)
                             || s.Gain != null && s.Gain.ToString().Contains(SearchString));
    }
    protected override Amplifier ToEntity(AmplifierData? data) => new Amplifier(data);
}
