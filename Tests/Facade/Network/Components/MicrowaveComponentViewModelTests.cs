using Nc.Facade.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Facade.Network.Components; 
[TestClass] public class MicrowaveComponentViewModelTests : SealedNewTests<MicrowaveComponentViewModel, ConnectionComponentViewModel> {
    [TestMethod] public void FrequencyTest() => PropertyTest("Frequency");
    [TestMethod] public void PowerOutputTest() => PropertyTest("Power Output");
}
