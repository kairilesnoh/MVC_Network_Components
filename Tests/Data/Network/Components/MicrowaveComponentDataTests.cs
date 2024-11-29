using Nc.Data.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Components; 
[TestClass] public class MicrowaveComponentDataTests : SealedNewTests<MicrowaveComponentData, ConnectionComponentData> {
    [TestMethod] public void FrequencyTest() => PropertyTest();
    [TestMethod] public void PowerOutputTest() => PropertyTest();
}
