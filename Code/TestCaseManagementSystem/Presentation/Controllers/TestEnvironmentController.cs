using Application.Api;
using Application.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/testEnvironment")]
public class TestEnvironmentController : ControllerBase
{
    private readonly ITestEnvironmentService _testEnvironmentService;
    private readonly ITestEnvironmentManger _testEnvironmentManger;

    public TestEnvironmentController(ITestEnvironmentService testEnvironmentService, ITestEnvironmentManger testEnvironmentManager)
    {
        _testEnvironmentService = testEnvironmentService;
        _testEnvironmentManger = testEnvironmentManager;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TestEnvironmentDTO>> FindTestEnvironmentById(string id)
    {
        var testEnvironmentDTO = await _testEnvironmentService.FindById(id);
        return Ok(testEnvironmentDTO);
    }
    
    [HttpGet("{id}/withTestPlans")]
    public async Task<ActionResult<TestEnvironmentDTO>> FindTestEnvironmentByIdWithFeatures(string id)
    {
        var testEnvironmentDTO = await _testEnvironmentManger.FindByIdWithTestPlans(id);
        return Ok(testEnvironmentDTO);
    }

    [HttpGet("shortDescription/{shortDescription}")]
    public async Task<ActionResult<TestEnvironmentDTO>> FindTestEnvironmentsByShortDescription(string shortDescription)
    {
        var testEnvironmentDTOs = await _testEnvironmentService.FindByShortDescription(shortDescription);
        return Ok(testEnvironmentDTOs);
    }

    [HttpPost("create")]
    public async Task<ActionResult<TestEnvironmentDTO>> CreateTestEnvironment(TestEnvironmentDTO testEnvironmentDTO)
    {
        await _testEnvironmentService.Create(testEnvironmentDTO);
        return Ok(testEnvironmentDTO);
    }
    
    [HttpPost("addTestPlans")]
    public async Task<int> AddTestPlans(TestEnvironmentUpdateTestPlanIdsDTO testEnvironmentUpdateTestPlanIdsDTO)
    {
        await _testEnvironmentService.AddTestPlans(testEnvironmentUpdateTestPlanIdsDTO);
        return Ok().StatusCode;
    }
    
    [HttpPost("removeTestPlans")]
    public async Task<int> RemoveTestPlans(TestEnvironmentUpdateTestPlanIdsDTO testEnvironmentUpdateTestPlanIdsDTO)
    {
        await _testEnvironmentService.RemoveTestPlans(testEnvironmentUpdateTestPlanIdsDTO);
        return Ok().StatusCode;
    }
}