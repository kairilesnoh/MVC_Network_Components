using Nc.Facade.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Components; 
[TestClass] public class SupportStructureViewModelTests : SealedNewTests<SupportStructureViewModel, ComponentEntityViewModel> {
    [TestMethod] public void LocationTest() => PropertyTest("Location");
    [TestMethod] public void InstallationDateTest() => PropertyTest("Installation Date");
    [TestMethod] public void IsMaintenanceValidTest() => PropertyTest("Valid Maintenance");
    [TestMethod] public void GeographicPointIdTest() => PropertyTest("Geographic Point Id");
}
