namespace Domain;

public class TestEnvironmentPlan
{
    public string TestEnvironmentDomainId {get; private set;}
    public string TestPlanDomainId {get; private set;}

    public TestEnvironmentPlan(string testEnvironmentDomainId, string testPlanDomainId)
    {
        TestEnvironmentDomainId = testEnvironmentDomainId;
        TestPlanDomainId = testPlanDomainId;
    }
}