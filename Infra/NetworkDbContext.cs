using Microsoft.EntityFrameworkCore;
using Nc.Data.Network.Components;
using Nc.Data.Network.ComponentType;
using Nc.Data.Network.Facility;
using Nc.Data.Network.Location;

namespace Nc.Infra;
public class NetworkDbContext(DbContextOptions<NetworkDbContext> options) : BaseDbContext<NetworkDbContext>(options) {
    internal const string _nsSchema = "NetworkServer";
    internal const string _ccSchema = "ConnectionComponent";
    internal const string _nssSchema = "SupportStructure";
    internal const string _nctSchema = "NetworkComponentType";
    internal const string _fSchema = "Facility";
    internal const string _lSchema = "Location";
    internal const string _dSchema = "Device";

    public DbSet<RouterData> Routers { get; set; } = default!;
    public DbSet<SwitchData> Switches { get; set; } = default!;
    public DbSet<CommunicationAppearanceData> CommunicationAppearances { get; set; } = default!;
    public DbSet<CableWiringData> CableWirings { get; set; } = default!;
    public DbSet<FiberWiringData> FiberWirings { get; set; } = default!;
    public DbSet<MicrowaveComponentData> MicrowaveComponents { get; set; } = default!;
    public DbSet<SupportStructureData> SupportStructures { get; set; } = default!;
    public DbSet<ServerTypeData> NetworkServerTypes { get; set; } = default!;
    public DbSet<DeviceTypeData> DeviceTypes { get; set; } = default!;
    public DbSet<ConnectionComponentTypeData> ConnectionComponentTypes { get; set; } = default!;
    public DbSet<SupportStructureTypeData> SupportStructureTypes { get; set; } = default!;
    public DbSet<GeographicBoundaryData> GeographicBoundaries { get; set; } = default!;
    public DbSet<GeographicPointData> GeographicPoints { get; set; } = default!;
    public DbSet<PathwayData> Pathways { get; set; } = default!;
    public DbSet<FacilityTypeData> FacilityTypes { get; set; } = default!;
    public DbSet<FacilityData> FacilityEntities { get; set; } = default!;
    public DbSet<AmplifierData> Amplifiers { get; set; } = default!;
    public DbSet<FilterData> Filters { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder builder) {
        base.OnModelCreating(builder);
        InitializeTables(builder);
    }

    internal static void InitializeTables(ModelBuilder builder) {
        ToTable<RouterData>(builder, nameof(Routers), _nsSchema);
        ToTable<SwitchData>(builder, nameof(Switches), _nsSchema);
        ToTable<CommunicationAppearanceData>(builder, nameof(CommunicationAppearances), _nsSchema);
        ToTable<CableWiringData>(builder, nameof(CableWirings), _ccSchema);
        ToTable<FiberWiringData>(builder, nameof(FiberWirings), _ccSchema);
        ToTable<MicrowaveComponentData>(builder, nameof(MicrowaveComponents), _ccSchema);
        ToTable<SupportStructureData>(builder, nameof(SupportStructures), _nssSchema);
        ToTable<ServerTypeData>(builder, nameof(NetworkServerTypes), _nctSchema);
        ToTable<DeviceTypeData>(builder, nameof(DeviceTypes), _nctSchema);
        ToTable<ConnectionComponentTypeData>(builder, nameof(ConnectionComponentTypes), _nctSchema);
        ToTable<SupportStructureTypeData>(builder, nameof(SupportStructureTypes), _nctSchema);
        ToTable<GeographicBoundaryData>(builder, nameof(GeographicBoundaries), _lSchema);
        ToTable<GeographicPointData>(builder, nameof(GeographicPoints), _lSchema);
        ToTable<PathwayData>(builder, nameof(Pathways), _lSchema);
        ToTable<FacilityTypeData>(builder, nameof(FacilityTypes), _fSchema);
        ToTable<FacilityData>(builder, nameof(FacilityEntities), _fSchema);
        ToTable<AmplifierData>(builder, nameof(Amplifiers), _dSchema);
        ToTable<FilterData>(builder, nameof(Filters), _lSchema);
    }
}
