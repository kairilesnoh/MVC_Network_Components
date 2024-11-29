using Nc.Facade.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Components; 
[TestClass] public class AmplifierViewModelTests : SealedNewTests<AmplifierViewModel, DeviceViewModel> {
    [TestMethod] public void GainTest() => PropertyTest("Gain");
}
