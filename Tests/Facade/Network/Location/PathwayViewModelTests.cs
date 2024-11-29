using Nc.Facade.Network.Components;
using Nc.Facade.Network.Location;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Location; 
[TestClass] public class PathwayViewModelTests : SealedNewTests<PathwayViewModel, LocationEntityViewModel> {
    [TestMethod] public void TotalDistanceTest() => PropertyTest("Total Distance");
    [TestMethod] public void CableWiringsTest() {
        var model = new PathwayViewModel();
        var cableWirings = new List<CableWiringViewModel> {
            new(),
            new()
        };
        model.CableWirings = cableWirings;
        Assert.AreEqual(cableWirings, model.CableWirings);
    }
    [TestMethod] public void FiberWiringsTest() {
        var model = new PathwayViewModel();
        var fiberWirings = new List<FiberWiringViewModel> {
            new(),
            new()
        };
        model.FiberWirings = fiberWirings;
        Assert.AreEqual(fiberWirings, model.FiberWirings);
    }
    [TestMethod] public void MicrowaveComponentsTest() {
        var model = new PathwayViewModel();
        var microwaveComponents = new List<MicrowaveComponentViewModel> {
            new(),
            new()
        };
        model.MicrowaveComponents = microwaveComponents;
        Assert.AreEqual(microwaveComponents, model.MicrowaveComponents);
    }
}
