using Application.api;
using Application.dto;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/testplan")]
public class TestPlanController : ControllerBase
{
    private readonly ITestPlanService _testPlanService;

    public TestPlanController(ITestPlanService testPlanService)
    {
        _testPlanService = testPlanService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TestPlanDTO>> GetTestPlanById(int id)
    {
        var testCaseDTO = await _testPlanService.GetById(id);
        return Ok(testCaseDTO);
    }
    
    [HttpPost("create")]
    public async Task<ActionResult<TestCaseDTO>> CreateTestPlan(TestPlanDTO testPlanDTO)
    {
        await _testPlanService.Add(testPlanDTO);
        return Ok(testPlanDTO);
    }
}