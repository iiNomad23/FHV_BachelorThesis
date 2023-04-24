namespace Domain.valueObjects;

public class ResultDetails : ValueObject
{
    public double Value { get; init; }
    public long Timestamp { get; init; }
    public string Description { get; init; }
    public bool Result { get; init; }

    public ResultDetails(double value, long timestamp, string description, bool result)
    {
        Value = value;
        Timestamp = timestamp;
        Description = description;
        Result = result;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
        yield return Timestamp;
        yield return Description;
        yield return Result;
    }
}