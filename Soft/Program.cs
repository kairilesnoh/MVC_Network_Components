using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Nc.Domain.Repos;
using Nc.Domain.Repos.Network.Components;
using Nc.Domain.Repos.Network.ComponentType;
using Nc.Domain.Repos.Network.Facility;
using Nc.Domain.Repos.Network.Location;
using Nc.Infra;
using Nc.Infra.Network.Components.DbInitializers;
using Nc.Infra.Network.Components.Repos;
using Nc.Infra.Network.ComponentType.DbInitializers;
using Nc.Infra.Network.ComponentType.Repos;
using Nc.Infra.Network.Facility.Repos;
using Nc.Infra.Network.Location.DbInitializers;
using Nc.Infra.Network.Location.Repos;
using Nc.Soft.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<NetworkDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<ISwitchRepo, SwitchesRepo>();
builder.Services.AddTransient<IRouterRepo, RoutersRepo>();
builder.Services.AddTransient<ICommunicationAppearanceRepo, CommunicationAppearanceRepo>();
builder.Services.AddTransient<ICableWiringRepo, CableWiringRepo>();
builder.Services.AddTransient<IFiberWiringRepo, FiberWiringRepo>();
builder.Services.AddTransient<IMicrowaveComponentRepo, MicrowaveComponentRepo>();
builder.Services.AddTransient<ISupportStructureRepo, SupportStructureRepo>();
builder.Services.AddTransient<ICommunicationAppearanceRepo, CommunicationAppearanceRepo>();

builder.Services.AddTransient<IServerTypeRepo, ServerTypeRepo>();
builder.Services.AddTransient<IConnectionComponentTypeRepo, ConnectionComponentTypeRepo>();
builder.Services.AddTransient<IDeviceTypeRepo, DeviceTypeRepo>();
builder.Services.AddTransient<ISupportStructureTypeRepo, SupportStructureTypeRepo>();


builder.Services.AddTransient<IGeographicPointRepo, GeographicPointRepo>();
builder.Services.AddTransient<IGeographicBoundaryRepo, GeographicBoundaryRepo>();
builder.Services.AddTransient<IPathwayRepo, PathwayRepo>();

builder.Services.AddTransient<IFacilityTypeRepo, FacilityTypeRepo>();
builder.Services.AddTransient<IFacilityEntityRepo, FacilityEntityRepo>();


builder.Services.AddTransient<IAmplifierRepo, AmplifierRepo>();
builder.Services.AddTransient<IFilterRepo, FilterRepo>();

GetFromRepo.SetServices(builder.Services);

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
    app.UseMigrationsEndPoint();
}
else {
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

EnsureDatabaseCreated(app);
var networkDbTask = Task.Run(async () => await TryInitializeNetworkDatabase(app));


app.Run();

networkDbTask.Wait();

static void EnsureDatabaseCreated(WebApplication app) {
    var db = GetContext<ApplicationDbContext>(app);
    db.Database.EnsureCreated();
}

static async Task TryInitializeNetworkDatabase(WebApplication app) {
    var networkDb = GetContext<NetworkDbContext>(app);
    await new SwitchDbInitializer(networkDb, networkDb.Switches).Initialize(10);
    await new RouterDbInitializer(networkDb, networkDb.Routers).Initialize(10);
    await new CommunicationAppearanceDbInitializer(networkDb, networkDb.CommunicationAppearances).Initialize(10);
    await new CableWiringDbInitializer(networkDb, networkDb.CableWirings).Initialize(10);
    await new FiberWiringDbInitializer(networkDb, networkDb.FiberWirings).Initialize(10);
    await new MicrowaveComponentInitializer(networkDb, networkDb.MicrowaveComponents).Initialize(10);
    await new SupportStructureInitializer(networkDb, networkDb.SupportStructures).Initialize(30);
    await new SupportStructureTypeDbInitializer(networkDb, networkDb.SupportStructureTypes).Initialize(30);
    await new DeviceTypeDbInitializer(networkDb, networkDb.DeviceTypes).Initialize(30);
    await new ConnectionComponentTypeDbInitializer(networkDb, networkDb.ConnectionComponentTypes).Initialize(30);
    await new ServerTypeDbInitializer(networkDb, networkDb.NetworkServerTypes).Initialize(30);
    await new GeographicBoundaryDbInitializer(networkDb, networkDb.GeographicBoundaries).Initialize(30);
    await new GeographicPointDbInitializer(networkDb, networkDb.GeographicPoints).Initialize(30);
    await new PathwayDbInitializer(networkDb, networkDb.Pathways).Initialize(30);
    await new AmplifierDbInitializer(networkDb, networkDb.Amplifiers).Initialize(30);
    await new FilterDbInitializer(networkDb, networkDb.Filters).Initialize(30);
}

static TDbContext GetContext<TDbContext>(WebApplication app) where TDbContext : DbContext => app
    .Services
    .CreateScope()
    .ServiceProvider
    .GetRequiredService<TDbContext>();