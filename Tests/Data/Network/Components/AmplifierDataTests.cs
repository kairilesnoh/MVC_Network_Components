using Nc.Data.Network.Components;
using Nc.Tests.Helpers;

namespace Nc.Tests.Data.Network.Components; 
[TestClass] public class AmplifierDataTests : SealedNewTests<AmplifierData, DeviceData> {
    [TestMethod] public void GainTest() => PropertyTest();
}
