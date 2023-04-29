namespace Domain;

public class TestSystem
{
    public string Name { get; private set; }
    public string Description { get; private set; }

    public TestSystem(string name, string description)
    {
        Name = name;
        Description = description;
    }
}