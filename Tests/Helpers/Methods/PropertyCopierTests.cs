using Nc.Data.Network.Components;
using Nc.Data.Network.ComponentType;
using Nc.Data.Network.Location;
using Nc.Facade.Network.Components;
using Nc.Facade.Network.ComponentType;
using Nc.Facade.Network.Location;
using Nc.Helpers.Methods;

namespace Nc.Tests.Helpers.Methods; 
[TestClass] public class PropertyCopierTests : BaseTests {
    protected override Type? type => typeof(PropertyCopier);

    [TestMethod] public void CopyPropertiesFromTest() {
        var testData = TestData();
        var method = typeof(PropertyCopier).GetMethod("CopyPropertiesFrom");

        foreach (var (sourceType, targetType) in testData) {
            var source = Activator.CreateInstance(sourceType);
            var genericMethod = method?.MakeGenericMethod(sourceType, targetType);
            var result = genericMethod?.Invoke(null, [source]);
            Assert.IsInstanceOfType(result, targetType);
            CompareProperties(source, result, Assert.AreEqual);
        }
    }

    private static Dictionary<Type, Type> TestData() {
        return new Dictionary<Type, Type>(){
            {typeof(CableWiringData), typeof(CableWiringViewModel)},
            {typeof(CommunicationAppearanceData), typeof(CommunicationAppearanceViewModel)},
            {typeof(FiberWiringData), typeof(FiberWiringViewModel)},
            {typeof(MicrowaveComponentData), typeof(MicrowaveComponentViewModel)},
            {typeof(RouterData), typeof(RouterViewModel)},
            {typeof(SupportStructureData), typeof(SupportStructureViewModel)},
            {typeof(SwitchData), typeof(SwitchViewModel)},

            {typeof(ConnectionComponentTypeData), typeof(ConnectionComponentTypeViewModel)},
            {typeof(DeviceTypeData), typeof(DeviceTypeViewModel)},
            {typeof(ServerTypeData), typeof(ServerTypeViewModel)},
            {typeof(SupportStructureTypeData), typeof(SupportStructureTypeViewModel)},

            {typeof(GeographicBoundaryData), typeof(GeographicBoundaryViewModel)},
            {typeof(GeographicPointData), typeof(GeographicPointViewModel)},
            {typeof(PathwayData), typeof(PathwayViewModel)}
        };
    }
}
