using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;

namespace Nc.Tests.Domain.Network.Components; 
[TestClass] public class AmplifierTests : DeviceDomainClassTests<Amplifier, AmplifierData> {
    [TestMethod] public void GainTest() => ValueTest();
}
