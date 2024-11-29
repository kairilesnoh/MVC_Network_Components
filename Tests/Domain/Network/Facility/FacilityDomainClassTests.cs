using Nc.Data;
using Nc.Domain;
using Nc.Helpers.Methods;
using Nc.Tests.Helpers;

namespace Nc.Tests.Domain.Network.Facility;

[TestClass] public abstract class FacilityDomainClassTests<TDomain, TData> : 
    SealedTests<TDomain, Entity<TData>> where TData : 
    EntityData, new() where TDomain : Entity<TData> {
    private TData? _data;

    protected override TDomain? CreateObject()
    {
        _data = GetRandom.Object<TData>();
        var constructor = type?.GetConstructor([typeof(TData)]);
        return constructor == null ? null : (TDomain)constructor.Invoke([_data]);
    }

    public void ValueTest()
    {
        var name = CallingMethod(nameof(ValueTest));
        var actualProperty = type?.GetProperty(name);
        var expectedProperty = _data?.GetType().GetProperty(name);
        var expectedValue = expectedProperty?.GetValue(_data);
        var actualValue = actualProperty?.GetValue(obj);
        Assert.AreEqual(expectedValue, actualValue);
    }
}
