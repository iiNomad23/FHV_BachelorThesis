namespace Domain.ids;

public class DomainId
{
    public string Id { get; }

    protected DomainId(string id)
    {
        Id = id;
    }

    public override string ToString()
    {
        return Id;
    }
}