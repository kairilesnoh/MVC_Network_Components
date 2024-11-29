using Nc.Data.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Components; 
[TestClass] public class SupportStructureDataTests : SealedNewTests<SupportStructureData, ComponentData> {
    [TestMethod] public void LocationTest() => PropertyTest();
    [TestMethod] public void InstallationDateTest() => PropertyTest();
    [TestMethod] public void IsMaintenanceValidTest() => PropertyTest();
    [TestMethod] public void GeographicPointIdTest() => PropertyTest();
}
