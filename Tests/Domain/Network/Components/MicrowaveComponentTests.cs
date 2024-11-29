using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;

namespace Nc.Tests.Domain.Network.Components; 
[TestClass] public class MicrowaveComponentTests : ConnectionComponentDomainClassTests<MicrowaveComponent, MicrowaveComponentData> {
    [TestMethod] public void FrequencyTest() => ValueTest();
    [TestMethod] public void PowerOutputTest() => ValueTest();
}
