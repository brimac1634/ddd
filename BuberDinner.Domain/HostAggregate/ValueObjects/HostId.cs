using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Host.ValueObjects;

public sealed class HostId : ValueObject
{
    public Guid Value { get; }

    private HostId(Guid value)
    {
        Value = value;
    }

    public static HostId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public static HostId Create(string value)
    {
        return new(new Guid(value));
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}