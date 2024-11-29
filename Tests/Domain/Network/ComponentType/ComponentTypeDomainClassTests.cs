using Nc.Data.Network.ComponentType;
using Nc.Domain.Network.ComponentType;
using Nc.Helpers.Methods;
using Nc.Tests.Helpers;

namespace Nc.Tests.Domain.Network.ComponentType; 
[TestClass] public abstract class ComponentTypeDomainClassTests<TDomain, TData> 
    : SealedTests<TDomain, ComponentTypeEntity<TData>> where TData : ComponentTypeData, new() where TDomain : ComponentTypeEntity<TData> {
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
