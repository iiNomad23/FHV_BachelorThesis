namespace Domain.ids;

public class DomainId
{
    private readonly string Id;

    protected DomainId(string id)
    {
        Id = id;
    }

    public override string ToString()
    {
        return Id;
    }
}