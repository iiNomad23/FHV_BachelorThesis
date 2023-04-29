using Application.api;
using Application.dto;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/testPlan")]
public class TestPlanController : ControllerBase
{
    private readonly ITestPlanService _testPlanService;

    public TestPlanController(ITestPlanService testPlanService)
    {
        _testPlanService = testPlanService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TestPlanDTO>> FindTestPlanById(string id)
    {
        var testPlanDTO = await _testPlanService.FindById(id);
        return Ok(testPlanDTO);
    }

    [HttpGet("shortDescription/{shortDescription}")]
    public async Task<ActionResult<TestPlanDTO>> FindTestPlansByShortDescription(string shortDescription)
    {
        var testPlanDTOs = await _testPlanService.FindByShortDescription(shortDescription);
        return Ok(testPlanDTOs);
    }

    [HttpPost("create")]
    public async Task<ActionResult<TestPlanDTO>> CreateTestPlan(TestPlanDTO testPlanDTO)
    {
        await _testPlanService.Add(testPlanDTO);
        return Ok(testPlanDTO);
    }
}