using Nc.Data.Network.Location;
using Nc.Domain.Network.Location;
using Nc.Helpers.Methods;
using Nc.Tests.Helpers;

namespace Nc.Tests.Domain.Network.Location; 
[TestClass] public abstract class LocationDomainClassTests<TDomain, TData> 
    : SealedTests<TDomain, LocationEntity<TData>> where TData : LocationData, new() where TDomain : LocationEntity<TData> {
    private TData? _data;

    protected override TDomain? CreateObject() {
        _data = GetRandom.Object<TData>();
        var constructor = type?.GetConstructor([typeof(TData)]);
        return constructor == null ? null : (TDomain)constructor.Invoke([_data]);
    }

    public void ValueTest() {
        var name = CallingMethod(nameof(ValueTest));
        var actualProperty = type?.GetProperty(name);
        var expectedProperty = _data?.GetType().GetProperty(name);
        var expectedValue = expectedProperty?.GetValue(_data);
        var actualValue = actualProperty?.GetValue(obj);
        Assert.AreEqual(expectedValue, actualValue);
    }
}
