using Nc.Data.Network.Components;
using Nc.Domain.Network.Components;
using Nc.Helpers.Methods;
using Nc.Tests.Helpers;

namespace Nc.Tests.Domain.Network.Components; 
[TestClass] public abstract class ComponentDomainClassTests<TDomain, TData> : SealedTests<TDomain, ComponentEntity<TData>> where TData : ComponentData, new() where TDomain : ComponentEntity<TData> {
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
