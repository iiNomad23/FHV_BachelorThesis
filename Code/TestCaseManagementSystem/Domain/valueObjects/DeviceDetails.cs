namespace Domain.valueObjects;

public class DeviceDetails : ValueObject
{
    public string Name { get; init; }
    public string Firmware { get; init; }
    public string MkCode { get; init; }
    public string Serial { get; init; }

    public DeviceDetails(string name, string firmware, string mkCode, string serial)
    {
        Name = name;
        Firmware = firmware;
        MkCode = mkCode;
        Serial = serial;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Name;
        yield return Firmware;
        yield return MkCode;
        yield return Serial;
    }
}