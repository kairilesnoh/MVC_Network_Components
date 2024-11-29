using Nc.Facade.Network.Components;
using Nc.Facade.Network.Location;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Location; 
[TestClass] public class GeographicPointViewModelTests : SealedNewTests<GeographicPointViewModel, LocationEntityViewModel> {
    [TestMethod] public void LatitudeTest() => PropertyTest("Latitude");
    [TestMethod] public void LongitudeTest() => PropertyTest("Longitude");
    [TestMethod] public void SupportStructuresTest() {
        var model = new GeographicPointViewModel();
        var supportStructures = new List<SupportStructureViewModel> {
            new(),
            new()
        };
        model.SupportStructures = supportStructures;
        Assert.AreEqual(supportStructures, model.SupportStructures);
    }
    [TestMethod] public void SwitchesTest() {
        var model = new GeographicPointViewModel();
        var switches = new List<SwitchViewModel> {
            new(),
            new()
        };
        model.Switches = switches;
        Assert.AreEqual(switches, model.Switches);
    }
    [TestMethod] public void RoutersTest() {
        var model = new GeographicPointViewModel();
        var switches = new List<RouterViewModel> {
            new(),
            new()
        };
        model.Routers = switches;
        Assert.AreEqual(switches, model.Routers);
    }
    [TestMethod] public void CommunicationAppearancesTest() {
        var model = new GeographicPointViewModel();
        var switches = new List<CommunicationAppearanceViewModel> {
            new(),
            new()
        };
        model.CommunicationAppearances = switches;
        Assert.AreEqual(switches, model.CommunicationAppearances);
    }
    [TestMethod] public void AmplifiersTest() {
        var model = new GeographicPointViewModel();
        var amplifiers = new List<AmplifierViewModel> {
            new(),
            new()
        };
        model.Amplifiers = amplifiers;
        Assert.AreEqual(amplifiers, model.Amplifiers);
    }
    [TestMethod] public void FiltersTest() {
        var model = new GeographicPointViewModel();
        var filters = new List<FilterViewModel> {
            new(),
            new()
        };
        model.Filters = filters;
        Assert.AreEqual(filters, model.Filters);
    }
}
