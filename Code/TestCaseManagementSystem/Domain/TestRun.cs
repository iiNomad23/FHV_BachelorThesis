using Domain.ValueObjects;

namespace Domain;

public class TestRun
{
    public long Id { get; }
    public string DomainId { get; }
    
    public DateTime StartDate { get; }
    public DateTime EndDate { get; }
    public string State { get; private set; }
    public string TestSystemId { get; }
    public Dictionary<string, ResultDetails> ResultDetailsMap { get; private set; }
    public List<DeviceDetails> DeviceDetailsList { get; private set; }
    
    public TestRun(long id, string domainId, DateTime startDate, DateTime endDate, string state, string testSystemId)
    {
        Id = id;
        DomainId = domainId;
        StartDate = startDate;
        EndDate = endDate;
        State = state;
        TestSystemId = testSystemId;
        ResultDetailsMap = new Dictionary<string, ResultDetails>();
        DeviceDetailsList = new List<DeviceDetails>();
    }
    
    public TestRun(string domainId, DateTime startDate, DateTime endDate, string state, string testSystemId)
    {
        DomainId = domainId;
        StartDate = startDate;
        EndDate = endDate;
        State = state;
        TestSystemId = testSystemId;
        ResultDetailsMap = new Dictionary<string, ResultDetails>();
        DeviceDetailsList = new List<DeviceDetails>();
    }

    public TestRun(long id, string domainId, DateTime startDate, DateTime endDate, string state, string testSystemId, Dictionary<string, ResultDetails> resultDetailsMap, List<DeviceDetails> deviceDetailsList)
    {
        Id = id;
        DomainId = domainId;
        StartDate = startDate;
        EndDate = endDate;
        State = state;
        TestSystemId = testSystemId;
        ResultDetailsMap = resultDetailsMap;
        DeviceDetailsList = deviceDetailsList;
    }
    
    public TestRun(string domainId, DateTime startDate, DateTime endDate, string state, string testSystemId, Dictionary<string, ResultDetails> resultDetailsMap, List<DeviceDetails> deviceDetailsList)
    {
        DomainId = domainId;
        StartDate = startDate;
        EndDate = endDate;
        State = state;
        TestSystemId = testSystemId;
        ResultDetailsMap = resultDetailsMap;
        DeviceDetailsList = deviceDetailsList;
    }
}